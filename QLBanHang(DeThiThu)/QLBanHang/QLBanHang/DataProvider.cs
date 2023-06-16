using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//thêm thư viên này vào
using System.Data.SqlClient;//thêm thư viện này vào
using System.Net;
using System.Drawing;
using System.Xml.Linq;

namespace QLBanHang
{
    public class DataProvider//nhớ là class public
    {
        string connectionString = "Data Source=.;DATABASE=QLBanHang;Integrated Security=True";
        //vào tool->connection to database-> chọn sever name->chọn database name-> advance-> copy dòng dưới cùng và sửa "Initial Catalog" thành "database"

        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }
        public DataProvider()
        {
        }
        //hàm ExcuteQuery trả về toàn bộ câu truy vấn mà bạn đưa vào thường để lấy data
        public DataTable ExcuteQuery(string query, List<object>paramether = null)//chuyền câu query và danh sách các dữ liệu vào nếu k chuyền danh sách thì danh sách sẽ mặc định là null
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))//hàm using tự giải phóng bộ nhớ sau khi kết thúc quá trình 
            {
                conn.Open();//mở cổng tới database để lấy dữ liệu
                SqlCommand sqlCommand = new SqlCommand(query, conn);// tạo câu query xuống database truyền câu query và link sql connection
                if (paramether != null)
                {
                    int i = 0;
                    string[] listPara = query.Split(' ');// cắt chuỗi query theo dấu cách
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))//nếu para chứa @ thì sẽ thay đổi para này thành dữ liệu của paramether 
                                               // ví dụ exec LoaiMatHang @TenLoaiMH thì sẽ thay @TenLoaiMH thành tên mặt hàng
                        {
                            sqlCommand.Parameters.AddWithValue(para, paramether[i]);
                            i++;
                        }
                    }

                }
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);//sử dụng sql adapter để lấy dữ liệu lên
                adapter.Fill(dt);//dổ dữ liệu từ adapter vào data table 
                conn.Close();//đóng kết nối
                return dt;
            }
        }

        //hàm ExecuteNonQuery trả về giá trị thành công của câu truy vấn thường dùng để kiểm tra tính xem thêm sửa xóa có hoạt động bằng cách giá trị trả về lớn hơn 0
        public int ExecuteNonQuery(string query, List<object> paramether = null)//chuyền câu query và danh sách các dữ liệu vào nếu k chuyền danh sách thì danh sách sẽ mặc định là null
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))//hàm using tự giải phóng bộ nhớ sau khi kết thúc quá trình 
            {
                conn.Open();//mở cổng tới database để lấy dữ liệu
                SqlCommand sqlCommand = new SqlCommand(query, conn);// tạo câu query xuống database truyền câu query và link sql connection
                if (paramether != null)
                {
                    int i = 0;
                    string[] listPara = query.Split(' ');// cắt chuỗi query theo dấu cách
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))//nếu para chứa @ thì sẽ thay đổi para này thành dữ liệu của paramether 
                                               // ví dụ exec LoaiMatHang @TenLoaiMH thì sẽ thay @TenLoaiMH thành tên mặt hàng
                        {
                            sqlCommand.Parameters.AddWithValue(para, paramether[i]);
                            i++;
                        }
                    }

                }
                count = sqlCommand.ExecuteNonQuery();
                conn.Close();
                return count;
            }
        }

        //hàm ExecuteScalar trả về dòng đầu tiên cell đầu tiên của câu truy vấn thường để dùng lấy giá trị lớn nhất 
        public object ExecuteScalar(string query, List<object> paramether = null)//chuyền câu query và danh sách các dữ liệu vào nếu k chuyền danh sách thì danh sách sẽ mặc định là null
        {
            object dt = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))//hàm using tự giải phóng bộ nhớ sau khi kết thúc quá trình 
            {
                conn.Open();//mở cổng tới database để lấy dữ liệu
                SqlCommand sqlCommand = new SqlCommand(query, conn);// tạo câu query xuống database truyền câu query và link sql connection
                if (paramether != null)
                {
                    int i = 0;
                    string[] listPara = query.Split(' ');// cắt chuỗi query theo dấu cách
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))//nếu para chứa @ thì sẽ thay đổi para này thành dữ liệu của paramether 
                                               // ví dụ exec LoaiMatHang @TenLoaiMH thì sẽ thay @TenLoaiMH thành tên mặt hàng
                        {
                            sqlCommand.Parameters.AddWithValue(para, paramether[i]);
                            i++;
                        }
                    }

                }
                dt = sqlCommand.ExecuteScalar();
                conn.Close();
                return dt;
            }
        }
    }
}