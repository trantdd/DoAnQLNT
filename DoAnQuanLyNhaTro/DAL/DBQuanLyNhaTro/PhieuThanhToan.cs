namespace DAL.DBQuanLyNhaTro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuThanhToan")]
    public partial class PhieuThanhToan
    {
        [Key]
        public int MaPhieu { get; set; }

        public int ThangSuDung { get; set; }

        public decimal? ThanhTien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThanhToan { get; set; }

        public int MaPhong { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
