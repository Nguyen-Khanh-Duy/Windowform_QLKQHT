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
    internal class ControllerGiangVien : IController
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
                List<IModel> giangvien = new List<IModel>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM GiangVien";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModelGiangVien gv = new ModelGiangVien
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaGV = reader["MaGV"].ToString(),
                                    TenGV = reader["TenGV"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    SDT = reader["SDT"].ToString(),
                                    ChuyenMon = reader["ChuyenMon"].ToString()
                                };
                                giangvien.Add(gv);
                            }
                        }
                    }
                }
                this.Items = giangvien;
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
            if (model is ModelGiangVien gv)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO GiangVien (STT, MaGV, TenGV, Email, SDT, ChuyenMon) VALUES (@STT, @MaGV, @TenGV, @Email, @SDT, @ChuyenMon)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@STT", gv.STT);
                            cmd.Parameters.AddWithValue("@MaGV", gv.MaGV);
                            cmd.Parameters.AddWithValue("@TenGV", gv.TenGV);                          
                            cmd.Parameters.AddWithValue("@Email", gv.Email);
                            cmd.Parameters.AddWithValue("@SDT", gv.SDT);
                            cmd.Parameters.AddWithValue("@ChuyenMon", gv.ChuyenMon);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true; // Trả về true nếu thao tác thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm giảng viên: " + ex.Message);
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
                    string query = "DELETE FROM GiangVien WHERE MaGV= @MaGV";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaGV", id);
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
                ModelGiangVien gv = (ModelGiangVien)model; 
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM GiangVien WHERE MaGV = @MaGV";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaGV", gv.MaGV);
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
                ModelGiangVien gv = (ModelGiangVien)model;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE GiangVien SET STT=@STT, TenGV = @TenGV, " +
                                   "Email = @Email, SDT = @SDT, ChuyenMon = @ChuyenMon WHERE MaGV = @MaGV";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@STT", gv.STT);
                        cmd.Parameters.AddWithValue("@MaGV", gv.MaGV);
                        cmd.Parameters.AddWithValue("@TenGV", gv.TenGV);
                        cmd.Parameters.AddWithValue("@Email", gv.Email);
                        cmd.Parameters.AddWithValue("@SDT", gv.SDT);
                        cmd.Parameters.AddWithValue("@ChuyenMon", gv.ChuyenMon);
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
                    string query = "SELECT COUNT(*) FROM GiangVien WHERE MaGV = @MaGV";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaGV", id);
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
                    string query = "SELECT * FROM GiangVien WHERE MaGV = @MaGV";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaGV", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new ModelGiangVien
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaGV = reader["MaGV"].ToString(),
                                    TenGV = reader["TenGV"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    SDT = reader["SDT"].ToString(),
                                    ChuyenMon = reader["ChuyenMon"].ToString()
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
        internal List<ModelGiangVien> Search(string searchQuery)
        {
            try
            {
                List<ModelGiangVien> filteredList = new List<ModelGiangVien>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Sử dụng LIKE trong SQL để tìm kiếm 
                    string query = "SELECT * FROM GiangVien WHERE MaGV LIKE @SearchQuery OR TenGV LIKE @SearchQuery";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số tìm kiếm với ký tự đại diện "%"
                        cmd.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                        // Thực hiện truy vấn và đọc kết quả
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                               
                                ModelGiangVien gv = new ModelGiangVien
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaGV = reader["MaGV"].ToString(),
                                    TenGV = reader["TenGV"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    SDT = reader["SDT"].ToString(),
                                    ChuyenMon = reader["ChuyenMon"].ToString()
                                };
                                
                                filteredList.Add(gv);
                            }
                        }
                    }
                }

                return filteredList; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm : " + ex.Message);
                return new List<ModelGiangVien>(); // Nếu có lỗi, trả về danh sách rỗng
            }
        }
    }
}
