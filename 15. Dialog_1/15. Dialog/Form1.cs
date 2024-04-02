using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15.Dialog
{
    public partial class DlgForm : Form
    {
        public DlgForm()
        {
            InitializeComponent();
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            MyDlg md = new MyDlg();
            DialogResult dResult = md.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
            else if(dResult == DialogResult.Cancel)
            {
                MessageBox.Show("Cancel");
            }
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            MyDlg md = new MyDlg();
            md.Owner = this;
            md.Show();
        }
    }
}
