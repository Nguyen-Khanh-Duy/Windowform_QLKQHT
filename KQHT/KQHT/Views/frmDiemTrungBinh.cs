using KQHT.Controllers;
using KQHT.KQHTDataSet1TableAdapters;
using KQHT.KQHTDataSet2TableAdapters;
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
    public partial class frmDiemTrungBinh : Form, IView
    {
        private ControllerDiemTrungBinh ControllerDiemTrungBinh;
        private ControllerMonHoc ControllerMonHoc;
        private ControllerSinhVien ControllerSinhVien;
        private ModelDiemTrungBinh item;
        private KQHTDataSet kQHTDataSet = new KQHTDataSet();
        private KQHTDataSet2 kQHTDataSet2 = new KQHTDataSet2();
        private SinhVienTableAdapter sinhVienTableAdapter = new SinhVienTableAdapter();
        private MonHocTableAdapter monHocTableAdapter = new MonHocTableAdapter();
        public frmDiemTrungBinh()
        {
            InitializeComponent();
            ControllerDiemTrungBinh = new ControllerDiemTrungBinh();
            ControllerMonHoc = new ControllerMonHoc();
            ControllerSinhVien = new ControllerSinhVien();
            LoadDanhSachMonHoc();
            LoadDanhSachSinhVien();
            LoadDanhSachDiemTrungBinh();
        }

        public void GetDataFromText()
        {
            var dtb = new ModelDiemTrungBinh
            {
                STT = int.Parse(txtSTT.Text), // Chuyển đổi STT sang số nguyên
                MaDTB = txtMaDTB.Text,
                MaSV = cmbMaSV.Text,
                MaMH = cmbMaMH.Text,
                DiemTB = txtDiemTB.Text,
            };

            ControllerDiemTrungBinh.Add(dtb);
            ControllerDiemTrungBinh.Update(dtb);
        }

        public void SetDataToText()
        {
            if (item is ModelDiemTrungBinh dtb)
            {
                txtSTT.Text = dtb.STT.ToString(); // Chuyển STT sang chuỗi để hiển thị
                txtMaDTB.Text = dtb.MaDTB;
                cmbMaSV.Text = dtb.MaSV;
                cmbMaMH.Text = dtb.MaMH;
                txtDiemTB.Text = dtb.DiemTB;
            }
            else
            {
                throw new ArgumentException("Item");
            }
        }
        private void frmDiemTrungBinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kQHTDataSet3.DiemTrungBinh' table. You can move, or remove it, as needed.
            this.diemTrungBinhTableAdapter.Fill(this.kQHTDataSet3.DiemTrungBinh);
            LoadDanhSachSinhVien();
            LoadDanhSachMonHoc();
            LoadDanhSachDiemTrungBinh();
        }
        private void LoadDanhSachDiemTrungBinh()
        {
            try
            {
                // Lấy danh sách mới từ TableAdapter và đưa vào DataSet
                this.diemTrungBinhTableAdapter.Fill(this.kQHTDataSet3.DiemTrungBinh);  // Lấy dữ liệu mới từ database vào DataSet

                // Tạo một DataView để sắp xếp dữ liệu từ DataTable
                DataView sortedView = new DataView(this.kQHTDataSet3.DiemTrungBinh)
                {
                    Sort = "STT ASC" // Sắp xếp theo cột STT tăng dần
                };

                // Gán DataView đã sắp xếp vào DataGridView hoặc thành phần giao diện khác
                bdDiemTrungBinh.DataSource = sortedView;

                // Tính tổng số từ DataTable
                int totalDiemTrungBinh = this.kQHTDataSet3.DiemTrungBinh.Rows.Count; // Đếm số dòng trong DataTable 

                // Hiển thị tổng số
                txtTongDTB.Text = totalDiemTrungBinh.ToString();
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
        private void LoadDanhSachMonHoc()
        {
            try
            {
                this.monHocTableAdapter.Fill(this.kQHTDataSet2.MonHoc);
                cmbMaMH.DataSource = this.kQHTDataSet2.MonHoc;
                cmbMaMH.ValueMember = "MaMH";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách MONHOC: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bdDiemTrungBinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu nhấp vào một hàng (không phải tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                // Lấy dòng dữ liệu từ DataGridView theo chỉ số dòng đã nhấp
                DataGridViewRow row = bdDiemTrungBinh.Rows[e.RowIndex];

                // Kiểm tra nếu dòng có dữ liệu và không phải là dòng trống
                if (row != null)
                {
                    // Gán dữ liệu từ DataGridView vào các TextBox tương ứng
                    txtSTT.Text = row.Cells["STT"].Value?.ToString() ?? string.Empty;
                    txtMaDTB.Text = row.Cells["MaDTB"].Value?.ToString() ?? string.Empty;
                    cmbMaSV.Text = row.Cells["MaSV"].Value?.ToString() ?? string.Empty;
                    cmbMaMH.Text = row.Cells["MaMH"].Value?.ToString() ?? string.Empty;
                    txtDiemTB.Text = row.Cells["DiemTB"].Value?.ToString() ?? string.Empty;
                }
            }
        }
        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ các điều khiển trên giao diện
                string sttText = txtSTT.Text.Trim(); // Thu thập giá trị STT từ giao diện
                string MaDTB = txtMaDTB.Text.Trim();
                string MaSV = cmbMaSV.Text.Trim();
                string MaMH = cmbMaMH.Text.Trim();
                string DiemTB = txtDiemTB.Text.Trim();
                // Kiểm tra tính hợp lệ của STT (STT phải là một số nguyên hợp lệ)
                if (!int.TryParse(txtSTT.Text, out int STT))
                {
                    MessageBox.Show("STT phải là một số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Kiểm tra dữ liệu hợp lệ
                if (string.IsNullOrEmpty(MaDTB) || string.IsNullOrEmpty(MaSV) || string.IsNullOrEmpty(MaMH) || string.IsNullOrEmpty(DiemTB))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Tạo đối tượng mới
                ModelDiemTrungBinh newDiemTrungBinh = new ModelDiemTrungBinh
                {
                    STT = int.Parse(txtSTT.Text),
                    MaDTB = MaDTB,
                    MaSV = MaSV,
                    MaMH = MaMH,
                    DiemTB = DiemTB,
                };

                // Gọi phương thức Add để thêm vào cơ sở dữ liệu
                if (ControllerDiemTrungBinh.Add(newDiemTrungBinh))
                {
                    MessageBox.Show("Thêm MonHoc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDiemTrungBinh();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm DiemTrungBinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ModelDiemTrungBinh dtb = new ModelDiemTrungBinh
                {

                    STT = int.Parse(txtSTT.Text), // Chuyển đổi STT sang số nguyên
                    MaDTB = txtMaDTB.Text,
                    MaSV = cmbMaSV.Text,
                    MaMH = cmbMaMH.Text,
                    DiemTB = txtDiemTB.Text,
                };

                // Gọi phương thức từ controller
                ControllerDiemTrungBinh.Update(dtb);

                // Làm mới lại DataGridView sau khi sửa
                LoadDanhSachDiemTrungBinh();

                MessageBox.Show("Sửa DiemTrungBinh thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa DiemTrungBinh: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu người dùng đã chọn một sinh viên trong DataGridView
                if (bdDiemTrungBinh.SelectedRows.Count > 0)
                {
                    // Lấy dòng được chọn trong DataGridView
                    DataGridViewRow row = bdDiemTrungBinh.SelectedRows[0];

                    // Lấy mã từ dòng đã chọn
                    string MaDTB = row.Cells["MaDTB"].Value?.ToString();

                    if (string.IsNullOrEmpty(MaDTB))
                    {
                        MessageBox.Show("Chưa có DiemTrungBinh được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Xác nhận với người dùng trước khi xóa
                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa DiemTrungBinh mã {MaDTB}?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Thực hiện xóa khỏi cơ sở dữ liệu
                        bool result = ControllerDiemTrungBinh.Delete(MaDTB); // Giả sử bạn có phương thức Delete trong Controller

                        if (result)
                        {
                            MessageBox.Show("DiemTrungBinh đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachDiemTrungBinh(); // Cập nhật lại danh sách sinh viên
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi xóa DiemTrungBinh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một DiemTrungBinh để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show("Lỗi khi xóa DiemTrungBinh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchDiemTrungBinh()
        {
            try
            {
                // Lấy nội dung tìm kiếm từ TextBox
                string searchQuery = txtSearchDTB.Text.Trim();

                // Lấy danh sách từ Controller
                List<ModelDiemTrungBinh> diemtrungbinh = ControllerDiemTrungBinh.Search(searchQuery);

                // Lọc danh sách dựa trên nội dung tìm kiếm
                var filteredList = diemtrungbinh
                    .Where(dtb => dtb.MaDTB.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                  dtb.MaSV.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                 dtb.MaMH.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
                    .OrderBy(dtb => dtb.STT) // Sắp xếp danh sách theo STT
                    .ToList();

                // Cập nhật DataGridView với danh sách đã lọc và sắp xếp
                bdDiemTrungBinh.DataSource = filteredList;

                // Hiển thị tổng số
                txtTongDTB.Text = filteredList.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void txtSearchDTB_TextChanged(object sender, EventArgs e)
        {
            SearchDiemTrungBinh();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchDiemTrungBinh();
        }
    }
}
