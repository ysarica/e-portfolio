namespace ECV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Surec")]
    public partial class Surec
    {
        [Key]
        public int SID { get; set; }

        [StringLength(150)]
        public string baslik { get; set; }

        public string aciklama { get; set; }
    }
}
