namespace Quanlyphongkham.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONGKHAM")]
    public partial class PHONGKHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONGKHAM()
        {
            BACSies = new HashSet<BACSY>();
            PHIEUKHAMBENHs = new HashSet<PHIEUKHAMBENH>();
        }

        [Key]
        [StringLength(5)]
        public string MAPK { get; set; }

        [Required]
        [StringLength(100)]
        public string TENPK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BACSY> BACSies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKHAMBENH> PHIEUKHAMBENHs { get; set; }
    }
}
