using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz0_1
{
    public partial class Form2 : Form
    {
        public event EventHandler Changed;

        public Form2()
        {
            InitializeComponent();
            this.btnAdd.Enabled = false;
        }

        private void hsbRed_Scroll(object sender, ScrollEventArgs e)
        {
            this.btnAdd.Enabled = true;
            this.BackColor = Color.FromArgb(this.hsbRed.Value, this.hsbGreen.Value, this.hsbBlue.Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Changed != null)
            {
                if (this.btnAdd.Enabled)
                {
                    Changed(this, new EventArgs());
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenColorDialog_Click(object sender, EventArgs e)
        {
            cld.Color = BackColor;
            cld.ShowDialog();
            BackColor = cld.Color;

            hsbRed.Value = BackColor.R;
            hsbGreen.Value = BackColor.G;
            hsbBlue.Value = BackColor.B;
        }
    }
}
