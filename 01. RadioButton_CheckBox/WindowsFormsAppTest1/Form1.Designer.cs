namespace WindowsFormsAppTest1
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
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.RadioButton = new System.Windows.Forms.GroupBox();
            this.rdoDotum = new System.Windows.Forms.RadioButton();
            this.rdoGulim = new System.Windows.Forms.RadioButton();
            this.rdoGungsuh = new System.Windows.Forms.RadioButton();
            this.CheckBox = new System.Windows.Forms.GroupBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.RadioButton.SuspendLayout();
            this.CheckBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(550, 49);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(130, 59);
            this.btnMessage.TabIndex = 0;
            this.btnMessage.Text = "Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(551, 183);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(129, 64);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(366, 262);
            this.textBox.TabIndex = 2;
            this.textBox.WordWrap = false;
            // 
            // RadioButton
            // 
            this.RadioButton.Controls.Add(this.rdoGungsuh);
            this.RadioButton.Controls.Add(this.rdoGulim);
            this.RadioButton.Controls.Add(this.rdoDotum);
            this.RadioButton.Location = new System.Drawing.Point(12, 292);
            this.RadioButton.Name = "RadioButton";
            this.RadioButton.Size = new System.Drawing.Size(349, 244);
            this.RadioButton.TabIndex = 3;
            this.RadioButton.TabStop = false;
            this.RadioButton.Text = "RadioButton";
            // 
            // rdoDotum
            // 
            this.rdoDotum.AutoSize = true;
            this.rdoDotum.Location = new System.Drawing.Point(7, 28);
            this.rdoDotum.Name = "rdoDotum";
            this.rdoDotum.Size = new System.Drawing.Size(69, 22);
            this.rdoDotum.TabIndex = 0;
            this.rdoDotum.TabStop = true;
            this.rdoDotum.Text = "돋움";
            this.rdoDotum.UseVisualStyleBackColor = true;
            this.rdoDotum.CheckedChanged += new System.EventHandler(this.rdoDotum_CheckedChanged);
            // 
            // rdoGulim
            // 
            this.rdoGulim.AutoSize = true;
            this.rdoGulim.Location = new System.Drawing.Point(7, 86);
            this.rdoGulim.Name = "rdoGulim";
            this.rdoGulim.Size = new System.Drawing.Size(69, 22);
            this.rdoGulim.TabIndex = 1;
            this.rdoGulim.TabStop = true;
            this.rdoGulim.Text = "굴림";
            this.rdoGulim.UseVisualStyleBackColor = true;
            this.rdoGulim.CheckedChanged += new System.EventHandler(this.rdoGulim_CheckedChanged);
            // 
            // rdoGungsuh
            // 
            this.rdoGungsuh.AutoSize = true;
            this.rdoGungsuh.Location = new System.Drawing.Point(7, 147);
            this.rdoGungsuh.Name = "rdoGungsuh";
            this.rdoGungsuh.Size = new System.Drawing.Size(69, 22);
            this.rdoGungsuh.TabIndex = 2;
            this.rdoGungsuh.TabStop = true;
            this.rdoGungsuh.Text = "궁서";
            this.rdoGungsuh.UseVisualStyleBackColor = true;
            this.rdoGungsuh.CheckedChanged += new System.EventHandler(this.rdoGungsuh_CheckedChanged);
            // 
            // CheckBox
            // 
            this.CheckBox.Controls.Add(this.chkItalic);
            this.CheckBox.Controls.Add(this.chkUnderline);
            this.CheckBox.Controls.Add(this.chkBold);
            this.CheckBox.Location = new System.Drawing.Point(387, 292);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(349, 244);
            this.CheckBox.TabIndex = 4;
            this.CheckBox.TabStop = false;
            this.CheckBox.Text = "CheckBox";
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(7, 28);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(69, 22);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Location = new System.Drawing.Point(7, 86);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(107, 22);
            this.chkUnderline.TabIndex = 1;
            this.chkUnderline.Text = "Underline";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(7, 146);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(68, 22);
            this.chkItalic.TabIndex = 2;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 548);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.RadioButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.RadioButton.ResumeLayout(false);
            this.RadioButton.PerformLayout();
            this.CheckBox.ResumeLayout(false);
            this.CheckBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.GroupBox RadioButton;
        private System.Windows.Forms.RadioButton rdoGungsuh;
        private System.Windows.Forms.RadioButton rdoGulim;
        private System.Windows.Forms.RadioButton rdoDotum;
        private System.Windows.Forms.GroupBox CheckBox;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkBold;
    }
}

