using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyNhaTro
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //form quan ly tai khoan
        private void menuQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan frm = new frmQuanLyTaiKhoan();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TenDanhMuc(string tenDanhMuc)
        {
            frmDanhMuc frm = new frmDanhMuc();
            frm.Text = tenDanhMuc;
            frm.ShowDialog();
        }

        private void menuDichVu_Click(object sender, EventArgs e)
        {
            TenDanhMuc("Dịch vụ");
        }

        private void menuThietBi_Click(object sender, EventArgs e)
        {
            TenDanhMuc("Thiết bị");
        }

        private void menuLoaiPhong_Click(object sender, EventArgs e)
        {
            TenDanhMuc("Loại phòng");
        }

        private void menuKhach_Click(object sender, EventArgs e)
        {
            TenDanhMuc("Khách");
        }

        private void menuPhong_Click(object sender, EventArgs e)
        {
            TenDanhMuc("Phòng");
        }

        private void menuQLKhach_Click(object sender, EventArgs e)
        {
            frmKhach frm = new frmKhach();
            frm.ShowDialog();
        }

        private void menuQLPhong_Click(object sender, EventArgs e)
        {
            frmPhong frm = new frmPhong();
            frm.ShowDialog();
        }
    }
}
