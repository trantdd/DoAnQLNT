using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBQuanLyNhaTro;

namespace BUS
{
    public class TaiKhoanService
    {
        public List<TaiKhoan> GetAll()
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.TaiKhoans.ToList();
        }
        //Lấy danh sách tài khoản theo tên tài khoản và mật khẩu
        public TaiKhoan GetByTenTKAndMatKhau(string tenTK, string matKhau)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.TaiKhoans.SingleOrDefault(tk => tk.TenTK == tenTK && tk.MatKhau == matKhau);
        }
        //Thêm tài khoản
        public void Add(TaiKhoan tk)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            context.TaiKhoans.Add(tk);
            context.SaveChanges();
        }

        //Sửa tài khoản
        public void Edit(TaiKhoan tk)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            TaiKhoan tkEdit = context.TaiKhoans.Find(tk.TenTK);
            if (tkEdit != null)
            {
                tkEdit.MatKhau = tk.MatKhau;
                context.SaveChanges();
            }
        }
        //Xóa tài khoản
        public void Delete(string tenTK)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            TaiKhoan tkDel = context.TaiKhoans.Find(tenTK);
            if (tkDel != null)
            {
                context.TaiKhoans.Remove(tkDel);
                context.SaveChanges();
            }
        }
        //Lấy danh sách tài khoản theo tên tài khoản
        public TaiKhoan GetByTenTK(string tenTK)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.TaiKhoans.SingleOrDefault(tk => tk.TenTK == tenTK);
        }
        // 
    }
}
