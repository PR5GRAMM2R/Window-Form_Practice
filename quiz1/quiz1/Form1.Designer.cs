namespace quiz1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView = new System.Windows.Forms.ListView();
            this.trun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secondNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thirdNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fourthNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fifthNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sixthNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.textBoxThird = new System.Windows.Forms.TextBox();
            this.textBoxFourth = new System.Windows.Forms.TextBox();
            this.textBoxFifth = new System.Windows.Forms.TextBox();
            this.textBoxSixth = new System.Windows.Forms.TextBox();
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelThird = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelFourth = new System.Windows.Forms.Label();
            this.labelFifth = new System.Windows.Forms.Label();
            this.labelSixth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelRank = new System.Windows.Forms.Label();
            this.buttonInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.trun,
            this.firstNum,
            this.secondNum,
            this.thirdNum,
            this.fourthNum,
            this.fifthNum,
            this.sixthNum,
            this.rank});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 169);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1368, 732);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // trun
            // 
            this.trun.Text = "회차";
            // 
            // firstNum
            // 
            this.firstNum.Text = "1";
            // 
            // secondNum
            // 
            this.secondNum.Text = "2";
            // 
            // thirdNum
            // 
            this.thirdNum.Text = "3";
            // 
            // fourthNum
            // 
            this.fourthNum.Text = "4";
            // 
            // fifthNum
            // 
            this.fifthNum.Text = "5";
            // 
            // sixthNum
            // 
            this.sixthNum.Text = "6";
            // 
            // rank
            // 
            this.rank.Text = "등수";
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Location = new System.Drawing.Point(72, 41);
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(100, 28);
            this.textBoxFirst.TabIndex = 1;
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Location = new System.Drawing.Point(223, 41);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(100, 28);
            this.textBoxSecond.TabIndex = 2;
            // 
            // textBoxThird
            // 
            this.textBoxThird.Location = new System.Drawing.Point(372, 41);
            this.textBoxThird.Name = "textBoxThird";
            this.textBoxThird.Size = new System.Drawing.Size(100, 28);
            this.textBoxThird.TabIndex = 3;
            // 
            // textBoxFourth
            // 
            this.textBoxFourth.Location = new System.Drawing.Point(524, 41);
            this.textBoxFourth.Name = "textBoxFourth";
            this.textBoxFourth.Size = new System.Drawing.Size(100, 28);
            this.textBoxFourth.TabIndex = 4;
            // 
            // textBoxFifth
            // 
            this.textBoxFifth.Location = new System.Drawing.Point(681, 41);
            this.textBoxFifth.Name = "textBoxFifth";
            this.textBoxFifth.Size = new System.Drawing.Size(100, 28);
            this.textBoxFifth.TabIndex = 5;
            // 
            // textBoxSixth
            // 
            this.textBoxSixth.Location = new System.Drawing.Point(838, 41);
            this.textBoxSixth.Name = "textBoxSixth";
            this.textBoxSixth.Size = new System.Drawing.Size(100, 28);
            this.textBoxSixth.TabIndex = 6;
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Location = new System.Drawing.Point(112, 88);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(18, 18);
            this.labelFirst.TabIndex = 7;
            this.labelFirst.Text = "0";
            // 
            // labelThird
            // 
            this.labelThird.AutoSize = true;
            this.labelThird.Location = new System.Drawing.Point(412, 88);
            this.labelThird.Name = "labelThird";
            this.labelThird.Size = new System.Drawing.Size(18, 18);
            this.labelThird.TabIndex = 8;
            this.labelThird.Text = "0";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(263, 88);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(18, 18);
            this.labelSecond.TabIndex = 9;
            this.labelSecond.Text = "0";
            // 
            // labelFourth
            // 
            this.labelFourth.AutoSize = true;
            this.labelFourth.Location = new System.Drawing.Point(564, 88);
            this.labelFourth.Name = "labelFourth";
            this.labelFourth.Size = new System.Drawing.Size(18, 18);
            this.labelFourth.TabIndex = 10;
            this.labelFourth.Text = "0";
            // 
            // labelFifth
            // 
            this.labelFifth.AutoSize = true;
            this.labelFifth.Location = new System.Drawing.Point(721, 88);
            this.labelFifth.Name = "labelFifth";
            this.labelFifth.Size = new System.Drawing.Size(18, 18);
            this.labelFifth.TabIndex = 11;
            this.labelFifth.Text = "0";
            // 
            // labelSixth
            // 
            this.labelSixth.AutoSize = true;
            this.labelSixth.Location = new System.Drawing.Point(878, 88);
            this.labelSixth.Name = "labelSixth";
            this.labelSixth.Size = new System.Drawing.Size(18, 18);
            this.labelSixth.TabIndex = 12;
            this.labelSixth.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1000, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "등수 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1068, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 18);
            this.label8.TabIndex = 14;
            // 
            // labelRank
            // 
            this.labelRank.AutoSize = true;
            this.labelRank.Location = new System.Drawing.Point(1068, 65);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(41, 18);
            this.labelRank.TabIndex = 15;
            this.labelRank.Text = "- 등";
            // 
            // buttonInput
            // 
            this.buttonInput.Enabled = false;
            this.buttonInput.Location = new System.Drawing.Point(1144, 45);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(174, 61);
            this.buttonInput.TabIndex = 16;
            this.buttonInput.Text = "button1";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 913);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.labelRank);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelSixth);
            this.Controls.Add(this.labelFifth);
            this.Controls.Add(this.labelFourth);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelThird);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.textBoxSixth);
            this.Controls.Add(this.textBoxFifth);
            this.Controls.Add(this.textBoxFourth);
            this.Controls.Add(this.textBoxThird);
            this.Controls.Add(this.textBoxSecond);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.listView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.TextBox textBoxThird;
        private System.Windows.Forms.TextBox textBoxFourth;
        private System.Windows.Forms.TextBox textBoxFifth;
        private System.Windows.Forms.TextBox textBoxSixth;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label labelThird;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelFourth;
        private System.Windows.Forms.Label labelFifth;
        private System.Windows.Forms.Label labelSixth;
        private System.Windows.Forms.ColumnHeader trun;
        private System.Windows.Forms.ColumnHeader firstNum;
        private System.Windows.Forms.ColumnHeader secondNum;
        private System.Windows.Forms.ColumnHeader thirdNum;
        private System.Windows.Forms.ColumnHeader fourthNum;
        private System.Windows.Forms.ColumnHeader fifthNum;
        private System.Windows.Forms.ColumnHeader sixthNum;
        private System.Windows.Forms.ColumnHeader rank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelRank;
        private System.Windows.Forms.Button buttonInput;
    }
}

