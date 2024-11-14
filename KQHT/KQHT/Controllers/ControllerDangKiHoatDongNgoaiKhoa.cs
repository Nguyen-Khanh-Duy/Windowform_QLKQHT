using KQHT.Model;
using KQHT.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KQHT.Controllers
{
    internal class ControllerDangKiHoatDongNgoaiKhoa : IController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Connectsql"].ConnectionString;
        private List<IModel> items = new List<IModel>();
        public List<IModel> Items { get; private set; }
        public List<IModel> Itemss
        {
            get { return items; }
        }
        List<IModel> IController.Items => this.Items;
        // Tải danh sách từ database
        public bool Load()
        {
            try
            {
                List<IModel> dangkihoatdongngoaikhoa = new List<IModel>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM DangKiHoatDongNgoaiKhoa";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModelDangKiHoatDongNgoaiKhoa dk = new ModelDangKiHoatDongNgoaiKhoa
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaDK = reader["MaDK"].ToString(),                                  
                                    MaSV = reader["MaSV"].ToString(),
                                    MaHD = reader["MaHD"].ToString(),
                                    NgayDK = reader["NgayDK"] != DBNull.Value ? Convert.ToDateTime(reader["NgayDK"]) : DateTime.MinValue,
                                
                                };
                                dangkihoatdongngoaikhoa.Add(dk);
                            }
                        }
                    }
                }
                this.Items = dangkihoatdongngoaikhoa;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        // Thêm một mới vào database
        public bool Add(IModel model)
        {
            if (model is ModelDangKiHoatDongNgoaiKhoa dk)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO DangKiHoatDongNgoaiKhoa (STT, MaDK, MaSV, MaHD, NgayDK) " +
                                  "VALUES (@STT, @MaDK, @MaSV, @MaHD, @NgayDK)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@STT", dk.STT);
                            cmd.Parameters.AddWithValue("@MaDK", dk.MaDK);
                            cmd.Parameters.AddWithValue("@MaSV", dk.MaSV);
                            cmd.Parameters.AddWithValue("@MaHD", dk.MaHD);
                            cmd.Parameters.AddWithValue("@NgayDK", dk.NgayDK);                          
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true; // Trả về true nếu thao tác thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm DangKiHoatDongNgoaiKhoa: " + ex.Message);
                    return false; // Trả về false nếu có lỗi xảy ra
                }
            }
            return false; // Trả về false nếu mô hình không đúng loại
        }
        // Xóa theo ID
        public bool Delete(object id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM DangKiHoatDongNgoaiKhoa WHERE MaDK= @MaDK";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDK", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        public bool Delete(IModel model)
        {
            try
            {
                ModelDangKiHoatDongNgoaiKhoa dk = (ModelDangKiHoatDongNgoaiKhoa)model;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM DangKiHoatDongNgoaiKhoa WHERE MaDK = @MaDK";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDK", dk.MaDK);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true; // Xóa thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false; // Xóa thất bại
            }
        }
        // Cập nhật thông tin 
        public bool Update(IModel model)
        {
            try
            {
                ModelDangKiHoatDongNgoaiKhoa dk = (ModelDangKiHoatDongNgoaiKhoa)model;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE DangKiHoatDongNgoaiKhoa SET STT = @STT, MaSV = @MaSV," +
                                    " MaHD = @MaHD, NgayDK = @NgayDK WHERE MaDK= @MaDK";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@STT", dk.STT);
                        cmd.Parameters.AddWithValue("@MaDK", dk.MaDK);
                        cmd.Parameters.AddWithValue("@MaSV", dk.MaSV);
                        cmd.Parameters.AddWithValue("@MaHD", dk.MaHD);
                        cmd.Parameters.AddWithValue("@NgayDK", dk.NgayDK);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Kiểm tra xem  có tồn tại không
        public bool IsExist(object id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM DangKiHoatDongNgoaiKhoa WHERE MaDK = @MaDK";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDK", id);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Đọc thông tin theo ID
        public IModel Read(object id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM DangKiHoatDongNgoaiKhoa WHERE MaDK = @MaDK";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDK", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new ModelDangKiHoatDongNgoaiKhoa
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaDK = reader["MaDK"].ToString(),
                                    MaSV = reader["MaSV"].ToString(),
                                    MaHD = reader["MaHD"].ToString(),
                                    NgayDK = reader["NgayDK"] != DBNull.Value ? Convert.ToDateTime(reader["NgayDK"]) : DateTime.MinValue,
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
        }
        internal List<ModelDangKiHoatDongNgoaiKhoa> Search(string searchQuery)
        {
            try
            {
                List<ModelDangKiHoatDongNgoaiKhoa> filteredList = new List<ModelDangKiHoatDongNgoaiKhoa>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Sử dụng LIKE trong SQL để tìm kiếm 
                    string query = "SELECT * FROM DangKiHoatDongNgoaiKhoa WHERE MaDK LIKE @SearchQuery OR MaSV LIKE @SearchQuery OR MaHD LIKE @SearchQuery";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số tìm kiếm với ký tự đại diện "%"
                        cmd.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                        // Thực hiện truy vấn và đọc kết quả
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                ModelDangKiHoatDongNgoaiKhoa dk = new ModelDangKiHoatDongNgoaiKhoa
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaDK = reader["MaDK"].ToString(),
                                    MaSV = reader["MaSV"].ToString(),
                                    MaHD = reader["MaHD"].ToString(),
                                    NgayDK = reader["NgayDK"] != DBNull.Value ? Convert.ToDateTime(reader["NgayDK"]) : DateTime.MinValue,
                                };

                                filteredList.Add(dk);
                            }
                        }
                    }
                }

                return filteredList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm : " + ex.Message);
                return new List<ModelDangKiHoatDongNgoaiKhoa>(); // Nếu có lỗi, trả về danh sách rỗng
            }
        }
    }
}
