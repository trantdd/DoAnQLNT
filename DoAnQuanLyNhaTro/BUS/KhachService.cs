using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBQuanLyNhaTro;

namespace BUS
{
    public class KhachService
    {
        //Lấy danh sách khách
        public List<Khach> GetKhach()
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.Khaches.ToList();
        }
        //Lấy khách theo mã
        public Khach GetKhachByMa(int maKhach)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.Khaches.Find(maKhach);
        }
        //Thêm khách
        public void AddKhach(Khach khach)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            context.Khaches.Add(khach);
            context.SaveChanges();
        }
        //Sửa khách
        public void EditKhach(Khach khach)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            Khach khachEdit = context.Khaches.Find(khach.MaKhach);
            khachEdit.TenKhach = khach.TenKhach;
            khachEdit.CMND = khach.CMND;
            khachEdit.GioiTinh = khach.GioiTinh;
            khachEdit.DiaChiKhach = khach.DiaChiKhach;
            khachEdit.NgheNghiep = khach.NgheNghiep;
            khachEdit.SdtKhach = khach.SdtKhach;
            khachEdit.HinhAnhK = khach.HinhAnhK;
            context.SaveChanges();
        }
        //Xóa khách
        public void DeleteKhach(int maKhach)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();

            Khach khach = context.Khaches.Find(maKhach);
            context.Khaches.Remove(khach);
            context.SaveChanges();
        }
        //Tim kiem khach theo ten
        public List<Khach> SearchTenKhach(string tenKhach)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.Khaches.Where(khach => khach.TenKhach.Contains(tenKhach)).ToList();
        }
        //tim kiem khach theo ma khach
        public List<Khach> SearchMaKhach(int maKhach)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.Khaches.Where(khach => khach.MaKhach == maKhach).ToList();
        }
    }
}
