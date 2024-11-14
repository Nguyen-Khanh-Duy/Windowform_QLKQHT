namespace KQHT.Views
{
    partial class frmGiangVien
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
            this.txtSearchGV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongGV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bdGiangVien = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtChuyenMon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kQHTDataSet = new KQHT.KQHTDataSet();
            this.kQHTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kQHTDataSet1 = new KQHT.KQHTDataSet1();
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giangVienTableAdapter = new KQHT.KQHTDataSet1TableAdapters.GiangVienTableAdapter();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(1204, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 46);
            this.btnSearch.TabIndex = 217;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchGV
            // 
            this.txtSearchGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchGV.Location = new System.Drawing.Point(955, 74);
            this.txtSearchGV.Multiline = true;
            this.txtSearchGV.Name = "txtSearchGV";
            this.txtSearchGV.Size = new System.Drawing.Size(199, 34);
            this.txtSearchGV.TabIndex = 215;
            this.txtSearchGV.TextChanged += new System.EventHandler(this.txtSearchGV_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(704, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 25);
            this.label11.TabIndex = 214;
            this.label11.Text = "Tìm Kiếm Giảng Viên :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(114, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(278, 32);
            this.label10.TabIndex = 213;
            this.label10.Text = "BẢNG GIẢNG VIÊN";
            // 
            // txtTongGV
            // 
            this.txtTongGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongGV.Location = new System.Drawing.Point(1393, 692);
            this.txtTongGV.Multiline = true;
            this.txtTongGV.Name = "txtTongGV";
            this.txtTongGV.ReadOnly = true;
            this.txtTongGV.Size = new System.Drawing.Size(106, 35);
            this.txtTongGV.TabIndex = 212;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(1157, 702);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 25);
            this.label9.TabIndex = 211;
            this.label9.Text = "Tổng Số Giảng Viên :";
            // 
            // bdGiangVien
            // 
            this.bdGiangVien.AllowUserToAddRows = false;
            this.bdGiangVien.AllowUserToDeleteRows = false;
            this.bdGiangVien.AutoGenerateColumns = false;
            this.bdGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaGV,
            this.TenGV,
            this.Email,
            this.SDT,
            this.ChuyenMon});
            this.bdGiangVien.DataSource = this.giangVienBindingSource;
            this.bdGiangVien.Location = new System.Drawing.Point(544, 142);
            this.bdGiangVien.Name = "bdGiangVien";
            this.bdGiangVien.ReadOnly = true;
            this.bdGiangVien.RowHeadersWidth = 51;
            this.bdGiangVien.RowTemplate.Height = 24;
            this.bdGiangVien.Size = new System.Drawing.Size(955, 520);
            this.bdGiangVien.TabIndex = 209;
            this.bdGiangVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdGiangVien_CellContentClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.Location = new System.Drawing.Point(214, 611);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 51);
            this.btnEdit.TabIndex = 208;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(367, 611);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 51);
            this.btnDelete.TabIndex = 207;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtChuyenMon
            // 
            this.txtChuyenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChuyenMon.Location = new System.Drawing.Point(281, 516);
            this.txtChuyenMon.Multiline = true;
            this.txtChuyenMon.Name = "txtChuyenMon";
            this.txtChuyenMon.Size = new System.Drawing.Size(199, 34);
            this.txtChuyenMon.TabIndex = 202;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(53, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 201;
            this.label5.Text = "Chuyên Môn :";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.Location = new System.Drawing.Point(281, 447);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(199, 34);
            this.txtSDT.TabIndex = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(53, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 199;
            this.label6.Text = "Số Điện Thoại :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.Location = new System.Drawing.Point(281, 384);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 34);
            this.txtEmail.TabIndex = 198;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenGV.Location = new System.Drawing.Point(281, 313);
            this.txtTenGV.Multiline = true;
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(199, 34);
            this.txtTenGV.TabIndex = 196;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(53, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 195;
            this.label4.Text = "Tên Giảng Viên :";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaGV.Location = new System.Drawing.Point(281, 244);
            this.txtMaGV.Multiline = true;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(199, 34);
            this.txtMaGV.TabIndex = 194;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(53, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 193;
            this.label2.Text = "Mã Giảng Viên :";
            // 
            // txtSTT
            // 
            this.txtSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSTT.Location = new System.Drawing.Point(281, 182);
            this.txtSTT.Multiline = true;
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(199, 34);
            this.txtSTT.TabIndex = 191;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreate.Location = new System.Drawing.Point(58, 611);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(113, 51);
            this.btnCreate.TabIndex = 190;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(53, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 189;
            this.label1.Text = "STT :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 57);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(507, 650);
            this.textBox2.TabIndex = 192;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(685, 57);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(658, 67);
            this.textBox3.TabIndex = 216;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(53, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 197;
            this.label3.Text = "Email :";
            // 
            // kQHTDataSet
            // 
            this.kQHTDataSet.DataSetName = "KQHTDataSet";
            this.kQHTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kQHTDataSetBindingSource
            // 
            this.kQHTDataSetBindingSource.DataSource = this.kQHTDataSet;
            this.kQHTDataSetBindingSource.Position = 0;
            // 
            // kQHTDataSet1
            // 
            this.kQHTDataSet1.DataSetName = "KQHTDataSet1";
            this.kQHTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giangVienBindingSource
            // 
            this.giangVienBindingSource.DataMember = "GiangVien";
            this.giangVienBindingSource.DataSource = this.kQHTDataSet1;
            // 
            // giangVienTableAdapter
            // 
            this.giangVienTableAdapter.ClearBeforeFill = true;
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
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã Giảng Viên";
            this.MaGV.MinimumWidth = 6;
            this.MaGV.Name = "MaGV";
            this.MaGV.ReadOnly = true;
            this.MaGV.Width = 125;
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Tên Giảng Viên";
            this.TenGV.MinimumWidth = 6;
            this.TenGV.Name = "TenGV";
            this.TenGV.ReadOnly = true;
            this.TenGV.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 125;
            // 
            // ChuyenMon
            // 
            this.ChuyenMon.DataPropertyName = "ChuyenMon";
            this.ChuyenMon.HeaderText = "Chuyên Môn";
            this.ChuyenMon.MinimumWidth = 6;
            this.ChuyenMon.Name = "ChuyenMon";
            this.ChuyenMon.ReadOnly = true;
            this.ChuyenMon.Width = 125;
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 766);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchGV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTongGV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bdGiangVien);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtChuyenMon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Name = "frmGiangVien";
            this.Text = "frmGiangVien";
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kQHTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchGV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView bdGiangVien;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtChuyenMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource kQHTDataSetBindingSource;
        private KQHTDataSet kQHTDataSet;
        private KQHTDataSet1 kQHTDataSet1;
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        private KQHTDataSet1TableAdapters.GiangVienTableAdapter giangVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenMon;
    }
}