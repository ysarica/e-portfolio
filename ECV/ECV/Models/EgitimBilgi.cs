namespace ECV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EgitimBilgi")]
    public partial class EgitimBilgi
    {
        [Key]
        public int EID { get; set; }

        [StringLength(250)]
        public string egitimTürü { get; set; }

        [StringLength(150)]
        public string bölüm { get; set; }

        [StringLength(150)]
        public string okul { get; set; }

        [StringLength(50)]
        public string yil { get; set; }
    }
}
