//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Otelwebsitesi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OtelDBEntities : DbContext
    {
        public OtelDBEntities()
            : base("name=OtelDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admin { get; set; }
        public virtual DbSet<hakkimizda> hakkimizda { get; set; }
        public virtual DbSet<insankaynaklari> insankaynaklari { get; set; }
        public virtual DbSet<insankaynaklaridetay> insankaynaklaridetay { get; set; }
        public virtual DbSet<odalardetay> odalardetay { get; set; }
        public virtual DbSet<odalar�m�z> odalar�m�z { get; set; }
        public virtual DbSet<Restuarant> Restuarant { get; set; }
        public virtual DbSet<restuarantdetay> restuarantdetay { get; set; }
        public virtual DbSet<rezervasyonumuz> rezervasyonumuz { get; set; }
        public virtual DbSet<Salonlar> Salonlar { get; set; }
        public virtual DbSet<salonlarimizdetay> salonlarimizdetay { get; set; }
        public virtual DbSet<sliderbilgi> sliderbilgi { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Uye> Uye { get; set; }
    }
}