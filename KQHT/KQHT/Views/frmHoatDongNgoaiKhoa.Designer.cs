namespace KQHT.Views
{
    partial class frmHoatDongNgoaiKhoa
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
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.bdHDNK = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoatDongNgoaiKhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kQHTDataSet4 = new KQHT.KQHTDataSet4();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchHDNK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongHDNK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtTenHD = new System.Windows.Forms.TextBox();
            this.hoatDongNgoaiKhoaTableAdapter = new KQHT.KQHTDataSet4TableAdapters.HoatDongNgoaiKhoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdHDNK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongNgoaiKhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(329, 360);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(199, 33);
            this.cmbMaSV.TabIndex = 294;
            // 
            // bdHDNK
            // 
            this.bdHDNK.AllowUserToAddRows = false;
            this.bdHDNK.AllowUserToDeleteRows = false;
            this.bdHDNK.AutoGenerateColumns = false;
            this.bdHDNK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdHDNK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHD,
            this.MaSV,
            this.TenHD,
            this.ThoiGianBD,
            this.ThoiGianKT,
            this.DiaDiem});
            this.bdHDNK.DataSource = this.hoatDongNgoaiKhoaBindingSource;
            this.bdHDNK.Location = new System.Drawing.Point(616, 163);
            this.bdHDNK.Name = "bdHDNK";
            this.bdHDNK.ReadOnly = true;
            this.bdHDNK.RowHeadersWidth = 51;
            this.bdHDNK.RowTemplate.Height = 24;
            this.bdHDNK.Size = new System.Drawing.Size(905, 520);
            this.bdHDNK.TabIndex = 293;
            this.bdHDNK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdHDNK_CellContentClick);
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
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hoạt Động";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            this.MaHD.Width = 125;
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
            // TenHD
            // 
            this.TenHD.DataPropertyName = "TenHD";
            this.TenHD.HeaderText = "Tên Hoạt Động";
            this.TenHD.MinimumWidth = 6;
            this.TenHD.Name = "TenHD";
            this.TenHD.ReadOnly = true;
            this.TenHD.Width = 125;
            // 
            // ThoiGianBD
            // 
            this.ThoiGianBD.DataPropertyName = "ThoiGianBD";
            this.ThoiGianBD.HeaderText = "Thời Gian Bắt Đầu";
            this.ThoiGianBD.MinimumWidth = 6;
            this.ThoiGianBD.Name = "ThoiGianBD";
            this.ThoiGianBD.ReadOnly = true;
            this.ThoiGianBD.Width = 150;
            // 
            // ThoiGianKT
            // 
            this.ThoiGianKT.DataPropertyName = "ThoiGianKT";
            this.ThoiGianKT.HeaderText = "Thời Gian Kết Thúc";
            this.ThoiGianKT.MinimumWidth = 6;
            this.ThoiGianKT.Name = "ThoiGianKT";
            this.ThoiGianKT.ReadOnly = true;
            this.ThoiGianKT.Width = 150;
            // 
            // DiaDiem
            // 
            this.DiaDiem.DataPropertyName = "DiaDiem";
            this.DiaDiem.HeaderText = "Địa Điểm";
            this.DiaDiem.MinimumWidth = 6;
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.ReadOnly = true;
            this.DiaDiem.Width = 125;
            // 
            // hoatDongNgoaiKhoaBindingSource
            // 
            this.hoatDongNgoaiKhoaBindingSource.DataMember = "HoatDongNgoaiKhoa";
            this.hoatDongNgoaiKhoaBindingSource.DataSource = this.kQHTDataSet4;
            // 
            // kQHTDataSet4
            // 
            this.kQHTDataSet4.DataSetName = "KQHTDataSet4";
            this.kQHTDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(1357, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 46);
            this.btnSearch.TabIndex = 291;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchHDNK
            // 
            this.txtSearchHDNK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchHDNK.Location = new System.Drawing.Point(1102, 95);
            this.txtSearchHDNK.Multiline = true;
            this.txtSearchHDNK.Name = "txtSearchHDNK";
            this.txtSearchHDNK.Size = new System.Drawing.Size(199, 34);
            this.txtSearchHDNK.TabIndex = 289;
            this.txtSearchHDNK.TextChanged += new System.EventHandler(this.txtSearchHDNK_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(712, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(343, 25);
            this.label11.TabIndex = 288;
            this.label11.Text = "Tìm Kiếm Hoạt Động Ngoại Khóa :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(479, 32);
            this.label10.TabIndex = 287;
            this.label10.Text = "BẢNG HOẠT ĐỘNG NGOẠI KHÓA";
            // 
            // txtTongHDNK
            // 
            this.txtTongHDNK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongHDNK.Location = new System.Drawing.Point(1415, 711);
            this.txtTongHDNK.Multiline = true;
            this.txtTongHDNK.Name = "txtTongHDNK";
            this.txtTongHDNK.ReadOnly = true;
            this.txtTongHDNK.Size = new System.Drawing.Size(106, 35);
            this.txtTongHDNK.TabIndex = 286;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(1046, 721);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(335, 25);
            this.label9.TabIndex = 285;
            this.label9.Text = "Tổng Số Hoạt Động Ngoại Khóa :";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.Location = new System.Drawing.Point(234, 711);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 61);
            this.btnEdit.TabIndex = 284;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(420, 711);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 61);
            this.btnDelete.TabIndex = 283;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaDiem.Location = new System.Drawing.Point(329, 634);
            this.txtDiaDiem.Multiline = true;
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(199, 38);
            this.txtDiaDiem.TabIndex = 282;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(66, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 25);
            this.label6.TabIndex = 281;
            this.label6.Text = "Thời Gian Bắt Đầu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(66, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 280;
            this.label3.Text = "Tên Hoạt Động :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(66, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 279;
            this.label4.Text = "Mã Sinh Viên :";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHD.Location = new System.Drawing.Point(329, 286);
            this.txtMaHD.Multiline = true;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(199, 34);
            this.txtMaHD.TabIndex = 278;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(66, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 277;
            this.label2.Text = "Mã Hoạt Động :";
            // 
            // txtSTT
            // 
            this.txtSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSTT.Location = new System.Drawing.Point(329, 218);
            this.txtSTT.Multiline = true;
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(199, 34);
            this.txtSTT.TabIndex = 275;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreate.Location = new System.Drawing.Point(71, 711);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 61);
            this.btnCreate.TabIndex = 274;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(66, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 273;
            this.label1.Text = "STT :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 76);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(560, 717);
            this.textBox2.TabIndex = 276;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(693, 76);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(794, 67);
            this.textBox3.TabIndex = 290;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(66, 580);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 25);
            this.label5.TabIndex = 295;
            this.label5.Text = "Thời Gian Kết Thúc :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(66, 644);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 296;
            this.label7.Text = "Địa Điểm :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(329, 505);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 30);
            this.dateTimePicker1.TabIndex = 297;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(329, 578);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(199, 30);
            this.dateTimePicker2.TabIndex = 298;
            // 
            // txtTenHD
            // 
            this.txtTenHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenHD.Location = new System.Drawing.Point(329, 432);
            this.txtTenHD.Multiline = true;
            this.txtTenHD.Name = "txtTenHD";
            this.txtTenHD.Size = new System.Drawing.Size(199, 34);
            this.txtTenHD.TabIndex = 299;
            // 
            // hoatDongNgoaiKhoaTableAdapter
            // 
            this.hoatDongNgoaiKhoaTableAdapter.ClearBeforeFill = true;
            // 
            // frmHoatDongNgoaiKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 823);
            this.Controls.Add(this.txtTenHD);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMaSV);
            this.Controls.Add(this.bdHDNK);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchHDNK);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTongHDNK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Name = "frmHoatDongNgoaiKhoa";
            this.Text = "frmHoatDongNgoaiKhoa";
            this.Load += new System.EventHandler(this.frmHoatDongNgoaiKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdHDNK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongNgoaiKhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMaSV;
        private System.Windows.Forms.DataGridView bdHDNK;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchHDNK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongHDNK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtTenHD;
        private KQHTDataSet4 kQHTDataSet4;
        private System.Windows.Forms.BindingSource hoatDongNgoaiKhoaBindingSource;
        private KQHTDataSet4TableAdapters.HoatDongNgoaiKhoaTableAdapter hoatDongNgoaiKhoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
    }
}