using KQHT.Controllers;
using KQHT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KQHT.Views
{
    public partial class frmUserAccount : Form, IView
    {
        private ModelUserAccount item;
        private ControllerUserAccount ControllerUserAccount;
        public frmUserAccount()
        {
            InitializeComponent();
            ControllerUserAccount = new ControllerUserAccount();
            LoadDanhSachUserAccount();
        }
        public void GetDataFromText()
        {
            var ua = new ModelUserAccount
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
            };

            ControllerUserAccount.Add(ua);
            ControllerUserAccount.Update(ua);
        }

        public void SetDataToText()
        {

            if (item is ModelUserAccount ua)
            {
                txtUsername.Text = ua.Username;
                txtPassword.Text = ua.Password;
            }
            else
            {
                throw new ArgumentException("Item");
            }
        }
        private void frmUserAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kQHTDataSet8.UserAccount' table. You can move, or remove it, as needed.
            this.userAccountTableAdapter.Fill(this.kQHTDataSet8.UserAccount);
            LoadDanhSachUserAccount();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ các điều khiển trên giao diện

                string Username = txtUsername.Text.Trim();
                string Password = txtPassword.Text.Trim();
                // Kiểm tra dữ liệu hợp lệ
                if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng mới
                ModelUserAccount newUserAccount = new ModelUserAccount
                {
                    Username = Username,
                    Password = Password,

                };

                // Gọi phương thức Add để thêm vào cơ sở dữ liệu
                if (ControllerUserAccount.Add(newUserAccount))
                {
                    MessageBox.Show("Thêm UserAccount thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachUserAccount();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm UserAccount.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDanhSachUserAccount()
        {
            try
            {
                // Lấy danh sách mới từ TableAdapter và đưa vào DataSet
                this.userAccountTableAdapter.Fill(this.kQHTDataSet8.UserAccount); // Lấy dữ liệu mới từ database vào DataSet

                // Tạo một DataView để sắp xếp dữ liệu từ DataTable
                DataView sortedView = new DataView(this.kQHTDataSet8.UserAccount)
                {
                    Sort = "Username ASC"
                };

                // Gán DataView đã sắp xếp vào DataGridView hoặc thành phần giao diện khác
                bduser.DataSource = sortedView;

                // Tính tổng số từ DataTable
                int totalUserAccount = this.kQHTDataSet8.UserAccount.Rows.Count; // Đếm số dòng trong DataTable 

                // Hiển thị tổng số
                txtTong.Text = totalUserAccount.ToString();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show("Lỗi khi tải danh sách : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bduser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu nhấp vào một hàng (không phải tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                // Lấy dòng dữ liệu từ DataGridView theo chỉ số dòng đã nhấp
                DataGridViewRow row = bduser.Rows[e.RowIndex];

                // Kiểm tra nếu dòng có dữ liệu và không phải là dòng trống
                if (row != null)
                {
                    // Gán dữ liệu từ DataGridView vào các TextBox tương ứng                  
                    txtUsername.Text = row.Cells["Username"].Value?.ToString() ?? string.Empty;
                    txtPassword.Text = row.Cells["Password"].Value?.ToString() ?? string.Empty;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu người dùng đã chọn một sinh viên trong DataGridView
                if (bduser.SelectedRows.Count > 0)
                {
                    // Lấy dòng được chọn trong DataGridView
                    DataGridViewRow row = bduser.SelectedRows[0];

                    // Lấy mã từ dòng đã chọn
                    string Username = row.Cells["Username"].Value?.ToString();

                    if (string.IsNullOrEmpty(Username))
                    {
                        MessageBox.Show("Chưa có UserAccount được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Xác nhận với người dùng trước khi xóa
                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa UserAccount mã {Username}?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Thực hiện xóa khỏi cơ sở dữ liệu
                        bool result = ControllerUserAccount.Delete(Username); // Giả sử bạn có phương thức Delete trong Controller

                        if (result)
                        {
                            MessageBox.Show("UserAccount đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachUserAccount(); // Cập nhật lại danh sách sinh viên
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi xóa UserAccount.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một UserAccount để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show("Lỗi khi xóa UserAccount: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo một đối tượng mới với dữ liệu từ các textbox
                ModelUserAccount ua = new ModelUserAccount
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,

                };

                // Gọi phương thức từ controller
                ControllerUserAccount.Update(ua);

                // Làm mới lại DataGridView sau khi sửa
                LoadDanhSachUserAccount();

                MessageBox.Show("Sửa UserAccount thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa UserAccount: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUserAccount();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchUserAccount();
        }
        private void SearchUserAccount()
        {
            try
            {
                // Lấy nội dung tìm kiếm từ TextBox
                string searchQuery = txtSearch.Text.Trim();

                // Lấy danh sách từ Controller
                List<ModelUserAccount> UserAccount = ControllerUserAccount.Search(searchQuery);

                // Lọc danh sách dựa trên nội dung tìm kiếm
                var filteredList = UserAccount
                    .Where(ua => ua.Username.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                 ua.Password.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
                    .OrderBy(ua => ua.Username) // Sắp xếp danh sách theo STT
                    .ToList();

                // Cập nhật DataGridView với danh sách đã lọc và sắp xếp
                bduser.DataSource = filteredList;

                // Hiển thị tổng số
                txtTong.Text = filteredList.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
