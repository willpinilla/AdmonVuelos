﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiVuelosEntrantes.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VuelosEntities : DbContext
    {
        public VuelosEntities()
            : base("name=VuelosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAerolineas> tblAerolineas { get; set; }
        public virtual DbSet<tblCiudades> tblCiudades { get; set; }
        public virtual DbSet<tblEstadoVuelo> tblEstadoVuelo { get; set; }
        public virtual DbSet<tblNumeroVuelo> tblNumeroVuelo { get; set; }
        public virtual DbSet<tblVuelos> tblVuelos { get; set; }
    }
}
