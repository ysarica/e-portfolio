namespace ECV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Portfoy")]
    public partial class Portfoy
    {
        [Key]
        public int PID { get; set; }

        [StringLength(150)]
        public string kategori { get; set; }

        [StringLength(150)]
        public string resim { get; set; }

        [StringLength(150)]
        public string kime { get; set; }

        [StringLength(150)]
        public string tarih { get; set; }

        [StringLength(50)]
        public string süre { get; set; }

        public string aciklama { get; set; }
    }
}
