namespace DAL.DBQuanLyNhaTro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Khach")]
    public partial class Khach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Khach()
        {
            HopDongThues = new HashSet<HopDongThue>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaKhach { get; set; }

        [Required]
        [StringLength(100)]
        public string TenKhach { get; set; }

        [StringLength(50)]
        public string CMND { get; set; }

        public int? GioiTinh { get; set; }

        [StringLength(100)]
        public string DiaChiKhach { get; set; }

        [StringLength(100)]
        public string NgheNghiep { get; set; }

        [StringLength(50)]
        public string SdtKhach { get; set; }

        [Column(TypeName = "image")]
        public byte[] HinhAnhK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDongThue> HopDongThues { get; set; }
    }
}
