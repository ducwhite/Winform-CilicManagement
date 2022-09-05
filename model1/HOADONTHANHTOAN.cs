namespace Quanlyphongkham.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONTHANHTOAN")]
    public partial class HOADONTHANHTOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONTHANHTOAN()
        {
            CT_HOADON = new HashSet<CT_HOADON>();
        }

        [Key]
        [StringLength(5)]
        public string MAHD { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONGTIEN { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAYLAP { get; set; }

        [Required]
        [StringLength(5)]
        public string MANV { get; set; }

        [Required]
        [StringLength(5)]
        public string MABN { get; set; }

        public virtual BENHNHAN BENHNHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON> CT_HOADON { get; set; }

        public virtual NV NV { get; set; }
    }
}
