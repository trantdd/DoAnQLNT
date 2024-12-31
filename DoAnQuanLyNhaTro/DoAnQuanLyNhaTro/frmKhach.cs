using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL.DBQuanLyNhaTro;

namespace DoAnQuanLyNhaTro
{
    public partial class frmKhach : Form
    {
        private readonly KhachService khachService = new KhachService();
        public frmKhach()
        {
            InitializeComponent();
        }

        private void loadKhach()
        {
            try
            {
                //load danh sách khách vào dgvKhach
                KhachService khachService = new KhachService();

                dgvKhach.Rows.Clear();
                foreach (var item in khachService.GetKhach())
                {
                    int index = dgvKhach.Rows.Add();
                    dgvKhach.Rows[index].Cells[0].Value = item.MaKhach;
                    dgvKhach.Rows[index].Cells[1].Value = item.TenKhach;
                    dgvKhach.Rows[index].Cells[2].Value = item.CMND;
                    //Nếu giới tính = 1 thì hiển thị Nam, ngược lại hiển thị Nữ
                    if (item.GioiTinh == 1)
                    {
                        dgvKhach.Rows[index].Cells[3].Value = "Nam";
                    }
                    else
                    {
                        dgvKhach.Rows[index].Cells[3].Value = "Nữ";
                    }
                    dgvKhach.Rows[index].Cells[4].Value = item.DiaChiKhach;
                    dgvKhach.Rows[index].Cells[5].Value = item.NgheNghiep;
                    dgvKhach.Rows[index].Cells[6].Value = item.SdtKhach;
                    dgvKhach.Rows[index].Cells[7].Value = item.HinhAnhK;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            //
            //List<Khach> khachList = khachService.GetAll();
            //lstKhach.DataSource = khachList;
            //lstKhach.DisplayMember = "TenKhach";
            //lstKhach.ValueMember = "MaKhach";
        }

        private void BinGrid(List<Khach> khaches)
        {
            dgvKhach.Rows.Clear();
            foreach (var item in khaches)
            {
                int index = dgvKhach.Rows.Add();
                dgvKhach.Rows[index].Cells[0].Value = item.MaKhach;
                dgvKhach.Rows[index].Cells[1].Value = item.TenKhach;
                dgvKhach.Rows[index].Cells[2].Value = item.CMND;
                //Nếu giới tính = 1 thì hiển thị Nam, ngược lại hiển thị Nữ
                if (item.GioiTinh == 1)
                {
                    dgvKhach.Rows[index].Cells[3].Value = "Nam";
                }
                else
                {
                    dgvKhach.Rows[index].Cells[3].Value = "Nữ";
                }
                dgvKhach.Rows[index].Cells[4].Value = item.DiaChiKhach;
                dgvKhach.Rows[index].Cells[5].Value = item.NgheNghiep;
                dgvKhach.Rows[index].Cells[6].Value = item.SdtKhach;
                dgvKhach.Rows[index].Cells[7].Value = item.HinhAnhK;
            }
        }

        private void frmKhach_Load(object sender, EventArgs e)
        {
            loadKhach();
        }

        private void dgvKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //khi click record trong dgvKhach thì thông tin sẽ đc đưa lên các textbox
            try
            {
                DataGridViewRow row = dgvKhach.Rows[e.RowIndex];
                tbxMaKhach.Text = row.Cells[0].Value.ToString();
                tbxTenKhach.Text = row.Cells[1].Value.ToString();
                tbxCMND.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value.ToString() == "Nam")
                {
                    rbNam.Checked = true;
                }
                else
                {
                    rbNu.Checked = true;
                }
                tbxDiaChi.Text = row.Cells[4].Value.ToString();
                tbxNgheNghiep.Text = row.Cells[5].Value.ToString();
                tbxSdt.Text = row.Cells[6].Value.ToString();
                //Hình ảnh
                try
                {
                    pbxAvatar.Image = Image.FromStream(new System.IO.MemoryStream((byte[])row.Cells[7].Value));
                }
                catch
                {
                    pbxAvatar.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        bool them = false;

        private bool checkInput()
        {
            KhachService khachService = new KhachService();
            try
            {
                //ktra nhập đầy đủ thông tin chưa
                if (string.IsNullOrEmpty(tbxMaKhach.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mã khách");
                    tbxMaKhach.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(tbxTenKhach.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tên khách");
                    tbxTenKhach.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(tbxCMND.Text))
                {
                    MessageBox.Show("Bạn chưa nhập CMND");
                    tbxCMND.Focus();
                    return false;
                }
                if (rbNam.Checked == false && rbNu.Checked == false)
                {
                    MessageBox.Show("Bạn chưa chọn giới tính");
                    return false;
                }
                if (string.IsNullOrEmpty(tbxDiaChi.Text))
                {
                    MessageBox.Show("Bạn chưa nhập địa chỉ");
                    tbxDiaChi.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(tbxNgheNghiep.Text))
                {
                    MessageBox.Show("Bạn chưa nhập nghề nghiệp");
                    tbxNgheNghiep.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(tbxSdt.Text))
                {
                    MessageBox.Show("Bạn chưa nhập số điện thoại");
                    tbxSdt.Focus();
                    return false;
                }
                if (pbxAvatar.Image == null)
                {
                    MessageBox.Show("Bạn chưa chọn ảnh");
                    return false;
                }
                //Kiem tra ma khach da ton tai chua

                foreach (var item in khachService.GetKhach())
                {
                    if (tbxMaKhach.Text == item.MaKhach.ToString())
                    {
                        MessageBox.Show("Mã khách đã tồn tại");
                        tbxMaKhach.Focus();
                        return false;
                    }
                }
                return true;
            }
            // bat cac loi ep kieu
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu nhập vào không đúng định dạng");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (!checkInput())
            {
                return;
            }
            try
            {
                Khach khach = new Khach();
                khach.MaKhach = int.Parse(tbxMaKhach.Text);
                khach.TenKhach = tbxTenKhach.Text;
                khach.CMND = tbxCMND.Text;
                if (rbNam.Checked == true)
                {
                    khach.GioiTinh = 1;
                }
                else
                {
                    khach.GioiTinh = 0;
                }
                khach.DiaChiKhach = tbxDiaChi.Text;
                khach.NgheNghiep = tbxNgheNghiep.Text;
                khach.SdtKhach = tbxSdt.Text;
                //Hình ảnh co the trung voi hinh anh cu
                if (!string.IsNullOrEmpty(avatarFilePath))
                {
                    khach.HinhAnhK = File.ReadAllBytes(avatarFilePath);
                }
                else
                {
                    MessageBox.Show("Ảnh đã được sử dụng");
                    return;
                }


                khachService.AddKhach(khach);
                MessageBox.Show("Thêm thành công");
                loadKhach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }



        private void btnReload_Click(object sender, EventArgs e)
        {
            loadKhach();

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            them = false;


            //xóa trắng textbox
            this.tbxMaKhach.ResetText();
            this.tbxTenKhach.ResetText();
            this.tbxSdt.ResetText();
            this.tbxNgheNghiep.ResetText();
            this.rbNam.Checked = false;
            this.rbNu.Checked = false;
            this.tbxDiaChi.ResetText();
            this.tbxCMND.ResetText();
            this.tbxTim.ResetText();

            //picbox
            this.pbxAvatar.Image = null;
        }

        private void btnChangeAv_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    avatarFilePath = ofd.FileName;
                    pbxAvatar.Image = Image.FromFile(avatarFilePath);
                }
            }

        }
        private string avatarFilePath = string.Empty;
        private string saveAvatar(string sourceFilePath, string MaKhach)
        {
            try
            {
                string folderPath = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                string fileExtension = Path.GetExtension(avatarFilePath);
                string targetFilePath = Path.Combine(folderPath, $"{MaKhach}{fileExtension}");
                if (!File.Exists(sourceFilePath))
                {
                    throw new FieldAccessException($"Không tìm thấy file:{sourceFilePath}");
                }
                File.Copy(sourceFilePath, targetFilePath, true);
                return $"{MaKhach}{fileExtension}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi luu Anh: " + ex.Message);
                return null;
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Xóa khách
            try
            {
                if (string.IsNullOrEmpty(tbxMaKhach.Text))
                {
                    MessageBox.Show("Bạn chưa chọn khách để xóa");
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    khachService.DeleteKhach(int.Parse(tbxMaKhach.Text));
                    MessageBox.Show("Xóa thành công");
                    loadKhach();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //Sửa khách
            KhachService khachService = new KhachService();
            try
            {
               if(!checkInputUpdate())
                {
                    return;
                }
                //Kiem tra ma khach da ton tai chua
                bool maKhachExists = khachService.GetKhach().Any(item => tbxMaKhach.Text == item.MaKhach.ToString());
                if (!maKhachExists)
                {
                    MessageBox.Show("Mã khách không tồn tại");
                    return;
                }

                Khach khach = new Khach();
                khach.MaKhach = int.Parse(tbxMaKhach.Text);
                khach.TenKhach = tbxTenKhach.Text;
                khach.CMND = tbxCMND.Text;
                if (rbNam.Checked == true)
                {
                    khach.GioiTinh = 1;
                }
                else
                {
                    khach.GioiTinh = 0;
                }
                khach.DiaChiKhach = tbxDiaChi.Text;
                khach.NgheNghiep = tbxNgheNghiep.Text;
                khach.SdtKhach = tbxSdt.Text;

                //Hình ảnh có thể trùng với hình ảnh cũ
                if (!string.IsNullOrEmpty(avatarFilePath))
                {
                    khach.HinhAnhK = File.ReadAllBytes(avatarFilePath);
                }
                else
                {
                    khach.HinhAnhK = khachService.GetKhachByMa(khach.MaKhach).HinhAnhK;
                }

                khachService.EditKhach(khach);
                MessageBox.Show("Sửa thành công");
                loadKhach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //Tìm kiếm khách
            try
            {
                //Neu tim theo ma khach cbxTim
                if (cbxTim.Text == "Mã khách")
                {
                    int maKhach = int.Parse(tbxTim.Text);
                    List<Khach> khachList = khachService.SearchMaKhach(maKhach);
                    BinGrid(khachList);
                }
                //Neu tim theo ten khach cbxTim
                else if (cbxTim.Text == "Tên")
                {
                    string tenKhach = tbxTim.Text;
                    List<Khach> khachList = khachService.SearchTenKhach(tenKhach);
                    BinGrid(khachList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private bool checkInputUpdate()
        {
            KhachService khachService = new KhachService();
            try
            {
                //ktra nhập đầy đủ thông tin chưa
                if (string.IsNullOrEmpty(tbxMaKhach.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mã khách");
                    tbxMaKhach.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(tbxTenKhach.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tên khách");
                    tbxTenKhach.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(tbxCMND.Text))
                {
                    MessageBox.Show("Bạn chưa nhập CMND");
                    tbxCMND.Focus();
                    return false;
                }
                if (rbNam.Checked == false && rbNu.Checked == false)
                {
                    MessageBox.Show("Bạn chưa chọn giới tính");
                    return false;
                }
                if (string.IsNullOrEmpty(tbxDiaChi.Text))
                {
                    MessageBox.Show("Bạn chưa nhập địa chỉ");
                    tbxDiaChi.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(tbxNgheNghiep.Text))
                {
                    MessageBox.Show("Bạn chưa nhập nghề nghiệp");
                    tbxNgheNghiep.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(tbxSdt.Text))
                {
                    MessageBox.Show("Bạn chưa nhập số điện thoại");
                    tbxSdt.Focus();
                    return false;
                }
                if (pbxAvatar.Image == null)
                {
                    MessageBox.Show("Bạn chưa chọn ảnh");
                    return false;
                }
                //Kiem tra ma khach da ton tai chua

                bool maKhachExists = khachService.GetKhach().Any(item => tbxMaKhach.Text == item.MaKhach.ToString());
                if (!maKhachExists)
                {
                    MessageBox.Show("Mã khách không tồn tại");
                    return false;
                }
                return true;
            }
            // bat cac loi ep kieu
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu nhập vào không đúng định dạng");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
    }
}
