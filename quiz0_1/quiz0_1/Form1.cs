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
    public partial class Form1 : Form
    {
        List<int[]> colorRGBList = new List<int[]>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void Dialog_Changed(object obj, EventArgs e)
        {
            Form dig = obj as Form;
            this.BackColor = dig.BackColor;
        }

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.Changed += new EventHandler(Dialog_Changed);
            form2.Show();
        }
    }
}
