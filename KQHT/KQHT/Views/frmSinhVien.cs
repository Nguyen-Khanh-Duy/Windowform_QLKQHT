using KQHT.Controllers;
using KQHT.Model;
using KQHT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KQHT.Views
{
    public partial class frmSinhVien : Form, IView
    {
        private ControllerSinhVien ControllerSinhVien;
        private ModelSinhVien item;

        public frmSinhVien()
        {
            InitializeComponent();
            ControllerSinhVien = new ControllerSinhVien(); // Khởi tạo Controller
            LoadDanhSachSinhVien(); // Tải danh sách sinh viên
                      
        }
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu vào bảng 'SinhVien' trong 'kQHTDataSet' khi cần thiết
            this.sinhVienTableAdapter.Fill(this.kQHTDataSet.SinhVien);
            LoadDanhSachSinhVien();
            
        }
        public void GetDataFromText()
        {
            var sv = new ModelSinhVien
            {
                STT = int.Parse(txtSTT.Text), // Chuyển đổi STT sang số nguyên
                MaSV = txtMaSV.Text,
                TenSV = txtTenSV.Text,
                NgaySinh = dateTimePicker1.Value,
                GioiTinh = checkBoxNam.Checked ? "Nam" : (checkBoxNu.Checked ? "Nữ" : ""),
                Email = txtEmail.Text,
                SDT = txtSDT.Text,
                MoTa = txtMoTa.Text
            };

            ControllerSinhVien.Add(sv);
            ControllerSinhVien.Update(sv);
        }

        public void SetDataToText()
        {
            if (item is ModelSinhVien sv)
            {
                txtSTT.Text = sv.STT.ToString(); // Chuyển STT sang chuỗi để hiển thị
                txtMaSV.Text = sv.MaSV;
                txtTenSV.Text = sv.TenSV;
                dateTimePicker1.Value = sv.NgaySinh;
                checkBoxNam.Checked = sv.GioiTinh == "Nam";
                checkBoxNu.Checked = sv.GioiTinh == "Nữ";
                txtEmail.Text = sv.Email;
                txtSDT.Text = sv.SDT;
                txtMoTa.Text = sv.MoTa;
            }
            else
            {
                throw new ArgumentException("Item phải thuộc loại ModelSinhVien");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ các điều khiển trên giao diện
                string sttText = txtSTT.Text.Trim(); // Thu thập giá trị STT từ giao diện
                string maSV = txtMaSV.Text.Trim();
                string tenSV = txtTenSV.Text.Trim();
                DateTime ngaySinh = dateTimePicker1.Value;
                string gioiTinh = checkBoxNam.Checked ? "Nam" : (checkBoxNu.Checked ? "Nữ" : null);
                string email = txtEmail.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string moTa = txtMoTa.Text.Trim();

                // Kiểm tra tính hợp lệ của STT (STT phải là một số nguyên hợp lệ)
                if (!int.TryParse(txtSTT.Text, out int stt))
                {
                    MessageBox.Show("STT phải là một số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra dữ liệu hợp lệ
                if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(tenSV) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sdt))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng sinh viên mới
                ModelSinhVien newSinhVien = new ModelSinhVien
                {
                    STT = int.Parse(txtSTT.Text),  // Gán giá trị STT
                    MaSV = maSV,
                    TenSV = tenSV,
                    NgaySinh = ngaySinh,
                    GioiTinh = gioiTinh,
                    Email = email,
                    SDT = sdt,
                    MoTa = moTa
                };

                // Gọi phương thức Add để thêm sinh viên vào cơ sở dữ liệu
                if (ControllerSinhVien.Add(newSinhVien))
                {
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachSinhVien(); // Tải lại danh sách sinh viên
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDanhSachSinhVien()
        {
            try
            {
                // Lấy danh sách sinh viên mới từ TableAdapter và đưa vào DataSet
                this.sinhVienTableAdapter.Fill(this.kQHTDataSet.SinhVien); // Lấy dữ liệu mới từ database vào DataSet

                // Tạo một DataView để sắp xếp dữ liệu từ DataTable
                DataView sortedView = new DataView(this.kQHTDataSet.SinhVien)
                {
                    Sort = "STT ASC" // Sắp xếp theo cột STT tăng dần
                };

                // Gán DataView đã sắp xếp vào DataGridView hoặc thành phần giao diện khác
                bdSinhVien.DataSource = sortedView;

                // Tính tổng số sinh viên từ DataTable
                int totalSinhVien = this.kQHTDataSet.SinhVien.Rows.Count; // Đếm số dòng trong DataTable SinhVien

                // Hiển thị tổng số sinh viên
                txtTongSV.Text = totalSinhVien.ToString();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show("Lỗi khi tải danh sách sinh viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bdSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu nhấp vào một hàng (không phải tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                // Lấy dòng dữ liệu từ DataGridView theo chỉ số dòng đã nhấp
                DataGridViewRow row = bdSinhVien.Rows[e.RowIndex];

                // Kiểm tra nếu dòng có dữ liệu và không phải là dòng trống
                if (row != null)
                {
                    // Gán dữ liệu từ DataGridView vào các TextBox tương ứng
                    txtSTT.Text = row.Cells["STT"].Value?.ToString() ?? string.Empty; // Gán STT vào TextBox
                    txtMaSV.Text = row.Cells["MaSV"].Value?.ToString() ?? string.Empty; // Gán MaSV vào TextBox
                    txtTenSV.Text = row.Cells["TenSV"].Value?.ToString() ?? string.Empty; // Gán TenSV vào TextBox

                    // Gán NgaySinh vào DateTimePicker
                    dateTimePicker1.Value = row.Cells["NgaySinh"].Value != DBNull.Value
                                            ? Convert.ToDateTime(row.Cells["NgaySinh"].Value)
                                            : DateTime.Now;

                    // Gán GioiTinh vào CheckBox Nam/Nữ
                    checkBoxNam.Checked = row.Cells["GioiTinh"].Value?.ToString() == "Nam"; // Gán GioiTinh vào CheckBox Nam
                    checkBoxNu.Checked = row.Cells["GioiTinh"].Value?.ToString() == "Nữ"; // Gán GioiTinh vào CheckBox Nữ

                    // Gán các giá trị vào các TextBox tương ứng
                    txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? string.Empty; // Gán Email vào TextBox
                    txtSDT.Text = row.Cells["SDT"].Value?.ToString() ?? string.Empty; // Gán SDT vào TextBox
                    txtMoTa.Text = row.Cells["MoTa"].Value?.ToString() ?? string.Empty; // Gán MoTa vào TextBox
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu người dùng đã chọn một sinh viên trong DataGridView
                if (bdSinhVien.SelectedRows.Count > 0)
                {
                    // Lấy dòng được chọn trong DataGridView
                    DataGridViewRow row = bdSinhVien.SelectedRows[0];

                    // Lấy mã sinh viên từ dòng đã chọn
                    string maSV = row.Cells["MaSV"].Value?.ToString();

                    if (string.IsNullOrEmpty(maSV))
                    {
                        MessageBox.Show("Chưa có sinh viên được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Xác nhận với người dùng trước khi xóa
                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên mã {maSV}?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Thực hiện xóa sinh viên khỏi cơ sở dữ liệu
                        bool result = ControllerSinhVien.Delete(maSV); // Giả sử bạn có phương thức Delete trong Controller

                        if (result)
                        {
                            MessageBox.Show("Sinh viên đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachSinhVien(); // Cập nhật lại danh sách sinh viên
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi xóa sinh viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ModelSinhVien sv = new ModelSinhVien
                {
                    STT = int.Parse(txtSTT.Text),
                    MaSV = txtMaSV.Text,
                    TenSV = txtTenSV.Text,
                    NgaySinh = dateTimePicker1.Value,
                    GioiTinh = checkBoxNam.Checked ? "Nam" : (checkBoxNu.Checked ? "Nữ" : ""),
                    Email = txtEmail.Text,
                    SDT = txtSDT.Text,
                    MoTa = txtMoTa.Text
                };

                // Gọi phương thức từ controller
                ControllerSinhVien.Update(sv);

                // Làm mới lại DataGridView sau khi sửa
                LoadDanhSachSinhVien();

                MessageBox.Show("Sửa sinh viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa sinh viên: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchSinhVien();
        }
        private void txtSearchSV_TextChanged(object sender, EventArgs e)
        {
            SearchSinhVien();
        }
        private void SearchSinhVien()
        {
            try
            {
                // Lấy nội dung tìm kiếm từ TextBox
                string searchQuery = txtSearchSV.Text.Trim();

                // Lấy danh sách sinh viên từ Controller
                List<ModelSinhVien> sinhvien = ControllerSinhVien.Search(searchQuery);

                // Lọc danh sách sinh viên dựa trên nội dung tìm kiếm
                var filteredList = sinhvien
                    .Where(sv => sv.MaSV.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 || // Tìm kiếm theo mã sinh viên
                                 sv.TenSV.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0) // Tìm kiếm theo tên sinh viên
                    .OrderBy(sv => sv.STT) // Sắp xếp danh sách theo STT
                    .ToList();

                // Cập nhật DataGridView với danh sách đã lọc và sắp xếp
                bdSinhVien.DataSource = filteredList;

                // Hiển thị tổng số sinh viên tìm thấy
                txtTongSV.Text = filteredList.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
    }
}
