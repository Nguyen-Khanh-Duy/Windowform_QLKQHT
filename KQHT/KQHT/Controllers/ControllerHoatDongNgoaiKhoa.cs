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
    internal class ControllerHoatDongNgoaiKhoa : IController
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
                List<IModel> hoatdongngoaikhoa = new List<IModel>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM HoatDongNgoaiKhoa";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModelHoatDongNgoaiKhoa hdnk = new ModelHoatDongNgoaiKhoa
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaHD = reader["MaHD"].ToString(),
                                    MaSV = reader["MaSV"].ToString(),
                                    TenHD = reader["TenHD"].ToString(),
                                    ThoiGianBD = reader["ThoiGianBD"] != DBNull.Value ? Convert.ToDateTime(reader["ThoiGianBD"]) : DateTime.MinValue,
                                    ThoiGianKT = reader["ThoiGianKT"] != DBNull.Value ? Convert.ToDateTime(reader["ThoiGianKT"]) : DateTime.MinValue,
                                    DiaDiem = reader["DiaDiem"].ToString(),
                                };
                                hoatdongngoaikhoa.Add(hdnk);
                            }
                        }
                    }
                }
                this.Items = hoatdongngoaikhoa;
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
            if (model is ModelHoatDongNgoaiKhoa hdnk)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO HoatDongNgoaiKhoa (STT, MaHD, MaSV, TenHD, ThoiGianBD, ThoiGianKT, DiaDiem) " +
                                  "VALUES (@STT, @MaHD, @MaSV, @TenHD , @ThoiGianBD, @ThoiGianKT, @DiaDiem)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@STT", hdnk.STT);
                            cmd.Parameters.AddWithValue("@MaHD", hdnk.MaHD);
                            cmd.Parameters.AddWithValue("@MaSV", hdnk.MaSV);
                            cmd.Parameters.AddWithValue("@TenHD", hdnk.TenHD);
                            cmd.Parameters.AddWithValue("@ThoiGianBD", hdnk.ThoiGianBD);
                            cmd.Parameters.AddWithValue("@ThoiGianKT", hdnk.ThoiGianKT);
                            cmd.Parameters.AddWithValue("@DiaDiem", hdnk.DiaDiem);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true; // Trả về true nếu thao tác thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm hoạt động ngoại khóa: " + ex.Message);
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
                    string query = "DELETE FROM HoatDongNgoaiKhoa WHERE MaHD= @MaHD";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", id);
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
                ModelHoatDongNgoaiKhoa hdnk = (ModelHoatDongNgoaiKhoa)model;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM HoatDongNgoaiKhoa WHERE MaHD = @MaHD";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", hdnk.MaHD);
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
                ModelHoatDongNgoaiKhoa hdnk = (ModelHoatDongNgoaiKhoa)model;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE HoatDongNgoaiKhoa  SET STT = @STT, MaSV = @MaSV," +
                                    "  TenHD = @TenHD, ThoiGianBD = @ThoiGianBD, ThoiGianKT= @ThoiGianKT, DiaDiem= @DiaDiem WHERE MaHD = @MaHD";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@STT", hdnk.STT);
                        cmd.Parameters.AddWithValue("@MaHD", hdnk.MaHD);
                        cmd.Parameters.AddWithValue("@MaSV", hdnk.MaSV);
                        cmd.Parameters.AddWithValue("@TenHD", hdnk.TenHD);
                        cmd.Parameters.AddWithValue("@ThoiGianBD", hdnk.ThoiGianBD);
                        cmd.Parameters.AddWithValue("@ThoiGianKT", hdnk.ThoiGianKT);
                        cmd.Parameters.AddWithValue("@DiaDiem", hdnk.DiaDiem);
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
                    string query = "SELECT COUNT(*) FROM HoatDongNgoaiKhoa WHERE MaHD = @MaHD";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", id);
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
                    string query = "SELECT * FROM HoatDongNgoaiKhoa WHERE MaHD = @MaHD";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new ModelHoatDongNgoaiKhoa
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaHD = reader["MaHD"].ToString(),
                                    MaSV = reader["MaSV"].ToString(),
                                    TenHD = reader["TenHD"].ToString(),
                                    ThoiGianBD = reader["ThoiGianBD"] != DBNull.Value ? Convert.ToDateTime(reader["ThoiGianBD"]) : DateTime.MinValue,
                                    ThoiGianKT = reader["ThoiGianKT"] != DBNull.Value ? Convert.ToDateTime(reader["ThoiGianKT"]) : DateTime.MinValue,
                                    DiaDiem = reader["DiaDiem"].ToString(),
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
        internal List<ModelHoatDongNgoaiKhoa> Search(string searchQuery)
        {
            try
            {
                List<ModelHoatDongNgoaiKhoa> filteredList = new List<ModelHoatDongNgoaiKhoa>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Sử dụng LIKE trong SQL để tìm kiếm 
                    string query = "SELECT * FROM HoatDongNgoaiKhoa WHERE MaHD LIKE @SearchQuery OR MaSV LIKE @SearchQuery OR TenHD LIKE @SearchQuery";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số tìm kiếm với ký tự đại diện "%"
                        cmd.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                        // Thực hiện truy vấn và đọc kết quả
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                ModelHoatDongNgoaiKhoa hdnk = new ModelHoatDongNgoaiKhoa
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaHD = reader["MaHD"].ToString(),
                                    MaSV = reader["MaSV"].ToString(),
                                    TenHD = reader["TenHD"].ToString(),
                                    ThoiGianBD = reader["ThoiGianBD"] != DBNull.Value ? Convert.ToDateTime(reader["ThoiGianBD"]) : DateTime.MinValue,
                                    ThoiGianKT = reader["ThoiGianKT"] != DBNull.Value ? Convert.ToDateTime(reader["ThoiGianKT"]) : DateTime.MinValue,
                                    DiaDiem = reader["DiaDiem"].ToString(),
                                };

                                filteredList.Add(hdnk);
                            }
                        }
                    }
                }

                return filteredList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm : " + ex.Message);
                return new List<ModelHoatDongNgoaiKhoa>(); // Nếu có lỗi, trả về danh sách rỗng
            }
        }
    }
}

