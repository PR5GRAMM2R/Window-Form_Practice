using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox.SelectedText);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
            textBox.Focus();
        }

        private void rdoDotum_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(rdoDotum.Text, textBox.Font.Size, textBox.Font.Style);
            textBox.Font = f;
        }

        private void rdoGulim_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(rdoGulim.Text, textBox.Font.Size, textBox.Font.Style);
            textBox.Font = f;
        }

        private void rdoGungsuh_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(rdoGungsuh.Text, textBox.Font.Size, textBox.Font.Style);
            textBox.Font = f;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(textBox.Font.FontFamily, textBox.Font.Size, FontStyle.Bold ^ textBox.Font.Style);
            textBox.Font = f;
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(textBox.Font.FontFamily, textBox.Font.Size, FontStyle.Underline ^ textBox.Font.Style);
            textBox.Font = f;
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(textBox.Font.FontFamily, textBox.Font.Size, FontStyle.Italic ^ textBox.Font.Style);
            textBox.Font = f;
        }
    }
}
