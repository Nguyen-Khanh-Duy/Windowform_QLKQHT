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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace KQHT.Views
{
    public partial class frmGiangVien : Form,IView
    {
        private ControllerGiangVien ControllerGiangVien;
        private ModelGiangVien item;
        public frmGiangVien()
        {
            InitializeComponent();
            ControllerGiangVien = new ControllerGiangVien(); 
            LoadDanhSachGiangVien(); 
        }

        public void GetDataFromText()
        {
            var gv = new ModelGiangVien
            {
                STT = int.Parse(txtSTT.Text), // Chuyển đổi STT sang số nguyên
                MaGV= txtMaGV.Text,
                TenGV = txtTenGV.Text,               
                Email = txtEmail.Text,
                SDT = txtSDT.Text,
                ChuyenMon = txtChuyenMon.Text
            };

            ControllerGiangVien.Add(gv);
            ControllerGiangVien.Update(gv);
        }

        public void SetDataToText()
        {

            if (item is ModelGiangVien gv)
            {
                txtSTT.Text = gv.STT.ToString(); // Chuyển STT sang chuỗi để hiển thị
                txtMaGV.Text = gv.MaGV;
                txtTenGV.Text = gv.TenGV;              
                txtEmail.Text = gv.Email;
                txtSDT.Text = gv.SDT;
                txtChuyenMon.Text = gv.ChuyenMon;
            }
            else
            {
                throw new ArgumentException("Item");
            }
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kQHTDataSet1.GiangVien' table. You can move, or remove it, as needed.
            this.giangVienTableAdapter.Fill(this.kQHTDataSet1.GiangVien);
            LoadDanhSachGiangVien();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ các điều khiển trên giao diện
                string sttText = txtSTT.Text.Trim(); // Thu thập giá trị STT từ giao diện
                string MaGV = txtMaGV.Text.Trim();
                string TenGV = txtTenGV.Text.Trim();              
                string Email = txtEmail.Text.Trim();
                string SDT = txtSDT.Text.Trim();
                string ChuyenMon= txtChuyenMon.Text.Trim();

                // Kiểm tra tính hợp lệ của STT (STT phải là một số nguyên hợp lệ)
                if (!int.TryParse(txtSTT.Text, out int STT))
                {
                    MessageBox.Show("STT phải là một số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra dữ liệu hợp lệ
                if (string.IsNullOrEmpty(MaGV) || string.IsNullOrEmpty(TenGV) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(SDT))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng mới
                ModelGiangVien newGiangVien = new ModelGiangVien
                {
                    STT = int.Parse(txtSTT.Text),
                    MaGV = MaGV,
                    TenGV = TenGV,               
                    Email = Email,
                    SDT = SDT,
                    ChuyenMon = ChuyenMon
                };

                // Gọi phương thức Add để thêm vào cơ sở dữ liệu
                if (ControllerGiangVien.Add(newGiangVien))
                {
                    MessageBox.Show("Thêm GiangVien thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachGiangVien(); 
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm GiangVien.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDanhSachGiangVien()
        {
            try
            {
                // Lấy danh sách mới từ TableAdapter và đưa vào DataSet
                this.giangVienTableAdapter.Fill(this.kQHTDataSet1.GiangVien); // Lấy dữ liệu mới từ database vào DataSet

                // Tạo một DataView để sắp xếp dữ liệu từ DataTable
                DataView sortedView = new DataView(this.kQHTDataSet1.GiangVien)
                {
                    Sort = "STT ASC" // Sắp xếp theo cột STT tăng dần
                };

                // Gán DataView đã sắp xếp vào DataGridView hoặc thành phần giao diện khác
                bdGiangVien.DataSource = sortedView;

                // Tính tổng số từ DataTable
                int totalGiangVien = this.kQHTDataSet1.GiangVien.Rows.Count; // Đếm số dòng trong DataTable 

                // Hiển thị tổng số
                txtTongGV.Text = totalGiangVien.ToString();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show("Lỗi khi tải danh sách : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bdGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu nhấp vào một hàng (không phải tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                // Lấy dòng dữ liệu từ DataGridView theo chỉ số dòng đã nhấp
                DataGridViewRow row = bdGiangVien.Rows[e.RowIndex];

                // Kiểm tra nếu dòng có dữ liệu và không phải là dòng trống
                if (row != null)
                {
                    // Gán dữ liệu từ DataGridView vào các TextBox tương ứng
                    txtSTT.Text = row.Cells["STT"].Value?.ToString() ?? string.Empty; 
                    txtMaGV.Text = row.Cells["MaGV"].Value?.ToString() ?? string.Empty; 
                    txtTenGV.Text = row.Cells["TenGV"].Value?.ToString() ?? string.Empty;                   
                    txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? string.Empty; 
                    txtSDT.Text = row.Cells["SDT"].Value?.ToString() ?? string.Empty; 
                    txtChuyenMon.Text = row.Cells["ChuyenMon"].Value?.ToString() ?? string.Empty; 
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu người dùng đã chọn một sinh viên trong DataGridView
                if (bdGiangVien.SelectedRows.Count > 0)
                {
                    // Lấy dòng được chọn trong DataGridView
                    DataGridViewRow row = bdGiangVien.SelectedRows[0];

                    // Lấy mã từ dòng đã chọn
                    string MaGV = row.Cells["MaGV"].Value?.ToString();

                    if (string.IsNullOrEmpty(MaGV))
                    {
                        MessageBox.Show("Chưa có GiangVien được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Xác nhận với người dùng trước khi xóa
                    DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa GiangVien mã {MaGV}?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Thực hiện xóa khỏi cơ sở dữ liệu
                        bool result = ControllerGiangVien.Delete(MaGV); // Giả sử bạn có phương thức Delete trong Controller

                        if (result)
                        {
                            MessageBox.Show("GiangVien đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachGiangVien(); // Cập nhật lại danh sách sinh viên
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi xóa GiangVien.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một GiangVien để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show("Lỗi khi xóa GiangVien: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ModelGiangVien gv = new ModelGiangVien
                {
                    STT = int.Parse(txtSTT.Text),
                    MaGV = txtMaGV.Text,
                    TenGV = txtTenGV.Text,                   
                    Email = txtEmail.Text,
                    SDT = txtSDT.Text,
                    ChuyenMon = txtChuyenMon.Text
                };

                // Gọi phương thức từ controller
                ControllerGiangVien.Update(gv);

                // Làm mới lại DataGridView sau khi sửa
                LoadDanhSachGiangVien();

                MessageBox.Show("Sửa GiangVien thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa GiangVien: " + ex.Message);
            }
        }
        private void SearchGiangVien()
        {
            try
            {
                // Lấy nội dung tìm kiếm từ TextBox
                string searchQuery = txtSearchGV.Text.Trim();

                // Lấy danh sách từ Controller
                List<ModelGiangVien> giangvien = ControllerGiangVien.Search(searchQuery);

                // Lọc danh sách dựa trên nội dung tìm kiếm
                var filteredList = giangvien
                    .Where(gv => gv.MaGV.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 || 
                                 gv.TenGV.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0) 
                    .OrderBy(gv => gv.STT) // Sắp xếp danh sách theo STT
                    .ToList();

                // Cập nhật DataGridView với danh sách đã lọc và sắp xếp
                bdGiangVien.DataSource = filteredList;

                // Hiển thị tổng số
                txtTongGV.Text = filteredList.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void txtSearchGV_TextChanged(object sender, EventArgs e)
        {
            SearchGiangVien();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchGiangVien();
        }
    }
}
