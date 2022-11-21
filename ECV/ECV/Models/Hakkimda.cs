namespace ECV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hakkimda")]
    public partial class Hakkimda
    {
        [Key]
        public int HID { get; set; }

        [StringLength(250)]
        public string pResim { get; set; }

        [Column("hakkimda")]
        public string hakkimda1 { get; set; }

        [StringLength(150)]
        public string adSoyad { get; set; }

        [StringLength(50)]
        public string dogumYili { get; set; }

        [StringLength(150)]
        public string mail { get; set; }

        [StringLength(50)]
        public string konum { get; set; }

        [StringLength(150)]
        public string cvLink { get; set; }

        [StringLength(150)]
        public string sayfaBaslik { get; set; }
    }
}
