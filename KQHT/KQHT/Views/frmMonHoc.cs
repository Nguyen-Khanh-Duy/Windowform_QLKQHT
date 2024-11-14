using KQHT.Controllers;
using KQHT.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KQHT; 
using KQHT.KQHTDataSet1TableAdapters;

namespace KQHT.Views
{
    public partial class frmMonHoc : Form, IView
    {
        private ControllerMonHoc ControllerMonHoc;
        private ControllerGiangVien ControllerGiangVien;     
        private ModelMonHoc item;
        private KQHTDataSet1 kQHTDataSet1 = new KQHTDataSet1();       
        private GiangVienTableAdapter giangVienTableAdapter = new GiangVienTableAdapter();        
        public frmMonHoc()
        {
            InitializeComponent();
            ControllerMonHoc = new ControllerMonHoc();
            ControllerGiangVien = new ControllerGiangVien();
            LoadDanhSachMonHoc();
            LoadDanhSachGiangVien();
        }

        public void GetDataFromText()
        {
            var mh = new ModelMonHoc
            {
                STT = int.Parse(txtSTT.Text), // Chuyển đổi STT sang số nguyên
                MaMH = txtMaMH.Text,
                TenMH = txtTenMH.Text,
                SoTinChi = txtSoTinChi.Text,
                MoTa = txtMoTa.Text,
                GiangVienPhuTrach = cmbGiangVienPhuTrach.Text,
                MaGV = txtMaGV.Text,
            };

            ControllerMonHoc.Add(mh);
            ControllerMonHoc.Update(mh);
        }

