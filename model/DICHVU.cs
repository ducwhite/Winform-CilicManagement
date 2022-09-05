namespace Quanlyphongkham.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICHVU")]
    public partial class DICHVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVU()
        {
            CT_SDDV = new HashSet<CT_SDDV>();
            CT_SDDV1 = new HashSet<CT_SDDV>();
        }

        [Key]
        [StringLength(5)]
        public string MADV { get; set; }

        [StringLength(100)]
        public string TENDV { get; set; }

        [StringLength(100)]
        public string MOTA { get; set; }

        [StringLength(10)]
        public string DONVITINH { get; set; }

        [Column(TypeName = "money")]
        public decimal? GIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_SDDV> CT_SDDV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_SDDV> CT_SDDV1 { get; set; }
    }
}
