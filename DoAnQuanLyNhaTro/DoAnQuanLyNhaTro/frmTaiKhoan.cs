using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL.DBQuanLyNhaTro;

namespace DoAnQuanLyNhaTro
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }
        public void DangNhap() // DangNhap
        {
            try
            {
                //ktra tài khoản có tồn tại hay ko
                TaiKhoanService tkService = new TaiKhoanService();
                if (tkService.GetByTenTKAndMatKhau(this.txtTenDangNhap.Text, this.txtMatKhau.Text) != null)
                {
                    //hiển thị form main, ẩn form đăng nhập
                    using (frmMain frm = new frmMain())
                    {
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    //xóa trắng textbox, focus vào TK
                    txtTenDangNhap.Text = "";
                    txtMatKhau.Text = "";
                    txtTenDangNhap.Focus();

                }
                else
                {
                    //nếu không đúng tài khoản thì thông báo
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenDangNhap.Text = "";
                    txtMatKhau.Text = "";
                    txtTenDangNhap.Focus();

                }
            }
            

            
            //bắt lỗi exception
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
