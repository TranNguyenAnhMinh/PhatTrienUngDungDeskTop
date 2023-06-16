using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang
{
    public class LoaiMH// chuyển thành public class
    {
        private int maLoaiMatHang;
        private string tenLoaiMatHang;
        public LoaiMH() { }
        #region đóng gói dữ liệu
        public int MaLoaiMatHang { get => maLoaiMatHang; set => maLoaiMatHang = value; }
        public string TenLoaiMatHang { get => tenLoaiMatHang; set => tenLoaiMatHang = value; }
        #endregion

        public LoaiMH(int maLoaiMatHang, string tenLoaiMatHang)
        {
            MaLoaiMatHang = maLoaiMatHang;
            TenLoaiMatHang = tenLoaiMatHang;
        }
        public LoaiMH(DataRow row)// tạo loại hàng hóa từ data row
        {
            this.maLoaiMatHang = (int)row[0];
            this.tenLoaiMatHang = row[1].ToString();
        }
    }
}
