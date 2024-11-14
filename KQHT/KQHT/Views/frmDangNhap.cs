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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            txtUsername.Text = Properties.Settings.Default.SavedUsername;
            txtPassword.Text = Properties.Settings.Default.SavedPassword;
            radioLuu.Checked = !string.IsNullOrEmpty(Properties.Settings.Default.SavedUsername);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            ModelUserAccount userAccount = new ModelUserAccount
            {
                Username = username,
                Password = password
            };

            ControllerUserAccount controller = new ControllerUserAccount();
            bool isLoginSuccessful = controller.CheckLogin(userAccount);

            if (isLoginSuccessful)
            {
                if (radioLuu.Checked)
                {
                    Properties.Settings.Default.SavedUsername = username;
                    Properties.Settings.Default.SavedPassword = password; // Có thể mã hóa nếu cần
                    Properties.Settings.Default.Save();
                }

                TrangChu trangChu = new TrangChu
                {
                    LoggedInUsername = username // Truyền tài khoản đã đăng nhập
                };
                trangChu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {          
            frmDangKy frmDangKy = new frmDangKy();
            frmDangKy.Show();  
            this.Hide();   
        }

        private void radioLuu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLuu.Checked)
            {
                // Lưu thông tin đăng nhập vào Settings
                Properties.Settings.Default.SavedUsername = txtUsername.Text;
                Properties.Settings.Default.SavedPassword = txtPassword.Text; // Có thể mã hóa nếu cần bảo mật
                Properties.Settings.Default.Save();
            }
            else
            {
                // Xóa thông tin đăng nhập nếu bỏ chọn radioLuu
                Properties.Settings.Default.SavedUsername = string.Empty;
                Properties.Settings.Default.SavedPassword = string.Empty;
                Properties.Settings.Default.Save();
            }
        }
    }
}
