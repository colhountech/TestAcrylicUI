using AcrylicUI.Controls;
using AcrylicUI.Forms;
using AcrylicUI.Resources;

namespace App5AcrylicUI
{
    public partial class Form1 : AcrylicForm
    {
        public Form1()
        {
            InitializeComponent();
            // Make sure you set this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            this.AutoScaleMode = AutoScaleMode.Dpi;

            this.Text = "";
            this.BackColor = Colors.GreyBackground;
            this.IsAcrylic = true;
            this.Icon = new IconFactory(IconFactory.GetDpiScale(this.Handle)).IconFromSvg(Icons.Cube_16x_svg);
        }

      
    }
}