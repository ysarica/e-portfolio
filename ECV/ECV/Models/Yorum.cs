namespace ECV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yorum")]
    public partial class Yorum
    {
        [Key]
        public int YID { get; set; }

        [StringLength(150)]
        public string adSoyad { get; set; }

        [Column("yorum")]
        public string yorum1 { get; set; }

        [StringLength(50)]
        public string unvan { get; set; }
    }
}
