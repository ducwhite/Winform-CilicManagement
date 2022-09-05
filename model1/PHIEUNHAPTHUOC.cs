namespace Quanlyphongkham.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUNHAPTHUOC")]
    public partial class PHIEUNHAPTHUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUNHAPTHUOC()
        {
            CT_PHIEUNHAPTHUOC = new HashSet<CT_PHIEUNHAPTHUOC>();
        }

        [Key]
        [StringLength(6)]
        public string MAPNT { get; set; }

        [Required]
        [StringLength(5)]
        public string MANV { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAYLAP { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONGTIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUNHAPTHUOC> CT_PHIEUNHAPTHUOC { get; set; }

        public virtual NV NV { get; set; }
    }
}
