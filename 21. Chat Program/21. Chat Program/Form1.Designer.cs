namespace _21.Chat_Program
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
            this.txt_All = new System.Windows.Forms.TextBox();
            this.txt_Send = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Server = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_ServerIP = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_All
            // 
            this.txt_All.Location = new System.Drawing.Point(44, 57);
            this.txt_All.Multiline = true;
            this.txt_All.Name = "txt_All";
            this.txt_All.Size = new System.Drawing.Size(803, 650);
            this.txt_All.TabIndex = 0;
            // 
            // txt_Send
            // 
            this.txt_Send.Location = new System.Drawing.Point(44, 789);
            this.txt_Send.Name = "txt_Send";
            this.txt_Send.Size = new System.Drawing.Size(803, 28);
            this.txt_Send.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ServerIP);
            this.groupBox1.Controls.Add(this.btn_Connect);
            this.groupBox1.Controls.Add(this.btn_Server);
            this.groupBox1.Location = new System.Drawing.Point(986, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 402);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "옵션";
            // 
            // btn_Server
            // 
            this.btn_Server.Location = new System.Drawing.Point(90, 73);
            this.btn_Server.Name = "btn_Server";
            this.btn_Server.Size = new System.Drawing.Size(228, 71);
            this.btn_Server.TabIndex = 0;
            this.btn_Server.Text = "서버 켜기";
            this.btn_Server.UseVisualStyleBackColor = true;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(90, 170);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(228, 71);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "연결 끊기";
            this.btn_Connect.UseVisualStyleBackColor = true;
            // 
            // txt_ServerIP
            // 
            this.txt_ServerIP.Location = new System.Drawing.Point(90, 303);
            this.txt_ServerIP.Name = "txt_ServerIP";
            this.txt_ServerIP.Size = new System.Drawing.Size(228, 28);
            this.txt_ServerIP.TabIndex = 2;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(1076, 611);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(228, 71);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "프로그램 종료";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(1076, 746);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(228, 71);
            this.btn_Send.TabIndex = 4;
            this.btn_Send.Text = "보내기";
            this.btn_Send.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 890);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Send);
            this.Controls.Add(this.txt_All);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_All;
        private System.Windows.Forms.TextBox txt_Send;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ServerIP;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Server;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Send;
    }
}

