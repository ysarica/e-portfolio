namespace ECV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hobiler")]
    public partial class Hobiler
    {
        [Key]
        public int HID { get; set; }

        [StringLength(150)]
        public string hobi { get; set; }

        [StringLength(150)]
        public string icon { get; set; }
    }
}
