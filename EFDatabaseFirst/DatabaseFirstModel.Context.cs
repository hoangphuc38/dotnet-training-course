﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFDatabaseFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MovieDBEntities : DbContext
    {
        public MovieDBEntities()
            : base("name=MovieDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual ObjectResult<CustomerInformation_Result> CustomerInformation()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomerInformation_Result>("CustomerInformation");
        }
    
        public virtual ObjectResult<MovieInformation_Result> MovieInformation()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MovieInformation_Result>("MovieInformation");
        }
    }
}
