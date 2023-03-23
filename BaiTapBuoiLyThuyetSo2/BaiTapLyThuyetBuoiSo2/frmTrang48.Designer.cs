namespace BaiTapLyThuyetBuoiSo2
{
    partial class frmTrang48
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
            this.lbChonNN = new System.Windows.Forms.Label();
            this.cboNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbChonNN
            // 
            this.lbChonNN.AutoSize = true;
            this.lbChonNN.Location = new System.Drawing.Point(37, 58);
            this.lbChonNN.Name = "lbChonNN";
            this.lbChonNN.Size = new System.Drawing.Size(100, 16);
            this.lbChonNN.TabIndex = 0;
            this.lbChonNN.Text = "Chọn ngoại ngữ";
            // 
            // cboNgoaiNgu
            // 
            this.cboNgoaiNgu.FormattingEnabled = true;
            this.cboNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nga"});
            this.cboNgoaiNgu.Location = new System.Drawing.Point(155, 58);
            this.cboNgoaiNgu.Name = "cboNgoaiNgu";
            this.cboNgoaiNgu.Size = new System.Drawing.Size(121, 24);
            this.cboNgoaiNgu.TabIndex = 1;
            this.cboNgoaiNgu.SelectedIndexChanged += new System.EventHandler(this.cboNgoaiNgu_SelectedIndexChanged);
            // 
            // frmTrang48
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 210);
            this.Controls.Add(this.cboNgoaiNgu);
            this.Controls.Add(this.lbChonNN);
            this.Name = "frmTrang48";
            this.Text = "frmTrang48";
            this.Load += new System.EventHandler(this.frmTrang48_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChonNN;
        private System.Windows.Forms.ComboBox cboNgoaiNgu;
    }
}