namespace Quanlyphongkham.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUKHAMBENH")]
    public partial class PHIEUKHAMBENH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUKHAMBENH()
        {
            PHIEUKETQUAs = new HashSet<PHIEUKETQUA>();
        }

        [Key]
        [StringLength(6)]
        public string MAPHIEUKB { get; set; }

        [Required]
        [StringLength(5)]
        public string MAPK { get; set; }

        [Required]
        [StringLength(5)]
        public string MALOAIK { get; set; }

        [Required]
        [StringLength(5)]
        public string MANV { get; set; }

        [Required]
        [StringLength(5)]
        public string MABN { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAYLAP { get; set; }

        [StringLength(200)]
        public string GHICHU { get; set; }

        public virtual BENHNHAN BENHNHAN { get; set; }

        public virtual LOAIKHAM LOAIKHAM { get; set; }

        public virtual NV NV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKETQUA> PHIEUKETQUAs { get; set; }

        public virtual PHONGKHAM PHONGKHAM { get; set; }
    }
}
