namespace Quanlyphongkham.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOANNV")]
    public partial class TAIKHOANNV
    {
        [Key]
        [Column(Order = 0)]
        public int ID_NV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MANV { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        public virtual NV NV { get; set; }
    }
}
