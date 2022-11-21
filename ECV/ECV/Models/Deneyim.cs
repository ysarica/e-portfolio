namespace ECV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Deneyim")]
    public partial class Deneyim
    {
        [Key]
        public int DID { get; set; }

        [StringLength(150)]
        public string firmaAdi { get; set; }

        [StringLength(150)]
        public string unvan { get; set; }

        [StringLength(150)]
        public string yil { get; set; }

        public string tecrübe { get; set; }
    }
}
