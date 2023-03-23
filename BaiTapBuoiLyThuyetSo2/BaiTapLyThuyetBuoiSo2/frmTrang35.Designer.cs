namespace BaiTapLyThuyetBuoiSo2
{
    partial class frmTrang35
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llbMail = new System.Windows.Forms.LinkLabel();
            this.llbweb = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(83, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ liên hệ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(83, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "trang web";
            // 
            // llbMail
            // 
            this.llbMail.AutoSize = true;
            this.llbMail.Location = new System.Drawing.Point(250, 62);
            this.llbMail.Name = "llbMail";
            this.llbMail.Size = new System.Drawing.Size(123, 16);
            this.llbMail.TabIndex = 2;
            this.llbMail.TabStop = true;
            this.llbMail.Text = "ctk45A@gmail.com";
            this.llbMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbMail_LinkClicked);
            // 
            // llbweb
            // 
            this.llbweb.AutoSize = true;
            this.llbweb.Location = new System.Drawing.Point(250, 106);
            this.llbweb.Name = "llbweb";
            this.llbweb.Size = new System.Drawing.Size(98, 16);
            this.llbweb.TabIndex = 3;
            this.llbweb.TabStop = true;
            this.llbweb.Text = "www.ctk45A.net";
            this.llbweb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbweb_LinkClicked);
            // 
            // frmTrang35
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 179);
            this.Controls.Add(this.llbweb);
            this.Controls.Add(this.llbMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTrang35";
            this.Text = "LinkLabel";
            this.Load += new System.EventHandler(this.frmTrang35_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llbMail;
        private System.Windows.Forms.LinkLabel llbweb;
    }
}

