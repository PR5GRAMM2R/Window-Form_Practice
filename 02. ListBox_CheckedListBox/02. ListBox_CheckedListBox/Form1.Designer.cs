namespace _02.ListBox_CheckedListBox
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
            this.lstLanguages = new System.Windows.Forms.ListBox();
            this.btnList2Checked = new System.Windows.Forms.Button();
            this.btnChecked2List = new System.Windows.Forms.Button();
            this.cklLanguages = new System.Windows.Forms.CheckedListBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnChecked2TextBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLanguages
            // 
            this.lstLanguages.FormattingEnabled = true;
            this.lstLanguages.ItemHeight = 18;
            this.lstLanguages.Items.AddRange(new object[] {
            "Java",
            "C",
            "C++",
            "Python",
            "C#",
            "Visual Basic .NET",
            "PHP",
            "JavaScript"});
            this.lstLanguages.Location = new System.Drawing.Point(31, 30);
            this.lstLanguages.Name = "lstLanguages";
            this.lstLanguages.Size = new System.Drawing.Size(297, 202);
            this.lstLanguages.TabIndex = 0;
            // 
            // btnList2Checked
            // 
            this.btnList2Checked.Location = new System.Drawing.Point(380, 79);
            this.btnList2Checked.Name = "btnList2Checked";
            this.btnList2Checked.Size = new System.Drawing.Size(75, 23);
            this.btnList2Checked.TabIndex = 1;
            this.btnList2Checked.Text = "→";
            this.btnList2Checked.UseVisualStyleBackColor = true;
            this.btnList2Checked.Click += new System.EventHandler(this.btnList2Checked_Click);
            // 
            // btnChecked2List
            // 
            this.btnChecked2List.Location = new System.Drawing.Point(380, 149);
            this.btnChecked2List.Name = "btnChecked2List";
            this.btnChecked2List.Size = new System.Drawing.Size(75, 23);
            this.btnChecked2List.TabIndex = 2;
            this.btnChecked2List.Text = "←";
            this.btnChecked2List.UseVisualStyleBackColor = true;
            this.btnChecked2List.Click += new System.EventHandler(this.btnChecked2List_Click);
            // 
            // cklLanguages
            // 
            this.cklLanguages.CheckOnClick = true;
            this.cklLanguages.FormattingEnabled = true;
            this.cklLanguages.Location = new System.Drawing.Point(509, 30);
            this.cklLanguages.Name = "cklLanguages";
            this.cklLanguages.Size = new System.Drawing.Size(279, 204);
            this.cklLanguages.TabIndex = 3;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(31, 245);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNote.Size = new System.Drawing.Size(297, 174);
            this.txtNote.TabIndex = 4;
            this.txtNote.WordWrap = false;
            // 
            // btnChecked2TextBox
            // 
            this.btnChecked2TextBox.Location = new System.Drawing.Point(600, 316);
            this.btnChecked2TextBox.Name = "btnChecked2TextBox";
            this.btnChecked2TextBox.Size = new System.Drawing.Size(75, 47);
            this.btnChecked2TextBox.TabIndex = 6;
            this.btnChecked2TextBox.Text = "⇐";
            this.btnChecked2TextBox.UseVisualStyleBackColor = true;
            this.btnChecked2TextBox.Click += new System.EventHandler(this.btnChecked2TextBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChecked2TextBox);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cklLanguages);
            this.Controls.Add(this.btnChecked2List);
            this.Controls.Add(this.btnList2Checked);
            this.Controls.Add(this.lstLanguages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLanguages;
        private System.Windows.Forms.Button btnList2Checked;
        private System.Windows.Forms.Button btnChecked2List;
        private System.Windows.Forms.CheckedListBox cklLanguages;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnChecked2TextBox;
    }
}

