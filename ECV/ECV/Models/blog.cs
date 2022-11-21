namespace ECV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("blog")]
    public partial class blog
    {
        [Key]
        public int BID { get; set; }

        [StringLength(150)]
        public string kategoriAd { get; set; }

        [StringLength(250)]
        public string resim { get; set; }

        [StringLength(150)]
        public string baslik { get; set; }

        [StringLength(250)]
        public string tarih { get; set; }

        public string ozetaciklama { get; set; }

        public string aciklama { get; set; }
    }
}
