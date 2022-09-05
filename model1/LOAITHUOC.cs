namespace Quanlyphongkham.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAITHUOC")]
    public partial class LOAITHUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAITHUOC()
        {
            THUOCs = new HashSet<THUOC>();
        }

        [Key]
        [StringLength(5)]
        public string MALOAI { get; set; }

        [Required]
        [StringLength(100)]
        public string TENLOAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THUOC> THUOCs { get; set; }
    }
}
