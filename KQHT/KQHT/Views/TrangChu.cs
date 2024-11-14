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
    public partial class TrangChu : Form
    {
        public string LoggedInUsername { get; set; }
        public TrangChu()
        {
            InitializeComponent();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinhVien frmSinhVien = new frmSinhVien();
            frmSinhVien.Show();
        }

        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiangVien frmGiangVien = new frmGiangVien();
            frmGiangVien.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc frmMonHoc = new frmMonHoc();  
            frmMonHoc.Show();
        }

        private void điểmTrungBìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiemTrungBinh frmDiemTrungBinh = new frmDiemTrungBinh();
            frmDiemTrungBinh.Show();
        }

        private void hoạtĐộngNgoạiKhóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoatDongNgoaiKhoa frmHoatDongNgoaiKhoa = new frmHoatDongNgoaiKhoa();
            frmHoatDongNgoaiKhoa.Show();
        }

        private void đăngKíHoạtĐộngNgoạiKhóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKiHoatDongNgoaiKhoa frmDangKiHoatDongNgoaiKhoa = new frmDangKiHoatDongNgoaiKhoa();
            frmDangKiHoatDongNgoaiKhoa.Show();
        }

        private void điểmRènLuyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiemRenLuyen frmDiemRenLuyen = new frmDiemRenLuyen();
            frmDiemRenLuyen.Show();
        }

        private void kếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKetQuaHocTap frmKetQuaHocTap = new frmKetQuaHocTap();
            frmKetQuaHocTap.Show();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserAccount frmUserAccount = new frmUserAccount();
            frmUserAccount.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap DangNhap = new frmDangNhap();
            DangNhap.Show();
            this.Hide();
        }
        private void UpdateUsernameLabel()
        {
            lblUsername.Text = "Tài Khoản : "  +  LoggedInUsername;
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            UpdateUsernameLabel();
        }
    }
}
