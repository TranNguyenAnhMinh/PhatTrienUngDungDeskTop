using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class fLoaiMatHang : Form
    {
        public fLoaiMatHang()
        {
            InitializeComponent();
        }

        private void dgrLoaiMH_CellClick(object sender, DataGridViewCellEventArgs e)//hiển thị thông tin của row được chọn
        {
            if (dgrLoaiMH.SelectedRows[0].Cells[0].Value != null)//nếu row được chọn có giá trị khác null
            {
                txtMaLoaiMH.Text = dgrLoaiMH.SelectedRows[0].Cells[0].Value.ToString();//gán mã
                txtTenLoaiMH.Text = dgrLoaiMH.SelectedRows[0].Cells[1].Value.ToString();//gán tên
            }
            else//nếu row được chọn bằng null thì gán rỗng
            {
                txtMaLoaiMH.Text = "";
                txtTenLoaiMH.Text = "";
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)//đặt lạic các giá trị của ô tương tự bên kia
        {
            if(dgrLoaiMH.SelectedRows.Count>0)
                foreach(DataGridViewRow row in dgrLoaiMH.SelectedRows)
                    row.Selected= false;
            txtMaLoaiMH.Text = "";
            txtTenLoaiMH.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)//thêm mới cập nhật 
        {
            bool check = false;
            if (txtMaLoaiMH.Text.Trim() != "" && txtTenLoaiMH.Text.Trim() != "")//nếu mã loại và tên loại khác rỗng
            {
                check = LoaiMHDAO.Instance.ThemSuaLoaiMatHang(txtTenLoaiMH.Text, txtMaLoaiMH.Text);//gọi hàm và truyền cả tên loại và mã loại (tức là sửa)
            }
            else if (txtTenLoaiMH.Text.Trim() != "")//nếu mã loại bằng rỗng và tên loại khác rỗng 
            {
                check = LoaiMHDAO.Instance.ThemSuaLoaiMatHang(txtTenLoaiMH.Text);//gọi hàm chỉ truyền vào tên loại (tức là thêm)
            }
            if (check == true)//nếu  giá trị được gán đúng
            {
                MessageBox.Show("Thao tác thành công");
                LoadLoaiMatHang();//hiển thị lại danh sách loại mặt hàng
            }
            else MessageBox.Show("Thiếu thông tin");


        }

        private void fLoaiMatHang_Load(object sender, EventArgs e)
        {
            LoadLoaiMatHang();
        }
        void LoadLoaiMatHang()
        {
            dgrLoaiMH.Rows.Clear();//xóa danh sách các mặt hàng trước khi load
            List<LoaiMH> list = LoaiMHDAO.Instance.LoadLoaiMatHang();//tạo danh sách các loại mặt hàng
            foreach (LoaiMH item in list)//duyệt foreach qua loại mặt hàng
            {
                dgrLoaiMH.Rows.Add(item.MaLoaiMatHang, item.TenLoaiMatHang);//thêm vào data grid view row các giá trị và thêm vào data grid view
            }
        }
    }
}
