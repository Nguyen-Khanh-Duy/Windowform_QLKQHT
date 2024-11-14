using KQHT.Controllers;
using KQHT.KQHTDataSet4TableAdapters;
using KQHT.KQHTDataSetTableAdapters;
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
    public partial class frmDangKiHoatDongNgoaiKhoa : Form, IView
    {
        private ModelDangKiHoatDongNgoaiKhoa item;
        private ControllerDangKiHoatDongNgoaiKhoa ControllerDangKiHoatDongNgoaiKhoa;
        private KQHTDataSet kQHTDataSet = new KQHTDataSet();
        private KQHTDataSet4 kQHTDataSet4 = new KQHTDataSet4();
        private SinhVienTableAdapter sinhVienTableAdapter = new SinhVienTableAdapter();
        private HoatDongNgoaiKhoaTableAdapter hoatDongNgoaiKhoaTableAdapter = new HoatDongNgoaiKhoaTableAdapter();
        public frmDangKiHoatDongNgoaiKhoa()
        {
            InitializeComponent();
            ControllerDangKiHoatDongNgoaiKhoa = new ControllerDangKiHoatDongNgoaiKhoa();
            LoadDanhSachSinhVien();
            LoadDanhSachHoatDongNgoaiKhoa();
            LoadDanhSachDangKiHoatDongNgoaiKhoa();
        }
        public void GetDataFromText()
        {
            var dk = new ModelDangKiHoatDongNgoaiKhoa
            {
                STT = int.Parse(txtSTT.Text), // Chuyển đổi STT sang số nguyên
                MaDK = txtMaDK.Text,
                MaSV = cmbMaSV.Text,
                MaHD = cmbMaHD.Text,
                NgayDK = dateTimePicker1.Value,              
            };

            ControllerDangKiHoatDongNgoaiKhoa.Add(dk);
            ControllerDangKiHoatDongNgoaiKhoa.Update(dk);
        }

        public void SetDataToText()
        {

            if (item is ModelDangKiHoatDongNgoaiKhoa dk)
            {
                txtSTT.Text = dk.STT.ToString(); // Chuyển STT sang chuỗi để hiển thị
                txtMaDK.Text = dk.MaDK;
                cmbMaSV.Text = dk.MaSV;
                cmbMaHD.Text = dk.MaHD;
                dateTimePicker1.Value = dk.NgayDK;               
            }
            else
            {
                throw new ArgumentException("Item");
            }
        }
        private void frmDangKiHoatDongNgoaiKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kQHTDataSet5.DangKiHoatDongNgoaiKhoa' table. You can move, or remove it, as needed.
            this.dangKiHoatDongNgoaiKhoaTableAdapter.Fill(this.kQHTDataSet5.DangKiHoatDongNgoaiKhoa);
            LoadDanhSachSinhVien();
            LoadDanhSachHoatDongNgoaiKhoa();
            LoadDanhSachDangKiHoatDongNgoaiKhoa();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ các điều khiển trên giao diện
                string sttText = txtSTT.Text.Trim(); // Thu thập giá trị STT từ giao diện
                string MaDK = txtMaDK.Text.Trim();
                string MaSV = cmbMaSV.Text.Trim();
                string MaHD = cmbMaHD.Text.Trim();
                DateTime NgayDK = dateTimePicker1.Value;              
                // Kiểm tra tính hợp lệ của STT (STT phải là một số nguyên hợp lệ)
                if (!int.TryParse(txtSTT.Text, out int STT))
                {
                    MessageBox.Show("STT phải là một số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra dữ liệu hợp lệ
                if (string.IsNullOrEmpty(MaDK) || string.IsNullOrEmpty(MaSV) || string.IsNullOrEmpty(MaHD))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng mới
                ModelDangKiHoatDongNgoaiKhoa newDangKiHoatDongNgoaiKhoa = new ModelDangKiHoatDongNgoaiKhoa
                {
                    STT = int.Parse(txtSTT.Text),
                    MaDK = MaDK,
                    MaSV = MaSV,
                    MaHD= MaHD,
                    NgayDK = NgayDK,
                    
                };

                // Gọi phương thức Add để thêm vào cơ sở dữ liệu
                if (ControllerDangKiHoatDongNgoaiKhoa.Add(newDangKiHoatDongNgoaiKhoa))
                {
                    MessageBox.Show("Thêm DangKiHoatDongNgoaiKhoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDangKiHoatDongNgoaiKhoa();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm DangKiHoatDongNgoaiKhoa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDanhSachDangKiHoatDongNgoaiKhoa()
        {
            try
            {
                // Lấy danh sách mới từ TableAdapter và đưa vào DataSet
                this.dangKiHoatDongNgoaiKhoaTableAdapter.Fill(this.kQHTDataSet5.DangKiHoatDongNgoaiKhoa);// Lấy dữ liệu mới từ database vào DataSet

                // Tạo một DataView để sắp xếp dữ liệu từ DataTable
                DataView sortedView = new DataView(this.kQHTDataSet5.DangKiHoatDongNgoaiKhoa)
                {
                    Sort = "STT ASC" // Sắp xếp theo cột STT tăng dần
                };

                // Gán DataView đã sắp xếp vào DataGridView hoặc thành phần giao diện khác
                bdDKHDNK.DataSource = sortedView;

                // Tính tổng số từ DataTable
                int totalDangKiHoatDongNgoaiKhoa = this.kQHTDataSet5.DangKiHoatDongNgoaiKhoa.Rows.Count; // Đếm số dòng trong DataTable 

                // Hiển thị tổng số
                txtTongDKHDNK.Text = totalDangKiHoatDongNgoaiKhoa.ToString();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show("Lỗi khi tải danh sách : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDanhSachSinhVien()
        {
            try
            {
                this.sinhVienTableAdapter.Fill(this.kQHTDataSet.SinhVien);
                cmbMaSV.DataSource = this.kQHTDataSet.SinhVien;
                cmbMaSV.ValueMember = "MaSV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách SINHVIEN: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDanhSachHoatDongNgoaiKhoa()
        {
            try
            {
                this.hoatDongNgoaiKhoaTableAdapter.Fill(this.kQHTDataSet4.HoatDongNgoaiKhoa);
                cmbMaHD.DataSource = this.kQHTDataSet4.HoatDongNgoaiKhoa;
                cmbMaHD.ValueMember = "MaHD";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách HoatDongNgoaiKhoa: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bdDKHDNK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng dữ liệu từ DataGridView theo chỉ số dòng đã nhấp
                DataGridViewRow row = bdDKHDNK.Rows[e.RowIndex];

                // Kiểm tra nếu dòng có dữ liệu và không phải là dòng trống
                if (row != null)
                {
                    // Gán dữ liệu từ DataGridView vào các TextBox tương ứng
                    txtSTT.Text = row.Cells["STT"].Value?.ToString() ?? string.Empty;
                    txtMaDK.Text = row.Cells["MaDK"].Value?.ToString() ?? string.Empty;
                    cmbMaSV.Text = row.Cells["MaSV"].Value?.ToString() ?? string.Empty;
                    cmbMaHD.Text = row.Cells["MaHD"].Value?.ToString() ?? string.Empty;
                    dateTimePicker1.Value = row.Cells["NgayDK"].Value != DBNull.Value
                                            ? Convert.ToDateTime(row.Cells["NgayDK"].Value) : DateTime.Now;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Chuyển đổi chuỗi thành int cho Số thứ tự
                if (!int.TryParse(txtSTT.Text, out int STT))
                {
                    MessageBox.Show("Số thứ tự (Số Thứ Tự ) phải là một số nguyên.");
                    return;
                }

                // Tạo một đối tượng mới với dữ liệu từ các textbox
                ModelDangKiHoatDongNgoaiKhoa dk = new ModelDangKiHoatDongNgoaiKhoa
                {
                    STT = int.Parse(txtSTT.Text), // Chuyển đổi STT sang số nguyên
                    MaDK = txtMaDK.Text,
                    MaSV = cmbMaSV.Text,
                    MaHD = cmbMaHD.Text,
                    NgayDK = dateTimePicker1.Value,
                   
                    
                };

                // Gọi phương thức từ controller
                ControllerDangKiHoatDongNgoaiKhoa.Update(dk);

                // Làm mới lại DataGridView sau khi sửa
                LoadDanhSachDangKiHoatDongNgoaiKhoa();

                MessageBox.Show("Sửa DangKiHoatDongNgoaiKhoa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa DangKiHoatDongNgoaiKhoa: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu người dùng đã chọn một  trong DataGridView
                if (bdDKHDNK.SelectedRows.Count > 0)
                {
                    // Lấy dòng được chọn trong DataGridView
                    DataGridViewRow row = bdDKHDNK.SelectedRows[0];

                    // Lấy mã từ dòng đã chọn
                    string MaDK = row.Cells["MaDK"].Value?.ToString();

                    if (string.IsNullOrEmpty(MaDK))
                    {
                        MessageBox.Show("Chưa có DangKiHoatDongNgoaiKhoa được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Xác nhận với người dùng trước khi xóa
                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa DangKiHoatDongNgoaiKhoa mã {MaDK}?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Thực hiện xóa khỏi cơ sở dữ liệu
                        bool result = ControllerDangKiHoatDongNgoaiKhoa.Delete(MaDK); // Giả sử bạn có phương thức Delete trong Controller

                        if (result)
                        {
                            MessageBox.Show("DangKiHoatDongNgoaiKhoa đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachDangKiHoatDongNgoaiKhoa(); // Cập nhật lại danh sách 
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi xóa DangKiHoatDongNgoaiKhoa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một DangKiHoatDongNgoaiKhoa để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show("Lỗi khi xóa DangKiHoatDongNgoaiKhoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchDangKiHoatDongNgoaiKhoa();
        }

        private void txtSearchDK_TextChanged(object sender, EventArgs e)
        {
            SearchDangKiHoatDongNgoaiKhoa();
        }
        private void SearchDangKiHoatDongNgoaiKhoa()
        {
            try
            {
                // Lấy nội dung tìm kiếm từ TextBox
                string searchQuery = txtSearchDK.Text.Trim();

                // Lấy danh sách từ Controller
                List<ModelDangKiHoatDongNgoaiKhoa> dangki = ControllerDangKiHoatDongNgoaiKhoa.Search(searchQuery);

                // Lọc danh sách sinh viên dựa trên nội dung tìm kiếm
                var filteredList = dangki
                .Where(dk => dk.MaDK.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                               dk.MaSV.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                               dk.MaHD.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                // Cập nhật DataGridView với danh sách đã lọc và sắp xếp
                bdDKHDNK.DataSource = filteredList;

                // Hiển thị tổng số sinh viên tìm thấy
                txtTongDKHDNK.Text = filteredList.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
    }
}
