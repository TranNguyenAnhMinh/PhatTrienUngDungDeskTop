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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        

        private void btnfrm35_Click(object sender, EventArgs e)
        {
            var form = new frmTrang35();
            form.ShowDialog();
        }

        private void btnfrm42_Click(object sender, EventArgs e)
        {
            var form = new frmTrang42();
            form.ShowDialog();
        }

        private void btnfrm48_Click(object sender, EventArgs e)
        {
            var form = new frmTrang48();
            form.ShowDialog();
        }

        private void btnfrm52_Click(object sender, EventArgs e)
        {
            var form = new frmTrang52();
            form.ShowDialog();
        }

        private void btnfrm56_Click(object sender, EventArgs e)
        {
            var form = new frmTrang56();
            form.ShowDialog();
        }

        private void btnfrm57_Click(object sender, EventArgs e)
        {
            var form = new frmTrang57();
            form.ShowDialog();
        }

        private void btnfrm60_Click(object sender, EventArgs e)
        {
            var form = new frmTrang60();
            form.ShowDialog();
        }
    }
}
