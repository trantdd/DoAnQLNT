namespace DoAnQuanLyNhaTro
{
    partial class frmKhach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNgheNghiep = new System.Windows.Forms.TextBox();
            this.tbxSdt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTenKhach = new System.Windows.Forms.TextBox();
            this.tbxMaKhach = new System.Windows.Forms.TextBox();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.tbxCMND = new System.Windows.Forms.TextBox();
            this.btnChangeAv = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.dgvMaKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgheNghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoLienLac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAvatar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.cbxTim = new System.Windows.Forms.ComboBox();
            this.tbxTim = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnChangeAv);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.pbxAvatar);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 269);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbNu);
            this.panel3.Controls.Add(this.rbNam);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbxNgheNghiep);
            this.panel3.Controls.Add(this.tbxSdt);
            this.panel3.Location = new System.Drawing.Point(716, 39);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 149);
            this.panel3.TabIndex = 1;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(243, 22);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(45, 20);
            this.rbNu.TabIndex = 8;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(151, 22);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(57, 20);
            this.rbNam.TabIndex = 7;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nghề nghiệp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số ĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // tbxNgheNghiep
            // 
            this.tbxNgheNghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNgheNghiep.Location = new System.Drawing.Point(151, 62);
            this.tbxNgheNghiep.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNgheNghiep.Name = "tbxNgheNghiep";
            this.tbxNgheNghiep.Size = new System.Drawing.Size(244, 26);
            this.tbxNgheNghiep.TabIndex = 4;
            // 
            // tbxSdt
            // 
            this.tbxSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSdt.Location = new System.Drawing.Point(151, 105);
            this.tbxSdt.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSdt.Name = "tbxSdt";
            this.tbxSdt.Size = new System.Drawing.Size(244, 26);
            this.tbxSdt.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbxTenKhach);
            this.panel2.Controls.Add(this.tbxMaKhach);
            this.panel2.Controls.Add(this.tbxDiaChi);
            this.panel2.Controls.Add(this.tbxCMND);
            this.panel2.Location = new System.Drawing.Point(301, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 198);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "CMND";
            // 
            // tbxTenKhach
            // 
            this.tbxTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenKhach.Location = new System.Drawing.Point(116, 50);
            this.tbxTenKhach.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTenKhach.Name = "tbxTenKhach";
            this.tbxTenKhach.Size = new System.Drawing.Size(273, 26);
            this.tbxTenKhach.TabIndex = 2;
            // 
            // tbxMaKhach
            // 
            this.tbxMaKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaKhach.Location = new System.Drawing.Point(116, 7);
            this.tbxMaKhach.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMaKhach.Name = "tbxMaKhach";
            this.tbxMaKhach.Size = new System.Drawing.Size(132, 26);
            this.tbxMaKhach.TabIndex = 1;
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiaChi.Location = new System.Drawing.Point(116, 94);
            this.tbxDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(273, 26);
            this.tbxDiaChi.TabIndex = 3;
            // 
            // tbxCMND
            // 
            this.tbxCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCMND.Location = new System.Drawing.Point(116, 137);
            this.tbxCMND.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCMND.Name = "tbxCMND";
            this.tbxCMND.Size = new System.Drawing.Size(273, 26);
            this.tbxCMND.TabIndex = 4;
            // 
            // btnChangeAv
            // 
            this.btnChangeAv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnChangeAv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeAv.Location = new System.Drawing.Point(279, 18);
            this.btnChangeAv.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeAv.Name = "btnChangeAv";
            this.btnChangeAv.Size = new System.Drawing.Size(131, 32);
            this.btnChangeAv.TabIndex = 8;
            this.btnChangeAv.Text = "Change Avatar";
            this.btnChangeAv.UseVisualStyleBackColor = false;
            this.btnChangeAv.Click += new System.EventHandler(this.btnChangeAv_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Avatar";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(987, 215);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(125, 41);
            this.btnReload.TabIndex = 12;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAvatar.Location = new System.Drawing.Point(17, 22);
            this.pbxAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(253, 233);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAvatar.TabIndex = 7;
            this.pbxAvatar.TabStop = false;
            // 
            // dgvKhach
            // 
            this.dgvKhach.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKhach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaKhach,
            this.dgvTenKhach,
            this.dgvCmnd,
            this.dgvGioiTinh,
            this.dgvDiachi,
            this.dgvNgheNghiep,
            this.dgvSoLienLac,
            this.dgvAvatar});
            this.dgvKhach.Location = new System.Drawing.Point(16, 359);
            this.dgvKhach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.ReadOnly = true;
            this.dgvKhach.RowHeadersWidth = 51;
            this.dgvKhach.Size = new System.Drawing.Size(1140, 234);
            this.dgvKhach.TabIndex = 16;
            this.dgvKhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhach_CellClick);
            // 
            // dgvMaKhach
            // 
            this.dgvMaKhach.HeaderText = "Mã khách";
            this.dgvMaKhach.MinimumWidth = 6;
            this.dgvMaKhach.Name = "dgvMaKhach";
            this.dgvMaKhach.ReadOnly = true;
            this.dgvMaKhach.Width = 125;
            // 
            // dgvTenKhach
            // 
            this.dgvTenKhach.HeaderText = "Tên Khách";
            this.dgvTenKhach.MinimumWidth = 6;
            this.dgvTenKhach.Name = "dgvTenKhach";
            this.dgvTenKhach.ReadOnly = true;
            this.dgvTenKhach.Width = 125;
            // 
            // dgvCmnd
            // 
            this.dgvCmnd.HeaderText = "Số CMND/CCCD";
            this.dgvCmnd.MinimumWidth = 6;
            this.dgvCmnd.Name = "dgvCmnd";
            this.dgvCmnd.ReadOnly = true;
            this.dgvCmnd.Width = 125;
            // 
            // dgvGioiTinh
            // 
            this.dgvGioiTinh.HeaderText = "Giới tính";
            this.dgvGioiTinh.MinimumWidth = 6;
            this.dgvGioiTinh.Name = "dgvGioiTinh";
            this.dgvGioiTinh.ReadOnly = true;
            this.dgvGioiTinh.Width = 125;
            // 
            // dgvDiachi
            // 
            this.dgvDiachi.HeaderText = "Địa chỉ";
            this.dgvDiachi.MinimumWidth = 6;
            this.dgvDiachi.Name = "dgvDiachi";
            this.dgvDiachi.ReadOnly = true;
            this.dgvDiachi.Width = 125;
            // 
            // dgvNgheNghiep
            // 
            this.dgvNgheNghiep.HeaderText = "Nghề nghiệp";
            this.dgvNgheNghiep.MinimumWidth = 6;
            this.dgvNgheNghiep.Name = "dgvNgheNghiep";
            this.dgvNgheNghiep.ReadOnly = true;
            this.dgvNgheNghiep.Width = 125;
            // 
            // dgvSoLienLac
            // 
            this.dgvSoLienLac.HeaderText = "Số điện thoại";
            this.dgvSoLienLac.MinimumWidth = 6;
            this.dgvSoLienLac.Name = "dgvSoLienLac";
            this.dgvSoLienLac.ReadOnly = true;
            this.dgvSoLienLac.Width = 125;
            // 
            // dgvAvatar
            // 
            this.dgvAvatar.HeaderText = "Avatar";
            this.dgvAvatar.MinimumWidth = 6;
            this.dgvAvatar.Name = "dgvAvatar";
            this.dgvAvatar.ReadOnly = true;
            this.dgvAvatar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvatar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvAvatar.Width = 125;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(856, 299);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 41);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(1004, 299);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(125, 41);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(708, 300);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 41);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(35, 299);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(116, 42);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cbxTim
            // 
            this.cbxTim.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxTim.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTim.FormattingEnabled = true;
            this.cbxTim.Items.AddRange(new object[] {
            "Mã khách",
            "Tên"});
            this.cbxTim.Location = new System.Drawing.Point(183, 324);
            this.cbxTim.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTim.Name = "cbxTim";
            this.cbxTim.Size = new System.Drawing.Size(160, 26);
            this.cbxTim.TabIndex = 15;
            // 
            // tbxTim
            // 
            this.tbxTim.Location = new System.Drawing.Point(183, 292);
            this.tbxTim.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTim.Name = "tbxTim";
            this.tbxTim.Size = new System.Drawing.Size(273, 22);
            this.tbxTim.TabIndex = 14;
            // 
            // frmKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1176, 608);
            this.Controls.Add(this.tbxTim);
            this.Controls.Add(this.cbxTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.dgvKhach);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách";
            this.Load += new System.EventHandler(this.frmKhach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSdt;
        private System.Windows.Forms.TextBox tbxNgheNghiep;
        private System.Windows.Forms.TextBox tbxCMND;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.TextBox tbxTenKhach;
        private System.Windows.Forms.TextBox tbxMaKhach;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox tbxTim;
        private System.Windows.Forms.Button btnChangeAv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgheNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoLienLac;
        private System.Windows.Forms.DataGridViewImageColumn dgvAvatar;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
    }
}