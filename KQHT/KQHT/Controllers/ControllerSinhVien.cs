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
    internal class ControllerSinhVien : IController
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
                List<IModel> sinhvien = new List<IModel>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM SinhVien";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModelSinhVien sv = new ModelSinhVien
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaSV = reader["MaSV"].ToString(),
                                    TenSV = reader["TenSV"].ToString(),
                                    NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                                    GioiTinh = reader["GioiTinh"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    SDT = reader["SDT"].ToString(),
                                    MoTa = reader["MoTa"].ToString()
                                };
                                sinhvien.Add(sv);
                            }
                        }
                    }
                }
                this.Items = sinhvien;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading student data: " + ex.Message);
                return false;
            }
        }

        // Thêm một sinh viên mới vào database
        public bool Add(IModel model)
{
    if (model is ModelSinhVien sinhVien)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO SinhVien (STT, MaSV, TenSV, NgaySinh, GioiTinh, Email, SDT, MoTa) VALUES (@STT, @MaSV, @TenSV, @NgaySinh, @GioiTinh, @Email, @SDT, @MoTa)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@STT", sinhVien.STT);
                    cmd.Parameters.AddWithValue("@MaSV", sinhVien.MaSV);
                    cmd.Parameters.AddWithValue("@TenSV", sinhVien.TenSV);
                    cmd.Parameters.AddWithValue("@NgaySinh", sinhVien.NgaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", sinhVien.GioiTinh);
                    cmd.Parameters.AddWithValue("@Email", sinhVien.Email);
                    cmd.Parameters.AddWithValue("@SDT", sinhVien.SDT);
                    cmd.Parameters.AddWithValue("@MoTa", sinhVien.MoTa);
                    cmd.ExecuteNonQuery();
                }
            }
            return true; // Trả về true nếu thao tác thành công
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message);
            return false; // Trả về false nếu có lỗi xảy ra
        }
    }
    return false; // Trả về false nếu mô hình không đúng loại
}


        // Xóa sinh viên theo ID
        public bool Delete(object id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM SinhVien WHERE MaSV = @MaSV";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting student: " + ex.Message);
                return false;
            }
        }
        public bool Delete(IModel model)
        {
            try
            {
                ModelSinhVien sv = (ModelSinhVien)model; // Ép kiểu từ IModel sang ModelSinhVien
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM SinhVien WHERE MaSV = @MaSV";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", sv.MaSV); // Thêm tham số
                        cmd.ExecuteNonQuery();
                    }
                }
                return true; // Xóa thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting student: " + ex.Message);
                return false; // Xóa thất bại
            }
        }
        // Cập nhật thông tin sinh viên
        public bool Update(IModel model)
        {
            try
            {
                ModelSinhVien sv = (ModelSinhVien)model;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE SinhVien SET STT = @STT, TenSV = @TenSV, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, " +
                                   "Email = @Email, SDT = @SDT, MoTa = @MoTa WHERE MaSV = @MaSV";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@STT", sv.STT);
                        cmd.Parameters.AddWithValue("@MaSV", sv.MaSV);
                        cmd.Parameters.AddWithValue("@TenSV", sv.TenSV);
                        cmd.Parameters.AddWithValue("@NgaySinh", sv.NgaySinh);
                        cmd.Parameters.AddWithValue("@GioiTinh", sv.GioiTinh);
                        cmd.Parameters.AddWithValue("@Email", sv.Email);
                        cmd.Parameters.AddWithValue("@SDT", sv.SDT);
                        cmd.Parameters.AddWithValue("@MoTa", sv.MoTa);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating student: " + ex.Message);
                return false;
            }
        }

        // Kiểm tra xem sinh viên có tồn tại không
        public bool IsExist(object id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM SinhVien WHERE MaSV = @MaSV";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", id);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while checking student existence: " + ex.Message);
                return false;
            }
        }

        // Đọc thông tin sinh viên theo ID
        public IModel Read(object id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM SinhVien WHERE MaSV = @MaSV";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new ModelSinhVien
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaSV = reader["MaSV"].ToString(),
                                    TenSV = reader["TenSV"].ToString(),
                                    NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                                    GioiTinh = reader["GioiTinh"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    SDT = reader["SDT"].ToString(),
                                    MoTa = reader["MoTa"].ToString()
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading student data: " + ex.Message);
                return null;
            }
        }
        internal List<ModelSinhVien> Search(string searchQuery)
        {
            try
            {
                List<ModelSinhVien> filteredList = new List<ModelSinhVien>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Sử dụng LIKE trong SQL để tìm kiếm các sinh viên theo MaSV hoặc TenSV
                    string query = "SELECT * FROM SinhVien WHERE MaSV LIKE @SearchQuery OR TenSV LIKE @SearchQuery";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số tìm kiếm với ký tự đại diện "%"
                        cmd.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                        // Thực hiện truy vấn và đọc kết quả
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Tạo đối tượng ModelSinhVien từ dữ liệu đọc được từ database
                                ModelSinhVien sv = new ModelSinhVien
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaSV = reader["MaSV"].ToString(),
                                    TenSV = reader["TenSV"].ToString(),
                                    NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                                    GioiTinh = reader["GioiTinh"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    SDT = reader["SDT"].ToString(),
                                    MoTa = reader["MoTa"].ToString()
                                };
                                // Thêm sinh viên vào danh sách đã lọc
                                filteredList.Add(sv);
                            }
                        }
                    }
                }

                return filteredList; // Trả về danh sách sinh viên tìm được
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm sinh viên: " + ex.Message);
                return new List<ModelSinhVien>(); // Nếu có lỗi, trả về danh sách rỗng
            }
        }

    }
}
