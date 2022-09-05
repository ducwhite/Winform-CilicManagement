namespace Quanlyphongkham.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOANBS")]
    public partial class TAIKHOANB
    {
        [Key]
        [Column(Order = 0)]
        public int ID_BS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MABS { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        public virtual BACSY BACSY { get; set; }
    }
}
