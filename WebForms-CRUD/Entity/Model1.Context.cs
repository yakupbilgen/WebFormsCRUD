﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebForms_CRUD.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBWebFormsCRUDEntities : DbContext
    {
        public DBWebFormsCRUDEntities()
            : base("name=DBWebFormsCRUDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBLCategory> TBLCategory { get; set; }
        public virtual DbSet<TBLProduct> TBLProduct { get; set; }
        public virtual DbSet<TBLUser> TBLUser { get; set; }
    }
}