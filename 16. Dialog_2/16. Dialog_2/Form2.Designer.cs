namespace _16.Dialog_2
{
    partial class MyApplyDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hsbRed = new System.Windows.Forms.HScrollBar();
            this.hsbGreen = new System.Windows.Forms.HScrollBar();
            this.hsbBlue = new System.Windows.Forms.HScrollBar();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hsbRed
            // 
            this.hsbRed.Location = new System.Drawing.Point(94, 64);
            this.hsbRed.Maximum = 255;
            this.hsbRed.Name = "hsbRed";
            this.hsbRed.Size = new System.Drawing.Size(601, 45);
            this.hsbRed.TabIndex = 0;
            this.hsbRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Color_Scroll);
            // 
            // hsbGreen
            // 
            this.hsbGreen.Location = new System.Drawing.Point(94, 124);
            this.hsbGreen.Maximum = 255;
            this.hsbGreen.Name = "hsbGreen";
            this.hsbGreen.Size = new System.Drawing.Size(601, 45);
            this.hsbGreen.TabIndex = 1;
            this.hsbGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Color_Scroll);
            // 
            // hsbBlue
            // 
            this.hsbBlue.Location = new System.Drawing.Point(94, 183);
            this.hsbBlue.Maximum = 255;
            this.hsbBlue.Name = "hsbBlue";
            this.hsbBlue.Size = new System.Drawing.Size(601, 45);
            this.hsbBlue.TabIndex = 2;
            this.hsbBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Color_Scroll);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(94, 303);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(142, 81);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(319, 303);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(142, 81);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "적용";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(553, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 81);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MyApplyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.hsbBlue);
            this.Controls.Add(this.hsbGreen);
            this.Controls.Add(this.hsbRed);
            this.Name = "MyApplyDialog";
            this.Text = "MyApplyDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar hsbRed;
        private System.Windows.Forms.HScrollBar hsbGreen;
        private System.Windows.Forms.HScrollBar hsbBlue;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
    }
}