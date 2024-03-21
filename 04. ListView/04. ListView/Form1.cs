using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04.ListView
{
    public enum ControlParseCase
    {
        None,
        Name,
        Age,
        Gender
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object select, EventArgs e)
        {
            lvwPeopleInfo.View = View.Details;

            lvwPeopleInfo.Columns.Add("Name", "name");
            lvwPeopleInfo.Columns.Add("Age", "Age");
            lvwPeopleInfo.Columns.Add("Gender", "Gender");
            lvwPeopleInfo.Columns.Add("last", "last");

            lvwPeopleInfo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvwPeopleInfo.Columns.RemoveByKey("last");

            lvwPeopleInfo.Columns[0].TextAlign = HorizontalAlignment.Left;
            lvwPeopleInfo.Columns[1].TextAlign = HorizontalAlignment.Center;
            lvwPeopleInfo.Columns[2].TextAlign = HorizontalAlignment.Right;
        }

        private void clearControls()
        {
            txtName.Clear();
            txtAge.Clear();
            cmbGender.SelectedItem = null;
        }

        private ControlParseCase GetControlParseCase()
        {
            if (string.Equals(txtName.Text, string.Empty)) return ControlParseCase.Name;
            else if (string.Equals(txtAge.Text, string.Empty)) return ControlParseCase.Age;    ///////
            else if (cmbGender.SelectedItem == null) return ControlParseCase.Gender;

            return ControlParseCase.None;
        }

        private Dictionary<string, string> GetControlParseDict()
        {
            return new Dictionary<string, string>()
            {
                { "Name", txtName.Text },
                { "Age", txtAge.Text },
                { "Gender", cmbGender.SelectedItem.ToString() }
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (GetControlParseCase() != ControlParseCase.None) return;

            var lvwItem = new ListViewItem(new string[lvwPeopleInfo.Columns.Count]);

            for (int i = 0; i < lvwPeopleInfo.Columns.Count; i++)
                lvwItem.SubItems[i].Name = lvwPeopleInfo.Columns[i].Name;

            var controlParseDict = GetControlParseDict();

            /*foreach(ColumnHeader item in lvwPeopleInfo.Columns)
                lvwItem.SubItems[item.Name].Text = controlParseDict[item.Name];*/

            foreach (string item in controlParseDict.Keys)
                lvwItem.SubItems[item].Text = controlParseDict[item];   // 오류가 남

            lvwPeopleInfo.Items.Add(lvwItem);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvwPeopleInfo.FocusedItem == null) return;
            lvwPeopleInfo.FocusedItem.Remove();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (GetControlParseCase() != ControlParseCase.None) return;

            var controlParseDict = GetControlParseDict();

            foreach (string item in controlParseDict.Keys)
            {
                var lvwItem = lvwPeopleInfo.FocusedItem;
                lvwItem.SubItems[item].Text = controlParseDict[item];
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }

    }
}
