using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz5
{
    public partial class Form1 : Form
    {
        int[,] nums = new int[4, 4];
        List<int> list = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    nums[i, j] = 0;

            GamePlayInit();
        }

        private void GamePlayInit()
        {
            Random random = new Random();


            int pos = random.Next(0, 15);

            list.Add(pos);

            while (list.Count < 2)
            {
                do
                {
                    pos = random.Next(0, 15);
                } while (list.Contains(pos) == true);

                list.Add(pos);
            }

            for (int i = 0; i < list.Count; i++)
            {
                int row = list[i] / 4;
                int col = list[i] % 4;
                nums[row, col] = 2;
            }

            Display();
        }

        private void Display()
        {
            int maxNum = 0;

            for(int i = 0; i < 4;i++)
            {
                for(int j = 0; j < 4;j++)
                {                    
                    int num = nums[i, j];
                    int pbPos = i * 4 + j;

                    string temp = "pb" + pbPos.ToString();
                    PictureBox control = (PictureBox)FindControlsByText(pbPanel, temp);

                    if(num >= maxNum)
                        maxNum = num;

                    if(control != null)
                    {
                        switch (num)
                        {
                            case 0:
                                control.Visible = false;
                                break;
                            case 2:
                                control.Image = Properties.Resources._2;
                                control.Visible = true;
                                break;
                            case 4:
                                control.Image = Properties.Resources._4;
                                control.Visible = true;
                                break;
                            case 8:
                                control.Image = Properties.Resources._8;
                                control.Visible = true;
                                break;
                            case 16:
                                control.Image = Properties.Resources._16;
                                control.Visible = true;
                                break;
                            case 32:
                                control.Image = Properties.Resources._32;
                                control.Visible = true;
                                break;
                            case 64:
                                control.Image = Properties.Resources._64;
                                control.Visible = true;
                                break;
                            case 128:
                                control.Image = Properties.Resources._128;
                                control.Visible = true;
                                break;
                            case 256:
                                control.Image = Properties.Resources._256;
                                control.Visible = true;
                                break;
                            case 512:
                                control.Image = Properties.Resources._512;
                                control.Visible = true;
                                break;
                            case 1024:
                                control.Image = Properties.Resources._1024;
                                control.Visible = true;
                                break;
                            case 2048:
                                control.Image = Properties.Resources._2048;
                                control.Visible = true;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            Control textControl = FindControlsByText(this, "lblScore");

            if(textControl is Label label)
                label.Text = "Score : " + maxNum.ToString();
        }

        private Control FindControlsByText(Control parent, string name)
        {
            //Control matches = new Control();
            foreach (Control control in parent.Controls)
            {
                if (control.Name == name)
                {
                    return control;
                }
            }
            return null;
        }
    }
}
