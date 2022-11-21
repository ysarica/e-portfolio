namespace ECV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SiteAyar")]
    public partial class SiteAyar
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string title { get; set; }

        [StringLength(450)]
        public string aciklama { get; set; }

        public string keywords { get; set; }

        [StringLength(50)]
        public string anarenk { get; set; }

        [StringLength(50)]
        public string ararenk { get; set; }

        [StringLength(50)]
        public string ozellik1 { get; set; }

        [StringLength(50)]
        public string ozellik2 { get; set; }

        [StringLength(50)]
        public string ozellik3 { get; set; }

        public string blog { get; set; }
        public string hizmet { get; set; }
        public string portfoy { get; set; }
        public string iletisim { get; set; }

    }
}
