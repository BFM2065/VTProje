﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VTProje
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VTProjeEntities : DbContext
    {
        public VTProjeEntities()
            : base("name=VTProjeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblArizaDetay> TblArizaDetay { get; set; }
        public virtual DbSet<TblDepartman> TblDepartman { get; set; }
        public virtual DbSet<TblKategori> TblKategori { get; set; }
        public virtual DbSet<TblKullanicilar> TblKullanicilar { get; set; }
        public virtual DbSet<TblMarka> TblMarka { get; set; }
        public virtual DbSet<TblModel> TblModel { get; set; }
        public virtual DbSet<TblMusteri> TblMusteri { get; set; }
        public virtual DbSet<TblNotlar> TblNotlar { get; set; }
        public virtual DbSet<TblPersonel> TblPersonel { get; set; }
        public virtual DbSet<TblSatis> TblSatis { get; set; }
        public virtual DbSet<TblTSUrunKabul> TblTSUrunKabul { get; set; }
        public virtual DbSet<TblUrun> TblUrun { get; set; }
    }
}