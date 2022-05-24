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
            this.Text = "";
            this.BackColor = Colors.GreyBackground;
            this.IsAcrylic = true;
            this.Icon = new IconFactory(IconFactory.GetDpiScale(this.Handle)).IconFromSvg(Icons.Cube_16x_svg);
        }

      
    }
}