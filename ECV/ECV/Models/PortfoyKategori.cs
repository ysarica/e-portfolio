namespace ECV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PortfoyKategori")]
    public partial class PortfoyKategori
    {
        [Key]
        public int PKID { get; set; }

        [StringLength(150)]
        public string kategoriAdi { get; set; }
    }
}
