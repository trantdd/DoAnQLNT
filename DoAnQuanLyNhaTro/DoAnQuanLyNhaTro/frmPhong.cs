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
    public partial class frmPhong : Form
    {

        public frmPhong()
        {
            InitializeComponent();
        }
        private void loadPhong()
        {
            try
            {
                PhongService phongService = new PhongService();
                var loaiPhongList = phongService.GetLoaiPhong();
                dgvPhong.Rows.Clear();
                foreach (var item in phongService.GetPhong())
                {
                    int index = dgvPhong.Rows.Add();
                    dgvPhong.Rows[index].Cells[0].Value = item.MaPhong;
                    dgvPhong.Rows[index].Cells[1].Value = item.TenPhong;
                    dgvPhong.Rows[index].Cells[2].Value = item.HienTrang;
                    dgvPhong.Rows[index].Cells[3].Value = item.SoLuongNguoi;
                    dgvPhong.Rows[index].Cells[4].Value = item.LoaiPhong.TenLoaiPhong;
                    dgvPhong.Rows[index].Cells[5].Value = item.MaNhaTro;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadLoaiPhong()
        {
            try
            {
                PhongService phongService = new PhongService();
                var loaiPhongList = phongService.GetLoaiPhong();
                dgvLoaiPhong.Rows.Clear();
                foreach (var item in loaiPhongList)
                {
                    int index = dgvLoaiPhong.Rows.Add();
                    dgvLoaiPhong.Rows[index].Cells[0].Value = item.MaLoaiPhong;

                    dgvLoaiPhong.Rows[index].Cells[1].Value = item.DienTich;
                    dgvLoaiPhong.Rows[index].Cells[2].Value = item.TenLoaiPhong;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadNhaTro()
        {
            try
            {
                PhongService phongService = new PhongService();
                var nhaTroList = phongService.GetNhaTro();
                dgvNhaTro.Rows.Clear();
                foreach (var item in nhaTroList)
                {
                    int index = dgvNhaTro.Rows.Add();
                    dgvNhaTro.Rows[index].Cells[0].Value = item.MaNhaTro;
                    dgvNhaTro.Rows[index].Cells[1].Value = item.DiaChi;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cmbMaNhaTro(List<NhaTro> nhaTros)
        {

            this.cbxMaNhaTro.DataSource = nhaTros;
            this.cbxMaNhaTro.DisplayMember = "MaNhaTro";
            this.cbxMaNhaTro.ValueMember = "MaNhaTro";
        }
        public void cmbLoaiPhong(List<LoaiPhong> loaiPhongs)
        {
            this.cbxLoaiPhong.DataSource = loaiPhongs;
            this.cbxLoaiPhong.DisplayMember = "TenLoaiPhong";
            this.cbxLoaiPhong.DisplayMember = "TenLoaiPhong";
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            try
            {
                var phongService = new PhongService().GetNhaTro();
                cmbMaNhaTro(phongService);
                var loaiPhong = new PhongService().GetLoaiPhong();
                cmbLoaiPhong(loaiPhong);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            loadPhong();
            loadLoaiPhong();
            loadNhaTro();
        }
        private void dgvNhaTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvNhaTro.Rows[e.RowIndex];
                tbxMaNhaTro.Text = row.Cells[0].Value.ToString();
                tbxDiaChiNhaTro.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvPhong.Rows[e.RowIndex];
                tbxMaPhong.Text = row.Cells[0].Value.ToString();
                tbxTenPhong.Text = row.Cells[1].Value.ToString();
                cbxHienTrang.Text = row.Cells[2].Value.ToString();
                tbxSoLuong.Text = row.Cells[3].Value.ToString();
                cbxLoaiPhong.Text = row.Cells[4].Value.ToString();
                cbxMaNhaTro.Text = row.Cells[5].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvLoaiPhong.Rows[e.RowIndex];
                tbxMaLP.Text = row.Cells[0].Value.ToString();
                tbxDienTichLP.Text = row.Cells[1].Value.ToString();
                tbxTenLP.Text = row.Cells[2].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool checkInputNhaTro(int i)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            PhongService phongService = new PhongService();
            try
            {
                if (string.IsNullOrEmpty(tbxMaNhaTro.Text))
                {
                    MessageBox.Show("Mã nhà trọ không được để trống");
                    tbxMaNhaTro.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(tbxDiaChiNhaTro.Text))
                {
                    MessageBox.Show("Địa chỉ nhà trọ không được để trống");
                    tbxDiaChiNhaTro.Focus();
                    return false;
                }
                if (i == 1) {
                    foreach (var item in context.NhaTroes)
                    {
                        if (item.MaNhaTro == int.Parse(tbxMaNhaTro.Text))
                        {
                            MessageBox.Show("Mã nhà trọ đã tồn tại");
                            tbxMaNhaTro.Focus();
                            return false;
                        }
                    }
                }
                else if (i == 2)
                {
                    bool maNhaTroExists = phongService.GetNhaTro().Any(item => tbxMaNhaTro.Text == item.MaNhaTro.ToString());
                    if (!maNhaTroExists)
                    {
                        MessageBox.Show("Mã nha tro không tồn tại");
                        return false;
                    }
                    return true;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        private void btnThemNT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkInputNhaTro(1))
                {
                    return;
                }
                NhaTro nhaTro = new NhaTro();
                nhaTro.MaNhaTro = int.Parse(tbxMaNhaTro.Text);
                nhaTro.DiaChi = tbxDiaChiNhaTro.Text;
                PhongService phongService = new PhongService();
                phongService.AddNhaTro(nhaTro);
                MessageBox.Show("Thêm nhà trọ thành công");
                loadNhaTro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhatNT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkInputNhaTro(2))
                {
                    return;
                }
                NhaTro nhaTro = new NhaTro();
                nhaTro.MaNhaTro = int.Parse(tbxMaNhaTro.Text);
                nhaTro.DiaChi = tbxDiaChiNhaTro.Text;
                PhongService phongService = new PhongService();
                phongService.EditNhaTro(nhaTro);
                MessageBox.Show("Cập nhật nhà trọ thành công");
                loadNhaTro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaNT_Click(object sender, EventArgs e)
        {
            //xoa nha tro
            try
            {
                if (!checkInputNhaTro(2))
                {
                    return;
                }
                //xacs nhan xoa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà trọ này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                PhongService phongService = new PhongService();
                phongService.DeleteNhaTro(int.Parse(tbxMaNhaTro.Text));
                MessageBox.Show("Xóa nhà trọ thành công");
                loadNhaTro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool checkLoaiPhong(int i)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            PhongService phongService = new PhongService();
            try
            {
                if (string.IsNullOrEmpty(tbxMaLP.Text))
                {
                    MessageBox.Show("Mã loại phòng không được để trống");
                    tbxMaLP.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(tbxTenLP.Text))
                {
                    MessageBox.Show("Tên loại phòng không được để trống");
                    tbxTenLP.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(tbxDienTichLP.Text))
                {
                    MessageBox.Show("Diện tích loại phòng không được để trống");
                    tbxDienTichLP.Focus();
                    return false;
                }
                if (i == 1)
                {
                    foreach (var item in context.LoaiPhongs)
                    {
                        if (item.MaLoaiPhong == int.Parse(tbxMaLP.Text))
                        {
                            MessageBox.Show("Mã loại phòng đã tồn tại");
                            tbxMaLP.Focus();
                            return false;
                        }
                    }
                }
                else if (i == 2)
                {
                    bool maLoaiPhongExists = phongService.GetLoaiPhong().Any(item => tbxMaLP.Text == item.MaLoaiPhong.ToString());
                    if (!maLoaiPhongExists)
                    {
                        MessageBox.Show("Mã loại phòng không tồn tại");
                        return false;
                    }
                    return true;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void btnThemLP_Click(object sender, EventArgs e)
        {
            //them loai phong
            try
            {
                if (!checkLoaiPhong(1))
                {
                    return;
                }
                LoaiPhong loaiPhong = new LoaiPhong();
                loaiPhong.MaLoaiPhong = int.Parse(tbxMaLP.Text);
                loaiPhong.TenLoaiPhong = tbxTenLP.Text;
                loaiPhong.DienTich = double.Parse(tbxDienTichLP.Text);
                PhongService phongService = new PhongService();
                phongService.AddLoaiPhong(loaiPhong);
                MessageBox.Show("Thêm loại phòng thành công");
                loadLoaiPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhatLP_Click(object sender, EventArgs e)
        {
            //cap nhat loai phong
            try
            {
                if (!checkLoaiPhong(2))
                {
                    return;
                }
                LoaiPhong loaiPhong = new LoaiPhong();
                loaiPhong.MaLoaiPhong = int.Parse(tbxMaLP.Text);
                loaiPhong.TenLoaiPhong = tbxTenLP.Text;
                loaiPhong.DienTich = double.Parse(tbxDienTichLP.Text);
                PhongService phongService = new PhongService();
                phongService.EditLoaiPhong(loaiPhong);
                //kiem tra loai phong da duoc cap nhat chua

                MessageBox.Show("Cập nhật loại phòng thành công");
                loadLoaiPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaLP_Click(object sender, EventArgs e)
        {
            //xoa loai phong
            try
            {
                if (!checkLoaiPhong(2))
                {
                    return;
                }
                //xacs nhan xoa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa loại phòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                PhongService phongService = new PhongService();
                phongService.DeleteLoaiPhong(int.Parse(tbxMaLP.Text));
                MessageBox.Show("Xóa loại phòng thành công");
                loadLoaiPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            //Xoa trang textbox
            this.tbxMaPhong.ResetText();
            this.tbxTenPhong.ResetText();
            this.tbxSoLuong.ResetText();
            this.cbxHienTrang.ResetText();
            this.tbxDienTichLP.ResetText();
            this.tbxMaLP.ResetText();
            this.tbxDiaChiNhaTro.ResetText();
            this.tbxMaNhaTro.ResetText();
            this.tbxTenLP.ResetText();
            loadNhaTro();
            loadLoaiPhong();
            loadPhong();
        }

        private bool checkInputPhong(int i)
        {
            //kiem tra thong tin phong
            try
            {
                if (string.IsNullOrEmpty(tbxMaPhong.Text))
                {
                    MessageBox.Show("Mã phòng không được để trống");
                    tbxMaPhong.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(tbxTenPhong.Text))
                {
                    MessageBox.Show("Tên phòng không được để trống");
                    tbxTenPhong.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(tbxSoLuong.Text))
                {
                    MessageBox.Show("Số lượng người không được để trống");
                    tbxSoLuong.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(cbxHienTrang.Text))
                {
                    MessageBox.Show("Hiện trạng không được để trống");
                    cbxHienTrang.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(cbxLoaiPhong.Text))
                {
                    MessageBox.Show("Loại phòng không được để trống");
                    cbxLoaiPhong.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(cbxMaNhaTro.Text))
                {
                    MessageBox.Show("Mã nhà trọ không được để trống");
                    cbxMaNhaTro.Focus();
                    return false;
                }
                if (i == 1)
                {
                    PhongService phongService = new PhongService();
                    bool maPhongExists = phongService.GetPhong().Any(item => tbxMaPhong.Text == item.MaPhong.ToString());
                    if (maPhongExists)
                    {
                        MessageBox.Show("Mã phòng đã tồn tại");
                        tbxMaPhong.Focus();
                        return false;
                    }
                }
                else if (i == 2)
                {
                    PhongService phongService = new PhongService();
                    bool maPhongExists = phongService.GetPhong().Any(item => tbxMaPhong.Text == item.MaPhong.ToString());
                    if (!maPhongExists)
                    {
                        MessageBox.Show("Mã phòng không tồn tại");
                        return false;
                    }
                    return true;
                }
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkInputPhong(1))
                {
                    return;
                }
                Phong phong = new Phong();
                phong.MaPhong = int.Parse(tbxMaPhong.Text);
                phong.TenPhong = tbxTenPhong.Text;
                phong.SoLuongNguoi = int.Parse(tbxSoLuong.Text);
                phong.HienTrang = cbxHienTrang.Text;
                phong.LoaiPhong.TenLoaiPhong = (cbxLoaiPhong.Text);
                phong.MaNhaTro = int.Parse(cbxMaNhaTro.Text);
                PhongService phongService = new PhongService();
                phongService.AddPhong(phong);
                MessageBox.Show("Thêm phòng thành công");
                loadPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkInputPhong(2))
                {
                    return;
                }
                Phong phong = new Phong();
                phong.MaPhong = int.Parse(tbxMaPhong.Text);
                phong.TenPhong = tbxTenPhong.Text;
                phong.SoLuongNguoi = int.Parse(tbxSoLuong.Text);
                phong.HienTrang = cbxHienTrang.Text;
                phong.LoaiPhong.TenLoaiPhong = (cbxLoaiPhong.Text);
                phong.MaNhaTro = int.Parse(cbxMaNhaTro.Text);
                PhongService phongService = new PhongService();
                phongService.EditPhong(phong);
                MessageBox.Show("Cập nhật phòng thành công");
                loadPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //xoa phong
            try
            {
                if (!checkInputPhong(2))
                {
                    return;
                }
                //xacs nhan xoa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                PhongService phongService = new PhongService();
                phongService.DeletePhong(int.Parse(tbxMaPhong.Text));
                MessageBox.Show("Xóa phòng thành công");
                loadPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
