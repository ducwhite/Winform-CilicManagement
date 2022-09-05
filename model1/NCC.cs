namespace Quanlyphongkham.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NCC")]
    public partial class NCC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NCC()
        {
            CT_CungCapThuoc = new HashSet<CT_CungCapThuoc>();
        }

        [Key]
        [StringLength(6)]
        public string MANCC { get; set; }

        [StringLength(100)]
        public string TENNCC { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(60)]
        public string WEBSITE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_CungCapThuoc> CT_CungCapThuoc { get; set; }
    }
}
