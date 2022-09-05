namespace Quanlyphongkham.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_TOATHUOC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MATOATHUOC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string MAPHIEUKQ { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string MAPHIEUKB { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string MATHUOC { get; set; }

        public int? SOLUONG { get; set; }

        public virtual THUOC THUOC { get; set; }

        public virtual TOATHUOC TOATHUOC { get; set; }
    }
}
