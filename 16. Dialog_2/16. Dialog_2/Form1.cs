using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16.Dialog_2
{
    public partial class DialogApplyForm : Form
    {
        public DialogApplyForm()
        {
            InitializeComponent();
        }

        private void Dialog_Changed(object obj, EventArgs e)
        {
            Form dig = obj as Form;
            this.BackColor = dig.BackColor;
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            MyApplyDialog mad = new MyApplyDialog();
            mad.Owner = this;
            mad.Changed += new EventHandler(Dialog_Changed);
            mad.Show();
        }
    }
}
