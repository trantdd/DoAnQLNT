using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBQuanLyNhaTro;

namespace BUS
{
    public class PhongService
    {
        // Lấy danh sách phòng
        public List<Phong> GetPhong()
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.Phongs.ToList();
        }
        // Lấy danh sách loại phòng
        public List<LoaiPhong> GetLoaiPhong()
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.LoaiPhongs.ToList();
        }
        //Lấy danh sachs nhà trọ
        public List<NhaTro> GetNhaTro()
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.NhaTroes.ToList();
        }
        //Lấy danh sách nhà trọ theo mã nhà trọ
        public NhaTro GetNhaTroByMa(int maNhaTro)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.NhaTroes.Find(maNhaTro);
        }
        //Them nha tro
        public void AddNhaTro(NhaTro nhaTro)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            context.NhaTroes.Add(nhaTro);
            context.SaveChanges();
        }
        //sua nha tro
        public void EditNhaTro(NhaTro nhaTro)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            NhaTro nhaTroEdit = context.NhaTroes.Find(nhaTro.MaNhaTro);
            nhaTroEdit.MaNhaTro = nhaTro.MaNhaTro;
            nhaTroEdit.DiaChi = nhaTro.DiaChi;
            context.SaveChanges();
        }
        //xoa nha tro
        public void DeleteNhaTro(int maNhaTro)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            NhaTro nhaTro = context.NhaTroes.Find(maNhaTro);
            context.NhaTroes.Remove(nhaTro);
            context.SaveChanges();
        }
        //Lấy danh sách loại phòng theo mã loại phòng
        public LoaiPhong GetLoaiPhongByMa(int maLoaiPhong)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.LoaiPhongs.Find(maLoaiPhong);
        }
        //Thêm loại phòng
        public void AddLoaiPhong(LoaiPhong loaiPhong)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            context.LoaiPhongs.Add(loaiPhong);
            context.SaveChanges();
        }
        // Cap nhat loai phong
        public void EditLoaiPhong(LoaiPhong loaiPhong)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            LoaiPhong loaiPhongEdit = context.LoaiPhongs.Find(loaiPhong.MaLoaiPhong);
            loaiPhongEdit.MaLoaiPhong = loaiPhong.MaLoaiPhong;
            loaiPhongEdit.TenLoaiPhong = loaiPhong.TenLoaiPhong;
            loaiPhongEdit.DienTich = loaiPhong.DienTich;
            context.SaveChanges();
        }
        //Xóa loại phòng
        public void DeleteLoaiPhong(int maLoaiPhong)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            LoaiPhong loaiPhong = context.LoaiPhongs.Find(maLoaiPhong);
            context.LoaiPhongs.Remove(loaiPhong);
            context.SaveChanges();
        }
        //Lấy danh sách phòng theo mã phòng
        public Phong GetPhongByMa(int maPhong)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            return context.Phongs.Find(maPhong);
        }
        //Thêm phòng
        public void AddPhong(Phong phong)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            context.Phongs.Add(phong);
            context.SaveChanges();
        }
        //Sửa phòng
        public void EditPhong(Phong phong)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            Phong phongEdit = context.Phongs.Find(phong.MaPhong);
            phongEdit.MaPhong = phong.MaPhong;
            phongEdit.TenPhong = phong.TenPhong;
            phongEdit.HienTrang = phong.HienTrang;
            phongEdit.SoLuongNguoi = phong.SoLuongNguoi;
            phongEdit.MaLoaiPhong = phong.MaLoaiPhong;
            phongEdit.MaNhaTro = phong.MaNhaTro;
        }
        //Xóa phòng
        public void DeletePhong(int maPhong)
        {
            QuanLyNhaTroContext context = new QuanLyNhaTroContext();
            Phong phong = context.Phongs.Find(maPhong);
            context.Phongs.Remove(phong);
            context.SaveChanges();
        }
    }
    }
