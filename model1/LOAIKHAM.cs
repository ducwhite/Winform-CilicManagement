namespace Quanlyphongkham.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIKHAM")]
    public partial class LOAIKHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIKHAM()
        {
            PHIEUKHAMBENHs = new HashSet<PHIEUKHAMBENH>();
        }

        [Key]
        [StringLength(5)]
        public string MALOAIK { get; set; }

        [Required]
        [StringLength(100)]
        public string TEN { get; set; }

        [Column(TypeName = "money")]
        public decimal GIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKHAMBENH> PHIEUKHAMBENHs { get; set; }
    }
}
