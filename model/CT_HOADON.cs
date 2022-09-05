namespace Quanlyphongkham.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_HOADON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MAHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MATOATHUOC { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(7)]
        public string MAPCLS { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string MAPHIEUKQ { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(6)]
        public string MAPHIEUKB { get; set; }

        public virtual HOADONTHANHTOAN HOADONTHANHTOAN { get; set; }

        public virtual PHIEUCANLAMSANG PHIEUCANLAMSANG { get; set; }

        public virtual TOATHUOC TOATHUOC { get; set; }
    }
}
