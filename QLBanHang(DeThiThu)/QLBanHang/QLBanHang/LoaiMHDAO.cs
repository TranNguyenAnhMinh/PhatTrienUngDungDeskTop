using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang
{
    public class LoaiMHDAO
    {
        #region phần đóng gói để các class khác chỉ có thể lấy và dùng code không thể sửa
        private static LoaiMHDAO instance;
        public static LoaiMHDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiMHDAO();
                return instance;
            }
            private set { LoaiMHDAO.instance = value; }
        }
        #endregion

        public List<LoaiMH> LoadLoaiMatHang()//lấy danh sách các loại mặt hàng và đổ vào list mặt hàng
        {
            string query = "select * from LoaiMatHang";
            List<LoaiMH> list = new List<LoaiMH>();
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow dr in dt.Rows)//duyệt qua từng data row của data table row
            {
                LoaiMH loai = new LoaiMH(dr);//thêm loại mặt hàng từ data row
                list.Add(loai);//thêm loại mặt hàng vào danh sách mặt hàng
            }
            return list;//trả về danh sách các loại mặt hàng
        }
        public bool ThemSuaLoaiMatHang(string tenLoaiMatHang, string maLMH = null)//hàm thêm và cập nhật mặc hàng, giá trị maLMH nếu không truyền vào mặc định là null
        {
            string query;
            if (maLMH != null)//nếu maLMH khác null thì mặt hàng này sẽ được cập nhật
                query = "Update LoaiMatHang set TenLoai=N'" + tenLoaiMatHang + "' where MaLoai=" + maLMH;
            else query = "insert into LoaiMatHang values (N'" + tenLoaiMatHang +"')";//ngược lại mặt hàng sẽ được thêm vào
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;//trả về true nếu kết quả lớn hơn 0

        }
    }
}