        public void SetDataToText()
        {
            if (item is ModelMonHoc mh)
            {
                txtSTT.Text = mh.STT.ToString(); // Chuyển STT sang chuỗi để hiển thị
                txtMaMH.Text = mh.MaMH;
                txtTenMH.Text = mh.TenMH;
                txtSoTinChi.Text = mh.SoTinChi;
                txtMoTa.Text = mh.MoTa;
                cmbGiangVienPhuTrach.Text = mh.GiangVienPhuTrach;
                txtMaGV.Text = mh.MaGV;
            }
            else
            {
                throw new ArgumentException("Item");
            }
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kQHTDataSet2.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.kQHTDataSet2.MonHoc);
            LoadDanhSachMonHoc();
            LoadDanhSachGiangVien();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ các điều khiển trên giao diện
                string sttText = txtSTT.Text.Trim(); // Thu thập giá trị STT từ giao diện
                string MaMH = txtMaMH.Text.Trim();
                string TenMH = txtTenMH.Text.Trim();
                string SoTinChi = txtSoTinChi.Text.Trim();
                string MoTa = txtMoTa.Text.Trim();
                string GiangVienPhuTrach = cmbGiangVienPhuTrach.Text.Trim();
                string MaGV= txtMaGV.Text.Trim();
                // Kiểm tra tính hợp lệ của STT (STT phải là một số nguyên hợp lệ)
                if (!int.TryParse(txtSTT.Text, out int STT))
                {
                    MessageBox.Show("STT phải là một số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra dữ liệu hợp lệ
                if (string.IsNullOrEmpty(MaMH) || string.IsNullOrEmpty(TenMH) || string.IsNullOrEmpty(SoTinChi) || string.IsNullOrEmpty(MoTa) || string.IsNullOrEmpty(GiangVienPhuTrach) || string.IsNullOrEmpty(MaGV))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng mới
                ModelMonHoc newMonHoc = new ModelMonHoc
                {
                    STT = int.Parse(txtSTT.Text),
                    MaMH = MaMH,
                    TenMH = TenMH,
                    SoTinChi = SoTinChi,
                    MoTa = MoTa,
                    GiangVienPhuTrach = GiangVienPhuTrach,
                    MaGV = MaGV,
                };

                // Gọi phương thức Add để thêm vào cơ sở dữ liệu
                if (ControllerMonHoc.Add(newMonHoc))
                {
                    MessageBox.Show("Thêm MonHoc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachMonHoc();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm MonHoc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDanhSachMonHoc()
        {
            try
            {
                // Lấy danh sách mới từ TableAdapter và đưa vào DataSet
                this.monHocTableAdapter.Fill(this.kQHTDataSet2.MonHoc);   // Lấy dữ liệu mới từ database vào DataSet

                // Tạo một DataView để sắp xếp dữ liệu từ DataTable
                DataView sortedView = new DataView(this.kQHTDataSet2.MonHoc)
                {
                    Sort = "STT ASC" // Sắp xếp theo cột STT tăng dần
                };

                // Gán DataView đã sắp xếp vào DataGridView hoặc thành phần giao diện khác
                bdMonHoc.DataSource = sortedView;

                // Tính tổng số từ DataTable
                int totalMonHoc = this.kQHTDataSet2.MonHoc.Rows.Count; // Đếm số dòng trong DataTable 

                // Hiển thị tổng số
                txtTongMH.Text = totalMonHoc.ToString();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show("Lỗi khi tải danh sách : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDanhSachGiangVien()
        {
            try
            {
                // Fetch data from the database to populate the ComboBox with GiangVien options
                this.giangVienTableAdapter.Fill(this.kQHTDataSet1.GiangVien);

                // Populate the ComboBox with GiangVien names or specific properties as required
                cmbGiangVienPhuTrach.DataSource = this.kQHTDataSet1.GiangVien;
                cmbGiangVienPhuTrach.DisplayMember = "TenGV"; // Display the teacher's name
                cmbGiangVienPhuTrach.ValueMember = "MaGV"; // Use MaGV as the value behind the scenes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách giảng viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bdMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu nhấp vào một hàng (không phải tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                // Lấy dòng dữ liệu từ DataGridView theo chỉ số dòng đã nhấp
                DataGridViewRow row = bdMonHoc.Rows[e.RowIndex];

                // Kiểm tra nếu dòng có dữ liệu và không phải là dòng trống
                if (row != null)
                {
                    // Gán dữ liệu từ DataGridView vào các TextBox tương ứng
                    txtSTT.Text = row.Cells["STT"].Value?.ToString() ?? string.Empty;
                    txtMaMH.Text = row.Cells["MaMH"].Value?.ToString() ?? string.Empty;
                    txtTenMH.Text = row.Cells["TenMH"].Value?.ToString() ?? string.Empty;
                    txtSoTinChi.Text = row.Cells["SoTinChi"].Value?.ToString() ?? string.Empty;
                    txtMoTa.Text = row.Cells["MoTa"].Value?.ToString() ?? string.Empty;
                    cmbGiangVienPhuTrach.Text = row.Cells["GiangVienPhuTrach"].Value?.ToString() ?? string.Empty;
                    txtMaGV.Text = row.Cells["MaGV"].Value?.ToString() ?? string.Empty;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu người dùng đã chọn một sinh viên trong DataGridView
                if (bdMonHoc.SelectedRows.Count > 0)
                {
                    // Lấy dòng được chọn trong DataGridView
                    DataGridViewRow row = bdMonHoc.SelectedRows[0];

                    // Lấy mã từ dòng đã chọn
                    string MaMH = row.Cells["MaMH"].Value?.ToString();

                    if (string.IsNullOrEmpty(MaMH))
                    {
                        MessageBox.Show("Chưa có MonHoc được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Xác nhận với người dùng trước khi xóa
                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa MonHoc mã {MaMH}?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Thực hiện xóa khỏi cơ sở dữ liệu
                        bool result = ControllerMonHoc.Delete(MaMH); // Giả sử bạn có phương thức Delete trong Controller

                        if (result)
                        {
                            MessageBox.Show("MonHoc đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachMonHoc(); 
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi xóa MonHoc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một MonHoc để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show("Lỗi khi xóa MonHoc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ModelMonHoc mh = new ModelMonHoc
                {
                   
                    STT = int.Parse(txtSTT.Text), // Chuyển đổi STT sang số nguyên
                    MaMH = txtMaMH.Text,
                    TenMH = txtTenMH.Text,
                    SoTinChi = txtSoTinChi.Text,
                    MoTa = txtMoTa.Text,
                    GiangVienPhuTrach = cmbGiangVienPhuTrach.Text,
                    MaGV = txtMaGV.Text,
                };

                // Gọi phương thức từ controller
                ControllerMonHoc.Update(mh);

                // Làm mới lại DataGridView sau khi sửa
                LoadDanhSachMonHoc();

                MessageBox.Show("Sửa MonHoc thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa MonHoc: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchMonHoc();
        }

        private void txtSearchMH_TextChanged(object sender, EventArgs e)
        {
            SearchMonHoc();
        }
        private void SearchMonHoc()
        {
            try
            {
                // Lấy nội dung tìm kiếm từ TextBox
                string searchQuery = txtSearchMH.Text.Trim();

                // Lấy danh sách từ Controller
                List<ModelMonHoc> monhoc = ControllerMonHoc.Search(searchQuery);

                // Lọc danh sách dựa trên nội dung tìm kiếm
                var filteredList = monhoc
                    .Where(mh => mh.MaMH.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                 mh.TenMH.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
                    .OrderBy(mh => mh.STT) // Sắp xếp danh sách theo STT
                    .ToList();

                // Cập nhật DataGridView với danh sách đã lọc và sắp xếp
                bdMonHoc.DataSource = filteredList;

                // Hiển thị tổng số
                txtTongMH.Text = filteredList.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void cmbGiangVienPhuTrach_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the selected item is valid
            if (cmbGiangVienPhuTrach.SelectedItem is DataRowView selectedRow)
            {
                // Retrieve the corresponding MaGV and display it
                string MaGV = selectedRow["MaGV"].ToString();
                txtMaGV.Text = MaGV; // Assuming txtMaGV is a TextBox where you want to display MaGV
            }
        }

        private void txtMaGV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
