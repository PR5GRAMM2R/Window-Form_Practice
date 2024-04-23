namespace quiz0_1
{
    partial class Form2
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOpenColorDialog = new System.Windows.Forms.Button();
            this.cld = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // hsbRed
            // 
            this.hsbRed.Location = new System.Drawing.Point(57, 39);
            this.hsbRed.Maximum = 255;
            this.hsbRed.Name = "hsbRed";
            this.hsbRed.Size = new System.Drawing.Size(677, 62);
            this.hsbRed.TabIndex = 0;
            this.hsbRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbRed_Scroll);
            // 
            // hsbGreen
            // 
            this.hsbGreen.Location = new System.Drawing.Point(57, 128);
            this.hsbGreen.Maximum = 255;
            this.hsbGreen.Name = "hsbGreen";
            this.hsbGreen.Size = new System.Drawing.Size(677, 62);
            this.hsbGreen.TabIndex = 1;
            this.hsbGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbRed_Scroll);
            // 
            // hsbBlue
            // 
            this.hsbBlue.Location = new System.Drawing.Point(57, 215);
            this.hsbBlue.Maximum = 255;
            this.hsbBlue.Name = "hsbBlue";
            this.hsbBlue.Size = new System.Drawing.Size(677, 62);
            this.hsbBlue.TabIndex = 2;
            this.hsbBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbRed_Scroll);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 59);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(598, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 59);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "닫기";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOpenColorDialog
            // 
            this.btnOpenColorDialog.Location = new System.Drawing.Point(314, 337);
            this.btnOpenColorDialog.Name = "btnOpenColorDialog";
            this.btnOpenColorDialog.Size = new System.Drawing.Size(165, 59);
            this.btnOpenColorDialog.TabIndex = 5;
            this.btnOpenColorDialog.Text = "Color Dialog 열기";
            this.btnOpenColorDialog.UseVisualStyleBackColor = true;
            this.btnOpenColorDialog.Click += new System.EventHandler(this.btnOpenColorDialog_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenColorDialog);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.hsbBlue);
            this.Controls.Add(this.hsbGreen);
            this.Controls.Add(this.hsbRed);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar hsbRed;
        private System.Windows.Forms.HScrollBar hsbGreen;
        private System.Windows.Forms.HScrollBar hsbBlue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOpenColorDialog;
        private System.Windows.Forms.ColorDialog cld;
    }
}