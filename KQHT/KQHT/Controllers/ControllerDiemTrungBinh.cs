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
    internal class ControllerDiemTrungBinh : IController
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
                List<IModel> diemtrungbinh = new List<IModel>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM DiemTrungBinh";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModelDiemTrungBinh dtb = new ModelDiemTrungBinh
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaDTB = reader["MaDTB"].ToString(),
                                    MaSV = reader["MaSV"].ToString(),
                                    MaMH = reader["MaMH"].ToString(),
                                    DiemTB = reader["DiemTB"].ToString(),
                                };
                                diemtrungbinh.Add(dtb);
                            }
                        }
                    }
                }
                this.Items = diemtrungbinh;
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
            if (model is ModelDiemTrungBinh dtb)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO DiemTrungBinh (STT, MaDTB, MaSV, MaMH, DiemTB) " +
                                   "VALUES (@STT, @MaDTB, @MaSV, @MaMH , @DiemTB)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@STT", dtb.STT);
                            cmd.Parameters.AddWithValue("@MaDTB", dtb.MaDTB);
                            cmd.Parameters.AddWithValue("@MaSV", dtb.MaSV);
                            cmd.Parameters.AddWithValue("@MaMH", dtb.MaMH);
                            cmd.Parameters.AddWithValue("@DiemTB", dtb.DiemTB);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true; // Trả về true nếu thao tác thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm điểm trung bình: " + ex.Message);
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
                    string query = "DELETE FROM DiemTrungBinh WHERE MaDTB= @MaDTB";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDTB", id);
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
                ModelDiemTrungBinh dtb = (ModelDiemTrungBinh)model;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM DiemTrungBinh WHERE MaDTB = @MaDTB";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDTB", dtb.MaDTB);
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
                ModelDiemTrungBinh dtb = (ModelDiemTrungBinh)model;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE DiemTrungBinh  SET STT = @STT, MaSV = @MaSV," +
                                   "  MaMH = @MaMH, DiemTB = @DiemTB  WHERE MaDTB = @MaDTB";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@STT", dtb.STT);
                        cmd.Parameters.AddWithValue("@MaDTB", dtb.MaDTB);
                        cmd.Parameters.AddWithValue("@MaSV", dtb.MaSV);
                        cmd.Parameters.AddWithValue("@MaMH", dtb.MaMH);
                        cmd.Parameters.AddWithValue("@DiemTB", dtb.DiemTB);
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
                    string query = "SELECT COUNT(*) FROM DiemTrungBinh WHERE MaDTB = @MaDTB";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDTB", id);
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
                    string query = "SELECT * FROM DiemTrungBinh WHERE MaDTB = @MaDTB";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDTB", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new ModelDiemTrungBinh
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaDTB = reader["MaDTB"].ToString(),
                                    MaSV = reader["MaSV"].ToString(),
                                    MaMH = reader["MaMH"].ToString(),
                                    DiemTB = reader["DiemTB"].ToString(),
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
        internal List<ModelDiemTrungBinh> Search(string searchQuery)
        {
            try
            {
                List<ModelDiemTrungBinh> filteredList = new List<ModelDiemTrungBinh>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Sử dụng LIKE trong SQL để tìm kiếm 
                    string query = "SELECT * FROM DiemTrungBinh WHERE MaDTB LIKE @SearchQuery OR MaSV LIKE @SearchQuery OR MaMH LIKE @SearchQuery";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số tìm kiếm với ký tự đại diện "%"
                        cmd.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");
                        // Thực hiện truy vấn và đọc kết quả
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModelDiemTrungBinh dtb = new ModelDiemTrungBinh
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaDTB = reader["MaDTB"].ToString(),
                                    MaSV = reader["MaSV"].ToString(),
                                    MaMH = reader["MaMH"].ToString(),
                                    DiemTB = reader["DiemTB"].ToString(),
                                };
                                filteredList.Add(dtb);
                            }
                        }
                    }
                }
                return filteredList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm : " + ex.Message);
                return new List<ModelDiemTrungBinh>(); // Nếu có lỗi, trả về danh sách rỗng
            }
        }
    }
}
