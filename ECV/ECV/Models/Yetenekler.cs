namespace ECV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yetenekler")]
    public partial class Yetenekler
    {
        [Key]
        public int YID { get; set; }

        [StringLength(150)]
        public string adi { get; set; }

        [StringLength(50)]
        public string yüzde { get; set; }
    }
}
