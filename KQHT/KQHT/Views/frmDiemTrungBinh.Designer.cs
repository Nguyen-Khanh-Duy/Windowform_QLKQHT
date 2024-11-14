namespace KQHT.Views
{
    partial class frmDiemTrungBinh
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
            this.bdDiemTrungBinh = new System.Windows.Forms.DataGridView();
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchDTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongDTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaDTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.kQHTDataSet3 = new KQHT.KQHTDataSet3();
            this.diemTrungBinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diemTrungBinhTableAdapter = new KQHT.KQHTDataSet3TableAdapters.DiemTrungBinhTableAdapter();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdDiemTrungBinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemTrungBinhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bdDiemTrungBinh
            // 
            this.bdDiemTrungBinh.AllowUserToAddRows = false;
            this.bdDiemTrungBinh.AllowUserToDeleteRows = false;
            this.bdDiemTrungBinh.AutoGenerateColumns = false;
            this.bdDiemTrungBinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdDiemTrungBinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaDTB,
            this.MaSV,
            this.MaMH,
            this.DiemTB});
            this.bdDiemTrungBinh.DataSource = this.diemTrungBinhBindingSource;
            this.bdDiemTrungBinh.Location = new System.Drawing.Point(587, 139);
            this.bdDiemTrungBinh.Name = "bdDiemTrungBinh";
            this.bdDiemTrungBinh.ReadOnly = true;
            this.bdDiemTrungBinh.RowHeadersWidth = 51;
            this.bdDiemTrungBinh.RowTemplate.Height = 24;
            this.bdDiemTrungBinh.Size = new System.Drawing.Size(939, 520);
            this.bdDiemTrungBinh.TabIndex = 271;
            this.bdDiemTrungBinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdDiemTrungBinh_CellContentClick);
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(324, 408);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(199, 33);
            this.cmbMaMH.TabIndex = 270;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(1301, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 46);
            this.btnSearch.TabIndex = 267;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchDTB
            // 
            this.txtSearchDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchDTB.Location = new System.Drawing.Point(1047, 71);
            this.txtSearchDTB.Multiline = true;
            this.txtSearchDTB.Name = "txtSearchDTB";
            this.txtSearchDTB.Size = new System.Drawing.Size(199, 34);
            this.txtSearchDTB.TabIndex = 265;
            this.txtSearchDTB.TextChanged += new System.EventHandler(this.txtSearchDTB_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(717, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(283, 25);
            this.label11.TabIndex = 264;
            this.label11.Text = "Tìm Kiếm Điểm Trung Bình :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(111, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(369, 32);
            this.label10.TabIndex = 263;
            this.label10.Text = "BẢNG ĐIỂM TRUNG BÌNH";
            // 
            // txtTongDTB
            // 
            this.txtTongDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongDTB.Location = new System.Drawing.Point(1420, 687);
            this.txtTongDTB.Multiline = true;
            this.txtTongDTB.Name = "txtTongDTB";
            this.txtTongDTB.ReadOnly = true;
            this.txtTongDTB.Size = new System.Drawing.Size(106, 35);
            this.txtTongDTB.TabIndex = 262;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(1106, 697);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 25);
            this.label9.TabIndex = 261;
            this.label9.Text = "Tổng Số Điểm Trung Bình :";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.Location = new System.Drawing.Point(232, 576);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 61);
            this.btnEdit.TabIndex = 260;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(413, 576);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 61);
            this.btnDelete.TabIndex = 259;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiemTB.Location = new System.Drawing.Point(324, 487);
            this.txtDiemTB.Multiline = true;
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(199, 38);
            this.txtDiemTB.TabIndex = 257;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(71, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 25);
            this.label6.TabIndex = 256;
            this.label6.Text = "Điểm Trung Bình :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(71, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 254;
            this.label3.Text = "Mã Môn Học :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(71, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 252;
            this.label4.Text = "Mã Sinh Viên :";
            // 
            // txtMaDTB
            // 
            this.txtMaDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDTB.Location = new System.Drawing.Point(324, 259);
            this.txtMaDTB.Multiline = true;
            this.txtMaDTB.Name = "txtMaDTB";
            this.txtMaDTB.Size = new System.Drawing.Size(199, 34);
            this.txtMaDTB.TabIndex = 251;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(71, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 250;
            this.label2.Text = "Mã Điểm Trung Bình :";
            // 
            // txtSTT
            // 
            this.txtSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSTT.Location = new System.Drawing.Point(324, 191);
            this.txtSTT.Multiline = true;
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(199, 34);
            this.txtSTT.TabIndex = 248;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreate.Location = new System.Drawing.Point(66, 576);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 61);
            this.btnCreate.TabIndex = 247;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(71, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 246;
            this.label1.Text = "STT :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 52);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(532, 652);
            this.textBox2.TabIndex = 249;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(698, 52);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(743, 67);
            this.textBox3.TabIndex = 266;
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(324, 333);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(199, 33);
            this.cmbMaSV.TabIndex = 272;
            // 
            // kQHTDataSet3
            // 
            this.kQHTDataSet3.DataSetName = "KQHTDataSet3";
            this.kQHTDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diemTrungBinhBindingSource
            // 
            this.diemTrungBinhBindingSource.DataMember = "DiemTrungBinh";
            this.diemTrungBinhBindingSource.DataSource = this.kQHTDataSet3;
            // 
            // diemTrungBinhTableAdapter
            // 
            this.diemTrungBinhTableAdapter.ClearBeforeFill = true;
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
            // MaDTB
            // 
            this.MaDTB.DataPropertyName = "MaDTB";
            this.MaDTB.HeaderText = "Mã Điểm Trung Bình";
            this.MaDTB.MinimumWidth = 6;
            this.MaDTB.Name = "MaDTB";
            this.MaDTB.ReadOnly = true;
            this.MaDTB.Width = 170;
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
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã Môn Học";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            this.MaMH.ReadOnly = true;
            this.MaMH.Width = 125;
            // 
            // DiemTB
            // 
            this.DiemTB.DataPropertyName = "DiemTB";
            this.DiemTB.HeaderText = "Điểm Trung Bình";
            this.DiemTB.MinimumWidth = 6;
            this.DiemTB.Name = "DiemTB";
            this.DiemTB.ReadOnly = true;
            this.DiemTB.Width = 150;
            // 
            // frmDiemTrungBinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 792);
            this.Controls.Add(this.cmbMaSV);
            this.Controls.Add(this.bdDiemTrungBinh);
            this.Controls.Add(this.cmbMaMH);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchDTB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTongDTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDiemTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaDTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Name = "frmDiemTrungBinh";
            this.Text = "frmDiemTrungBinh";
            this.Load += new System.EventHandler(this.frmDiemTrungBinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdDiemTrungBinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemTrungBinhBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bdDiemTrungBinh;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchDTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongDTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaDTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private KQHTDataSet3 kQHTDataSet3;
        private System.Windows.Forms.BindingSource diemTrungBinhBindingSource;
        private KQHTDataSet3TableAdapters.DiemTrungBinhTableAdapter diemTrungBinhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
    }
}