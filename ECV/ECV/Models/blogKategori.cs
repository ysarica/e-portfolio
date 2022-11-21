namespace ECV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("blogKategori")]
    public partial class blogKategori
    {
        [Key]
        public int BKID { get; set; }

        [Required]
        [StringLength(150)]
        public string kategoriAdi { get; set; }
    }
}
