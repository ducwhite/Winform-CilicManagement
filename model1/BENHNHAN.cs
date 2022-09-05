namespace Quanlyphongkham.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BENHNHAN")]
    public partial class BENHNHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BENHNHAN()
        {
            HOADONTHANHTOANs = new HashSet<HOADONTHANHTOAN>();
            PHIEUCANLAMSANGs = new HashSet<PHIEUCANLAMSANG>();
            PHIEUKHAMBENHs = new HashSet<PHIEUKHAMBENH>();
        }

        [Key]
        [StringLength(5)]
        public string MABN { get; set; }

        [StringLength(40)]
        public string TENBN { get; set; }

        [StringLength(4)]
        public string GIOITINH { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(30)]
        public string NGHENGHIEP { get; set; }

        [Required]
        [StringLength(4)]
        public string MADT { get; set; }

        public virtual DANTOC DANTOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONTHANHTOAN> HOADONTHANHTOANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUCANLAMSANG> PHIEUCANLAMSANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKHAMBENH> PHIEUKHAMBENHs { get; set; }
    }
}
