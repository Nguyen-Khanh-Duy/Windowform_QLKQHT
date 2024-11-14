namespace KQHT.Views
{
    partial class frmDangKiHoatDongNgoaiKhoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.bdDKHDNK = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchDK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongDKHDNK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaDK = new System.Windows.Forms.TextBox();
            this.cmbMaHD = new System.Windows.Forms.ComboBox();
            this.kQHTDataSet5 = new KQHT.KQHTDataSet5();
            this.dangKiHoatDongNgoaiKhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dangKiHoatDongNgoaiKhoaTableAdapter = new KQHT.KQHTDataSet5TableAdapters.DangKiHoatDongNgoaiKhoaTableAdapter();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdDKHDNK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKiHoatDongNgoaiKhoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(325, 498);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 30);
            this.dateTimePicker1.TabIndex = 349;
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(325, 353);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(199, 33);
            this.cmbMaSV.TabIndex = 346;
            // 
            // bdDKHDNK
            // 
            this.bdDKHDNK.AllowUserToAddRows = false;
            this.bdDKHDNK.AllowUserToDeleteRows = false;
            this.bdDKHDNK.AutoGenerateColumns = false;
            this.bdDKHDNK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdDKHDNK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaDK,
            this.MaSV,
            this.MaHD,
            this.NgayDK});
            this.bdDKHDNK.DataSource = this.dangKiHoatDongNgoaiKhoaBindingSource;
            this.bdDKHDNK.Location = new System.Drawing.Point(584, 135);
            this.bdDKHDNK.Name = "bdDKHDNK";
            this.bdDKHDNK.ReadOnly = true;
            this.bdDKHDNK.RowHeadersWidth = 51;
            this.bdDKHDNK.RowTemplate.Height = 24;
            this.bdDKHDNK.Size = new System.Drawing.Size(939, 520);
            this.bdDKHDNK.TabIndex = 345;
            this.bdDKHDNK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdDKHDNK_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(1283, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 46);
            this.btnSearch.TabIndex = 344;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchDK
            // 
            this.txtSearchDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchDK.Location = new System.Drawing.Point(1041, 67);
            this.txtSearchDK.Multiline = true;
            this.txtSearchDK.Name = "txtSearchDK";
            this.txtSearchDK.Size = new System.Drawing.Size(199, 34);
            this.txtSearchDK.TabIndex = 342;
            this.txtSearchDK.TextChanged += new System.EventHandler(this.txtSearchDK_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(714, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(299, 25);
            this.label11.TabIndex = 341;
            this.label11.Text = "Tìm Kiếm Sinh Viên Đăng Kí :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(176, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 32);
            this.label10.TabIndex = 340;
            this.label10.Text = "BẢNG ĐĂNG KÍ  ";
            // 
            // txtTongDKHDNK
            // 
            this.txtTongDKHDNK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongDKHDNK.Location = new System.Drawing.Point(1417, 683);
            this.txtTongDKHDNK.Multiline = true;
            this.txtTongDKHDNK.Name = "txtTongDKHDNK";
            this.txtTongDKHDNK.ReadOnly = true;
            this.txtTongDKHDNK.Size = new System.Drawing.Size(106, 35);
            this.txtTongDKHDNK.TabIndex = 339;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(1125, 686);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 25);
            this.label9.TabIndex = 338;
            this.label9.Text = "Tổng Sinh Viên Đăng Kí :";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.Location = new System.Drawing.Point(222, 594);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 61);
            this.btnEdit.TabIndex = 337;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(411, 594);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 61);
            this.btnDelete.TabIndex = 336;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(72, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 334;
            this.label6.Text = "Ngày Đăng Ký :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(72, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 333;
            this.label3.Text = "Mã Hoạt Động :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(72, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 332;
            this.label4.Text = "Mã Sinh Viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(72, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 330;
            this.label2.Text = "Mã Đăng Ký :";
            // 
            // txtSTT
            // 
            this.txtSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSTT.Location = new System.Drawing.Point(325, 211);
            this.txtSTT.Multiline = true;
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(199, 34);
            this.txtSTT.TabIndex = 328;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreate.Location = new System.Drawing.Point(56, 594);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 61);
            this.btnCreate.TabIndex = 327;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(72, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 326;
            this.label1.Text = "STT :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 48);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(532, 660);
            this.textBox2.TabIndex = 329;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(695, 48);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(727, 67);
            this.textBox3.TabIndex = 343;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(387, 32);
            this.label8.TabIndex = 352;
            this.label8.Text = "HOẠT ĐỘNG NGOẠI KHÓA";
            // 
            // txtMaDK
            // 
            this.txtMaDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDK.Location = new System.Drawing.Point(325, 279);
            this.txtMaDK.Multiline = true;
            this.txtMaDK.Name = "txtMaDK";
            this.txtMaDK.Size = new System.Drawing.Size(199, 34);
            this.txtMaDK.TabIndex = 331;
            // 
            // cmbMaHD
            // 
            this.cmbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaHD.FormattingEnabled = true;
            this.cmbMaHD.Location = new System.Drawing.Point(325, 428);
            this.cmbMaHD.Name = "cmbMaHD";
            this.cmbMaHD.Size = new System.Drawing.Size(199, 33);
            this.cmbMaHD.TabIndex = 353;
            // 
            // kQHTDataSet5
            // 
            this.kQHTDataSet5.DataSetName = "KQHTDataSet5";
            this.kQHTDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dangKiHoatDongNgoaiKhoaBindingSource
            // 
            this.dangKiHoatDongNgoaiKhoaBindingSource.DataMember = "DangKiHoatDongNgoaiKhoa";
            this.dangKiHoatDongNgoaiKhoaBindingSource.DataSource = this.kQHTDataSet5;
            // 
            // dangKiHoatDongNgoaiKhoaTableAdapter
            // 
            this.dangKiHoatDongNgoaiKhoaTableAdapter.ClearBeforeFill = true;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 125;
            // 
            // MaDK
            // 
            this.MaDK.DataPropertyName = "MaDK";
            this.MaDK.HeaderText = "Mã Đăng Ký";
            this.MaDK.MinimumWidth = 6;
            this.MaDK.Name = "MaDK";
            this.MaDK.ReadOnly = true;
            this.MaDK.Width = 125;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã Sinh Viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            this.MaSV.Width = 125;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hoạt Động";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            this.MaHD.Width = 125;
            // 
            // NgayDK
            // 
            this.NgayDK.DataPropertyName = "NgayDK";
            this.NgayDK.HeaderText = "Ngày Đăng Ký";
            this.NgayDK.MinimumWidth = 6;
            this.NgayDK.Name = "NgayDK";
            this.NgayDK.ReadOnly = true;
            this.NgayDK.Width = 125;
            // 
            // frmDangKiHoatDongNgoaiKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 813);
            this.Controls.Add(this.cmbMaHD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbMaSV);
            this.Controls.Add(this.bdDKHDNK);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchDK);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTongDKHDNK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaDK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Name = "frmDangKiHoatDongNgoaiKhoa";
            this.Text = "frmDangKiHoatDongNgoaiKhoa";
            this.Load += new System.EventHandler(this.frmDangKiHoatDongNgoaiKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdDKHDNK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKiHoatDongNgoaiKhoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private System.Windows.Forms.DataGridView bdDKHDNK;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchDK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongDKHDNK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaDK;
        private System.Windows.Forms.ComboBox cmbMaHD;
        private KQHTDataSet5 kQHTDataSet5;
        private System.Windows.Forms.BindingSource dangKiHoatDongNgoaiKhoaBindingSource;
        private KQHTDataSet5TableAdapters.DangKiHoatDongNgoaiKhoaTableAdapter dangKiHoatDongNgoaiKhoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDK;
    }
}