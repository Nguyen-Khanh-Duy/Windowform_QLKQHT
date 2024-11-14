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
    internal class ControllerDiemRenLuyen : IController
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
                List<IModel> diemrenluyen = new List<IModel>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM DiemRenLuyen";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModelDiemRenLuyen drl = new ModelDiemRenLuyen
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaRL = reader["MaRL"].ToString(),
                                    MaSV = reader["MaSV"].ToString(),
                                    MaHD = reader["MaHD"].ToString(),
                                    DiemRL = reader["DiemRL"].ToString(),

                                };
                                diemrenluyen.Add(drl);
                            }
                        }
                    }
                }
                this.Items = diemrenluyen;
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
            if (model is ModelDiemRenLuyen drl)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO DiemRenLuyen (STT, MaRL, MaSV, MaHD, DiemRL) " +
                                   "VALUES (@STT, @MaRL, @MaSV, @MaHD, @DiemRL)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@STT", drl.STT);
                            cmd.Parameters.AddWithValue("@MaRL", drl.MaRL);
                            cmd.Parameters.AddWithValue("@MaSV", drl.MaSV);
                            cmd.Parameters.AddWithValue("@MaHD", drl.MaHD);
                            cmd.Parameters.AddWithValue("@DiemRL", drl.DiemRL);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true; // Trả về true nếu thao tác thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm DiemRenLuyen: " + ex.Message);
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
                    string query = "DELETE FROM DiemRenLuyen WHERE MaRL= @MaRL";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaRL", id);
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
                ModelDiemRenLuyen drl = (ModelDiemRenLuyen)model;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM DiemRenLuyen WHERE MaRL = @MaRL";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaRL", drl.MaRL);
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
                ModelDiemRenLuyen drl = (ModelDiemRenLuyen)model;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE DiemRenLuyen SET STT = @STT, MaSV = @MaSV," +
                                  "  MaHD = @MaHD, DiemRL = @DiemRL  WHERE MaRL = @MaRL";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@STT", drl.STT);
                        cmd.Parameters.AddWithValue("@MaRL", drl.MaRL);
                        cmd.Parameters.AddWithValue("@MaSV", drl.MaSV);
                        cmd.Parameters.AddWithValue("@MaHD", drl.MaHD);
                        cmd.Parameters.AddWithValue("@DiemRL", drl.DiemRL);
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
                    string query = "SELECT COUNT(*) FROM DiemRenLuyen WHERE MaRL = @MaRL";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaRL", id);
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
                    string query = "SELECT * FROM DiemRenLuyen WHERE MaRL = @MaRL";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaRL", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new ModelDiemRenLuyen
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaRL = reader["MaRL"].ToString(),
                                    MaSV = reader["MaSV"].ToString(),
                                    MaHD = reader["MaHD"].ToString(),
                                    DiemRL = reader["DiemRL"].ToString(),
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
        internal List<ModelDiemRenLuyen> Search(string searchQuery)
        {
            try
            {
                List<ModelDiemRenLuyen> filteredList = new List<ModelDiemRenLuyen>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Sử dụng LIKE trong SQL để tìm kiếm 
                    string query = "SELECT * FROM DiemRenLuyen WHERE MaRL LIKE @SearchQuery OR MaSV LIKE @SearchQuery OR MaHD LIKE @SearchQuery";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số tìm kiếm với ký tự đại diện "%"
                        cmd.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                        // Thực hiện truy vấn và đọc kết quả
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                ModelDiemRenLuyen drl = new ModelDiemRenLuyen
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaRL = reader["MaRL"].ToString(),
                                    MaSV = reader["MaSV"].ToString(),
                                    MaHD = reader["MaHD"].ToString(),
                                    DiemRL = reader["DiemRL"].ToString(),
                                };

                                filteredList.Add(drl);
                            }
                        }
                    }
                }

                return filteredList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm : " + ex.Message);
                return new List<ModelDiemRenLuyen>(); // Nếu có lỗi, trả về danh sách rỗng
            }
        }
    }
}
