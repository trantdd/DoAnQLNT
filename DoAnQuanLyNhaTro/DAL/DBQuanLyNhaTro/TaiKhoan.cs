namespace DAL.DBQuanLyNhaTro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(100)]
        public string TenTK { get; set; }

        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; }
    }
}
