﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinPro1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TrenBiletiSatisSistemiEntities5 : DbContext
    {
        public TrenBiletiSatisSistemiEntities5()
            : base("name=TrenBiletiSatisSistemiEntities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Biletler> Biletler { get; set; }
        public virtual DbSet<GiseGorevlileri> GiseGorevlileri { get; set; }
        public virtual DbSet<Seferler> Seferler { get; set; }
        public virtual DbSet<Yoneticiler> Yoneticiler { get; set; }
    }
}
