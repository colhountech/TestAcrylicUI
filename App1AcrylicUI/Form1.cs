using AcrylicUI.Forms;
using AcrylicUI.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1AcrylicUI
{
    public partial class Form1 : AcrylicForm
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "";
            this.IsAcrylic = true;
            this.BlurColor = Colors.GreyBackground; // This keeps getting overwritten when you change Designer properties

        }

    }
}
