using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06.PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            picProfile.ImageLocation = txtUrl.Text;
        }

        private void rdoNormal_CheckedChanged(object sender, EventArgs e)
        {
            picProfile.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void rdoStretchImage_CheckedChanged(object sender, EventArgs e)
        {
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rdoAutosize_CheckedChanged(object sender, EventArgs e)
        {
            picProfile.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void rdoCenterImage_CheckedChanged(object sender, EventArgs e)
        {
            picProfile.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void rdoZoom_CheckedChanged(object sender, EventArgs e)
        {
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void chbVisible_CheckedChanged(object sender, EventArgs e)
        {
            picProfile.Visible = !chbVisible.Checked;
        }
    }
}
