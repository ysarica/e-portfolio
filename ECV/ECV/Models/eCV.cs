namespace ECV.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class eCV : DbContext
    {
        public eCV()
            : base("name=eCV")
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<blog> blog { get; set; }
        public virtual DbSet<blogKategori> blogKategori { get; set; }
        public virtual DbSet<Deneyim> Deneyim { get; set; }
        public virtual DbSet<EgitimBilgi> EgitimBilgi { get; set; }
        public virtual DbSet<GelenMesaj> GelenMesaj { get; set; }
        public virtual DbSet<Hakkimda> Hakkimda { get; set; }
        public virtual DbSet<Hizmetler> Hizmetler { get; set; }
        public virtual DbSet<Hobiler> Hobiler { get; set; }
        public virtual DbSet<Portfoy> Portfoy { get; set; }
        public virtual DbSet<PortfoyKategori> PortfoyKategori { get; set; }
        public virtual DbSet<SiteAyar> SiteAyar { get; set; }
        public virtual DbSet<Sosyal> Sosyal { get; set; }
        public virtual DbSet<Surec> Surec { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Yetenekler> Yetenekler { get; set; }
        public virtual DbSet<Yorum> Yorum { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
