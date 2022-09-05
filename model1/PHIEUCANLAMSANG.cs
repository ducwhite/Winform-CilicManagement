namespace Quanlyphongkham.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUCANLAMSANG")]
    public partial class PHIEUCANLAMSANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUCANLAMSANG()
        {
            CT_HOADON = new HashSet<CT_HOADON>();
            DICHVUs = new HashSet<DICHVU>();
        }

        [Key]
        [StringLength(7)]
        public string MAPCLS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAYLAP { get; set; }

        [Required]
        [StringLength(5)]
        public string MABN { get; set; }

        public virtual BENHNHAN BENHNHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON> CT_HOADON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DICHVU> DICHVUs { get; set; }
    }
}
