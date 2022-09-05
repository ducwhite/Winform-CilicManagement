namespace Quanlyphongkham.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THUOC")]
    public partial class THUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THUOC()
        {
            CT_CungCapThuoc = new HashSet<CT_CungCapThuoc>();
            CT_TOATHUOC = new HashSet<CT_TOATHUOC>();
        }

        [Key]
        [StringLength(5)]
        public string MATHUOC { get; set; }

        [Required]
        [StringLength(100)]
        public string TEN { get; set; }

        public int? SOLUONG { get; set; }

        [Column(TypeName = "money")]
        public decimal? DONGIA { get; set; }

        [StringLength(10)]
        public string DONVITINH { get; set; }

        [Required]
        [StringLength(5)]
        public string MALOAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_CungCapThuoc> CT_CungCapThuoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_TOATHUOC> CT_TOATHUOC { get; set; }

        public virtual LOAITHUOC LOAITHUOC { get; set; }
    }
}
