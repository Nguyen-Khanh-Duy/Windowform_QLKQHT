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
    internal class ControllerUserAccount : IController
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
                List<IModel> UserAccount = new List<IModel>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM UserAccount";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModelUserAccount ua = new ModelUserAccount
                                {
                                    Username = reader["Username"].ToString(),
                                    Password = reader["Password"].ToString(),
                                };
                                UserAccount.Add(ua);
                            }
                        }
                    }
                }
                this.Items = UserAccount;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading data: " + ex.Message);
                return false;
            }
        }

        // Thêm một sinh viên mới vào database
        public bool Add(IModel model)
        {
            if (model is ModelUserAccount UserAccount)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO UserAccount (Username, Password) VALUES (@Username, @Password)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", UserAccount.Username);
                            cmd.Parameters.AddWithValue("@Password", UserAccount.Password);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true; // Trả về true nếu thao tác thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
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
                    string query = "DELETE FROM UserAccount WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", id);
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
                ModelUserAccount ua = (ModelUserAccount)model;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM UserAccount WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", ua.Username);
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

        public bool Update(IModel model)
        {
            try
            {
                ModelUserAccount ua = (ModelUserAccount)model;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE UserAccount SET Password = @Password WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Username", ua.Username));
                        cmd.Parameters.Add(new SqlParameter("@Password", ua.Password));

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

        public bool IsExist(object id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM UserAccount WHERE UserAccount = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", id);
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
        public IModel Read(object id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM UserAccount WHERE UserAccount = @UserAccount";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserAccount", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new ModelUserAccount
                                {
                                    Username = reader["Username"].ToString(),
                                    Password = reader["Password"].ToString(),
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
        internal List<ModelUserAccount> Search(string searchQuery)
        {
            try
            {
                List<ModelUserAccount> filteredList = new List<ModelUserAccount>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM UserAccount WHERE Username LIKE @SearchQuery OR Password LIKE @SearchQuery";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số tìm kiếm với ký tự đại diện "%"
                        cmd.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                        // Thực hiện truy vấn và đọc kết quả
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModelUserAccount ua = new ModelUserAccount
                                {
                                    Username = reader["Username"].ToString(),
                                    Password = reader["Password"].ToString(),
                                };

                                filteredList.Add(ua);
                            }
                        }
                    }
                }

                return filteredList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return new List<ModelUserAccount>(); // Nếu có lỗi, trả về danh sách rỗng
            }
        }

        public bool CheckLogin(ModelUserAccount userAccount)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(1) FROM UserAccount WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", userAccount.Username);
                        cmd.Parameters.AddWithValue("@Password", userAccount.Password);

                        int result = (int)cmd.ExecuteScalar();

                        return result > 0; // Nếu tìm thấy, trả về true (đăng nhập thành công)
                    }
                }
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần hoặc xử lý ngoại lệ
                MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool Register(ModelUserAccount userAccount)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra xem Username đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(1) FROM UserAccount WHERE Username = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", userAccount.Username);

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            return false; // Username đã tồn tại
                        }
                    }

                    // Nếu Username chưa tồn tại, thêm tài khoản mới
                    string insertQuery = "INSERT INTO UserAccount (Username, Password) VALUES (@Username, @Password)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@Username", userAccount.Username);
                        insertCmd.Parameters.AddWithValue("@Password", userAccount.Password);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Trả về true nếu thêm thành công
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}
