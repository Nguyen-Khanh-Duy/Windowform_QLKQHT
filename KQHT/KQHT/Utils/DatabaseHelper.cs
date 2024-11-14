using System;
using System.Data.SqlClient;

namespace KQHT.Utils
{
    internal class DatabaseHelper : IDisposable
    {
        private SqlConnection conn;

        public DatabaseHelper()
        {
            // Khởi tạo kết nối với chuỗi kết nối chính xác
            conn = new SqlConnection("Data Source=DIZ\\DIZ;Initial Catalog=KQHT;User ID=sa;Password=123;Encrypt=False");
        }

        public void FetchData()
        {
            try
            {
                conn.Open(); // Mở kết nối

                // Sử dụng 'using' để đảm bảo cmd và reader được giải phóng tài nguyên
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM titles", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Sử dụng WriteLine thay vì Writeln
                            Console.WriteLine(reader["title"].ToString());
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message); // In thông báo lỗi
            }
            finally
            {
                conn.Close(); // Đóng kết nối
            }
        }

        // Triển khai IDisposable để đảm bảo tài nguyên được giải phóng
        public void Dispose()
        {
            if (conn != null)
            {
                conn.Dispose();
            }
        }
    }
}
