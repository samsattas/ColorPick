using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPick
{
    public partial class Form1 : Form
    {
        string path = "";
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            tableLayoutPanelMain.Height = this.Height-50;
            tableLayoutPanelMain.Width = this.Width-50;
            
        }

        /*
         * Bitmap b = new Bitmap( "some path" );
         * Color x = b.GetPixel( x, y );
         */

        public string getFile()
        {
            
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
            }

            return path;
        }

        private void buttonLoadImg_Click(object sender, EventArgs e)
        {
            string aux = getFile();
            if (aux!="")
            {
                pictureBoxImg.Image = Image.FromFile(aux);
            }
            
        }

        private void pictureBoxImg_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxImg_MouseDown(object sender, MouseEventArgs e)
        {
            
            //labelColor.Text = e.X + ", " + e.Y;
            
            if (path != "")
            {
                try
                {
                    Bitmap b = new Bitmap(path);
                    Color x = b.GetPixel(e.X, e.Y);
                    labelImgColor.BackColor = x;
                    labelImgColor.Text = "";
                }
                catch (Exception)
                {
                    labelImgColor.Text = "No Color Selected";
                }
            }
        }
    }
}
