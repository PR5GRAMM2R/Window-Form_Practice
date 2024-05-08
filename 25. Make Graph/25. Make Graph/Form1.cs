using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25.Make_Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            SolidBrush clearBrush = new SolidBrush(Form1.DefaultBackColor);
            Graphics g = this.CreateGraphics();

            booksTB.Clear();
            periodicalsTB.Clear();
            foodsTB.Clear();

            booksTB.Focus();

            g.FillEllipse(clearBrush, 130, 110, 100, 100);
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayBTN_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            decimal totalSales;
            decimal booksSales;
            decimal periodicalsSales;
            decimal foodsSales;

            try
            {
                booksSales = Decimal.Parse(booksTB.Text);

                try
                {
                    periodicalsSales = Decimal.Parse(periodicalsTB.Text);
                    try
                    {
                        foodsSales = Decimal.Parse(foodsTB.Text);
                        totalSales = booksSales + periodicalsSales + foodsSales;

                        SolidBrush bookBr = new SolidBrush(Color.Blue);
                        SolidBrush periodicalBr = new SolidBrush(Color.Yellow);
                        SolidBrush foodBr = new SolidBrush(Color.Red);

                        if(totalSales != 0)
                        {
                            int endBook = (int)(booksSales / totalSales * 360);
                            g.FillPie(bookBr, 130, 110, 100, 100, 0, endBook);
                            int endPeriodical = (int)(periodicalsSales / totalSales * 360);
                            g.FillPie(periodicalBr, 130, 110, 100, 100, endBook, endPeriodical);
                            int endFood = (int)(foodsSales / totalSales * 360);
                            g.FillPie(foodBr, 130, 110, 100, 100, endBook + endPeriodical, endFood);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("invalid Food Sales");
                        foodsTB.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("invalid Periodical Sales");
                    periodicalsTB.Focus();
                }
            }
            catch
            {
                MessageBox.Show("invalid Book Sales");
                booksTB.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
