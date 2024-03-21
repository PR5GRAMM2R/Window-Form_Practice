namespace _06.PictureBox
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
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoStretchImage = new System.Windows.Forms.RadioButton();
            this.rdoAutosize = new System.Windows.Forms.RadioButton();
            this.rdoCenterImage = new System.Windows.Forms.RadioButton();
            this.rdoZoom = new System.Windows.Forms.RadioButton();
            this.chbVisible = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // picProfile
            // 
            this.picProfile.Image = global::_06.PictureBox.Properties.Resources.KakaoTalk_20240126_111759148;
            this.picProfile.Location = new System.Drawing.Point(37, 45);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(510, 593);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 0;
            this.picProfile.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(632, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1097, 593);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "프로필 관리";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChange);
            this.groupBox2.Controls.Add(this.txtUrl);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(30, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1031, 203);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "사진 변경";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbVisible);
            this.groupBox3.Controls.Add(this.rdoZoom);
            this.groupBox3.Controls.Add(this.rdoCenterImage);
            this.groupBox3.Controls.Add(this.rdoAutosize);
            this.groupBox3.Controls.Add(this.rdoStretchImage);
            this.groupBox3.Controls.Add(this.rdoNormal);
            this.groupBox3.Location = new System.Drawing.Point(30, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1031, 232);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "옵션";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url ";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(66, 50);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(928, 32);
            this.txtUrl.TabIndex = 1;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(855, 119);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(139, 63);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Location = new System.Drawing.Point(42, 72);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(91, 25);
            this.rdoNormal.TabIndex = 0;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "Normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            this.rdoNormal.CheckedChanged += new System.EventHandler(this.rdoNormal_CheckedChanged);
            // 
            // rdoStretchImage
            // 
            this.rdoStretchImage.AutoSize = true;
            this.rdoStretchImage.Location = new System.Drawing.Point(242, 72);
            this.rdoStretchImage.Name = "rdoStretchImage";
            this.rdoStretchImage.Size = new System.Drawing.Size(146, 25);
            this.rdoStretchImage.TabIndex = 1;
            this.rdoStretchImage.TabStop = true;
            this.rdoStretchImage.Text = "StretchImage";
            this.rdoStretchImage.UseVisualStyleBackColor = true;
            this.rdoStretchImage.CheckedChanged += new System.EventHandler(this.rdoStretchImage_CheckedChanged);
            // 
            // rdoAutosize
            // 
            this.rdoAutosize.AutoSize = true;
            this.rdoAutosize.Location = new System.Drawing.Point(447, 72);
            this.rdoAutosize.Name = "rdoAutosize";
            this.rdoAutosize.Size = new System.Drawing.Size(108, 25);
            this.rdoAutosize.TabIndex = 2;
            this.rdoAutosize.TabStop = true;
            this.rdoAutosize.Text = "Autosize";
            this.rdoAutosize.UseVisualStyleBackColor = true;
            this.rdoAutosize.CheckedChanged += new System.EventHandler(this.rdoAutosize_CheckedChanged);
            // 
            // rdoCenterImage
            // 
            this.rdoCenterImage.AutoSize = true;
            this.rdoCenterImage.Location = new System.Drawing.Point(653, 72);
            this.rdoCenterImage.Name = "rdoCenterImage";
            this.rdoCenterImage.Size = new System.Drawing.Size(140, 25);
            this.rdoCenterImage.TabIndex = 3;
            this.rdoCenterImage.TabStop = true;
            this.rdoCenterImage.Text = "CenterImage";
            this.rdoCenterImage.UseVisualStyleBackColor = true;
            this.rdoCenterImage.CheckedChanged += new System.EventHandler(this.rdoCenterImage_CheckedChanged);
            // 
            // rdoZoom
            // 
            this.rdoZoom.AutoSize = true;
            this.rdoZoom.Location = new System.Drawing.Point(855, 72);
            this.rdoZoom.Name = "rdoZoom";
            this.rdoZoom.Size = new System.Drawing.Size(84, 25);
            this.rdoZoom.TabIndex = 4;
            this.rdoZoom.TabStop = true;
            this.rdoZoom.Text = "Zoom";
            this.rdoZoom.UseVisualStyleBackColor = true;
            this.rdoZoom.CheckedChanged += new System.EventHandler(this.rdoZoom_CheckedChanged);
            // 
            // chbVisible
            // 
            this.chbVisible.AutoSize = true;
            this.chbVisible.Location = new System.Drawing.Point(42, 153);
            this.chbVisible.Name = "chbVisible";
            this.chbVisible.Size = new System.Drawing.Size(99, 25);
            this.chbVisible.TabIndex = 5;
            this.chbVisible.Text = "숨기기";
            this.chbVisible.UseVisualStyleBackColor = true;
            this.chbVisible.CheckedChanged += new System.EventHandler(this.chbVisible_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1772, 693);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picProfile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoZoom;
        private System.Windows.Forms.RadioButton rdoCenterImage;
        private System.Windows.Forms.RadioButton rdoAutosize;
        private System.Windows.Forms.RadioButton rdoStretchImage;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbVisible;
    }
}

