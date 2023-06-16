using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public class HangHoaDAO //chuyển class thành public
    {
        #region phần giúp cho các đoạn code không thể tác động làm thay đổi code trong bài làm
        private static HangHoaDAO instance;
        public static HangHoaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HangHoaDAO();
                return instance;
            }
            private set { HangHoaDAO.instance = value; }
        }

        private HangHoaDAO() { }
        #endregion

        public List<HangHoa> LoadHangHoaList()//lấy danh sách các hàng hóa đổ vào list hàng hóa
        {
            List<HangHoa> ListHH = new List<HangHoa>();
            DataTable dt = new DataTable();
            string query = "select MaMatHang,TenLoaiMatHang,TenLoai,SoLuongTon,DonGia from MatHang,LoaiMatHang where LoaiMatHang=MaLoai";
            dt = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in dt.Rows)//duyệt foreach lấy data row từ data table row
            {
                HangHoa hangHoa = new HangHoa(row);//tạo mới hàng hóa truyền data row
                ListHH.Add(hangHoa);//thêm hàng hóa vào danh sách
            }
            return ListHH;// trả về mảng danh sách các hàng hóa
        }
        public bool ThemMatHang(List<object> paramether)//thêm hàng hóa vào database sử dụng list các object 
        {
        return DataProvider.Instance.ExecuteNonQuery("USP_ThemHang @TenLoaiMatHang , @LoaiMatHang , @SoLuongTon , @DonGia ", paramether)>0;//trả về true nếu kết quả lớn hơn 0
            //LƯU Ý KHI DÙNG CÂU TRUY VẤN DẤU PHẨY PHẢI KHÔNG ĐƯỢC DÍNH VỚI CHỮ NẾU DÍNH SẼ LỖI TRUY VẤN BÊN DATA PROVIDER
        }
        public bool SuaMatHang(List<object> paramether)//sửa hàng hóa vào database sử dụng list các object 
        {
            return DataProvider.Instance.ExecuteNonQuery("USP_SuaHang @MaMatHang , @TenLoaiMatHang , @LoaiMatHang , @SoLuongTon , @DonGia ", paramether) > 0;//trả về true nếu kết quả lớn hơn 0
            //LƯU Ý KHI DÙNG CÂU TRUY VẤN DẤU PHẨY PHẢI KHÔNG ĐƯỢC DÍNH VỚI CHỮ NẾU DÍNH SẼ LỖI TRUY VẤN BÊN DATA PROVIDER
        }
    }

}


