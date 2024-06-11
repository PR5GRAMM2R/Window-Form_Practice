namespace quiz3_Client
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
            this.lsvNums = new System.Windows.Forms.ListView();
            this.btnCreateNums = new System.Windows.Forms.Button();
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.num1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.num2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.num3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.num4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.num5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.num6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsvNums
            // 
            this.lsvNums.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.count,
            this.num1,
            this.num2,
            this.num3,
            this.num4,
            this.num5,
            this.num6});
            this.lsvNums.HideSelection = false;
            this.lsvNums.Location = new System.Drawing.Point(13, 13);
            this.lsvNums.Name = "lsvNums";
            this.lsvNums.Size = new System.Drawing.Size(425, 425);
            this.lsvNums.TabIndex = 0;
            this.lsvNums.UseCompatibleStateImageBehavior = false;
            // 
            // btnCreateNums
            // 
            this.btnCreateNums.Location = new System.Drawing.Point(501, 187);
            this.btnCreateNums.Name = "btnCreateNums";
            this.btnCreateNums.Size = new System.Drawing.Size(108, 49);
            this.btnCreateNums.TabIndex = 1;
            this.btnCreateNums.Text = "번호 생성";
            this.btnCreateNums.UseVisualStyleBackColor = true;
            this.btnCreateNums.Click += new System.EventHandler(this.btnCreateNums_Click);
            // 
            // count
            // 
            this.count.Text = "회차";
            // 
            // num1
            // 
            this.num1.Text = "1";
            // 
            // num2
            // 
            this.num2.Text = "2";
            // 
            // num3
            // 
            this.num3.Text = "3";
            // 
            // num4
            // 
            this.num4.Text = "4";
            // 
            // num5
            // 
            this.num5.Text = "5";
            // 
            // num6
            // 
            this.num6.Text = "6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.btnCreateNums);
            this.Controls.Add(this.lsvNums);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvNums;
        private System.Windows.Forms.Button btnCreateNums;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader num1;
        private System.Windows.Forms.ColumnHeader num2;
        private System.Windows.Forms.ColumnHeader num3;
        private System.Windows.Forms.ColumnHeader num4;
        private System.Windows.Forms.ColumnHeader num5;
        private System.Windows.Forms.ColumnHeader num6;
    }
}

