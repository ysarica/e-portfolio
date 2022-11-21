namespace ECV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hizmetler")]
    public partial class Hizmetler
    {
        [Key]
        public int HID { get; set; }

        [StringLength(50)]
        public string icon { get; set; }

        [StringLength(150)]
        public string baslik { get; set; }

        public string aciklama { get; set; }
    }
}
