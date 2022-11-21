namespace ECV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GelenMesaj")]
    public partial class GelenMesaj
    {
        [Key]
        public int MID { get; set; }

        [StringLength(150)]
        public string adSoyad { get; set; }

        [StringLength(50)]
        public string mail { get; set; }

        [StringLength(50)]
        public string tel { get; set; }

        [StringLength(150)]
        public string konu { get; set; }

        public string mesaj { get; set; }

        [StringLength(50)]
        public string tarih { get; set; }
    }
}
