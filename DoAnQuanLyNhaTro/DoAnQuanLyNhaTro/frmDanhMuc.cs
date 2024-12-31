using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL.DBQuanLyNhaTro;

namespace DoAnQuanLyNhaTro
{
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            try
            {
                string tenDanhMuc = this.Text;
                switch(tenDanhMuc){
                    case "Dịch vụ":
                        DanhMucService dmService = new DanhMucService();
                        
                        List<DichVu> dichVuList = dmService.GetDichVu();
                        dgvDanhMuc.DataSource = dichVuList;
                        lblTen.Text = "Danh sách dịch vụ";
                        
                        dgvDanhMuc.Columns[0].HeaderText = "Mã dịch vụ";
                        dgvDanhMuc.Columns[1].HeaderText = "Tên dịch vụ";
                        dgvDanhMuc.Columns[2].HeaderText = "Gói dịch vụ";
                        dgvDanhMuc.Columns[3].Visible = false;
                        //Sửa lại sao lại có cột chi tiết dich vụ

                        break;
                    case "Thiết bị":
                        DanhMucService dmService1 = new DanhMucService();
                        List<ThietBi> thietBiList = dmService1.GetThietBi();
                        dgvDanhMuc.DataSource = thietBiList;
                        lblTen.Text = "Danh sách thiết bị";
                        dgvDanhMuc.Columns[0].HeaderText = "Mã thiết bị";
                        dgvDanhMuc.Columns[1].HeaderText = "Tên thiết bị";
                        dgvDanhMuc.Columns[2].Visible = false;
                        break;
                    case "Loại phòng":
                        DanhMucService dmService2 = new DanhMucService();
                        List<LoaiPhong> loaiPhongList = dmService2.GetLoaiPhong();
                        dgvDanhMuc.DataSource = loaiPhongList;
                        lblTen.Text = "Danh sách loại phòng";
                        dgvDanhMuc.Columns[0].HeaderText = "Mã loại phòng";
                        dgvDanhMuc.Columns[1].HeaderText = "Tên loại phòng";
                        dgvDanhMuc.Columns[2].HeaderText = "Số lượng người";
                        dgvDanhMuc.Columns[3].HeaderText = "Giá phòng";
                        break;
                    case "Khách":
                        KhachService khachService = new KhachService();
                        List<Khach> khachList = khachService.GetKhach();
                        dgvDanhMuc.DataSource = khachList;
                        lblTen.Text = "Danh sách khách";
                        dgvDanhMuc.Columns[0].HeaderText = "Mã khách";
                        dgvDanhMuc.Columns[1].HeaderText = "Tên khách";
                        dgvDanhMuc.Columns[2].HeaderText = "Số CMND";
                        //Nếu gioi tinh = 1 thì là nam, ngược lại là nữ
                        dgvDanhMuc.Columns[3].HeaderText = "Giới tính";
                        
                        dgvDanhMuc.Columns[4].HeaderText = "Địa chỉ";
                        dgvDanhMuc.Columns[5].HeaderText = "Nghề nghiệp";
                        dgvDanhMuc.Columns[6].HeaderText = "Số điện thoại";
                        dgvDanhMuc.Columns[7].HeaderText = "Hình ảnh";
                        dgvDanhMuc.Columns[8].Visible = false;

                        break;
                    case "Phòng":
                        PhongService phongService = new PhongService();
                        List<Phong> phongList = phongService.GetPhong();
                        dgvDanhMuc.DataSource = phongList;
                        lblTen.Text = "Danh sách phòng";
                        dgvDanhMuc.Columns[0].HeaderText = "Mã phòng";
                        dgvDanhMuc.Columns[1].HeaderText = "Tên phòng";
                        dgvDanhMuc.Columns[2].HeaderText = "Hiện trạng";
                        dgvDanhMuc.Columns[3].HeaderText = "Số lượng người";
                        dgvDanhMuc.Columns[4].HeaderText = "Mã loại phòng";
                        dgvDanhMuc.Columns[5].HeaderText = "Mã nhà trọ";
                        //Chặn tất cả các cột tiếp theo
                        for (int i = 6; i < dgvDanhMuc.Columns.Count; i++)
                        {
                            dgvDanhMuc.Columns[i].Visible = false;
                        }

                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
