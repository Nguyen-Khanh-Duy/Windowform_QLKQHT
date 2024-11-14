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
    public partial class frmDangKy : Form
    {
        private ControllerUserAccount ControllerUserAccount;
        public frmDangKy()
        {
            InitializeComponent();
            ControllerUserAccount = new ControllerUserAccount();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ các TextBox
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                // Kiểm tra dữ liệu hợp lệ
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng ModelUserAccount mới với thông tin từ TextBox
                ModelUserAccount newUserAccount = new ModelUserAccount
                {
                    Username = username,
                    Password = password
                };

                // Gọi phương thức Add từ ControllerUserAccount để thêm tài khoản mới
                bool isRegistered = ControllerUserAccount.Register(newUserAccount);

                if (isRegistered)
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại hoặc xảy ra lỗi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức để xóa các TextBox sau khi đăng ký
        private void ClearTextBoxes()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmDangNhap DangNhap = new frmDangNhap();
            DangNhap.Show();
            this.Hide();
        }
    }
}
