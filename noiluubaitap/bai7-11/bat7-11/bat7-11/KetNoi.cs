using System;
using System.Data;
using System.Data.SqlClient;

namespace SimThe
{
    class KetNoi
    {
        string conStr = @"Data Source=UMA\SQLEXPRESS;Initial Catalog=SimThe;User ID=tuan;Password=123456";

        SqlConnection conn;

        public KetNoi()
        {
            conn = new SqlConnection(conStr);
        }

        // Phương thức kiểm tra kết nối
        public bool KiemTraKetNoi()
        {
            try
            {
                conn.Open();
                conn.Close();
                return true; // Kết nối thành công
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kết nối: " + ex.Message); // Ghi log lỗi nếu kết nối thất bại
                return false;
            }
        }

        // Phương thức lấy dữ liệu từ cơ sở dữ liệu
        public DataSet LayDuLieu(string truyvan)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message); // Ghi log chi tiết lỗi
                return null;
            }
        }

        // Phương thức thực thi các truy vấn không trả về dữ liệu (INSERT, UPDATE, DELETE)
        public bool ThucThi(string truyvan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                int r = cmd.ExecuteNonQuery();
                return r > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thực thi: " + ex.Message); // Ghi log lỗi nếu có lỗi trong quá trình thực thi
                return false;
            }
            finally
            {
                conn.Close(); // Đảm bảo luôn đóng kết nối
            }
        }
    }
}
