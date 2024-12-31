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
using static System.Net.Mime.MediaTypeNames;

namespace DoAnQuanLyNhaTro
{

   
    public partial class frmQuanLyTaiKhoan : Form
    {
        DataTable dt = new DataTable();
        TaiKhoanService tkService = new TaiKhoanService();
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        public void LoadData()
        {

            try
            {
                //load danh sách tên tài khoản vào lstTaiKhoan
                List<TaiKhoan> taiKhoanList = tkService.GetAll();
                lstTaiKhoan.DataSource = taiKhoanList;
                lstTaiKhoan.DisplayMember = "TenTK";
                lstTaiKhoan.ValueMember = "TenTK";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
        //
        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
            //disable và ẩn panel Themtaikhoan, Doimatkhau
            pnlThemTaiKhoan.Enabled = false;
            pnlDoiMatKhau.Enabled = false;
            pnlDoiMatKhau.Visible = false;
            pnlThemTaiKhoan.Visible = false;
            

               
        }

        private void lstTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //đưa tên tài khoản lên textbox khi chọn vào listbox
            TaiKhoan tk = (TaiKhoan)lstTaiKhoan.SelectedItem;
            txtTaiKhoan.Text = tk.TenTK;
            tbxTenTK2.Text = tk.TenTK;
        }



        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            //xóa tài khoản
            try
            {
                TaiKhoan tk = (TaiKhoan)lstTaiKhoan.SelectedItem;
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    tkService.Delete(tk.TenTK);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            //Enable và hiện panel Themtaikhoan, ẩn panel Doimatkhau
            pnlThemTaiKhoan.Enabled = true;            
            pnlDoiMatKhau.Visible = false;
            pnlThemTaiKhoan.Visible = true;

            txtTenTK1.Text = "";
            txtMatKhau1.Text = "";
            txtNhapLaiMK1.Text = "";


        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan_Load(sender, e);
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra nhập đủ thông tin để tạo tài khoản
            if (txtTenTK1.Text == "" || txtMatKhau1.Text == "" || txtNhapLaiMK1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //nếu có tài khoản trùng thì không cho tạo tài khoản
                if (tkService.GetByTenTK(txtTenTK1.Text) != null)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // kiểm tra mật khẩu và nhập lại mật khẩu có khớp không
                if (txtMatKhau1.Text != txtNhapLaiMK1.Text)
                {
                    MessageBox.Show("Mật khẩu và nhập lại mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // tạo tài khoản mới
                TaiKhoan newTaiKhoan = new TaiKhoan
                {
                    TenTK = txtTenTK1.Text,
                    MatKhau = txtMatKhau1.Text
                };

                try
                {
                    tkService.Add(newTaiKhoan);
                    MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    txtTenTK1.Text = "";
                    txtMatKhau1.Text = "";
                    txtNhapLaiMK1.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            //ẩn panel Themtaikhoan, enable và hiện panel Doimatkhau
            pnlThemTaiKhoan.Visible = false;
            pnlDoiMatKhau.Enabled = true;
            pnlDoiMatKhau.Visible = true;

            tbxTenTK2.Text = "";
            tbxMatKhau2.Text = "";
            tbxMatKhauMoi.Text = "";
            tbxNhapLaiMK2.Text = "";

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            // kiểm tra nhập đủ thông tin
            if (tbxTenTK2.Text == "" || tbxMatKhau2.Text == "" || tbxMatKhauMoi.Text == "" || tbxNhapLaiMK2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //kiểm tra tồn tại tài khoản và mật khẩu cũ
            if (tkService.GetByTenTKAndMatKhau(tbxTenTK2.Text, tbxMatKhau2.Text) == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            TaiKhoan tk = tkService.GetByTenTKAndMatKhau(tbxTenTK2.Text, tbxMatKhau2.Text);
            // kiểm tra mật khẩu mới và nhập lại mật khẩu có khớp không
            if (tbxMatKhauMoi.Text != tbxNhapLaiMK2.Text)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tk.MatKhau = tbxMatKhauMoi.Text;

            try
            {
                tkService.Edit(tk);
                MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
