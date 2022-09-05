namespace Quanlyphongkham.model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        [StringLength(25)]
        public string TENTK { get; set; }

        [Required]
        [StringLength(25)]
        public string MATKHAUTK { get; set; }

        [Required]
        [StringLength(10)]
        public string QUYENTK { get; set; }

        public virtual PHANQUYEN PHANQUYEN { get; set; }
    }
}
