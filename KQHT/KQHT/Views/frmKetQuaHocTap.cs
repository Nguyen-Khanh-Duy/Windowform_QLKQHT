using KQHT.Controllers;
using KQHT.KQHTDataSet3TableAdapters;
using KQHT.KQHTDataSet6TableAdapters;
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
    public partial class frmKetQuaHocTap : Form, IView
    {
        private ModelKetQuaHocTap item;
        private ControllerKetQuaHocTap ControllerKetQuaHocTap;
        private KQHTDataSet kQHTDataSet = new KQHTDataSet();
        private KQHTDataSet3 kQHTDataSet3 = new KQHTDataSet3();
        private KQHTDataSet6 kQHTDataSet6 = new KQHTDataSet6();
        private SinhVienTableAdapter sinhVienTableAdapter = new SinhVienTableAdapter();
        private DiemTrungBinhTableAdapter diemTrungBinhTableAdapter = new DiemTrungBinhTableAdapter();
        private DiemRenLuyenTableAdapter diemRenLuyenTableAdapter = new DiemRenLuyenTableAdapter();
        public frmKetQuaHocTap()
        {
            InitializeComponent();
            ControllerKetQuaHocTap = new ControllerKetQuaHocTap();
            LoadDanhSachKetQuaHocTap();
            LoadDanhSachSinhVien();
            LoadDanhSachDiemTrungBinh();
            LoadDanhSachDiemRenLuyen();

        }
        public void GetDataFromText()
        {
            var kqht = new ModelKetQuaHocTap
            {
                STT = int.Parse(txtSTT.Text),
                MaKQ = txtMaKQ.Text,
                MaSV = cmbMaSV.Text,
                TenSV = txtTenSV.Text,
                MaDTB = cmbMaDTB.Text,
                DiemTBM = txtDiemTBM.Text,
                MaRL = cmbMaRL.Text,
                DiemRL = txtDiemRL.Text,
                XepLoai = txtXepLoai.Text,
            };

            // Tính XepLoai dựa vào DiemTBM và DiemRL
            if (double.TryParse(kqht.DiemTBM, out double diemTBM) && double.TryParse(kqht.DiemRL, out double diemRL))
            {
                kqht.XepLoai = TinhXepLoai(diemTBM, diemRL);
                txtXepLoai.Text = kqht.XepLoai; // Cập nhật XepLoai lên giao diện
            }

            ControllerKetQuaHocTap.Add(kqht);
            ControllerKetQuaHocTap.Update(kqht);
        }
        public void SetDataToText()
        {
            if (item is ModelKetQuaHocTap kqht)
            {
                txtSTT.Text = kqht.STT.ToString(); // Chuyển STT sang chuỗi để hiển thị
                txtMaKQ.Text = kqht.MaKQ;
                cmbMaSV.Text = kqht.MaSV;
                txtTenSV.Text = kqht.TenSV;
                cmbMaDTB.Text = kqht.MaDTB;
                txtDiemTBM.Text = kqht.DiemTBM;
                cmbMaRL.Text = kqht.MaRL;
                txtDiemRL.Text = kqht.DiemRL;
                txtXepLoai.Text = kqht.XepLoai;
            }
            else
            {
                throw new ArgumentException("Item");
            }
        }
        private void frmKetQuaHocTap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kQHTDataSet7.KetQuaHocTap' table. You can move, or remove it, as needed.
            this.ketQuaHocTapTableAdapter.Fill(this.kQHTDataSet7.KetQuaHocTap);
            LoadDanhSachKetQuaHocTap();
            LoadDanhSachSinhVien();
            LoadDanhSachDiemTrungBinh();
            LoadDanhSachDiemRenLuyen();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập và kiểm tra dữ liệu từ giao diện
                string sttText = txtSTT.Text.Trim();
                string MaKQ = txtMaKQ.Text.Trim();
                string MaSV = cmbMaSV.Text.Trim();
                string TenSV = txtTenSV.Text.Trim();
                string MaDTB = cmbMaDTB.Text.Trim();
                string DiemTBM = txtDiemTBM.Text.Trim();
                string MaRL = cmbMaRL.Text.Trim();
                string DiemRL = txtDiemRL.Text.Trim();

                // Kiểm tra tính hợp lệ của STT (STT phải là một số nguyên)
                if (!int.TryParse(sttText, out int STT))
                {
                    MessageBox.Show("STT phải là một số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra các trường bắt buộc
                if (string.IsNullOrEmpty(MaKQ) || string.IsNullOrEmpty(MaSV) || string.IsNullOrEmpty(TenSV) ||
                    string.IsNullOrEmpty(MaDTB) || string.IsNullOrEmpty(DiemTBM) || string.IsNullOrEmpty(MaRL) ||
                    string.IsNullOrEmpty(DiemRL))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tính XepLoai dựa vào DiemTBM và DiemRL
                string xepLoai = "Không xác định";
                if (double.TryParse(DiemTBM, out double diemTBMValue) && double.TryParse(DiemRL, out double diemRLValue))
                {
                    xepLoai = TinhXepLoai(diemTBMValue, diemRLValue);
                    txtXepLoai.Text = xepLoai; // Hiển thị XepLoai lên giao diện
                }

                // Tạo đối tượng ModelKetQuaHocTap và thêm vào database
                ModelKetQuaHocTap newKetQuaHocTap = new ModelKetQuaHocTap
                {
                    STT = STT,
                    MaKQ = MaKQ,
                    MaSV = MaSV,
                    TenSV = TenSV,
                    MaDTB = MaDTB,
                    DiemTBM = DiemTBM,
                    MaRL = MaRL,
                    DiemRL = DiemRL,
                    XepLoai = xepLoai // Sử dụng giá trị XepLoai đã tính
                };

                // Thêm vào database thông qua Controller
                if (ControllerKetQuaHocTap.Add(newKetQuaHocTap))
                {
                    MessageBox.Show("Thêm KetQuaHocTap thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachKetQuaHocTap();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm KetQuaHocTap.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDanhSachKetQuaHocTap()
        {
            try
            {
                // Lấy danh sách mới từ TableAdapter và đưa vào DataSet
                this.ketQuaHocTapTableAdapter.Fill(this.kQHTDataSet7.KetQuaHocTap); // Lấy dữ liệu mới từ database vào DataSet

                // Tạo một DataView để sắp xếp dữ liệu từ DataTable
                DataView sortedView = new DataView(this.kQHTDataSet7.KetQuaHocTap)
                {
                    Sort = "STT ASC" // Sắp xếp theo cột STT tăng dần
                };

                // Gán DataView đã sắp xếp vào DataGridView hoặc thành phần giao diện khác
                bdKQHT.DataSource = sortedView;

                // Tính tổng số từ DataTable
                int totalKetQuaHocTap = this.kQHTDataSet7.KetQuaHocTap.Rows.Count; // Đếm số dòng trong DataTable 

                // Hiển thị tổng số
                txtTongKQHT.Text = totalKetQuaHocTap.ToString();
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
        private void LoadDanhSachDiemTrungBinh()
        {
            try
            {
                this.diemTrungBinhTableAdapter.Fill(this.kQHTDataSet3.DiemTrungBinh);
                cmbMaDTB.DataSource = this.kQHTDataSet3.DiemTrungBinh;
                cmbMaDTB.ValueMember = "MaDTB";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách DiemTrungBinh: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDanhSachDiemRenLuyen()
        {
            try
            {
                this.diemRenLuyenTableAdapter.Fill(this.kQHTDataSet6.DiemRenLuyen);
                cmbMaRL.DataSource = this.kQHTDataSet6.DiemRenLuyen;
                cmbMaRL.ValueMember = "MaRL";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách DiemRenLuyen: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaSV.SelectedItem is DataRowView selectedRow)
            {
                string TenSV = selectedRow["TenSV"].ToString();
                txtTenSV.Text = TenSV;
            }
        }

        private void cmbMaDTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaDTB.SelectedItem is DataRowView selectedRow)
            {
                string DiemTB = selectedRow["DiemTB"].ToString();
                txtDiemTBM.Text = DiemTB;
            }
            CapNhatXepLoai();
        }

        private void cmbMaRL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaRL.SelectedItem is DataRowView selectedRow)
            {
                string DiemRL = selectedRow["DiemRL"].ToString();
                txtDiemRL.Text = DiemRL;
            }
            CapNhatXepLoai();
        }

        private void bdKQHT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu nhấp vào một hàng (không phải tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                // Lấy dòng dữ liệu từ DataGridView theo chỉ số dòng đã nhấp
                DataGridViewRow row = bdKQHT.Rows[e.RowIndex];

                // Kiểm tra nếu dòng có dữ liệu và không phải là dòng trống
                if (row != null)
                {
                    // Gán dữ liệu từ DataGridView vào các TextBox tương ứng
                    txtSTT.Text = row.Cells["STT"].Value?.ToString() ?? string.Empty;
                    txtMaKQ.Text = row.Cells["MaKQ"].Value?.ToString() ?? string.Empty;
                    cmbMaSV.Text = row.Cells["MaSV"].Value?.ToString() ?? string.Empty;
                    txtTenSV.Text = row.Cells["TenSV"].Value?.ToString() ?? string.Empty;
                    cmbMaDTB.Text = row.Cells["MaDTB"].Value?.ToString() ?? string.Empty;
                    txtDiemTBM.Text = row.Cells["DiemTBM"].Value?.ToString() ?? string.Empty;
                    cmbMaRL.Text = row.Cells["MaRL"].Value?.ToString() ?? string.Empty;
                    txtDiemRL.Text = row.Cells["DiemRL"].Value?.ToString() ?? string.Empty;
                    txtXepLoai.Text = row.Cells["XepLoai"].Value?.ToString() ?? string.Empty;
                }
            }
        }
        private string TinhXepLoai(double diemTBM, double diemRL)
        {
            if (diemTBM >= 9.0 && diemRL >= 90)
                return "Xuất sắc";
            else if (diemTBM >= 8.5 && diemRL >= 85)
                return "Giỏi";
            else if (diemTBM >= 6.5 && diemRL >= 65)
                return "Khá";
            else if (diemTBM >= 5.0 && diemRL >= 50)
                return "Trung bình";
            else
                return "Yếu";
        }
        private void CapNhatXepLoai()
        {
            if (double.TryParse(txtDiemTBM.Text, out double diemTBM) && double.TryParse(txtDiemRL.Text, out double diemRL))
            {
                txtXepLoai.Text = TinhXepLoai(diemTBM, diemRL);
            }
            else
            {
                txtXepLoai.Text = string.Empty; // Xóa nếu giá trị không hợp lệ
            }
        }
        private void txtXepLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu người dùng đã chọn một sinh viên trong DataGridView
                if (bdKQHT.SelectedRows.Count > 0)
                {
                    // Lấy dòng được chọn trong DataGridView
                    DataGridViewRow row = bdKQHT.SelectedRows[0];

                    // Lấy mã từ dòng đã chọn
                    string MaKQ = row.Cells["MaKQ"].Value?.ToString();

                    if (string.IsNullOrEmpty(MaKQ))
                    {
                        MessageBox.Show("Chưa có KetQuaHocTap được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Xác nhận với người dùng trước khi xóa
                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa KetQuaHocTap mã {MaKQ}?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Thực hiện xóa khỏi cơ sở dữ liệu
                        bool result = ControllerKetQuaHocTap.Delete(MaKQ); // Giả sử bạn có phương thức Delete trong Controller

                        if (result)
                        {
                            MessageBox.Show("KetQuaHocTap đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachKetQuaHocTap();
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi xóa KetQuaHocTap.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một KetQuaHocTap để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show("Lỗi khi xóa KetQuaHocTap: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ModelKetQuaHocTap kqht = new ModelKetQuaHocTap
                {

                    STT = int.Parse(txtSTT.Text),
                    MaKQ = txtMaKQ.Text,
                    MaSV = cmbMaSV.Text,
                    TenSV = txtTenSV.Text,
                    MaDTB = cmbMaDTB.Text,
                    DiemTBM = txtDiemTBM.Text,
                    MaRL = cmbMaRL.Text,
                    DiemRL = txtDiemRL.Text,
                    XepLoai = txtXepLoai.Text,
                };

                // Gọi phương thức từ controller
                ControllerKetQuaHocTap.Update(kqht);

                // Làm mới lại DataGridView sau khi sửa
                LoadDanhSachKetQuaHocTap();

                MessageBox.Show("Sửa KetQuaHocTap thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa KetQuaHocTap: " + ex.Message);
            }
        }
        private void SearchKetQuaHocTap()
        {
            try
            {
                // Lấy nội dung tìm kiếm từ TextBox
                string searchQuery = txtSearchKQHT.Text.Trim();

                // Lấy danh sách từ Controller
                List<ModelKetQuaHocTap> kqht = ControllerKetQuaHocTap.Search(searchQuery);

                // Lọc danh sách dựa trên nội dung tìm kiếm
                var filteredList = kqht
                    .Where(kq => kq.MaKQ.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                 kq.MaSV.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                 kq.TenSV.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                 kq.MaDTB.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                 kq.MaRL.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
                    .OrderBy(kq => kq.STT) // Sắp xếp danh sách theo STT
                    .ToList();

                // Cập nhật DataGridView với danh sách đã lọc và sắp xếp
                bdKQHT.DataSource = filteredList;

                // Hiển thị tổng số
                txtTongKQHT.Text = filteredList.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void txtSearchKQHT_TextChanged(object sender, EventArgs e)
        {
            SearchKetQuaHocTap();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchKetQuaHocTap();
        }
    }
}
