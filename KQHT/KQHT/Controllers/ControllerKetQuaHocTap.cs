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
    internal class ControllerKetQuaHocTap : IController
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
                List<IModel> ketquahoctap = new List<IModel>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM KetQuaHocTap";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModelKetQuaHocTap kqht = new ModelKetQuaHocTap
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaKQ = reader["MaKQ"].ToString(),
                                    MaSV = reader["MaSV"].ToString(),
                                    TenSV = reader["TenSV"].ToString(),
                                    MaDTB = reader["MaDTB"].ToString(),
                                    DiemTBM = reader["DiemTBM"].ToString(),
                                    MaRL = reader["MaRL"].ToString(),
                                    DiemRL = reader["DiemRL"].ToString(),
                                    XepLoai = reader["XepLoai"].ToString(),
                                    
                                };
                                ketquahoctap.Add(kqht);
                            }
                        }
                    }
                }
                this.Items = ketquahoctap;
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
            if (model is ModelKetQuaHocTap kqht)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO KetQuaHocTap (STT, MaKQ, MaSV, TenSV, MaDTB, DiemTBM, MaRL, DiemRL, XepLoai) " +
                                  "VALUES (@STT, @MaKQ, @MaSV, @TenSV, @MaDTB, @DiemTBM, @MaRL, @DiemRL, @XepLoai)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@STT", kqht.STT);
                            cmd.Parameters.AddWithValue("@MaKQ", kqht.MaKQ);
                            cmd.Parameters.AddWithValue("@MaSV", kqht.MaSV);
                            cmd.Parameters.AddWithValue("@TenSV", kqht.TenSV);
                            cmd.Parameters.AddWithValue("@MaDTB", kqht.MaDTB);
                            cmd.Parameters.AddWithValue("@DiemTBM", kqht.DiemTBM);
                            cmd.Parameters.AddWithValue("@MaRL", kqht.MaRL);
                            cmd.Parameters.AddWithValue("@DiemRL", kqht.DiemRL);
                            cmd.Parameters.AddWithValue("@XepLoai", kqht.XepLoai);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true; // Trả về true nếu thao tác thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm KetQuaHocTap: " + ex.Message);
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
                    string query = "DELETE FROM KetQuaHocTap WHERE MaKQ= @MaKQ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKQ", id);
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
                ModelKetQuaHocTap kqht = (ModelKetQuaHocTap)model;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM KetQuaHocTap WHERE MaKQ = @MaKQ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKQ", kqht.MaKQ);
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
                ModelKetQuaHocTap kqht = (ModelKetQuaHocTap)model;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE KetQuaHocTap SET STT = @STT, MaSV = @MaSV, TenSV = @TenSV, " +
                                   "MaDTB = @MaDTB, DiemTBM = @DiemTBM, MaRL = @MaRL, DiemRL = @DiemRL, XepLoai = @XepLoai WHERE MaKQ = @MaKQ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@STT", kqht.STT);
                        cmd.Parameters.AddWithValue("@MaKQ", kqht.MaKQ);
                        cmd.Parameters.AddWithValue("@MaSV", kqht.MaSV);
                        cmd.Parameters.AddWithValue("@TenSV", kqht.TenSV);
                        cmd.Parameters.AddWithValue("@MaDTB", kqht.MaDTB);
                        cmd.Parameters.AddWithValue("@DiemTBM", kqht.DiemTBM);
                        cmd.Parameters.AddWithValue("@MaRL", kqht.MaRL);
                        cmd.Parameters.AddWithValue("@DiemRL", kqht.DiemRL);
                        cmd.Parameters.AddWithValue("@XepLoai", kqht.XepLoai);
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
                    string query = "SELECT COUNT(*) FROM KetQuaHocTap WHERE MaKQ = @MaKQ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKQ", id);
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
                    string query = "SELECT * FROM KetQuaHocTap WHERE MaKQ = @MaKQ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKQ", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new ModelKetQuaHocTap
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaKQ = reader["MaKQ"].ToString(),
                                    MaSV = reader["MaSV"].ToString(),
                                    TenSV = reader["TenSV"].ToString(),
                                    MaDTB = reader["MaDTB"].ToString(),
                                    DiemTBM = reader["DiemTBM"].ToString(),
                                    MaRL = reader["MaRL"].ToString(),
                                    DiemRL = reader["DiemRL"].ToString(),
                                    XepLoai = reader["XepLoai"].ToString(),
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
        internal List<ModelKetQuaHocTap> Search(string searchQuery)
        {
            try
            {
                List<ModelKetQuaHocTap> filteredList = new List<ModelKetQuaHocTap>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Sử dụng LIKE trong SQL để tìm kiếm 
                    string query = "SELECT * FROM KetQuaHocTap WHERE MaKQ LIKE @SearchQuery OR MaSV LIKE @SearchQuery OR TenSV LIKE @SearchQuery OR MaDTB LIKE @SearchQuery OR MaRL LIKE @SearchQuery";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số tìm kiếm với ký tự đại diện "%"
                        cmd.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                        // Thực hiện truy vấn và đọc kết quả
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                ModelKetQuaHocTap kqht = new ModelKetQuaHocTap
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaKQ = reader["MaKQ"].ToString(),
                                    MaSV = reader["MaSV"].ToString(),
                                    TenSV = reader["TenSV"].ToString(),
                                    MaDTB = reader["MaDTB"].ToString(),
                                    DiemTBM = reader["DiemTBM"].ToString(),
                                    MaRL = reader["MaRL"].ToString(),
                                    DiemRL = reader["DiemRL"].ToString(),
                                    XepLoai = reader["XepLoai"].ToString(),
                                };

                                filteredList.Add(kqht);
                            }
                        }
                    }
                }

                return filteredList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm : " + ex.Message);
                return new List<ModelKetQuaHocTap>(); // Nếu có lỗi, trả về danh sách rỗng
            }
        }
    }
}
