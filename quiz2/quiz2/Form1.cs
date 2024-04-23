using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz2
{
    public partial class Form1 : Form
    {
        List<int[]> colorRGBList = new List<int[]>();

        int startNum = 0;

        int redValue;
        int greenValue;
        int blueValue;

        public Form1()
        {
            InitializeComponent();
            InitializeOpenFileDialog();

            timer.Start();
        }

        private void InitializeOpenFileDialog()
        {
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "CSV (*.csv)|*.csv|" + "All files (*.*)|*.*";
            ofd.FileName = "";
        }

        public void Dialog_Changed1(object obj, EventArgs e)
        {
            Form dig = obj as Form;

            colorRGBList.Add(new int[3]);

            colorRGBList[colorRGBList.Count - 1][0] = dig.BackColor.R;
            colorRGBList[colorRGBList.Count - 1][1] = dig.BackColor.G;
            colorRGBList[colorRGBList.Count - 1][2] = dig.BackColor.B;
        }

        public void Dialog_Changed2(object obj, EventArgs e)
        {
            if(ofd.FileName == string.Empty)
            {
                MessageBox.Show("입력된 파일이 없습니다.");
                return;
            }

            string FileName = Path.GetFileName(ofd.FileName);
            StreamWriter sw = new StreamWriter(FileName, true);

            for(int i = 0; i < colorRGBList.Count; i++)
            {
                sw.WriteLine(((colorRGBList[i][0]) + "," + (colorRGBList[i][1]) +
                                "," + (colorRGBList[i][2])).ToString());
            }

            sw.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.Changed1 += new EventHandler(Dialog_Changed1);
            form2.Changed2 += new EventHandler(Dialog_Changed2);
            form2.Show();
        }

        private List<int[]> readCSV(string path)
        {
            StreamReader sr = new StreamReader(path);
            var csvList = new List<string[]>();
            var csvRBGList = new List<int[]>();

            try
            {
                Text = Path.GetFileName(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                    csvList.Add(line.Split(','));
            }
            catch(Exception ex)
            {
                Text = "";
                MessageBox.Show(ex.Message, "File Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sr.Close();
            }

            for(int i = 0; i < csvList.Count; i++)
            {
                csvRBGList.Add(new int[3]);

                csvRBGList[i][0] = int.Parse(csvList[i][0]);
                csvRBGList[i][1] = int.Parse(csvList[i][1]);
                csvRBGList[i][2] = int.Parse(csvList[i][2]);
            }

            return csvRBGList;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                colorRGBList = readCSV(ofd.FileName);

                startNum = 0;

                redValue = colorRGBList[startNum][0];
                greenValue = colorRGBList[startNum][1];
                blueValue = colorRGBList[startNum][2];

                this.BackColor = Color.FromArgb(redValue, greenValue, blueValue);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           if(colorRGBList.Count > 0 )
            {
                startNum = (startNum + 1) % colorRGBList.Count;

                redValue = colorRGBList[startNum][0];
                greenValue = colorRGBList[startNum][1];
                blueValue = colorRGBList[startNum][2];

                this.BackColor = Color.FromArgb(redValue, greenValue, blueValue);
            }
        }
    }
}
