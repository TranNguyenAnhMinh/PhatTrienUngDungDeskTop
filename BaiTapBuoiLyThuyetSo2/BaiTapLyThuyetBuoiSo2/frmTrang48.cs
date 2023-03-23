﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLyThuyetBuoiSo2
{
    public partial class frmTrang48 : Form
    {
        public frmTrang48()
        {
            InitializeComponent();
        }

        private void frmTrang48_Load(object sender, EventArgs e)
        {
            string[] datas = { "Tiếng Anh", "Tiếng Pháp", "Tiếng Nhật", "Tiếng Việt" };
            this.cboNgoaiNgu.DataSource = datas;
        }

        private void cboNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.cboNgoaiNgu.SelectedItem.ToString());
        }
    }
}
