using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.DBQuanLyNhaTro
{
    public partial class QuanLyNhaTroContext : DbContext
    {
        public QuanLyNhaTroContext()
            : base("name=QuanLyNhaTroDB")
        {
        }

        public virtual DbSet<BangGia> BangGias { get; set; }
        public virtual DbSet<ChiTietHopDong> ChiTietHopDongs { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HopDongThue> HopDongThues { get; set; }
        public virtual DbSet<Khach> Khaches { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<NhaTro> NhaTroes { get; set; }
        public virtual DbSet<PhieuThanhToan> PhieuThanhToans { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThietBi> ThietBis { get; set; }
        public virtual DbSet<ChiTietDichVu> ChiTietDichVus { get; set; }
        public virtual DbSet<TrangBi> TrangBis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHopDong>()
                .HasMany(e => e.ChiTietDichVus)
                .WithRequired(e => e.ChiTietHopDong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.GiaDV)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.ChiTietDichVus)
                .WithRequired(e => e.DichVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HopDongThue>()
                .HasMany(e => e.ChiTietHopDongs)
                .WithRequired(e => e.HopDongThue)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khach>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<Khach>()
                .Property(e => e.SdtKhach)
                .IsUnicode(false);

            modelBuilder.Entity<Khach>()
                .HasMany(e => e.HopDongThues)
                .WithRequired(e => e.Khach)
                .HasForeignKey(e => e.MaKH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiPhong>()
                .HasMany(e => e.Phongs)
                .WithRequired(e => e.LoaiPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaTro>()
                .Property(e => e.DoanhThu)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NhaTro>()
                .HasMany(e => e.Phongs)
                .WithRequired(e => e.NhaTro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuThanhToan>()
                .Property(e => e.ThanhTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.BangGias)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.ChiTietHopDongs)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.PhieuThanhToans)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.TrangBis)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsFixedLength();

            modelBuilder.Entity<ThietBi>()
                .HasMany(e => e.TrangBis)
                .WithRequired(e => e.ThietBi)
                .WillCascadeOnDelete(false);
        }
    }
}
