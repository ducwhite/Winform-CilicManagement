namespace Quanlyphongkham.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_SDDV
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string MAPCLS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MADV { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual DICHVU DICHVU1 { get; set; }

        public virtual PHIEUCANLAMSANG PHIEUCANLAMSANG { get; set; }

        public virtual PHIEUCANLAMSANG PHIEUCANLAMSANG1 { get; set; }
    }
}
