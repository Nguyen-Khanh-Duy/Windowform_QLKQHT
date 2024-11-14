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
    public partial class frmDiemRenLuyen : Form, IView
    {
        private ModelDiemRenLuyen item;      
        private ControllerDiemRenLuyen ControllerDiemRenLuyen;
        private KQHTDataSet kQHTDataSet = new KQHTDataSet();
        private KQHTDataSet4 kQHTDataSet4 = new KQHTDataSet4();
        private SinhVienTableAdapter sinhVienTableAdapter = new SinhVienTableAdapter();
        private HoatDongNgoaiKhoaTableAdapter hoatDongNgoaiKhoaTableAdapter = new HoatDongNgoaiKhoaTableAdapter();
        public frmDiemRenLuyen()
        { 
            InitializeComponent();
            ControllerDiemRenLuyen = new ControllerDiemRenLuyen();
            LoadDanhSachSinhVien();
            LoadDanhSachHoatDongNgoaiKhoa();
            LoadDanhSachDiemRenLuyen();
        }
        public void GetDataFromText()
        {
            var drl = new ModelDiemRenLuyen
            {
                STT = int.Parse(txtSTT.Text), // Chuyển đổi STT sang số nguyên
                MaRL = txtMaRL.Text,
                MaSV = cmbMaSV.Text,
                MaHD = cmbMaHD.Text,
                DiemRL = txtDiemRL.Text,
            };

            ControllerDiemRenLuyen.Add(drl);
            ControllerDiemRenLuyen.Update(drl);
        }

        public void SetDataToText()
        {

            if (item is ModelDiemRenLuyen drl)
            {
                txtSTT.Text = drl.STT.ToString(); // Chuyển STT sang chuỗi để hiển thị
                txtMaRL.Text = drl.MaRL;
                cmbMaSV.Text = drl.MaSV;
                cmbMaHD.Text = drl.MaHD;
                txtDiemRL.Text = drl.DiemRL;
            }
            else
            {
                throw new ArgumentException("Item");
            }
        }
        private void frmDiemRenLuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kQHTDataSet6.DiemRenLuyen' table. You can move, or remove it, as needed.
            this.diemRenLuyenTableAdapter.Fill(this.kQHTDataSet6.DiemRenLuyen);
            LoadDanhSachSinhVien();
            LoadDanhSachHoatDongNgoaiKhoa();
            LoadDanhSachDiemRenLuyen();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ các điều khiển trên giao diện
                string sttText = txtSTT.Text.Trim(); // Thu thập giá trị STT từ giao diện
                string MaRL = txtMaRL.Text.Trim();
                string MaSV = cmbMaSV.Text.Trim();
                string MaHD = cmbMaHD.Text.Trim();
                string DiemRL = txtDiemRL.Text.Trim();
                // Kiểm tra tính hợp lệ của STT (STT phải là một số nguyên hợp lệ)
                if (!int.TryParse(txtSTT.Text, out int STT))
                {
                    MessageBox.Show("STT phải là một số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra dữ liệu hợp lệ
                if (string.IsNullOrEmpty(MaRL) || string.IsNullOrEmpty(MaSV) || string.IsNullOrEmpty(MaHD) || string.IsNullOrEmpty(DiemRL))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng mới
                ModelDiemRenLuyen newDiemRenLuyen = new ModelDiemRenLuyen
                {
                    STT = int.Parse(txtSTT.Text),
                    MaRL = MaRL,
                    MaSV = MaSV,
                    MaHD = MaHD,
                    DiemRL = DiemRL,

                };

                // Gọi phương thức Add để thêm vào cơ sở dữ liệu
                if (ControllerDiemRenLuyen.Add(newDiemRenLuyen))
                {
                    MessageBox.Show("Thêm DiemRenLuyen thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDiemRenLuyen();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm DiemRenLuyen.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDanhSachDiemRenLuyen()
        {
            try
            {
                // Lấy danh sách mới từ TableAdapter và đưa vào DataSet
                this.diemRenLuyenTableAdapter.Fill(this.kQHTDataSet6.DiemRenLuyen);// Lấy dữ liệu mới từ database vào DataSet

                // Tạo một DataView để sắp xếp dữ liệu từ DataTable
                DataView sortedView = new DataView(this.kQHTDataSet6.DiemRenLuyen)
                {
                    Sort = "STT ASC" // Sắp xếp theo cột STT tăng dần
                };

                // Gán DataView đã sắp xếp vào DataGridView hoặc thành phần giao diện khác
                bdDRL.DataSource = sortedView;

                // Tính tổng số từ DataTable
                int totalSachDiemRenLuyen = this.kQHTDataSet6.DiemRenLuyen.Rows.Count; // Đếm số dòng trong DataTable 

                // Hiển thị tổng số
                txtTongDRL.Text = totalSachDiemRenLuyen.ToString();
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
        private void bdDRL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng dữ liệu từ DataGridView theo chỉ số dòng đã nhấp
                DataGridViewRow row = bdDRL.Rows[e.RowIndex];

                // Kiểm tra nếu dòng có dữ liệu và không phải là dòng trống
                if (row != null)
                {
                    // Gán dữ liệu từ DataGridView vào các TextBox tương ứng
                    txtSTT.Text = row.Cells["STT"].Value?.ToString() ?? string.Empty;
                    txtMaRL.Text = row.Cells["MaRL"].Value?.ToString() ?? string.Empty;
                    cmbMaSV.Text = row.Cells["MaSV"].Value?.ToString() ?? string.Empty;
                    cmbMaHD.Text = row.Cells["MaHD"].Value?.ToString() ?? string.Empty;
                    txtDiemRL.Text = row.Cells["DiemRL"].Value?.ToString() ?? string.Empty;
                    
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
                ModelDiemRenLuyen drl = new ModelDiemRenLuyen
                {
                    STT = int.Parse(txtSTT.Text), // Chuyển đổi STT sang số nguyên
                    MaRL = txtMaRL.Text,
                    MaSV = cmbMaSV.Text,
                    MaHD = cmbMaHD.Text,
                    DiemRL = txtDiemRL.Text,


                };

                // Gọi phương thức từ controller
                ControllerDiemRenLuyen.Update(drl);

                // Làm mới lại DataGridView sau khi sửa
                LoadDanhSachDiemRenLuyen();

                MessageBox.Show("Sửa DiemRenLuyen thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa DiemRenLuyen: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu người dùng đã chọn một  trong DataGridView
                if (bdDRL.SelectedRows.Count > 0)
                {
                    // Lấy dòng được chọn trong DataGridView
                    DataGridViewRow row = bdDRL.SelectedRows[0];

                    // Lấy mã từ dòng đã chọn
                    string MaRL = row.Cells["MaRL"].Value?.ToString();

                    if (string.IsNullOrEmpty(MaRL))
                    {
                        MessageBox.Show("Chưa có DiemRenLuyen được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Xác nhận với người dùng trước khi xóa
                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa DiemRenLuyen mã {MaRL}?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Thực hiện xóa khỏi cơ sở dữ liệu
                        bool result = ControllerDiemRenLuyen.Delete(MaRL); // Giả sử bạn có phương thức Delete trong Controller

                        if (result)
                        {
                            MessageBox.Show("DiemRenLuyen đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachDiemRenLuyen(); // Cập nhật lại danh sách 
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi xóa DiemRenLuyen.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một DiemRenLuyen để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show("Lỗi khi xóa DiemRenLuyen: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchDRL_TextChanged(object sender, EventArgs e)
        {
            SearchDiemRenLuyen();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchDiemRenLuyen();
        }
        private void SearchDiemRenLuyen()
        {
            try
            {
                // Lấy nội dung tìm kiếm từ TextBox
                string searchQuery = txtSearchDRL.Text.Trim();

                // Lấy danh sách từ Controller
                List<ModelDiemRenLuyen> drl = ControllerDiemRenLuyen.Search(searchQuery);

                // Lọc danh sách sinh viên dựa trên nội dung tìm kiếm
                var filteredList = drl
                .Where(rl => rl.MaRL.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                               rl.MaSV.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                               rl.MaHD.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                // Cập nhật DataGridView với danh sách đã lọc và sắp xếp
                bdDRL.DataSource = filteredList;

                // Hiển thị tổng số sinh viên tìm thấy
                txtTongDRL.Text = filteredList.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
    }
}
