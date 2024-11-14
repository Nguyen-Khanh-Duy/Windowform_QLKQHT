namespace KQHT.Views
{
    partial class frmDiemRenLuyen
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
            this.cmbMaHD = new System.Windows.Forms.ComboBox();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.bdDRL = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaRL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemRL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemRenLuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kQHTDataSet6 = new KQHT.KQHTDataSet6();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchDRL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongDRL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaRL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtDiemRL = new System.Windows.Forms.TextBox();
            this.diemRenLuyenTableAdapter = new KQHT.KQHTDataSet6TableAdapters.DiemRenLuyenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdDRL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemRenLuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMaHD
            // 
            this.cmbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaHD.FormattingEnabled = true;
            this.cmbMaHD.Location = new System.Drawing.Point(311, 421);
            this.cmbMaHD.Name = "cmbMaHD";
            this.cmbMaHD.Size = new System.Drawing.Size(199, 33);
            this.cmbMaHD.TabIndex = 376;
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(311, 346);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(199, 33);
            this.cmbMaSV.TabIndex = 373;
            // 
            // bdDRL
            // 
            this.bdDRL.AllowUserToAddRows = false;
            this.bdDRL.AllowUserToDeleteRows = false;
            this.bdDRL.AutoGenerateColumns = false;
            this.bdDRL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdDRL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaRL,
            this.MaSV,
            this.MaHD,
            this.DiemRL});
            this.bdDRL.DataSource = this.diemRenLuyenBindingSource;
            this.bdDRL.Location = new System.Drawing.Point(565, 150);
            this.bdDRL.Name = "bdDRL";
            this.bdDRL.ReadOnly = true;
            this.bdDRL.RowHeadersWidth = 51;
            this.bdDRL.RowTemplate.Height = 24;
            this.bdDRL.Size = new System.Drawing.Size(939, 520);
            this.bdDRL.TabIndex = 372;
            this.bdDRL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdDRL_CellContentClick);
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
            // MaRL
            // 
            this.MaRL.DataPropertyName = "MaRL";
            this.MaRL.HeaderText = "Mã Rèn Luyện";
            this.MaRL.MinimumWidth = 6;
            this.MaRL.Name = "MaRL";
            this.MaRL.ReadOnly = true;
            this.MaRL.Width = 125;
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
            // DiemRL
            // 
            this.DiemRL.DataPropertyName = "DiemRL";
            this.DiemRL.HeaderText = "Điểm Rèn Luyện";
            this.DiemRL.MinimumWidth = 6;
            this.DiemRL.Name = "DiemRL";
            this.DiemRL.ReadOnly = true;
            this.DiemRL.Width = 140;
            // 
            // diemRenLuyenBindingSource
            // 
            this.diemRenLuyenBindingSource.DataMember = "DiemRenLuyen";
            this.diemRenLuyenBindingSource.DataSource = this.kQHTDataSet6;
            // 
            // kQHTDataSet6
            // 
            this.kQHTDataSet6.DataSetName = "KQHTDataSet6";
            this.kQHTDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(1235, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 46);
            this.btnSearch.TabIndex = 371;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchDRL
            // 
            this.txtSearchDRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchDRL.Location = new System.Drawing.Point(940, 88);
            this.txtSearchDRL.Multiline = true;
            this.txtSearchDRL.Name = "txtSearchDRL";
            this.txtSearchDRL.Size = new System.Drawing.Size(230, 34);
            this.txtSearchDRL.TabIndex = 369;
            this.txtSearchDRL.TextChanged += new System.EventHandler(this.txtSearchDRL_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(770, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 25);
            this.label11.TabIndex = 368;
            this.label11.Text = "Tìm Kiếm :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(91, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(364, 32);
            this.label10.TabIndex = 367;
            this.label10.Text = "BẢNG ĐIỂM RÈN LUYỆN ";
            // 
            // txtTongDRL
            // 
            this.txtTongDRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongDRL.Location = new System.Drawing.Point(1398, 698);
            this.txtTongDRL.Multiline = true;
            this.txtTongDRL.Name = "txtTongDRL";
            this.txtTongDRL.ReadOnly = true;
            this.txtTongDRL.Size = new System.Drawing.Size(106, 35);
            this.txtTongDRL.TabIndex = 366;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(1174, 701);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 25);
            this.label9.TabIndex = 365;
            this.label9.Text = "Tổng Danh Sách :";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.Location = new System.Drawing.Point(203, 609);
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
            this.btnDelete.Location = new System.Drawing.Point(392, 609);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 61);
            this.btnDelete.TabIndex = 363;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(58, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 25);
            this.label6.TabIndex = 362;
            this.label6.Text = "Điểm Rèn Luyện :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(58, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 361;
            this.label3.Text = "Mã Hoạt Động :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(58, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 360;
            this.label4.Text = "Mã Sinh Viên :";
            // 
            // txtMaRL
            // 
            this.txtMaRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaRL.Location = new System.Drawing.Point(311, 272);
            this.txtMaRL.Multiline = true;
            this.txtMaRL.Name = "txtMaRL";
            this.txtMaRL.Size = new System.Drawing.Size(199, 34);
            this.txtMaRL.TabIndex = 359;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(58, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 358;
            this.label2.Text = "Mã Rèn Luyện:";
            // 
            // txtSTT
            // 
            this.txtSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSTT.Location = new System.Drawing.Point(311, 204);
            this.txtSTT.Multiline = true;
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(199, 34);
            this.txtSTT.TabIndex = 356;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreate.Location = new System.Drawing.Point(37, 609);
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
            this.label1.Location = new System.Drawing.Point(58, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 354;
            this.label1.Text = "STT :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 63);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(532, 660);
            this.textBox2.TabIndex = 357;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(751, 65);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(611, 67);
            this.textBox3.TabIndex = 370;
            // 
            // txtDiemRL
            // 
            this.txtDiemRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiemRL.Location = new System.Drawing.Point(311, 493);
            this.txtDiemRL.Multiline = true;
            this.txtDiemRL.Name = "txtDiemRL";
            this.txtDiemRL.Size = new System.Drawing.Size(199, 34);
            this.txtDiemRL.TabIndex = 377;
            // 
            // diemRenLuyenTableAdapter
            // 
            this.diemRenLuyenTableAdapter.ClearBeforeFill = true;
            // 
            // frmDiemRenLuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 794);
            this.Controls.Add(this.txtDiemRL);
            this.Controls.Add(this.cmbMaHD);
            this.Controls.Add(this.cmbMaSV);
            this.Controls.Add(this.bdDRL);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchDRL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTongDRL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaRL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Name = "frmDiemRenLuyen";
            this.Text = "frmDiemRenLuyen";
            this.Load += new System.EventHandler(this.frmDiemRenLuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdDRL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemRenLuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMaHD;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private System.Windows.Forms.DataGridView bdDRL;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchDRL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongDRL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaRL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtDiemRL;
        private KQHTDataSet6 kQHTDataSet6;
        private System.Windows.Forms.BindingSource diemRenLuyenBindingSource;
        private KQHTDataSet6TableAdapters.DiemRenLuyenTableAdapter diemRenLuyenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaRL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemRL;
    }
}