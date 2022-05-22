using AcrylicUI.Controls;
using AcrylicUI.Forms;
using AcrylicUI.Resources;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App4AcrylicUI
{
    public partial class Form1 : AcrylicForm
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "";
            this.IsAcrylic = true;
            this.BlurColor = Colors.GreyBackground; // This keeps getting overwritten when you change Designer properties
            this.Icon = new IconFactory(IconFactory.GetDpiScale(this.Handle)).IconFromSvg(Icons.Cube_16x_svg);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var iconFactory = new IconFactory(IconFactory.GetDpiScale(this.Handle));

            this.acrylicLabel1.Image = iconFactory.BitmapFromSvg(Icons.Cube_16x_svg, 64, 64); ;
            this.acrylicLabel1.Text = "Cube";

            this.acrylicLabel2.Image = iconFactory.BitmapFromSvg(Icons.Document_16x_svg, 64, 64);
            this.acrylicLabel2.Text = "Document";

            this.acrylicLabel3.Image = iconFactory.BitmapFromSvg(Icons.Audio_16x_svg, 64, 64);
            this.acrylicLabel3.Text = "Audio";

            this.acrylicLabel4.Image = iconFactory.BitmapFromSvg(Icons.VideoCamera_16x_svg, 64, 64);
            this.acrylicLabel4.Text = "Video";

            this.acrylicLabel5.Image = iconFactory.BitmapFromSvg(Icons.DiagnosticFile_16x_svg, 64, 64);
            this.acrylicLabel5.Text = "File";

            this.acrylicLabel6.Image = iconFactory.BitmapFromSvg(Icons.TextFile_16x_svg, 64, 64);
            this.acrylicLabel6.Text = "Text File";

            // Modules List
            this.acrylicListView1.ShowIcons = true;
            this.acrylicListView1.Items.Clear();
            this.acrylicListView1.ItemHeight = 50;
            this.acrylicListView1.ShowIcons = true;
            var profiles = new List<String> { "Mic", "Mixer", "Cough", "Lighting", "Routing", "System" };           
            profiles.ForEach(p =>
            {
                var text = $"{p}";
                var item = new AcrylicListItem(text);
                item.Icon = (Bitmap)iconFactory.BitmapFromSvg(Icons.StatusWarning_16x_svg);
                acrylicListView1.Items.Add(item);
                
                });


            // Mic Profile List
            var settings = new List<String> { "AKG Condenser", "DEFAULT", "Sennheiser ew 100G3", "Shure SM7b Flat", "Shure SM7B" };
            this.acrylicListView2.ShowIcons = true;
            this.acrylicListView2.Items.Clear();
            this.acrylicListView2.ItemHeight = 50;
            this.acrylicListView2.ShowIcons = true;
            this.acrylicListView2.AlternateBackground = true;
            settings.ForEach(p =>
            {
                var item = new AcrylicListItem($"{p}\nThis is a subitem");
                item.Icon = (Bitmap)iconFactory.BitmapFromSvg(Icons.TextFile_16x_svg);
                acrylicListView2.Items.Add(item);
            });

            // Project List
            this.acrylicListView3.ShowIcons = true;
            this.acrylicListView3.Items.Clear();
            this.acrylicListView3.ItemHeight = 50;
            this.acrylicListView3.ShowIcons = true;
            this.acrylicListView3.AlternateBackground = false;
            var projects = new List<String> {
                "New Episode\nJust in Draft for now",
                "YouTube Episode #16\nStreamed Live 29th Jun 2021",
                "YouTube Episode #05\nStreamed Live 27th Apr 2021",
                "YouTube Episode #04\nStreamed Live 22th Apr 2021",
            };
            projects.ForEach(p =>
            {
                var item = new AcrylicListItem(p);            
                item.Icon = IconChar.Youtube.ToBitmap(IconFont.Brands, color: Color.Red, size:16 );
                acrylicListView3.Items.Add(item);
            });

        }
    }
}
