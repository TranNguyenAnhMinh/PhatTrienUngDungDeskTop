using System;
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
    public partial class frmTrang57 : Form
    {
        public frmTrang57()
        {
            InitializeComponent();
        }

        private void ckbMauChu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMauChu.Checked)
                this.btnButtion.ForeColor = Color.Red;
            else
                this.btnButtion.ForeColor = Color.Black;
        }

        private void ckbMauNen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMauNen.Checked)
                this.btnButtion.BackColor = Color.LightCyan;
            else
                this.btnButtion.BackColor = this.btnButtionFlat.BackColor;
        }

        private void rdFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdFlat.Checked)
                this.btnButtionFlat.FlatStyle = FlatStyle.Flat;
            else
                this.btnButtionFlat.FlatStyle = FlatStyle.Popup;
        }
    }
}
