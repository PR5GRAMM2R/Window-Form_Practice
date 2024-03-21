using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05.Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrClock.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrClock.Stop();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblDisplay.Text = (int.Parse(lblDisplay.Text) + 1).ToString();
        }
    }
}
