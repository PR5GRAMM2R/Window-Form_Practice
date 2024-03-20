using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum ComboBoxParceCase
{
    None,
    Year,
    Month,
    Day,
    Combine
}

namespace _03.ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            for(int i = localDate.Year - 100; i <= localDate.Year + 100; i++)
            {
                cmbYear.Items.Add(i);
            }

            cmbYear.SelectedIndex = cmbYear.Items.Count - 1;

            for(int i = 1; i <= 12; i++)
            {
                cmbMonth.Items.Add(i);
            }
            //cmbMonth.SelectedIndex = 0;
            for (int i = 1; i <= 31; i++)
            {
                cmbDay.Items.Add(i);
            }
            //cmbDay.SelectedIndex = 0;
        }

        public bool IsDate(int year, int month, int day)
        {
            return year >= 0 && month > 0 && month < 13 && day > 0 && day <= DateTime.DaysInMonth(year, month);
        }

        private ComboBoxParceCase GetComboBoxParceCase()
        {
            if(cmbYear.SelectedItem == null)
            {
                return ComboBoxParceCase.Year;
            }
            else if(cmbMonth.SelectedItem == null)
            {
                return ComboBoxParceCase.Month;
            }
            else if (cmbDay.SelectedItem == null)
            {
                return ComboBoxParceCase.Day;
            }
            else if (!IsDate((int)cmbYear.SelectedItem, (int)cmbMonth.SelectedItem, (int)cmbDay.SelectedItem))
            {
                return ComboBoxParceCase.Combine;
            }

            return ComboBoxParceCase.None;
        }

        private void cmb_ItemOrTextChanged(object sender, EventArgs e)
        {
            switch (GetComboBoxParceCase())
            {
                case ComboBoxParceCase.Year:
                    lblToggle.Text = "태어난 년도를 입력하세요.";
                    break;
                case ComboBoxParceCase.Month:
                    lblToggle.Text = "태어난 월을 입력하세요.";
                    break;
                case ComboBoxParceCase.Day:
                    lblToggle.Text = "태어난 일을 입력하세요.";
                    break;
                case ComboBoxParceCase.Combine:
                    lblToggle.Text = "생년월일을 다시 확인해주세요.";
                    break;
                default:
                    lblToggle.Text = "";
                    break;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(GetComboBoxParceCase() != ComboBoxParceCase.None)
            {
                return;
            }

            int year = (int) cmbYear.SelectedItem;
            int month = (int)cmbMonth.SelectedItem;
            int day = (int)cmbDay.SelectedItem;

            DateTime BirthDay = new DateTime(year, month, day);
            DateTime CurrentDate = DateTime.Now;

            txtNote.Text += "세는 나이 : " + (CurrentDate.Year - BirthDay.Year + 1).ToString() + "\r\n";
            int age = CurrentDate.Year - BirthDay.Year;
            if(CurrentDate.Month < BirthDay.Month)
            {
                age -= 1;
            }
            else if(CurrentDate.Month == BirthDay.Month && CurrentDate.Day < BirthDay.Day)
            {
                age -= 1;
            }
            txtNote.Text += "만 나이 : " + age.ToString() + "\r\n";
        }
    }
}
