namespace db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TheLoaiDauSach")]
    public partial class TheLoaiDauSach
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaDauSach { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaTheLoai { get; set; }

        public int? ViTriVaiTro { get; set; }

        public virtual DauSach DauSach { get; set; }

        public virtual TheLoai TheLoai { get; set; }
    }
}
