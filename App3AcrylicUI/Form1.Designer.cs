using AcrylicUI.Resources;

namespace App3AcrylicUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.windowPanel1 = new AcrylicUI.Controls.WindowPanel();
            this.boxControl1 = new AcrylicUI.Controls.BoxControl();
            this.acrylicSectionPanel2 = new DarkUI.Controls.AcrylicSectionPanel();
            this.acrylicListView2 = new AcrylicUI.Controls.AcrylicListView();
            this.btn1_Mic = new AcrylicUI.Controls.AcrylicButton();
            this.acrylicSectionPanel1 = new DarkUI.Controls.AcrylicSectionPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.acrylicListView1 = new AcrylicUI.Controls.AcrylicListView();
            this.acrylicButton5 = new AcrylicUI.Controls.AcrylicButton();
            this.acrylicButton2 = new AcrylicUI.Controls.AcrylicButton();
            this.acrylicButton1 = new AcrylicUI.Controls.AcrylicButton();
            this.acrylicButton3 = new AcrylicUI.Controls.AcrylicButton();
            this.acrylicButton4 = new AcrylicUI.Controls.AcrylicButton();
            this.acrylicContextMenu1 = new AcrylicUI.Controls.AcrylicContextMenu();
            this.windowPanel1.SuspendLayout();
            this.acrylicSectionPanel2.SuspendLayout();
            this.acrylicSectionPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowPanel1
            // 
            this.windowPanel1.Controls.Add(this.boxControl1);
            this.windowPanel1.Controls.Add(this.acrylicSectionPanel2);
            this.windowPanel1.Controls.Add(this.btn1_Mic);
            this.windowPanel1.Controls.Add(this.acrylicSectionPanel1);
            this.windowPanel1.Controls.Add(this.acrylicButton5);
            this.windowPanel1.Controls.Add(this.acrylicButton2);
            this.windowPanel1.Controls.Add(this.acrylicButton1);
            this.windowPanel1.Controls.Add(this.acrylicButton3);
            this.windowPanel1.Controls.Add(this.acrylicButton4);
            this.windowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowPanel1.Icon = null;
            this.windowPanel1.IsAcrylicEnabled = false;
            this.windowPanel1.Location = new System.Drawing.Point(0, 0);
            this.windowPanel1.Name = "windowPanel1";
            this.windowPanel1.ProfileFeature = false;
            this.windowPanel1.RoundCorners = false;
            this.windowPanel1.SectionHeader = null;
            this.windowPanel1.Size = new System.Drawing.Size(1027, 573);
            this.windowPanel1.TabIndex = 0;
            // 
            // boxControl1
            // 
            this.boxControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.boxControl1.DefaultDockArea = AcrylicUI.Docking.DockArea.None;
            this.boxControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.boxControl1.DockText = null;
            this.boxControl1.Icon = null;
            this.boxControl1.Location = new System.Drawing.Point(1, 25);
            this.boxControl1.Name = "boxControl1";
            this.boxControl1.SerializationKey = null;
            this.boxControl1.Size = new System.Drawing.Size(219, 547);
            this.boxControl1.TabIndex = 21;
            // 
            // acrylicSectionPanel2
            // 
            this.acrylicSectionPanel2.Controls.Add(this.acrylicListView2);
            this.acrylicSectionPanel2.Location = new System.Drawing.Point(668, 176);
            this.acrylicSectionPanel2.Name = "acrylicSectionPanel2";
            this.acrylicSectionPanel2.SectionHeader = "Mic Setup";
            this.acrylicSectionPanel2.Size = new System.Drawing.Size(142, 279);
            this.acrylicSectionPanel2.TabIndex = 20;
            // 
            // acrylicListView2
            // 
            this.acrylicListView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.acrylicListView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acrylicListView2.Location = new System.Drawing.Point(1, 25);
            this.acrylicListView2.Name = "acrylicListView2";
            this.acrylicListView2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.acrylicListView2.Size = new System.Drawing.Size(140, 253);
            this.acrylicListView2.TabIndex = 14;
            this.acrylicListView2.Text = "acrylicListView2";
            // 
            // btn1_Mic
            // 
            this.btn1_Mic.BackColor = System.Drawing.Color.Transparent;
            this.btn1_Mic.Default = false;
            this.btn1_Mic.HasRoundedCorners = false;
            this.btn1_Mic.ImagePadding = 6;
            this.btn1_Mic.Location = new System.Drawing.Point(306, 176);
            this.btn1_Mic.Margin = new System.Windows.Forms.Padding(0);
            this.btn1_Mic.Name = "btn1_Mic";
            this.btn1_Mic.Padding = new System.Windows.Forms.Padding(10);
            this.btn1_Mic.Size = new System.Drawing.Size(104, 32);
            this.btn1_Mic.TabIndex = 14;
            this.btn1_Mic.Text = "Mic";
            this.btn1_Mic.UseVisualStyleBackColor = false;
            // 
            // acrylicSectionPanel1
            // 
            this.acrylicSectionPanel1.Controls.Add(this.panel3);
            this.acrylicSectionPanel1.Location = new System.Drawing.Point(413, 73);
            this.acrylicSectionPanel1.Name = "acrylicSectionPanel1";
            this.acrylicSectionPanel1.SectionHeader = "Mic Profiles";
            this.acrylicSectionPanel1.Size = new System.Drawing.Size(200, 282);
            this.acrylicSectionPanel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.acrylicListView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1, 25);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(198, 256);
            this.panel3.TabIndex = 14;
            // 
            // acrylicListView1
            // 
            this.acrylicListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.acrylicListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acrylicListView1.Location = new System.Drawing.Point(4, 4);
            this.acrylicListView1.Margin = new System.Windows.Forms.Padding(12);
            this.acrylicListView1.Name = "acrylicListView1";
            this.acrylicListView1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.acrylicListView1.Size = new System.Drawing.Size(190, 248);
            this.acrylicListView1.TabIndex = 13;
            this.acrylicListView1.Text = "acrylicListView1";
            // 
            // acrylicButton5
            // 
            this.acrylicButton5.Default = false;
            this.acrylicButton5.HasRoundedCorners = false;
            this.acrylicButton5.ImagePadding = 6;
            this.acrylicButton5.Location = new System.Drawing.Point(306, 356);
            this.acrylicButton5.Name = "acrylicButton5";
            this.acrylicButton5.Padding = new System.Windows.Forms.Padding(6);
            this.acrylicButton5.Size = new System.Drawing.Size(104, 32);
            this.acrylicButton5.TabIndex = 18;
            this.acrylicButton5.Text = "Routing";
            this.acrylicButton5.UseVisualStyleBackColor = false;
            // 
            // acrylicButton2
            // 
            this.acrylicButton2.Default = false;
            this.acrylicButton2.HasRoundedCorners = false;
            this.acrylicButton2.ImagePadding = 6;
            this.acrylicButton2.Location = new System.Drawing.Point(306, 221);
            this.acrylicButton2.Margin = new System.Windows.Forms.Padding(0);
            this.acrylicButton2.Name = "acrylicButton2";
            this.acrylicButton2.Padding = new System.Windows.Forms.Padding(10);
            this.acrylicButton2.Size = new System.Drawing.Size(104, 32);
            this.acrylicButton2.TabIndex = 15;
            this.acrylicButton2.Text = "Mixer";
            this.acrylicButton2.UseVisualStyleBackColor = false;
            // 
            // acrylicButton1
            // 
            this.acrylicButton1.Default = false;
            this.acrylicButton1.HasRoundedCorners = false;
            this.acrylicButton1.ImagePadding = 6;
            this.acrylicButton1.Location = new System.Drawing.Point(306, 401);
            this.acrylicButton1.Name = "acrylicButton1";
            this.acrylicButton1.Padding = new System.Windows.Forms.Padding(6);
            this.acrylicButton1.Size = new System.Drawing.Size(104, 32);
            this.acrylicButton1.TabIndex = 19;
            this.acrylicButton1.Text = "System";
            this.acrylicButton1.UseVisualStyleBackColor = false;
            // 
            // acrylicButton3
            // 
            this.acrylicButton3.Default = false;
            this.acrylicButton3.HasRoundedCorners = false;
            this.acrylicButton3.ImagePadding = 6;
            this.acrylicButton3.Location = new System.Drawing.Point(306, 266);
            this.acrylicButton3.Name = "acrylicButton3";
            this.acrylicButton3.Padding = new System.Windows.Forms.Padding(6);
            this.acrylicButton3.Size = new System.Drawing.Size(104, 32);
            this.acrylicButton3.TabIndex = 16;
            this.acrylicButton3.Text = "Cough";
            this.acrylicButton3.UseVisualStyleBackColor = false;
            // 
            // acrylicButton4
            // 
            this.acrylicButton4.Default = false;
            this.acrylicButton4.HasRoundedCorners = false;
            this.acrylicButton4.ImagePadding = 6;
            this.acrylicButton4.Location = new System.Drawing.Point(306, 311);
            this.acrylicButton4.Name = "acrylicButton4";
            this.acrylicButton4.Padding = new System.Windows.Forms.Padding(6);
            this.acrylicButton4.Size = new System.Drawing.Size(104, 32);
            this.acrylicButton4.TabIndex = 17;
            this.acrylicButton4.Text = "Lighting";
            this.acrylicButton4.UseVisualStyleBackColor = false;
            // 
            // acrylicContextMenu1
            // 
            this.acrylicContextMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.acrylicContextMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.acrylicContextMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.acrylicContextMenu1.Name = "acrylicContextMenu1";
            this.acrylicContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BlurColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1027, 573);
            this.Controls.Add(this.windowPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.windowPanel1.ResumeLayout(false);
            this.acrylicSectionPanel2.ResumeLayout(false);
            this.acrylicSectionPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AcrylicUI.Controls.WindowPanel windowPanel1;
        private AcrylicUI.Controls.AcrylicContextMenu acrylicContextMenu1;
        private DarkUI.Controls.AcrylicSectionPanel acrylicSectionPanel1;
        private System.Windows.Forms.Panel panel3;
        private AcrylicUI.Controls.AcrylicListView acrylicListView1;
        private AcrylicUI.Controls.AcrylicButton btn1_Mic;
        private AcrylicUI.Controls.AcrylicButton acrylicButton1;
        private AcrylicUI.Controls.AcrylicButton acrylicButton2;
        private AcrylicUI.Controls.AcrylicButton acrylicButton3;
        private AcrylicUI.Controls.AcrylicButton acrylicButton5;
        private AcrylicUI.Controls.AcrylicButton acrylicButton4;
        private DarkUI.Controls.AcrylicSectionPanel acrylicSectionPanel2;
        private AcrylicUI.Controls.AcrylicListView acrylicListView2;
        private AcrylicUI.Controls.BoxControl boxControl1;
    }
}
