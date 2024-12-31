namespace DoAnQuanLyNhaTro
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThietBi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKhach = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.cơSởVậtChấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLKhach = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHopDong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChiTietHopDong = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuChiTietDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhieuThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLíToolStripMenuItem,
            this.cơSởVậtChấtToolStripMenuItem,
            this.doanhThuToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1172, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuanLyTaiKhoan,
            this.menuDangXuat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // menuQuanLyTaiKhoan
            // 
            this.menuQuanLyTaiKhoan.Name = "menuQuanLyTaiKhoan";
            this.menuQuanLyTaiKhoan.Size = new System.Drawing.Size(204, 26);
            this.menuQuanLyTaiKhoan.Text = "Quản lí tài khoản";
            this.menuQuanLyTaiKhoan.Click += new System.EventHandler(this.menuQuanLyTaiKhoan_Click);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(204, 26);
            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDichVu,
            this.menuThietBi,
            this.menuLoaiPhong,
            this.menuKhach,
            this.menuPhong});
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.quảnLíToolStripMenuItem.Text = "Xem danh mục";
            // 
            // menuDichVu
            // 
            this.menuDichVu.Name = "menuDichVu";
            this.menuDichVu.Size = new System.Drawing.Size(224, 26);
            this.menuDichVu.Text = "Dịch vụ";
            this.menuDichVu.Click += new System.EventHandler(this.menuDichVu_Click);
            // 
            // menuThietBi
            // 
            this.menuThietBi.Name = "menuThietBi";
            this.menuThietBi.Size = new System.Drawing.Size(224, 26);
            this.menuThietBi.Text = "Thiết bị";
            this.menuThietBi.Click += new System.EventHandler(this.menuThietBi_Click);
            // 
            // menuLoaiPhong
            // 
            this.menuLoaiPhong.Name = "menuLoaiPhong";
            this.menuLoaiPhong.Size = new System.Drawing.Size(224, 26);
            this.menuLoaiPhong.Text = "Loại phòng";
            this.menuLoaiPhong.Click += new System.EventHandler(this.menuLoaiPhong_Click);
            // 
            // menuKhach
            // 
            this.menuKhach.Name = "menuKhach";
            this.menuKhach.Size = new System.Drawing.Size(224, 26);
            this.menuKhach.Text = "Khách";
            this.menuKhach.Click += new System.EventHandler(this.menuKhach_Click);
            // 
            // menuPhong
            // 
            this.menuPhong.Name = "menuPhong";
            this.menuPhong.Size = new System.Drawing.Size(224, 26);
            this.menuPhong.Text = "Phòng";
            this.menuPhong.Click += new System.EventHandler(this.menuPhong_Click);
            // 
            // cơSởVậtChấtToolStripMenuItem
            // 
            this.cơSởVậtChấtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQLKhach,
            this.menuQLPhong});
            this.cơSởVậtChấtToolStripMenuItem.Name = "cơSởVậtChấtToolStripMenuItem";
            this.cơSởVậtChấtToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.cơSởVậtChấtToolStripMenuItem.Text = "Quản lí";
            // 
            // menuQLKhach
            // 
            this.menuQLKhach.Name = "menuQLKhach";
            this.menuQLKhach.Size = new System.Drawing.Size(224, 26);
            this.menuQLKhach.Text = "Khách";
            this.menuQLKhach.Click += new System.EventHandler(this.menuQLKhach_Click);
            // 
            // menuQLPhong
            // 
            this.menuQLPhong.Name = "menuQLPhong";
            this.menuQLPhong.Size = new System.Drawing.Size(224, 26);
            this.menuQLPhong.Text = "Phòng";
            this.menuQLPhong.Click += new System.EventHandler(this.menuQLPhong_Click);
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHopDong,
            this.menuChiTietHopDong,
            this.MenuChiTietDichVu,
            this.menuPhieuThanhToan});
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.doanhThuToolStripMenuItem.Text = "Hợp đồng - Thanh toán";
            // 
            // menuHopDong
            // 
            this.menuHopDong.Name = "menuHopDong";
            this.menuHopDong.Size = new System.Drawing.Size(208, 26);
            this.menuHopDong.Text = "Hợp đồng";
            // 
            // menuChiTietHopDong
            // 
            this.menuChiTietHopDong.Name = "menuChiTietHopDong";
            this.menuChiTietHopDong.Size = new System.Drawing.Size(208, 26);
            this.menuChiTietHopDong.Text = "Chi tiết hợp đồng";
            // 
            // MenuChiTietDichVu
            // 
            this.MenuChiTietDichVu.Name = "MenuChiTietDichVu";
            this.MenuChiTietDichVu.Size = new System.Drawing.Size(208, 26);
            this.MenuChiTietDichVu.Text = "Chi tiết dịch vụ";
            // 
            // menuPhieuThanhToan
            // 
            this.menuPhieuThanhToan.Name = "menuPhieuThanhToan";
            this.menuPhieuThanhToan.Size = new System.Drawing.Size(208, 26);
            this.menuPhieuThanhToan.Text = "Phiếu thanh toán";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(30, 24);
            this.toolStripMenuItem1.Text = "?";
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.ImageLocation = "";
            this.pbxLogo.Location = new System.Drawing.Point(941, 490);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(215, 106);
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1172, 610);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lí nhà trọ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDichVu;
        private System.Windows.Forms.ToolStripMenuItem menuThietBi;
        private System.Windows.Forms.ToolStripMenuItem cơSởVậtChấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuQLKhach;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHopDong;
        private System.Windows.Forms.ToolStripMenuItem menuChiTietHopDong;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuLoaiPhong;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.ToolStripMenuItem menuQLPhong;
        private System.Windows.Forms.ToolStripMenuItem menuKhach;
        private System.Windows.Forms.ToolStripMenuItem menuPhong;
        private System.Windows.Forms.ToolStripMenuItem MenuChiTietDichVu;
        private System.Windows.Forms.ToolStripMenuItem menuPhieuThanhToan;
    }
}