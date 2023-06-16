namespace QLBanHang
{
    partial class fLoaiMatHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrLoaiMH = new System.Windows.Forms.DataGridView();
            this.cMaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenLoaiMH = new System.Windows.Forms.TextBox();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoaiMH = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrLoaiMH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrLoaiMH);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách loại mặt hàng";
            // 
            // dgrLoaiMH
            // 
            this.dgrLoaiMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrLoaiMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaLoai,
            this.cTenLoai});
            this.dgrLoaiMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrLoaiMH.Location = new System.Drawing.Point(3, 16);
            this.dgrLoaiMH.Name = "dgrLoaiMH";
            this.dgrLoaiMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrLoaiMH.Size = new System.Drawing.Size(300, 358);
            this.dgrLoaiMH.TabIndex = 0;
            this.dgrLoaiMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrLoaiMH_CellClick);
            // 
            // cMaLoai
            // 
            this.cMaLoai.HeaderText = "Mã loại";
            this.cMaLoai.Name = "cMaLoai";
            this.cMaLoai.Width = 60;
            // 
            // cTenLoai
            // 
            this.cTenLoai.HeaderText = "Tên loại";
            this.cTenLoai.Name = "cTenLoai";
            this.cTenLoai.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên loại mặt hàng";
            // 
            // txtTenLoaiMH
            // 
            this.txtTenLoaiMH.Location = new System.Drawing.Point(356, 140);
            this.txtTenLoaiMH.Name = "txtTenLoaiMH";
            this.txtTenLoaiMH.Size = new System.Drawing.Size(210, 20);
            this.txtTenLoaiMH.TabIndex = 2;
            // 
            // btnDatLai
            // 
            this.btnDatLai.Location = new System.Drawing.Point(366, 166);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(75, 39);
            this.btnDatLai.TabIndex = 3;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.UseVisualStyleBackColor = true;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại mặt hàng";
            // 
            // txtMaLoaiMH
            // 
            this.txtMaLoaiMH.Location = new System.Drawing.Point(356, 87);
            this.txtMaLoaiMH.Name = "txtMaLoaiMH";
            this.txtMaLoaiMH.ReadOnly = true;
            this.txtMaLoaiMH.Size = new System.Drawing.Size(210, 20);
            this.txtMaLoaiMH.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(474, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm loại mặt hàng";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fLoaiMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 399);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.txtMaLoaiMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenLoaiMH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "fLoaiMatHang";
            this.Text = "Danh sách loại mặt hàng";
            this.Load += new System.EventHandler(this.fLoaiMatHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrLoaiMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrLoaiMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenLoaiMH;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLoaiMH;
        private System.Windows.Forms.Button btnAdd;
    }
}