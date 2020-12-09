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
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanelMain.Height = this.Height-50;
            tableLayoutPanelMain.Width = this.Width-50;
            
        }

        public string getFile()
        {
            string path = "";
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
            }

            return path;
        }

        private void buttonLoadImg_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(getFile());
        }
    }
}
