namespace Quanlyphongkham.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_CungCapThuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CT_CungCapThuoc()
        {
            CT_PHIEUNHAPTHUOC = new HashSet<CT_PHIEUNHAPTHUOC>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MATHUOC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string MANCC { get; set; }

        public virtual NCC NCC { get; set; }

        public virtual THUOC THUOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUNHAPTHUOC> CT_PHIEUNHAPTHUOC { get; set; }
    }
}
