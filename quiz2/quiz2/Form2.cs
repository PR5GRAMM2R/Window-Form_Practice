using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz2
{ 
    public partial class Form2 : Form
    {
        public event EventHandler Changed1;
        public event EventHandler Changed2;

        public Form2()
        {
            InitializeComponent();
            this.btnAdd.Enabled = false;
            this.btnSave.Enabled = false;
        }

        private void hsbRed_Scroll(object sender, ScrollEventArgs e)
        {
            this.btnAdd.Enabled = true;
            this.btnSave.Enabled = true;
            this.BackColor = Color.FromArgb(this.hsbRed.Value, this.hsbGreen.Value, this.hsbBlue.Value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Changed1 != null)
            {
                if(this.btnAdd.Enabled)
                {
                    Changed1(this, new EventArgs());
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Changed2 != null)
            {
                if (this.btnSave.Enabled)
                {
                    Changed2(this, new EventArgs());
                }
            }

            this.Close();
        }
    }
}
