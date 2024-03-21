namespace _07.Event_Handler_Reuse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApple = new System.Windows.Forms.TextBox();
            this.txtBanana = new System.Windows.Forms.TextBox();
            this.btnSummit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apple";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Banana";
            // 
            // txtApple
            // 
            this.txtApple.Location = new System.Drawing.Point(177, 45);
            this.txtApple.Name = "txtApple";
            this.txtApple.Size = new System.Drawing.Size(100, 32);
            this.txtApple.TabIndex = 2;
            this.txtApple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // txtBanana
            // 
            this.txtBanana.Location = new System.Drawing.Point(177, 129);
            this.txtBanana.Name = "txtBanana";
            this.txtBanana.Size = new System.Drawing.Size(100, 32);
            this.txtBanana.TabIndex = 3;
            this.txtBanana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // btnSummit
            // 
            this.btnSummit.Location = new System.Drawing.Point(177, 195);
            this.btnSummit.Name = "btnSummit";
            this.btnSummit.Size = new System.Drawing.Size(100, 38);
            this.btnSummit.TabIndex = 4;
            this.btnSummit.Text = "Summit";
            this.btnSummit.UseVisualStyleBackColor = true;
            this.btnSummit.Click += new System.EventHandler(this.btnSummit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 729);
            this.Controls.Add(this.btnSummit);
            this.Controls.Add(this.txtBanana);
            this.Controls.Add(this.txtApple);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApple;
        private System.Windows.Forms.TextBox txtBanana;
        private System.Windows.Forms.Button btnSummit;
    }
}

