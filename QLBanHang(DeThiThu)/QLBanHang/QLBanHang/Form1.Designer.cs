namespace QLBanHang
{
    partial class Form1
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
            this.btnDatLai = new System.Windows.Forms.Button();
            this.btnThemLoaiMatHang = new System.Windows.Forms.Button();
            this.nupDonGia = new System.Windows.Forms.NumericUpDown();
            this.nupSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cboLoaiMatHang = new System.Windows.Forms.ComboBox();
            this.txtTenMatHang = new System.Windows.Forms.TextBox();
            this.txtMaMatHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrDSMatHang = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cMaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenLoaiMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDSMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDatLai);
            this.groupBox1.Controls.Add(this.btnThemLoaiMatHang);
            this.groupBox1.Controls.Add(this.nupDonGia);
            this.groupBox1.Controls.Add(this.nupSoLuong);
            this.groupBox1.Controls.Add(this.cboLoaiMatHang);
            this.groupBox1.Controls.Add(this.txtTenMatHang);
            this.groupBox1.Controls.Add(this.txtMaMatHang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết mặt hàng";
            // 
            // btnDatLai
            // 
            this.btnDatLai.Location = new System.Drawing.Point(465, 115);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(94, 35);
            this.btnDatLai.TabIndex = 4;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.UseVisualStyleBackColor = true;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // btnThemLoaiMatHang
            // 
            this.btnThemLoaiMatHang.Location = new System.Drawing.Point(465, 74);
            this.btnThemLoaiMatHang.Name = "btnThemLoaiMatHang";
            this.btnThemLoaiMatHang.Size = new System.Drawing.Size(94, 35);
            this.btnThemLoaiMatHang.TabIndex = 4;
            this.btnThemLoaiMatHang.Text = "Thêm loại";
            this.btnThemLoaiMatHang.UseVisualStyleBackColor = true;
            this.btnThemLoaiMatHang.Click += new System.EventHandler(this.btnThemLoaiMatHang_Click);
            // 
            // nupDonGia
            // 
            this.nupDonGia.Location = new System.Drawing.Point(136, 187);
            this.nupDonGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nupDonGia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupDonGia.Name = "nupDonGia";
            this.nupDonGia.Size = new System.Drawing.Size(298, 20);
            this.nupDonGia.TabIndex = 3;
            this.nupDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupDonGia.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nupSoLuong
            // 
            this.nupSoLuong.Location = new System.Drawing.Point(136, 153);
            this.nupSoLuong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupSoLuong.Name = "nupSoLuong";
            this.nupSoLuong.Size = new System.Drawing.Size(298, 20);
            this.nupSoLuong.TabIndex = 3;
            this.nupSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboLoaiMatHang
            // 
            this.cboLoaiMatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiMatHang.FormattingEnabled = true;
            this.cboLoaiMatHang.Location = new System.Drawing.Point(136, 112);
            this.cboLoaiMatHang.Name = "cboLoaiMatHang";
            this.cboLoaiMatHang.Size = new System.Drawing.Size(298, 21);
            this.cboLoaiMatHang.TabIndex = 2;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Location = new System.Drawing.Point(136, 71);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(298, 20);
            this.txtTenMatHang.TabIndex = 1;
            // 
            // txtMaMatHang
            // 
            this.txtMaMatHang.Location = new System.Drawing.Point(136, 32);
            this.txtMaMatHang.Name = "txtMaMatHang";
            this.txtMaMatHang.ReadOnly = true;
            this.txtMaMatHang.Size = new System.Drawing.Size(298, 20);
            this.txtMaMatHang.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Mặt Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Mặt Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại Mặt Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Mặt Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Mặt Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrDSMatHang);
            this.groupBox2.Location = new System.Drawing.Point(12, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 377);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách mặt hàng";
            // 
            // dgrDSMatHang
            // 
            this.dgrDSMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDSMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaHH,
            this.cTenHH,
            this.cTenLoaiMH,
            this.cSoLuong,
            this.cDonGia});
            this.dgrDSMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrDSMatHang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgrDSMatHang.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgrDSMatHang.Location = new System.Drawing.Point(3, 16);
            this.dgrDSMatHang.Name = "dgrDSMatHang";
            this.dgrDSMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrDSMatHang.Size = new System.Drawing.Size(580, 358);
            this.dgrDSMatHang.TabIndex = 0;
            this.dgrDSMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDSMatHang_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(329, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(467, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cMaHH
            // 
            this.cMaHH.HeaderText = "Mã MH";
            this.cMaHH.Name = "cMaHH";
            this.cMaHH.Width = 70;
            // 
            // cTenHH
            // 
            this.cTenHH.HeaderText = "Tên mặt hàng";
            this.cTenHH.Name = "cTenHH";
            this.cTenHH.Width = 150;
            // 
            // cTenLoaiMH
            // 
            this.cTenLoaiMH.HeaderText = "Tên loại mặt hàng";
            this.cTenLoaiMH.Name = "cTenLoaiMH";
            this.cTenLoaiMH.Width = 150;
            // 
            // cSoLuong
            // 
            this.cSoLuong.HeaderText = "Số lượng còn";
            this.cSoLuong.Name = "cSoLuong";
            this.cSoLuong.Width = 70;
            // 
            // cDonGia
            // 
            this.cDonGia.HeaderText = "Đơn giá";
            this.cDonGia.Name = "cDonGia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 652);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Quản lý bán hàng cho tạp hóa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDSMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nupDonGia;
        private System.Windows.Forms.NumericUpDown nupSoLuong;
        private System.Windows.Forms.ComboBox cboLoaiMatHang;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private System.Windows.Forms.TextBox txtMaMatHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemLoaiMatHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrDSMatHang;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenLoaiMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonGia;
    }
}

