using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quiz1
{
    public partial class Form1 : Form
    {
        private int turn = 0;

        public Form1()
        {
            InitializeComponent();

            textBoxFirst.TextChanged += TextBox_TextChanged;
            textBoxSecond.TextChanged += TextBox_TextChanged;
            textBoxThird.TextChanged += TextBox_TextChanged;
            textBoxFourth.TextChanged += TextBox_TextChanged;
            textBoxFifth.TextChanged += TextBox_TextChanged;
            textBoxSixth.TextChanged += TextBox_TextChanged;

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // 모든 TextBox의 텍스트가 입력되었는지 확인
            bool allTextBoxesFilled = textBoxFirst.Text.Length > 0 &&
                                        textBoxSecond.Text.Length > 0 &&
                                        textBoxThird.Text.Length > 0 &&
                                        textBoxFourth.Text.Length > 0 &&
                                        textBoxFifth.Text.Length > 0 &&
                                        textBoxSixth.Text.Length > 0;

            // 모든 TextBox에 입력이 되었다면 버튼 활성화, 아니면 비활성화
            buttonInput.Enabled = allTextBoxesFilled;
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            int[] inputNums = new int[6];
            int[] victoryNums = new int[6] { 0, 0, 0, 0, 0, 0 };

            inputNums[0] = int.Parse(textBoxFirst.Text);
            inputNums[1] = int.Parse(textBoxSecond.Text);
            inputNums[2] = int.Parse(textBoxThird.Text);
            inputNums[3] = int.Parse(textBoxFourth.Text);
            inputNums[4] = int.Parse(textBoxFifth.Text);
            inputNums[5] = int.Parse(textBoxSixth.Text);

            if((inputNums[0] <= 0 || inputNums[0] > 45) ||
                (inputNums[1] <= 0 || inputNums[1] > 45) ||
                (inputNums[2] <= 0 || inputNums[2] > 45) ||
                (inputNums[3] <= 0 || inputNums[3] > 45) ||
                (inputNums[4] <= 0 || inputNums[4] > 45) ||
                (inputNums[5] <= 0 || inputNums[5] > 45))
            {
                MessageBox.Show("적절한 입력이 아닙니다.");
                return;
            }

            for(int i = 0; i < inputNums.Length - 1; i++)
                for(int j = i + 1; j < inputNums.Length; j++)
                    if(inputNums[i] == inputNums[j])
                    {
                        MessageBox.Show("적절한 입력이 아닙니다.");
                        return;
                    }

            getVictoryNums(victoryNums);

            /*foreach (int i in victoryNums)
                MessageBox.Show(i.ToString());*/

            AscendingOrder(victoryNums);

            labelFirst.Text = victoryNums[0].ToString();
            labelSecond.Text = victoryNums[1].ToString();
            labelThird.Text = victoryNums[2].ToString();
            labelFourth.Text = victoryNums[3].ToString();
            labelFifth.Text = victoryNums[4].ToString();
            labelSixth.Text = victoryNums[5].ToString();

            string rank = GetRankAndInputRank(inputNums, victoryNums);

            var listViewItem = new ListViewItem(new string[listView.Columns.Count]);

            turn++;

            listViewItem.SubItems[0].Text = turn.ToString();

            for(int i = 1; i < 7; i++)
                listViewItem.SubItems[i].Text = victoryNums[i - 1].ToString();

            listViewItem.SubItems[7].Text = rank;

            listView.Items.Add(listViewItem);

            return;
        }

        private void getVictoryNums(int[] victoryNums)
        {
            Random random = new Random();

            bool isOverlaped;

            for (int i = 0; i < victoryNums.Length; i++)
            {
                do
                {
                    isOverlaped = false;

                    victoryNums[i] = random.Next(1, 46);

                    for(int j = 0; j < i; j++)
                    {
                        if (victoryNums[i] == victoryNums[j])
                        {
                            isOverlaped = true;
                            break;
                        }
                    }
                } while (isOverlaped);
            }

            return;
        }

        private void AscendingOrder(int[] victoryNums)
        {
            for(int i = 0; i < victoryNums.Length; i++)
            {
                for(int j = 0; j < victoryNums.Length; j++)
                {
                    if (victoryNums[i] < victoryNums[j])
                    {
                        int temp = victoryNums[i];
                        victoryNums[i] = victoryNums[j];
                        victoryNums[j] = temp;
                    }
                }
            }
        }

        private string GetRankAndInputRank(int[] inputNums, int[] victoryNums)
        {
            int sameNumCount = 0;
            string rank;

            for (int i = 0; i < inputNums.Length; i++)
                for (int j = 0; j < victoryNums.Length; j++)
                    if (inputNums[i] == victoryNums[j])
                    {
                        sameNumCount++;
                        break;
                    }

            switch(sameNumCount)
            {
                case 3:
                    labelRank.Text = "4 등";
                    rank = "4 등";
                    break;

                case 4:
                    labelRank.Text = "3 등";
                    rank = "3 등";
                    break;

                case 5:
                    labelRank.Text = "2 등";
                    rank = "2 등";
                    break;

                case 6:
                    labelRank.Text = "1 등";
                    rank = "1 등";
                    break;

                default:
                    labelRank.Text = "실패";
                    rank = "실패";
                    break;
            }

            /*if(sameNumCount == 6)
            {
                if()
            }*/

            return rank;
        }

        /*private bool isAllInserted()
        {
            if(textBoxFirst.Text.Length == 0 ||
                textBoxSecond.Text.Length == 0 ||
                textBoxThird.Text.Length == 0 ||
                textBoxFourth.Text.Length == 0 ||
                textBoxFifth.Text.Length == 0 ||
                textBoxSixth.Text.Length == 0)
                return false;

            return true;
        }*/
    }
}
