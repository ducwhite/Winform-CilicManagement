namespace Quanlyphongkham.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PHIEUNHAPTHUOC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string MAPNT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MATHUOC { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string MANCC { get; set; }

        public int SOLUONG { get; set; }

        [Column(TypeName = "money")]
        public decimal? DONGIA { get; set; }

        [StringLength(10)]
        public string DONVITINH { get; set; }

        public virtual CT_CungCapThuoc CT_CungCapThuoc { get; set; }

        public virtual PHIEUNHAPTHUOC PHIEUNHAPTHUOC { get; set; }
    }
}
