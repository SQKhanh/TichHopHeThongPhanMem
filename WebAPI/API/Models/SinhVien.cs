namespace API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        [StringLength(10)]
        public string code { get; set; }

        [StringLength(30)]
        public string fullname { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday { get; set; }
    }
}
