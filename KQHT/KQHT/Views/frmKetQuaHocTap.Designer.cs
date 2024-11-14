namespace KQHT.Views
{
    partial class frmKetQuaHocTap
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
            this.cmbMaDTB = new System.Windows.Forms.ComboBox();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.bdKQHT = new System.Windows.Forms.DataGridView();
            this.ketQuaHocTapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kQHTDataSet7 = new KQHT.KQHTDataSet7();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchKQHT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongKQHT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiemTBM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiemRL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMaRL = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtXepLoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ketQuaHocTapTableAdapter = new KQHT.KQHTDataSet7TableAdapters.KetQuaHocTapTableAdapter();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaRL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemRL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XepLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdKQHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaHocTapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMaDTB
            // 
            this.cmbMaDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaDTB.FormattingEnabled = true;
            this.cmbMaDTB.Location = new System.Drawing.Point(323, 384);
            this.cmbMaDTB.Name = "cmbMaDTB";
            this.cmbMaDTB.Size = new System.Drawing.Size(199, 33);
            this.cmbMaDTB.TabIndex = 376;
            this.cmbMaDTB.SelectedIndexChanged += new System.EventHandler(this.cmbMaDTB_SelectedIndexChanged);
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(323, 247);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(199, 33);
            this.cmbMaSV.TabIndex = 373;
            this.cmbMaSV.SelectedIndexChanged += new System.EventHandler(this.cmbMaSV_SelectedIndexChanged);
            // 
            // bdKQHT
            // 
            this.bdKQHT.AllowUserToAddRows = false;
            this.bdKQHT.AllowUserToDeleteRows = false;
            this.bdKQHT.AutoGenerateColumns = false;
            this.bdKQHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdKQHT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaKQ,
            this.MaSV,
            this.TenSV,
            this.MaDTB,
            this.DiemTBM,
            this.MaRL,
            this.DiemRL,
            this.XepLoai});
            this.bdKQHT.DataSource = this.ketQuaHocTapBindingSource;
            this.bdKQHT.Location = new System.Drawing.Point(582, 112);
            this.bdKQHT.Name = "bdKQHT";
            this.bdKQHT.ReadOnly = true;
            this.bdKQHT.RowHeadersWidth = 51;
            this.bdKQHT.RowTemplate.Height = 24;
            this.bdKQHT.Size = new System.Drawing.Size(939, 602);
            this.bdKQHT.TabIndex = 372;
            this.bdKQHT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdKQHT_CellContentClick);
            // 
            // ketQuaHocTapBindingSource
            // 
            this.ketQuaHocTapBindingSource.DataMember = "KetQuaHocTap";
            this.ketQuaHocTapBindingSource.DataSource = this.kQHTDataSet7;
            // 
            // kQHTDataSet7
            // 
            this.kQHTDataSet7.DataSetName = "KQHTDataSet7";
            this.kQHTDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(1378, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 46);
            this.btnSearch.TabIndex = 371;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchKQHT
            // 
            this.txtSearchKQHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchKQHT.Location = new System.Drawing.Point(1149, 46);
            this.txtSearchKQHT.Multiline = true;
            this.txtSearchKQHT.Name = "txtSearchKQHT";
            this.txtSearchKQHT.Size = new System.Drawing.Size(199, 34);
            this.txtSearchKQHT.TabIndex = 369;
            this.txtSearchKQHT.TextChanged += new System.EventHandler(this.txtSearchKQHT_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(656, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(436, 25);
            this.label11.TabIndex = 368;
            this.label11.Text = "Tìm Kiếm Kết Quả Học Tập Của Sinh Viên :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(157, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(283, 32);
            this.label10.TabIndex = 367;
            this.label10.Text = "KẾT QUẢ HỌC TẬP";
            // 
            // txtTongKQHT
            // 
            this.txtTongKQHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongKQHT.Location = new System.Drawing.Point(1415, 742);
            this.txtTongKQHT.Multiline = true;
            this.txtTongKQHT.Name = "txtTongKQHT";
            this.txtTongKQHT.ReadOnly = true;
            this.txtTongKQHT.Size = new System.Drawing.Size(106, 35);
            this.txtTongKQHT.TabIndex = 366;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(1001, 745);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(395, 25);
            this.label9.TabIndex = 365;
            this.label9.Text = "Tổng Kết Quả Học Tập Của Sinh Viên :";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.Location = new System.Drawing.Point(230, 727);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 61);
            this.btnEdit.TabIndex = 364;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(419, 727);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 61);
            this.btnDelete.TabIndex = 363;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(70, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 25);
            this.label3.TabIndex = 361;
            this.label3.Text = "Mã Điểm Trung Bình :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(70, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 360;
            this.label4.Text = "Mã Sinh Viên :";
            // 
            // txtMaKQ
            // 
            this.txtMaKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaKQ.Location = new System.Drawing.Point(323, 176);
            this.txtMaKQ.Multiline = true;
            this.txtMaKQ.Name = "txtMaKQ";
            this.txtMaKQ.Size = new System.Drawing.Size(199, 34);
            this.txtMaKQ.TabIndex = 359;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(70, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 358;
            this.label2.Text = "Mã Kết Quả :";
            // 
            // txtSTT
            // 
            this.txtSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSTT.Location = new System.Drawing.Point(323, 112);
            this.txtSTT.Multiline = true;
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(199, 34);
            this.txtSTT.TabIndex = 356;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreate.Location = new System.Drawing.Point(64, 727);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 61);
            this.btnCreate.TabIndex = 355;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(70, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 354;
            this.label1.Text = "STT :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 24);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(532, 777);
            this.textBox2.TabIndex = 357;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(630, 24);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(877, 67);
            this.textBox3.TabIndex = 370;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSV.Location = new System.Drawing.Point(323, 317);
            this.txtTenSV.Multiline = true;
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(199, 34);
            this.txtTenSV.TabIndex = 378;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(70, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 377;
            this.label5.Text = "Tên Sinh Viên :";
            // 
            // txtDiemTBM
            // 
            this.txtDiemTBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiemTBM.Location = new System.Drawing.Point(323, 452);
            this.txtDiemTBM.Multiline = true;
            this.txtDiemTBM.Name = "txtDiemTBM";
            this.txtDiemTBM.Size = new System.Drawing.Size(199, 34);
            this.txtDiemTBM.TabIndex = 380;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(70, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 25);
            this.label7.TabIndex = 379;
            this.label7.Text = "Điếm Trung Bình Môn :";
            // 
            // txtDiemRL
            // 
            this.txtDiemRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiemRL.Location = new System.Drawing.Point(323, 592);
            this.txtDiemRL.Multiline = true;
            this.txtDiemRL.Name = "txtDiemRL";
            this.txtDiemRL.Size = new System.Drawing.Size(199, 34);
            this.txtDiemRL.TabIndex = 384;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(70, 588);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 25);
            this.label8.TabIndex = 383;
            this.label8.Text = "Điểm Rèn Luyện:";
            // 
            // cmbMaRL
            // 
            this.cmbMaRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaRL.FormattingEnabled = true;
            this.cmbMaRL.Location = new System.Drawing.Point(323, 525);
            this.cmbMaRL.Name = "cmbMaRL";
            this.cmbMaRL.Size = new System.Drawing.Size(199, 33);
            this.cmbMaRL.TabIndex = 382;
            this.cmbMaRL.SelectedIndexChanged += new System.EventHandler(this.cmbMaRL_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(70, 525);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 25);
            this.label12.TabIndex = 381;
            this.label12.Text = "Mã Rèn Luyện :";
            // 
            // txtXepLoai
            // 
            this.txtXepLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtXepLoai.Location = new System.Drawing.Point(323, 662);
            this.txtXepLoai.Multiline = true;
            this.txtXepLoai.Name = "txtXepLoai";
            this.txtXepLoai.Size = new System.Drawing.Size(199, 34);
            this.txtXepLoai.TabIndex = 386;
            this.txtXepLoai.TextChanged += new System.EventHandler(this.txtXepLoai_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(70, 658);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 385;
            this.label6.Text = "Xếp Loại :";
            // 
            // ketQuaHocTapTableAdapter
            // 
            this.ketQuaHocTapTableAdapter.ClearBeforeFill = true;
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
            // MaKQ
            // 
            this.MaKQ.DataPropertyName = "MaKQ";
            this.MaKQ.HeaderText = "Mã Kết Quả";
            this.MaKQ.MinimumWidth = 6;
            this.MaKQ.Name = "MaKQ";
            this.MaKQ.ReadOnly = true;
            this.MaKQ.Width = 125;
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
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "Tên Sinh Viên";
            this.TenSV.MinimumWidth = 6;
            this.TenSV.Name = "TenSV";
            this.TenSV.ReadOnly = true;
            this.TenSV.Width = 125;
            // 
            // MaDTB
            // 
            this.MaDTB.DataPropertyName = "MaDTB";
            this.MaDTB.HeaderText = "Mã Điểm Trung Bình";
            this.MaDTB.MinimumWidth = 6;
            this.MaDTB.Name = "MaDTB";
            this.MaDTB.ReadOnly = true;
            this.MaDTB.Width = 160;
            // 
            // DiemTBM
            // 
            this.DiemTBM.DataPropertyName = "DiemTBM";
            this.DiemTBM.HeaderText = "Điểm Trung Bình Môn";
            this.DiemTBM.MinimumWidth = 6;
            this.DiemTBM.Name = "DiemTBM";
            this.DiemTBM.ReadOnly = true;
            this.DiemTBM.Width = 165;
            // 
            // MaRL
            // 
            this.MaRL.DataPropertyName = "MaRL";
            this.MaRL.HeaderText = "Mã Rèn Luyện";
            this.MaRL.MinimumWidth = 6;
            this.MaRL.Name = "MaRL";
            this.MaRL.ReadOnly = true;
            this.MaRL.Width = 125;
            // 
            // DiemRL
            // 
            this.DiemRL.DataPropertyName = "DiemRL";
            this.DiemRL.HeaderText = "Điểm Rèn Luyện";
            this.DiemRL.MinimumWidth = 6;
            this.DiemRL.Name = "DiemRL";
            this.DiemRL.ReadOnly = true;
            this.DiemRL.Width = 125;
            // 
            // XepLoai
            // 
            this.XepLoai.DataPropertyName = "XepLoai";
            this.XepLoai.HeaderText = "Xếp Loại";
            this.XepLoai.MinimumWidth = 6;
            this.XepLoai.Name = "XepLoai";
            this.XepLoai.ReadOnly = true;
            this.XepLoai.Width = 125;
            // 
            // frmKetQuaHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 824);
            this.Controls.Add(this.txtXepLoai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiemRL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbMaRL);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDiemTBM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMaDTB);
            this.Controls.Add(this.cmbMaSV);
            this.Controls.Add(this.bdKQHT);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchKQHT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTongKQHT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Name = "frmKetQuaHocTap";
            this.Text = "frmKetQuaHocTap";
            this.Load += new System.EventHandler(this.frmKetQuaHocTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdKQHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaHocTapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMaDTB;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private System.Windows.Forms.DataGridView bdKQHT;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchKQHT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongKQHT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiemTBM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiemRL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMaRL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtXepLoai;
        private System.Windows.Forms.Label label6;
        private KQHTDataSet7 kQHTDataSet7;
        private System.Windows.Forms.BindingSource ketQuaHocTapBindingSource;
        private KQHTDataSet7TableAdapters.KetQuaHocTapTableAdapter ketQuaHocTapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaRL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemRL;
        private System.Windows.Forms.DataGridViewTextBoxColumn XepLoai;
    }
}