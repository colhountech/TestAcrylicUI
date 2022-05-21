﻿using AcrylicUI;
using AcrylicUI.Controls;
using AcrylicUI.Forms;
using AcrylicUI.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace App3AcrylicUI
{
    public partial class Form1 : AcrylicForm
    {
        #region Fields for Borderless Windows
        private int borderSize = 0;
        private bool _flatBorder = true;
        private Size _restoreSize;
        #endregion

        public Form1()
        {
            InitializeComponent();
            SetupUIDefaults();
            HookEvents();

            bool _isWindows11 = true;
            RoundCorners(_isWindows11);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var dpiScale = IconFactory.GetDpiScale(this.Handle);
            this.windowPanel1.Icon = new IconFactory(IconFactory.GetDpiScale(Handle)).BitmapFromSvg(Icons.Cube_16x_svg);
            this.windowPanel1.SectionHeader = "CT Studio";
            this.windowPanel1.IsAcrylicEnabled = true;
            
            this.BackColor = Colors.GreyBackground;

            // Main App Setup
            LoadMicTab();
            LoadMicProfiles();
            LoadMicSetup();
        }

        #region Borderless

        #region fix FormWindowState changes


        private void SetupUIDefaults()
        {
            // Don't change this: NoBorder with Resize Hack
            var designSize = this.ClientSize;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Size = designSize;
            this._restoreSize = designSize; // save for restore
        }

        private void HookEvents()
        {
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);

        }






        #endregion

        #region Min/Max/Restore for catching resize events to adjust form

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            _restoreSize = ClientSize;
            this.WindowState = (this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal);
            AdjustForm();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            _restoreSize = ClientSize;
            this.WindowState = FormWindowState.Minimized;
            AdjustForm();
        }



        protected override void OnResizeBegin(EventArgs e)
        {
            this.SuspendLayout();
            base.OnResizeBegin(e);
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            this.ResumeLayout();
        }

        protected override void OnResize(EventArgs e)
        {
            this.SuspendLayout();
            base.OnResize(e);
            AdjustForm();
            this.ResumeLayout();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 8);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }



        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Clicks == 2) // DoubleClick
            {
                BtnMaximize_Click(this, e);
            }
            else
            {
                WinProcExtentsions.TitleBarHit(Handle);
            }
        }


        #endregion

        #region Window, No Border Hacks

        protected override void WndProc(ref Message message)
        {
            // Resize Window
            if (message.Msg == WinUserH.WM_NCHITTEST)
            {
                base.WndProc(ref message);

                if (this.WindowState == FormWindowState.Normal)
                {
                    if ((int)message.Result == WinUserH.HT_CLIENT)
                    {
                        var cursor = this.PointToClient(Cursor.Position);
                        WindowPanel.CheckResizeClientAreaHit(this.ClientSize, ref message, cursor);
                    }
                }
                return;
            }

            // Remove border and keep snap window
            if (message.Msg == WinUserH.WM_NCCALCSIZE && message.WParam.ToInt32() == 1)
            {
                return;
            }

            // Keep form size when it is minimized and restored.            
            if (message.Msg == WinUserH.WM_SYSCOMMAND)
            {
                int wParam = (message.WParam.ToInt32() & 0xFFF0);
                if (wParam == WinUserH.SC_MINIMIZE)
                {
                    //save client size
                    _restoreSize = this.ClientSize;
                }
                if (wParam == WinUserH.SC_RESTORE)
                {
                    // restore client size
                    this.Size = _restoreSize;
                }
            }

            base.WndProc(ref message);
        }



        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            if (!_flatBorder)
                return;

            //var g = e.Graphics;

            //using (var p = new Pen(Colors.DarkBorder))
            //{
            //    var modRect = new Rectangle(ClientRectangle.Location, new Size(ClientRectangle.Width - 1, ClientRectangle.Height - 1));
            //    g.DrawRectangle(p, modRect);
            //}
        }

        [DllImport("user32.dll")]
        private static extern uint GetDpiForWindow(IntPtr hwnd);

        /// <summary>
        /// Add DropShadow to top level windows
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        #endregion

        #region Round Corners


        private void RoundCorners(bool _isWindows11)
        {
            if (_isWindows11)
            {
                var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
                var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
                DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));
            }
            this.windowPanel1.RoundCorners = _isWindows11;
        }

        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_WINDOW_CORNER_PREFERENCE = 33
        }

        // The DWM_WINDOW_CORNER_PREFERENCE enum for DwmSetWindowAttribute's third parameter, which tells the function
        // what value of the enum to set.
        public enum DWM_WINDOW_CORNER_PREFERENCE
        {
            DWMWCP_DEFAULT = 0,
            DWMWCP_DONOTROUND = 1,
            DWMWCP_ROUND = 2,
            DWMWCP_ROUNDSMALL = 3
        }

        // Import dwmapi.dll and define DwmSetWindowAttribute in C# corresponding to the native function.
        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern long DwmSetWindowAttribute(IntPtr hwnd,
                                                         DWMWINDOWATTRIBUTE attribute,
                                                         ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute,
                                                         uint cbAttribute);

        #endregion

        #endregion

        private void LoadMicTab()
        {          

        }

        private void btn1_Mic_Click(object sender, EventArgs e)
        {
            LoadMicProfiles();
        }

        private void LoadMicProfiles()
        {
            panel3.BackColor = Color.Black;
            this.acrylicListView1.Items.Clear();
            var profiles = new List<String> { "AKG Condenser", "DEFAULT", "Sennheiser ew 100G3", "Shure SM7b Flat", "Shure SM7B" };

            profiles.ForEach(p => acrylicListView1.Items.Add(new AcrylicListItem(Text = p)));
        }

        private void LoadMicSetup()
        {
            this.acrylicListView2.Items.Clear();
            var profiles = new List<String> {
                "Mic Type: Dynamic",
                "Gain: 68dB",
                "Level: 32db" };

            profiles.ForEach(p => acrylicListView2.Items.Add(new AcrylicListItem(Text = p)));
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.windowPanel1.IsAcrylicEnabled = true;
            Refresh();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.windowPanel1.IsAcrylicEnabled = false;
            Refresh();
        }

      
    }
}