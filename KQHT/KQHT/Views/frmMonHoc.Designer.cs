namespace KQHT.Views
{
    partial class frmMonHoc
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchMH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongMH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kQHTDataSet2 = new KQHT.KQHTDataSet2();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.monHocTableAdapter = new KQHT.KQHTDataSet2TableAdapters.MonHocTableAdapter();
            this.cmbGiangVienPhuTrach = new System.Windows.Forms.ComboBox();
            this.bdMonHoc = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiangVienPhuTrach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monHocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kQHTDataSet21 = new KQHT.KQHTDataSet2();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet21)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(1218, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 46);
            this.btnSearch.TabIndex = 241;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchMH
            // 
            this.txtSearchMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchMH.Location = new System.Drawing.Point(969, 69);
            this.txtSearchMH.Multiline = true;
            this.txtSearchMH.Name = "txtSearchMH";
            this.txtSearchMH.Size = new System.Drawing.Size(199, 34);
            this.txtSearchMH.TabIndex = 239;
            this.txtSearchMH.TextChanged += new System.EventHandler(this.txtSearchMH_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(718, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 25);
            this.label11.TabIndex = 238;
            this.label11.Text = "Tìm Kiếm Môn Học :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(128, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 32);
            this.label10.TabIndex = 237;
            this.label10.Text = "BẢNG MÔN HỌC";
            // 
            // txtTongMH
            // 
            this.txtTongMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongMH.Location = new System.Drawing.Point(1407, 687);
            this.txtTongMH.Multiline = true;
            this.txtTongMH.Name = "txtTongMH";
            this.txtTongMH.ReadOnly = true;
            this.txtTongMH.Size = new System.Drawing.Size(106, 35);
            this.txtTongMH.TabIndex = 236;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(1171, 697);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 25);
            this.label9.TabIndex = 235;
            this.label9.Text = "Tổng Số Môn Học :";
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.kQHTDataSet2;
            // 
            // kQHTDataSet2
            // 
            this.kQHTDataSet2.DataSetName = "KQHTDataSet2";
            this.kQHTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.Location = new System.Drawing.Point(230, 661);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 61);
            this.btnEdit.TabIndex = 233;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(411, 661);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 61);
            this.btnDelete.TabIndex = 232;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(67, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 25);
            this.label5.TabIndex = 230;
            this.label5.Text = "Giảng Viên Phụ Trách :";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMoTa.Location = new System.Drawing.Point(320, 435);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(199, 62);
            this.txtMoTa.TabIndex = 229;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(67, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 228;
            this.label6.Text = "Mô Tả :";
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoTinChi.Location = new System.Drawing.Point(320, 372);
            this.txtSoTinChi.Multiline = true;
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(199, 34);
            this.txtSoTinChi.TabIndex = 227;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(67, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 226;
            this.label3.Text = "Số Tín Chỉ :";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenMH.Location = new System.Drawing.Point(320, 301);
            this.txtTenMH.Multiline = true;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(199, 34);
            this.txtTenMH.TabIndex = 225;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(67, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 224;
            this.label4.Text = "Tên Môn Học :";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaMH.Location = new System.Drawing.Point(320, 232);
            this.txtMaMH.Multiline = true;
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(199, 34);
            this.txtMaMH.TabIndex = 223;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(67, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 222;
            this.label2.Text = "Mã Môn Học :";
            // 
            // txtSTT
            // 
            this.txtSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSTT.Location = new System.Drawing.Point(320, 170);
            this.txtSTT.Multiline = true;
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(199, 34);
            this.txtSTT.TabIndex = 220;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreate.Location = new System.Drawing.Point(64, 661);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 61);
            this.btnCreate.TabIndex = 219;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(67, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 218;
            this.label1.Text = "STT :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 52);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(532, 688);
            this.textBox2.TabIndex = 221;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(699, 52);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(658, 67);
            this.textBox3.TabIndex = 240;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaGV.Location = new System.Drawing.Point(320, 595);
            this.txtMaGV.Multiline = true;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(199, 34);
            this.txtMaGV.TabIndex = 243;
            this.txtMaGV.TextChanged += new System.EventHandler(this.txtMaGV_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(67, 591);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 25);
            this.label7.TabIndex = 242;
            this.label7.Text = "Mã Giảng Viên :";
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // cmbGiangVienPhuTrach
            // 
            this.cmbGiangVienPhuTrach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbGiangVienPhuTrach.FormattingEnabled = true;
            this.cmbGiangVienPhuTrach.Location = new System.Drawing.Point(320, 533);
            this.cmbGiangVienPhuTrach.Name = "cmbGiangVienPhuTrach";
            this.cmbGiangVienPhuTrach.Size = new System.Drawing.Size(199, 33);
            this.cmbGiangVienPhuTrach.TabIndex = 244;
            this.cmbGiangVienPhuTrach.SelectedIndexChanged += new System.EventHandler(this.cmbGiangVienPhuTrach_SelectedIndexChanged);
            // 
            // bdMonHoc
            // 
            this.bdMonHoc.AllowUserToAddRows = false;
            this.bdMonHoc.AllowUserToDeleteRows = false;
            this.bdMonHoc.AutoGenerateColumns = false;
            this.bdMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaMH,
            this.TenMH,
            this.SoTinChi,
            this.MoTa,
            this.GiangVienPhuTrach,
            this.MaGV});
            this.bdMonHoc.DataSource = this.monHocBindingSource1;
            this.bdMonHoc.Location = new System.Drawing.Point(588, 139);
            this.bdMonHoc.Name = "bdMonHoc";
            this.bdMonHoc.ReadOnly = true;
            this.bdMonHoc.RowHeadersWidth = 51;
            this.bdMonHoc.RowTemplate.Height = 24;
            this.bdMonHoc.Size = new System.Drawing.Size(939, 520);
            this.bdMonHoc.TabIndex = 245;
            this.bdMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdMonHoc_CellContentClick);
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
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã Môn Học";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            this.MaMH.ReadOnly = true;
            this.MaMH.Width = 125;
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên Môn Học";
            this.TenMH.MinimumWidth = 6;
            this.TenMH.Name = "TenMH";
            this.TenMH.ReadOnly = true;
            this.TenMH.Width = 125;
            // 
            // SoTinChi
            // 
            this.SoTinChi.DataPropertyName = "SoTinChi";
            this.SoTinChi.HeaderText = "Số Tín Chỉ";
            this.SoTinChi.MinimumWidth = 6;
            this.SoTinChi.Name = "SoTinChi";
            this.SoTinChi.ReadOnly = true;
            this.SoTinChi.Width = 125;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 125;
            // 
            // GiangVienPhuTrach
            // 
            this.GiangVienPhuTrach.DataPropertyName = "GiangVienPhuTrach";
            this.GiangVienPhuTrach.HeaderText = "Giảng Viên Phụ Trách";
            this.GiangVienPhuTrach.MinimumWidth = 6;
            this.GiangVienPhuTrach.Name = "GiangVienPhuTrach";
            this.GiangVienPhuTrach.ReadOnly = true;
            this.GiangVienPhuTrach.Width = 170;
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã Giảng Viên";
            this.MaGV.MinimumWidth = 6;
            this.MaGV.Name = "MaGV";
            this.MaGV.ReadOnly = true;
            this.MaGV.Width = 125;
            // 
            // monHocBindingSource1
            // 
            this.monHocBindingSource1.DataMember = "MonHoc";
            this.monHocBindingSource1.DataSource = this.kQHTDataSet21;
            // 
            // kQHTDataSet21
            // 
            this.kQHTDataSet21.DataSetName = "KQHTDataSet2";
            this.kQHTDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 775);
            this.Controls.Add(this.bdMonHoc);
            this.Controls.Add(this.cmbGiangVienPhuTrach);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchMH);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTongMH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoTinChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Name = "frmMonHoc";
            this.Text = "frmMonHoc";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchMH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongMH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label7;
        private KQHTDataSet2 kQHTDataSet2;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private KQHTDataSet2TableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.ComboBox cmbGiangVienPhuTrach;
        private System.Windows.Forms.DataGridView bdMonHoc;
        private KQHTDataSet2 kQHTDataSet21;
        private System.Windows.Forms.BindingSource monHocBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiangVienPhuTrach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
    }
}