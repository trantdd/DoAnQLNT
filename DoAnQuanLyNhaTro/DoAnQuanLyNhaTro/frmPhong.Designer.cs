namespace DoAnQuanLyNhaTro
{
    partial class frmPhong
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
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.MaLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaLP = new System.Windows.Forms.Button();
            this.tbxDienTichLP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapNhatLP = new System.Windows.Forms.Button();
            this.tbxTenLP = new System.Windows.Forms.TextBox();
            this.btnThemLP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMaLP = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbxHienTrang = new System.Windows.Forms.ComboBox();
            this.cbxMaNhaTro = new System.Windows.Forms.ComboBox();
            this.cbxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxSoLuong = new System.Windows.Forms.TextBox();
            this.tbxTenPhong = new System.Windows.Forms.TextBox();
            this.tbxMaPhong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvNhaTro = new System.Windows.Forms.DataGridView();
            this.NhaTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoaNT = new System.Windows.Forms.Button();
            this.btnCapNhatNT = new System.Windows.Forms.Button();
            this.btnThemNT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDiaChiNhaTro = new System.Windows.Forms.TextBox();
            this.tbxMaNhaTro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HienTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhaTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaTro)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhong
            // 
            this.dgvPhong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenPhong,
            this.HienTrang,
            this.SoLuongNguoi,
            this.LoaiPhong,
            this.MaNhaTro});
            this.dgvPhong.Location = new System.Drawing.Point(423, 294);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.Size = new System.Drawing.Size(755, 298);
            this.dgvPhong.TabIndex = 2;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiPhong,
            this.DienTich,
            this.TenLoaiPhong});
            this.dgvLoaiPhong.Location = new System.Drawing.Point(16, 318);
            this.dgvLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.ReadOnly = true;
            this.dgvLoaiPhong.RowHeadersWidth = 51;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(397, 140);
            this.dgvLoaiPhong.TabIndex = 3;
            this.dgvLoaiPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiPhong_CellClick);
            // 
            // MaLoaiPhong
            // 
            this.MaLoaiPhong.DataPropertyName = "MaLoaiPhong";
            this.MaLoaiPhong.Frozen = true;
            this.MaLoaiPhong.HeaderText = "Mã loại";
            this.MaLoaiPhong.MinimumWidth = 6;
            this.MaLoaiPhong.Name = "MaLoaiPhong";
            this.MaLoaiPhong.ReadOnly = true;
            this.MaLoaiPhong.Width = 80;
            // 
            // DienTich
            // 
            this.DienTich.DataPropertyName = "DienTich";
            this.DienTich.HeaderText = "Diện tích";
            this.DienTich.MinimumWidth = 6;
            this.DienTich.Name = "DienTich";
            this.DienTich.ReadOnly = true;
            this.DienTich.Width = 80;
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.DataPropertyName = "TenLoaiPhong";
            this.TenLoaiPhong.HeaderText = "Tên loại";
            this.TenLoaiPhong.MinimumWidth = 6;
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            this.TenLoaiPhong.ReadOnly = true;
            this.TenLoaiPhong.Width = 80;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnXoaLP);
            this.panel1.Controls.Add(this.tbxDienTichLP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCapNhatLP);
            this.panel1.Controls.Add(this.tbxTenLP);
            this.panel1.Controls.Add(this.btnThemLP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxMaLP);
            this.panel1.Location = new System.Drawing.Point(16, 469);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 123);
            this.panel1.TabIndex = 4;
            // 
            // btnXoaLP
            // 
            this.btnXoaLP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnXoaLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLP.Location = new System.Drawing.Point(289, 82);
            this.btnXoaLP.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaLP.Name = "btnXoaLP";
            this.btnXoaLP.Size = new System.Drawing.Size(92, 28);
            this.btnXoaLP.TabIndex = 12;
            this.btnXoaLP.Text = "Xóa ";
            this.btnXoaLP.UseVisualStyleBackColor = true;
            this.btnXoaLP.Click += new System.EventHandler(this.btnXoaLP_Click);
            // 
            // tbxDienTichLP
            // 
            this.tbxDienTichLP.Location = new System.Drawing.Point(93, 82);
            this.tbxDienTichLP.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDienTichLP.Name = "tbxDienTichLP";
            this.tbxDienTichLP.Size = new System.Drawing.Size(187, 22);
            this.tbxDienTichLP.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Diện tích";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên loại";
            // 
            // btnCapNhatLP
            // 
            this.btnCapNhatLP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCapNhatLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLP.Location = new System.Drawing.Point(289, 46);
            this.btnCapNhatLP.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhatLP.Name = "btnCapNhatLP";
            this.btnCapNhatLP.Size = new System.Drawing.Size(92, 28);
            this.btnCapNhatLP.TabIndex = 11;
            this.btnCapNhatLP.Text = "Cập nhật";
            this.btnCapNhatLP.UseVisualStyleBackColor = true;
            this.btnCapNhatLP.Click += new System.EventHandler(this.btnCapNhatLP_Click);
            // 
            // tbxTenLP
            // 
            this.tbxTenLP.Location = new System.Drawing.Point(93, 49);
            this.tbxTenLP.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTenLP.Name = "tbxTenLP";
            this.tbxTenLP.Size = new System.Drawing.Size(187, 22);
            this.tbxTenLP.TabIndex = 7;
            // 
            // btnThemLP
            // 
            this.btnThemLP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThemLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLP.Location = new System.Drawing.Point(288, 10);
            this.btnThemLP.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemLP.Name = "btnThemLP";
            this.btnThemLP.Size = new System.Drawing.Size(93, 28);
            this.btnThemLP.TabIndex = 10;
            this.btnThemLP.Text = "Thêm";
            this.btnThemLP.UseVisualStyleBackColor = true;
            this.btnThemLP.Click += new System.EventHandler(this.btnThemLP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã loại";
            // 
            // tbxMaLP
            // 
            this.tbxMaLP.Location = new System.Drawing.Point(93, 15);
            this.tbxMaLP.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMaLP.Name = "tbxMaLP";
            this.tbxMaLP.Size = new System.Drawing.Size(91, 22);
            this.tbxMaLP.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.cbxHienTrang);
            this.panel2.Controls.Add(this.cbxMaNhaTro);
            this.panel2.Controls.Add(this.cbxLoaiPhong);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.tbxSoLuong);
            this.panel2.Controls.Add(this.tbxTenPhong);
            this.panel2.Controls.Add(this.tbxMaPhong);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(380, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 268);
            this.panel2.TabIndex = 5;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(307, 214);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(187, 38);
            this.btnCapNhat.TabIndex = 30;
            this.btnCapNhat.Text = "Cập nhật thông tin";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(548, 214);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(187, 38);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa phòng";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(548, 140);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(187, 38);
            this.btnReload.TabIndex = 28;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(69, 215);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(187, 38);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm phòng";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbxHienTrang
            // 
            this.cbxHienTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHienTrang.FormattingEnabled = true;
            this.cbxHienTrang.Items.AddRange(new object[] {
            "Phòng trống",
            "Có người"});
            this.cbxHienTrang.Location = new System.Drawing.Point(563, 68);
            this.cbxHienTrang.Margin = new System.Windows.Forms.Padding(4);
            this.cbxHienTrang.Name = "cbxHienTrang";
            this.cbxHienTrang.Size = new System.Drawing.Size(201, 28);
            this.cbxHienTrang.TabIndex = 4;
            // 
            // cbxMaNhaTro
            // 
            this.cbxMaNhaTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaNhaTro.FormattingEnabled = true;
            this.cbxMaNhaTro.Location = new System.Drawing.Point(164, 111);
            this.cbxMaNhaTro.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMaNhaTro.Name = "cbxMaNhaTro";
            this.cbxMaNhaTro.Size = new System.Drawing.Size(244, 28);
            this.cbxMaNhaTro.TabIndex = 5;
            // 
            // cbxLoaiPhong
            // 
            this.cbxLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoaiPhong.FormattingEnabled = true;
            this.cbxLoaiPhong.Location = new System.Drawing.Point(164, 154);
            this.cbxLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLoaiPhong.Name = "cbxLoaiPhong";
            this.cbxLoaiPhong.Size = new System.Drawing.Size(244, 28);
            this.cbxLoaiPhong.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Book Antiqua", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 111);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 23);
            this.label14.TabIndex = 24;
            this.label14.Text = "Mã nhà trọ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 154);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 23);
            this.label13.TabIndex = 23;
            this.label13.Text = "Loại phòng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(433, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "Số lượng";
            // 
            // tbxSoLuong
            // 
            this.tbxSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSoLuong.Location = new System.Drawing.Point(563, 25);
            this.tbxSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSoLuong.Name = "tbxSoLuong";
            this.tbxSoLuong.Size = new System.Drawing.Size(104, 26);
            this.tbxSoLuong.TabIndex = 3;
            // 
            // tbxTenPhong
            // 
            this.tbxTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenPhong.Location = new System.Drawing.Point(164, 68);
            this.tbxTenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTenPhong.Name = "tbxTenPhong";
            this.tbxTenPhong.Size = new System.Drawing.Size(244, 26);
            this.tbxTenPhong.TabIndex = 2;
            // 
            // tbxMaPhong
            // 
            this.tbxMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaPhong.Location = new System.Drawing.Point(164, 25);
            this.tbxMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMaPhong.Name = "tbxMaPhong";
            this.tbxMaPhong.Size = new System.Drawing.Size(119, 26);
            this.tbxMaPhong.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(433, 71);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Hiện trạng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 68);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tên phòng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã phòng";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(376, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "   Loại phòng";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "   Nhà trọ";
            // 
            // dgvNhaTro
            // 
            this.dgvNhaTro.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvNhaTro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhaTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaTro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NhaTro,
            this.DiaChi});
            this.dgvNhaTro.Location = new System.Drawing.Point(16, 37);
            this.dgvNhaTro.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhaTro.Name = "dgvNhaTro";
            this.dgvNhaTro.ReadOnly = true;
            this.dgvNhaTro.RowHeadersWidth = 51;
            this.dgvNhaTro.Size = new System.Drawing.Size(356, 133);
            this.dgvNhaTro.TabIndex = 15;
            this.dgvNhaTro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaTro_CellClick);
            // 
            // NhaTro
            // 
            this.NhaTro.DataPropertyName = "MaNhaTro";
            this.NhaTro.Frozen = true;
            this.NhaTro.HeaderText = "Mã nhà trọ";
            this.NhaTro.MinimumWidth = 6;
            this.NhaTro.Name = "NhaTro";
            this.NhaTro.ReadOnly = true;
            this.NhaTro.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 105;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnXoaNT);
            this.panel3.Controls.Add(this.btnCapNhatNT);
            this.panel3.Controls.Add(this.btnThemNT);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tbxDiaChiNhaTro);
            this.panel3.Controls.Add(this.tbxMaNhaTro);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(16, 177);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 105);
            this.panel3.TabIndex = 17;
            // 
            // btnXoaNT
            // 
            this.btnXoaNT.BackColor = System.Drawing.Color.Lavender;
            this.btnXoaNT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnXoaNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNT.Location = new System.Drawing.Point(232, 63);
            this.btnXoaNT.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaNT.Name = "btnXoaNT";
            this.btnXoaNT.Size = new System.Drawing.Size(97, 28);
            this.btnXoaNT.TabIndex = 20;
            this.btnXoaNT.Text = "Xóa";
            this.btnXoaNT.UseVisualStyleBackColor = false;
            this.btnXoaNT.Click += new System.EventHandler(this.btnXoaNT_Click);
            // 
            // btnCapNhatNT
            // 
            this.btnCapNhatNT.BackColor = System.Drawing.Color.Lavender;
            this.btnCapNhatNT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCapNhatNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatNT.Location = new System.Drawing.Point(127, 63);
            this.btnCapNhatNT.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhatNT.Name = "btnCapNhatNT";
            this.btnCapNhatNT.Size = new System.Drawing.Size(97, 28);
            this.btnCapNhatNT.TabIndex = 19;
            this.btnCapNhatNT.Text = "Cập nhật";
            this.btnCapNhatNT.UseVisualStyleBackColor = false;
            this.btnCapNhatNT.Click += new System.EventHandler(this.btnCapNhatNT_Click);
            // 
            // btnThemNT
            // 
            this.btnThemNT.BackColor = System.Drawing.Color.Lavender;
            this.btnThemNT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThemNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNT.Location = new System.Drawing.Point(21, 63);
            this.btnThemNT.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNT.Name = "btnThemNT";
            this.btnThemNT.Size = new System.Drawing.Size(97, 28);
            this.btnThemNT.TabIndex = 18;
            this.btnThemNT.Text = "Thêm";
            this.btnThemNT.UseVisualStyleBackColor = false;
            this.btnThemNT.Click += new System.EventHandler(this.btnThemNT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Địa chỉ";
            // 
            // tbxDiaChiNhaTro
            // 
            this.tbxDiaChiNhaTro.Location = new System.Drawing.Point(127, 30);
            this.tbxDiaChiNhaTro.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDiaChiNhaTro.Name = "tbxDiaChiNhaTro";
            this.tbxDiaChiNhaTro.Size = new System.Drawing.Size(201, 22);
            this.tbxDiaChiNhaTro.TabIndex = 17;
            // 
            // tbxMaNhaTro
            // 
            this.tbxMaNhaTro.Location = new System.Drawing.Point(21, 31);
            this.tbxMaNhaTro.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMaNhaTro.Name = "tbxMaNhaTro";
            this.tbxMaNhaTro.Size = new System.Drawing.Size(81, 22);
            this.tbxMaNhaTro.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã nhà trọ";
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.Frozen = true;
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            this.MaPhong.Width = 125;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            this.TenPhong.Width = 125;
            // 
            // HienTrang
            // 
            this.HienTrang.DataPropertyName = "HienTrang";
            this.HienTrang.HeaderText = "Hiện trạng";
            this.HienTrang.MinimumWidth = 6;
            this.HienTrang.Name = "HienTrang";
            this.HienTrang.ReadOnly = true;
            this.HienTrang.Width = 125;
            // 
            // SoLuongNguoi
            // 
            this.SoLuongNguoi.DataPropertyName = "SoLuongNguoi";
            this.SoLuongNguoi.HeaderText = "Số lượng người";
            this.SoLuongNguoi.MinimumWidth = 6;
            this.SoLuongNguoi.Name = "SoLuongNguoi";
            this.SoLuongNguoi.ReadOnly = true;
            this.SoLuongNguoi.Width = 125;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.DataPropertyName = "MaLoaiPhong";
            this.LoaiPhong.HeaderText = "Loại phòng";
            this.LoaiPhong.MinimumWidth = 6;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.ReadOnly = true;
            this.LoaiPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoaiPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LoaiPhong.Width = 125;
            // 
            // MaNhaTro
            // 
            this.MaNhaTro.DataPropertyName = "MaNhaTro";
            this.MaNhaTro.HeaderText = "Mã nhà trọ";
            this.MaNhaTro.MinimumWidth = 6;
            this.MaNhaTro.Name = "MaNhaTro";
            this.MaNhaTro.ReadOnly = true;
            this.MaNhaTro.Width = 125;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1193, 610);
            this.Controls.Add(this.dgvNhaTro);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvLoaiPhong);
            this.Controls.Add(this.dgvPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng trọ";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaTro)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxTenLP;
        private System.Windows.Forms.TextBox tbxMaLP;
        private System.Windows.Forms.TextBox tbxDienTichLP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaLP;
        private System.Windows.Forms.Button btnCapNhatLP;
        private System.Windows.Forms.Button btnThemLP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvNhaTro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXoaNT;
        private System.Windows.Forms.Button btnCapNhatNT;
        private System.Windows.Forms.Button btnThemNT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxDiaChiNhaTro;
        private System.Windows.Forms.TextBox tbxMaNhaTro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxSoLuong;
        private System.Windows.Forms.TextBox tbxTenPhong;
        private System.Windows.Forms.TextBox tbxMaPhong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxLoaiPhong;
        private System.Windows.Forms.ComboBox cbxMaNhaTro;
        private System.Windows.Forms.ComboBox cbxHienTrang;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HienTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaTro;
    }
}