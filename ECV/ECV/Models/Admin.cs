namespace ECV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        public int AID { get; set; }

        [StringLength(150)]
        public string ka { get; set; }

        [StringLength(150)]
        public string pw { get; set; }

        [StringLength(150)]
        public string songiris { get; set; }
    }
}
