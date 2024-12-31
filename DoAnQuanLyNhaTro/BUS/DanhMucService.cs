using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBQuanLyNhaTro;

namespace BUS
{
    public class DanhMucService
    {
        //Lấy danh sách dịch vụ
        public List<DichVu> GetDichVu()
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.DichVus.ToList();
        }
        
        public DichVu GetDichVu1(int MaDV, string TenDV, decimal GiaDV)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.DichVus.SingleOrDefault(dv => dv.MaDV == MaDV && dv.TenDV == TenDV && dv.GiaDV == GiaDV);
        }
        //Lấy danh sách thiết bị
        public List<ThietBi> GetThietBi()
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.ThietBis.ToList();
        }
        //Lấy danh sách loại phòng
        public List<LoaiPhong> GetLoaiPhong()
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.LoaiPhongs.ToList();
        }
    }
}
