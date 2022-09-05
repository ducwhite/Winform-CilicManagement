namespace Quanlyphongkham.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUKETQUA")]
    public partial class PHIEUKETQUA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUKETQUA()
        {
            TOATHUOCs = new HashSet<TOATHUOC>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string MAPHIEUKQ { get; set; }

        [StringLength(100)]
        public string NOIDUNG { get; set; }

        [Required]
        [StringLength(5)]
        public string MABS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string MAPHIEUKB { get; set; }

        [StringLength(100)]
        public string TienSu { get; set; }

        public int? MACH { get; set; }

        public int? NHIPTHO { get; set; }

        public int? HUYETAP { get; set; }

        public int? NHIETDO { get; set; }

        public int? CANNANG { get; set; }

        public int? CHIEUCAO { get; set; }

        [StringLength(100)]
        public string CHUANDOAN { get; set; }

        [StringLength(100)]
        public string KETLUAN { get; set; }

        public virtual BACSY BACSY { get; set; }

        public virtual PHIEUKHAMBENH PHIEUKHAMBENH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOATHUOC> TOATHUOCs { get; set; }
    }
}
