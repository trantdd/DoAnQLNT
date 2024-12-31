namespace DAL.DBQuanLyNhaTro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BangGia")]
    public partial class BangGia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBG { get; set; }

        public double? DonGia { get; set; }

        public int MaPhong { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
