namespace _13.FIle_Directory
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
            this.testFileBtn = new System.Windows.Forms.Button();
            this.testDirBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testFileBtn
            // 
            this.testFileBtn.Location = new System.Drawing.Point(160, 86);
            this.testFileBtn.Name = "testFileBtn";
            this.testFileBtn.Size = new System.Drawing.Size(370, 97);
            this.testFileBtn.TabIndex = 0;
            this.testFileBtn.Text = "File.Exists (string filepath)";
            this.testFileBtn.UseVisualStyleBackColor = true;
            this.testFileBtn.Click += new System.EventHandler(this.testFileBtn_Click);
            // 
            // testDirBtn
            // 
            this.testDirBtn.Location = new System.Drawing.Point(160, 239);
            this.testDirBtn.Name = "testDirBtn";
            this.testDirBtn.Size = new System.Drawing.Size(370, 97);
            this.testDirBtn.TabIndex = 1;
            this.testDirBtn.Text = "Directory.Exists (string directorypath)";
            this.testDirBtn.UseVisualStyleBackColor = true;
            this.testDirBtn.Click += new System.EventHandler(this.testDirBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testDirBtn);
            this.Controls.Add(this.testFileBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testFileBtn;
        private System.Windows.Forms.Button testDirBtn;
    }
}

