using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public void LoadListMH()//hiển thị danh sách mặt hàng lên data gird view
        {
            dgrDSMatHang.Rows.Clear();// xóa danh sách các mặt hàng trước khi thêm mới
            List<HangHoa> listMH =HangHoaDAO.Instance.LoadHangHoaList();//tạo danh sách các mặt hàng
            foreach (HangHoa MH in listMH)// duyệt vòng foreach lấy  mặt hàng từ danh sách các mặt hàng
            {
                dgrDSMatHang.Rows.Add(MH.IDMH, MH.TenMatHang, MH.LoaiMatHang,MH.SoLuongTon, MH.DonGia);//gán giá trị cho data grid view row là thông tin của mặt hàng
                                                                                                       //sau đó thêm mặt hàng vào data grid view row                 
            }

        }
        public void LoadListLoaiMatHang()//hiển thị danh sách các loại mặt hàng
        {
            //dgrDSMatHang.r();
            List<LoaiMH> listLoaiMH = LoaiMHDAO.Instance.LoadLoaiMatHang();//tạo danh sác loại các mặt hàng
            cboLoaiMatHang.DataSource=listLoaiMH;//gán cho combo box loại mặt hàng data source= list danh sách các mặt hàng.
            cboLoaiMatHang.DisplayMember = "tenLoaiMatHang";//gán giá trị hiển thị là thuộc tính tên loại mặt hàng
            cboLoaiMatHang.ValueMember = "maLoaiMatHang";//gán giá trị ẩn của là thuộc tính mã loại mặt hàng
        }
            private void Form1_Load(object sender, EventArgs e)
            {
                LoadListMH();// hiển thị danh sách các mặt hàng
            LoadListLoaiMatHang();//hiển thị danh sác các loại mặt hàng
        }

        private void dgrDSMatHang_CellClick(object sender, DataGridViewCellEventArgs e)//hàm ev khi bấm vào row của danh sách mặt hàng 
        {
            //DataGridViewRow row = dgrDSMatHang.SelectedRows[0];
            if (dgrDSMatHang.SelectedRows[0].Cells[0].Value != null)//kiểm tra nếu hàm được bấm vào có giá trị ở ô 0 khác null 
            {
                txtMaMatHang.Text = dgrDSMatHang.SelectedRows[0].Cells[0].Value.ToString();//gán mã mặt hàng
                txtTenMatHang.Text = dgrDSMatHang.SelectedRows[0].Cells[1].Value.ToString();//gán tên mặt hàng
                cboLoaiMatHang.Text = dgrDSMatHang.SelectedRows[0].Cells[2].Value.ToString();//gán loại mặt hàng
                nupSoLuong.Value = int.Parse(dgrDSMatHang.SelectedRows[0].Cells[3].Value.ToString());//gán số lượng 
                nupDonGia.Value = int.Parse(dgrDSMatHang.SelectedRows[0].Cells[4].Value.ToString());//gán đơn giá
            }
            else btnDatLai.PerformClick();//nếu chọn vào row cuối cùng tức là giá trị row đó bằng null thì nút đặt lại được chạy
        }

        private void btnAdd_Click(object sender, EventArgs e)//hàm thêm mới mặt hàng
        {
            if (txtMaMatHang.Text.Trim() == "")//kiểm tra nếu mã mặt hàng bằng rỗng thì tiếp tục
            {
                if (txtTenMatHang.Text.Trim() != "" && cboLoaiMatHang.Text != "")//kiểm tra tên mặt hàng và loại mặt hàng đã khác rỗng thì tiếp tục
                {
                    List<object> paramether = new List<object>();//tạo danh sách các đối tượng cần truyền
                    paramether.Add(txtTenMatHang.Text.Trim());//thêm tên mặt hàng vào danh sách
                    paramether.Add(cboLoaiMatHang.SelectedValue);//thêm giá trị (value member) của loại mặt hàng vào danh sách
                    paramether.Add(nupSoLuong.Value);//thêm số lượng của mặt hàng vào danh sách
                    paramether.Add(nupDonGia.Value);//thêm đơn giá của mặt hàng vào danh sách
                    if (HangHoaDAO.Instance.ThemMatHang(paramether) == true)//kiểm tra nếu hàm thêm trả về true thì tiếp tục
                    {
                        MessageBox.Show("Thêm thành công");
                        LoadListMH();//hiển thị lại danh sách mặt hàng
                        btnDatLai.PerformClick();//đặt lại thông tin ở các ô
                    }
                    else { MessageBox.Show("Lỗi thông tin"); }
                }
                else MessageBox.Show("Thiếu thông tin");
            }
            else MessageBox.Show("Vui lòng chọn cập nhật thay cho thêm mới");//nếu mã mặt hàng khác rỗng thì hiển thị thông báo
        }

        private void btnUpdate_Click(object sender, EventArgs e)//thêm mặt hàng mới
        {
            if (txtTenMatHang.Text.Trim() != "" && cboLoaiMatHang.Text != ""&&txtMaMatHang.Text.Trim()!="")
            //kiểm tra tên mặt hàng, loại mặt hàng và mã khác rỗng
            {
                //tương tự thêm mặt hàng
                List<object> paramether = new List<object>();
                paramether.Add(txtMaMatHang.Text);
                paramether.Add(txtTenMatHang.Text.Trim());
                paramether.Add(cboLoaiMatHang.SelectedValue);
                paramether.Add(nupSoLuong.Value);
                paramether.Add(nupDonGia.Value);
                if (HangHoaDAO.Instance.SuaMatHang(paramether)==true)
                {
                    MessageBox.Show("Sửa thành công");
                    LoadListMH();
                    btnDatLai.PerformClick();
                }
                else { MessageBox.Show("Lỗi thông tin"); }
            }
            else MessageBox.Show("Thiếu thông tin");
        }

        private void btnThemLoaiMatHang_Click(object sender, EventArgs e)//thêm loại mặt hàng
        {
            fLoaiMatHang formLoai = new fLoaiMatHang();//tạo biến để hiển thị form loại mặt hàng
            formLoai.Show(this);//hiển thị form lên
            LoadListLoaiMatHang();//sau khi kết thúc thì hiển thị lại danh sách loại mặt hàng
            //formLoai.load
        }

        private void btnDatLai_Click(object sender, EventArgs e)//đặt lại các giá trị của ô tex
        {
            if(dgrDSMatHang.SelectedRows.Count > 0)//kiểm tra nếu các row là selected lớn hơn 0 thì chuyển các thành selected=false 
            {
                foreach(DataGridViewRow row in dgrDSMatHang.SelectedRows)
                {
                    row.Selected = false;
                }
            }
            txtMaMatHang.Text = "";
            txtTenMatHang.Text = "";
            cboLoaiMatHang.SelectedIndex = 0;
            nupSoLuong.Value = 0;
            nupDonGia.Value = 1000;
        }

        
    }
    }
