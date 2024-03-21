using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08.Menustrip_ToolStripMenuItem_ContextMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 파일FToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("저장");
        }
    }
}
