namespace Quanlyphongkham.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TOATHUOC")]
    public partial class TOATHUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOATHUOC()
        {
            CT_HOADON = new HashSet<CT_HOADON>();
            CT_TOATHUOC = new HashSet<CT_TOATHUOC>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MATOATHUOC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string MAPHIEUKQ { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string MAPHIEUKB { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAYLAP { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONGTIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON> CT_HOADON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_TOATHUOC> CT_TOATHUOC { get; set; }

        public virtual PHIEUKETQUA PHIEUKETQUA { get; set; }
    }
}
