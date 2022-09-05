namespace Quanlyphongkham.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BACSY")]
    public partial class BACSY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BACSY()
        {
            PHIEUKETQUAs = new HashSet<PHIEUKETQUA>();
            TAIKHOANBS = new HashSet<TAIKHOANB>();
        }

        [Key]
        [StringLength(5)]
        public string MABS { get; set; }

        [StringLength(40)]
        public string TENBS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(4)]
        public string GIOITINH { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [Required]
        [StringLength(4)]
        public string MADT { get; set; }

        [Required]
        [StringLength(4)]
        public string MAKHOA { get; set; }

        [Required]
        [StringLength(5)]
        public string MAPK { get; set; }

        public virtual DANTOC DANTOC { get; set; }

        public virtual KHOADIEUTRI KHOADIEUTRI { get; set; }

        public virtual PHONGKHAM PHONGKHAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKETQUA> PHIEUKETQUAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOANB> TAIKHOANBS { get; set; }
    }
}
