using KQHT.Controllers;
using KQHT.KQHTDataSetTableAdapters;
using KQHT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace KQHT.Views
{
    public partial class frmHoatDongNgoaiKhoa : Form, IView
    {
        private ModelHoatDongNgoaiKhoa item;
        private ControllerHoatDongNgoaiKhoa ControllerHoatDongNgoaiKhoa;
        private ControllerSinhVien ControllerSinhVien;
        private KQHTDataSet kQHTDataSet = new KQHTDataSet();
        private SinhVienTableAdapter sinhVienTableAdapter = new SinhVienTableAdapter();
        public frmHoatDongNgoaiKhoa()
        {
            InitializeComponent();
            ControllerHoatDongNgoaiKhoa = new ControllerHoatDongNgoaiKhoa();
            ControllerSinhVien = new ControllerSinhVien();
            LoadDanhSachHoatDongNgoaiKhoa();
            LoadDanhSachSinhVien();
        }
        public void GetDataFromText()
        {
            var hdnk = new ModelHoatDongNgoaiKhoa
            {
                STT = int.Parse(txtSTT.Text), // Chuyển đổi STT sang số nguyên
                MaHD = txtMaHD.Text,
                MaSV = cmbMaSV.Text,
                TenHD = txtTenHD.Text,
                ThoiGianBD = dateTimePicker1.Value,
                ThoiGianKT = dateTimePicker2.Value,
                DiaDiem = txtDiaDiem.Text
            };

            ControllerHoatDongNgoaiKhoa.Add(hdnk);
            ControllerHoatDongNgoaiKhoa.Update(hdnk);
        }

        public void SetDataToText()
        {

            if (item is ModelHoatDongNgoaiKhoa hdnk)
            {
                txtSTT.Text = hdnk.STT.ToString(); // Chuyển STT sang chuỗi để hiển thị
                txtMaHD.Text = hdnk.MaHD;
                cmbMaSV.Text = hdnk.MaSV;
                txtTenHD.Text = hdnk.TenHD;
                dateTimePicker1.Value = hdnk.ThoiGianBD;
                dateTimePicker2.Value = hdnk.ThoiGianKT;
                txtDiaDiem.Text = hdnk.DiaDiem;
            }
            else
            {
                throw new ArgumentException("Item");
            }
        }
        private void frmHoatDongNgoaiKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kQHTDataSet4.HoatDongNgoaiKhoa' table. You can move, or remove it, as needed.
            this.hoatDongNgoaiKhoaTableAdapter.Fill(this.kQHTDataSet4.HoatDongNgoaiKhoa);
            LoadDanhSachHoatDongNgoaiKhoa();
            LoadDanhSachSinhVien();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ các điều khiển trên giao diện
                string sttText = txtSTT.Text.Trim(); // Thu thập giá trị STT từ giao diện
                string MaHD = txtMaHD.Text.Trim();
                string MaSV = cmbMaSV.Text.Trim();
                string TenHD = txtTenHD.Text.Trim();
                DateTime ThoiGianBD = dateTimePicker1.Value;
                DateTime ThoiGianKT = dateTimePicker2.Value;
                string DiaDiem = txtDiaDiem.Text.Trim();
                // Kiểm tra tính hợp lệ của STT (STT phải là một số nguyên hợp lệ)
                if (!int.TryParse(txtSTT.Text, out int STT))
                {
                    MessageBox.Show("STT phải là một số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra dữ liệu hợp lệ
                if (string.IsNullOrEmpty(MaHD) || string.IsNullOrEmpty(MaSV) || string.IsNullOrEmpty(TenHD) || string.IsNullOrEmpty(DiaDiem))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng mới
                ModelHoatDongNgoaiKhoa newHoatDongNgoaiKhoa = new ModelHoatDongNgoaiKhoa
                {
                    STT = int.Parse(txtSTT.Text),
                    MaHD = MaHD,
                    MaSV = MaSV,
                    TenHD = TenHD,
                    ThoiGianBD = ThoiGianBD,
                    ThoiGianKT = ThoiGianKT,
                    DiaDiem = DiaDiem,
                };

                // Gọi phương thức Add để thêm vào cơ sở dữ liệu
                if (ControllerHoatDongNgoaiKhoa.Add(newHoatDongNgoaiKhoa))
                {
                    MessageBox.Show("Thêm HoatDongNgoaiKhoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachHoatDongNgoaiKhoa();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm HoatDongNgoaiKhoa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDanhSachHoatDongNgoaiKhoa()
        {
            try
            {
                // Lấy danh sách mới từ TableAdapter và đưa vào DataSet
                this.hoatDongNgoaiKhoaTableAdapter.Fill(this.kQHTDataSet4.HoatDongNgoaiKhoa);// Lấy dữ liệu mới từ database vào DataSet

                // Tạo một DataView để sắp xếp dữ liệu từ DataTable
                DataView sortedView = new DataView(this.kQHTDataSet4.HoatDongNgoaiKhoa)
                {
                    Sort = "STT ASC" // Sắp xếp theo cột STT tăng dần
                };

                // Gán DataView đã sắp xếp vào DataGridView hoặc thành phần giao diện khác
                bdHDNK.DataSource = sortedView;

                // Tính tổng số từ DataTable
                int totalHoatDongNgoaiKhoa = this.kQHTDataSet4.HoatDongNgoaiKhoa.Rows.Count; // Đếm số dòng trong DataTable 

                // Hiển thị tổng số
                txtTongHDNK.Text = totalHoatDongNgoaiKhoa.ToString();
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

        private void bdHDNK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu nhấp vào một hàng (không phải tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                // Lấy dòng dữ liệu từ DataGridView theo chỉ số dòng đã nhấp
                DataGridViewRow row = bdHDNK.Rows[e.RowIndex];

                // Kiểm tra nếu dòng có dữ liệu và không phải là dòng trống
                if (row != null)
                {
                    // Gán dữ liệu từ DataGridView vào các TextBox tương ứng
                    txtSTT.Text = row.Cells["STT"].Value?.ToString() ?? string.Empty; 
                    txtMaHD.Text = row.Cells["MaHD"].Value?.ToString() ?? string.Empty; 
                    cmbMaSV.Text = row.Cells["MaSV"].Value?.ToString() ?? string.Empty;
                    txtTenHD.Text = row.Cells["TenHD"].Value?.ToString() ?? string.Empty;
                    dateTimePicker1.Value = row.Cells["ThoiGianBD"].Value != DBNull.Value
                                            ? Convert.ToDateTime(row.Cells["ThoiGianBD"].Value)
                                            : DateTime.Now;
                    dateTimePicker1.Value = row.Cells["ThoiGianKT"].Value != DBNull.Value
                                            ? Convert.ToDateTime(row.Cells["ThoiGianKT"].Value)
                                            : DateTime.Now;
                    txtDiaDiem.Text = row.Cells["DiaDiem"].Value?.ToString() ?? string.Empty;
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
                ModelHoatDongNgoaiKhoa hdnk = new ModelHoatDongNgoaiKhoa
                {
                    STT = int.Parse(txtSTT.Text), // Chuyển đổi STT sang số nguyên
                    MaHD = txtMaHD.Text,
                    MaSV = cmbMaSV.Text,
                    TenHD = txtTenHD.Text,
                    ThoiGianBD = dateTimePicker1.Value,
                    ThoiGianKT = dateTimePicker2.Value,
                    DiaDiem = txtDiaDiem.Text
                };

                // Gọi phương thức từ controller
                ControllerHoatDongNgoaiKhoa.Update(hdnk);

                // Làm mới lại DataGridView sau khi sửa
                LoadDanhSachHoatDongNgoaiKhoa();

                MessageBox.Show("Sửa HoatDongNgoaiKhoa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa HoatDongNgoaiKhoa: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu người dùng đã chọn một  trong DataGridView
                if (bdHDNK.SelectedRows.Count > 0)
                {
                    // Lấy dòng được chọn trong DataGridView
                    DataGridViewRow row = bdHDNK.SelectedRows[0];

                    // Lấy mã từ dòng đã chọn
                    string MaHD = row.Cells["MaHD"].Value?.ToString();

                    if (string.IsNullOrEmpty(MaHD))
                    {
                        MessageBox.Show("Chưa có HoatDongNgoaiKhoa được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Xác nhận với người dùng trước khi xóa
                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa HoatDongNgoaiKhoa mã {MaHD}?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Thực hiện xóa khỏi cơ sở dữ liệu
                        bool result = ControllerHoatDongNgoaiKhoa.Delete(MaHD); // Giả sử bạn có phương thức Delete trong Controller

                        if (result)
                        {
                            MessageBox.Show("HoatDongNgoaiKhoa đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachHoatDongNgoaiKhoa(); // Cập nhật lại danh sách 
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi xóa HoatDongNgoaiKhoa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một HoatDongNgoaiKhoa để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show("Lỗi khi xóa HoatDongNgoaiKhoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchHoatDongNgoaiKhoa()
        {
            try
            {
                // Lấy nội dung tìm kiếm từ TextBox
                string searchQuery = txtSearchHDNK.Text.Trim();

                // Lấy danh sách từ Controller
                List<ModelHoatDongNgoaiKhoa> hoatdongngoaikhoa = ControllerHoatDongNgoaiKhoa.Search(searchQuery);

                // Lọc danh sách sinh viên dựa trên nội dung tìm kiếm
                var filteredList = hoatdongngoaikhoa
                .Where(hdnk => hdnk.MaHD.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                               hdnk.MaSV.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                               hdnk.TenHD.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0) 
                    .ToList();

                // Cập nhật DataGridView với danh sách đã lọc và sắp xếp
                bdHDNK.DataSource = filteredList;

                // Hiển thị tổng số sinh viên tìm thấy
                txtTongHDNK.Text = filteredList.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchHoatDongNgoaiKhoa();
        }

        private void txtSearchHDNK_TextChanged(object sender, EventArgs e)
        {
            SearchHoatDongNgoaiKhoa();
        }
    }
}
