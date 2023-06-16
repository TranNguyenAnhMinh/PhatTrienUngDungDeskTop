using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBanHang
{
    public  class HangHoa// xóa "internal class" thành "public class"
    {
        private int iDMH;// bôi đen sử dụng ctrl+R+E để đóng gói\
        private string tenMatHang;
        private string loaiMatHang;
        private int soLuongTon;
        private int donGia;
        #region đóng gói
        public int IDMH { get { return iDMH; } set { iDMH = value; } }
        public string TenMatHang { get { return tenMatHang; } set { tenMatHang = value; } }
        public string LoaiMatHang { get { return loaiMatHang; } set { loaiMatHang = value; } }
        public int SoLuongTon { get { return soLuongTon; } set { soLuongTon = value; } }
        public int DonGia { get { return donGia; } set { donGia = value; } }
        #endregion
        public HangHoa(int iDMH,string tenMatHang, string loaiMatHang,int soLuongTon,int donGia) {
            this.IDMH = iDMH;
            this.TenMatHang= tenMatHang;
            this.LoaiMatHang= loaiMatHang;
            this.SoLuongTon= soLuongTon;
            this.DonGia = donGia;
        }
        public HangHoa() { }
        public HangHoa(DataRow row)//gán giá trị cho hàng hóa bằng data row
        {
            this.IDMH =(int)row[0];
            this.TenMatHang = row[1].ToString();
            this.LoaiMatHang =row[2].ToString();
            this.SoLuongTon = (int)row[3];
            this.DonGia = (int)row[4];
        }
    }
}
