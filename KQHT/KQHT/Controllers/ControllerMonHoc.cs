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
    internal class ControllerMonHoc : IController
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
                List<IModel> monhoc = new List<IModel>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM MonHoc";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModelMonHoc mh = new ModelMonHoc
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaMH = reader["MaMH"].ToString(),
                                    TenMH = reader["TenMH"].ToString(),
                                    SoTinChi = reader["SoTinChi"].ToString(),
                                    MoTa = reader["MoTa"].ToString(),
                                    GiangVienPhuTrach = reader["GiangVienPhuTrach"].ToString(),
                                    MaGV = reader["MaGV"].ToString(),
                                };
                                monhoc.Add(mh);
                            }
                        }
                    }
                }
                this.Items = monhoc;
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
            if (model is ModelMonHoc mh)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO MonHoc (STT, MaMH, TenMH, SoTinChi, MoTa, GiangVienPhuTrach, MaGV) " +
                                   "VALUES (@STT, @MaMH, @TenMH, @SoTinChi , @MoTa, @GiangVienPhuTrach, @MaGV)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@STT", mh.STT);
                            cmd.Parameters.AddWithValue("@MaMH", mh.MaMH);
                            cmd.Parameters.AddWithValue("@TenMH", mh.TenMH);
                            cmd.Parameters.AddWithValue("@SoTinChi", mh.SoTinChi);
                            cmd.Parameters.AddWithValue("@MoTa", mh.MoTa);
                            cmd.Parameters.AddWithValue("@GiangVienPhuTrach", mh.GiangVienPhuTrach);
                            cmd.Parameters.AddWithValue("@MaGV", mh.MaGV);
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
                    string query = "DELETE FROM MonHoc WHERE MaMH= @MaMH";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMH", id);
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
                ModelMonHoc mh = (ModelMonHoc)model;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM MonHoc WHERE MaMH= @MaMH";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMH", mh.MaMH);
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
                ModelMonHoc mh = (ModelMonHoc)model;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE MonHoc SET STT = @STT,TenMH = @TenMH, SoTinChi = @SoTinChi," +
                                   "  MoTa = @Mota, GiangVienPhuTrach = @GiangVienPhuTrach, MaGV = @MaGV WHERE MaMH = @MaMH";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@STT", mh.STT);
                        cmd.Parameters.AddWithValue("@MaMH", mh.MaMH);
                        cmd.Parameters.AddWithValue("@TenMH", mh.TenMH);
                        cmd.Parameters.AddWithValue("@SoTinChi", mh.SoTinChi);
                        cmd.Parameters.AddWithValue("@MoTa", mh.MoTa);
                        cmd.Parameters.AddWithValue("@GiangVienPhuTrach", mh.GiangVienPhuTrach);
                        cmd.Parameters.AddWithValue("@MaGV", mh.MaGV);
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
                    string query = "SELECT COUNT(*) FROM MonHoc WHERE MaMH = @MaMH";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMH", id);
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
                    string query = "SELECT * FROM MonHoc WHERE MaMH = @MaMH";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMH", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new ModelMonHoc
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaMH = reader["MaMH"].ToString(),
                                    TenMH = reader["TenMH"].ToString(),
                                    SoTinChi = reader["SoTinChi"].ToString(),
                                    MoTa = reader["MoTa"].ToString(),
                                    GiangVienPhuTrach = reader["GiangVienPhuTrach"].ToString(),
                                    MaGV = reader["MaGV"].ToString(),
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
        internal List<ModelMonHoc> Search(string searchQuery)
        {
            try
            {
                List<ModelMonHoc> filteredList = new List<ModelMonHoc>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Sử dụng LIKE trong SQL để tìm kiếm 
                    string query = "SELECT * FROM MonHoc WHERE MaMH LIKE @SearchQuery OR TenMH LIKE @SearchQuery";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số tìm kiếm với ký tự đại diện "%"
                        cmd.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                        // Thực hiện truy vấn và đọc kết quả
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                ModelMonHoc mh = new ModelMonHoc
                                {
                                    STT = reader["STT"] != DBNull.Value ? Convert.ToInt32(reader["STT"]) : 0,
                                    MaMH = reader["MaMH"].ToString(),
                                    TenMH = reader["TenMH"].ToString(),
                                    SoTinChi = reader["SoTinChi"].ToString(),
                                    MoTa = reader["MoTa"].ToString(),
                                    GiangVienPhuTrach = reader["GiangVienPhuTrach"].ToString(),
                                    MaGV = reader["MaGV"].ToString(),
                                };

                                filteredList.Add(mh);
                            }
                        }
                    }
                }

                return filteredList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm : " + ex.Message);
                return new List<ModelMonHoc>(); // Nếu có lỗi, trả về danh sách rỗng
            }
        }
    }
}
