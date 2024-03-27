using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09.OpenFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "Text (*.txt)|*.txt|" + "All files (*.*)|*.*";
            ofd.Title = "My Text Browser";
            ofd.FileName = "";
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName);
                ofd.FileName = "";
            }
        }

        private void tsmiBackColor_Click(object sender, EventArgs e)
        {
            cld.Color = BackColor;
            cld.ShowDialog();
            BackColor = cld.Color;
        }
    }
}
