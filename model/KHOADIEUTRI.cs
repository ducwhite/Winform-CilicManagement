namespace Quanlyphongkham.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHOADIEUTRI")]
    public partial class KHOADIEUTRI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOADIEUTRI()
        {
            BACSies = new HashSet<BACSY>();
        }

        [Key]
        [StringLength(4)]
        public string MAKHOA { get; set; }

        [StringLength(100)]
        public string TENKHOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BACSY> BACSies { get; set; }
    }
}
