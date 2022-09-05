namespace Quanlyphongkham.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NV")]
    public partial class NV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NV()
        {
            HOADONTHANHTOANs = new HashSet<HOADONTHANHTOAN>();
            PHIEUKHAMBENHs = new HashSet<PHIEUKHAMBENH>();
            PHIEUNHAPTHUOCs = new HashSet<PHIEUNHAPTHUOC>();
        }

        [Key]
        [StringLength(5)]
        public string MANV { get; set; }

        [StringLength(40)]
        public string TENNV { get; set; }

        [StringLength(4)]
        public string GIOITINH { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NAMSINH { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [Required]
        [StringLength(4)]
        public string MADT { get; set; }

        [Required]
        [StringLength(2)]
        public string MACV { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        public virtual DANTOC DANTOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONTHANHTOAN> HOADONTHANHTOANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKHAMBENH> PHIEUKHAMBENHs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAPTHUOC> PHIEUNHAPTHUOCs { get; set; }
    }
}
