﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WassetPortal_DAL.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class WassetPortalDBEntities : DbContext
    {
        public WassetPortalDBEntities()
            : base("name=WassetPortalDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User_Role> User_Role { get; set; }
        public virtual DbSet<UserAction> UserActions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
    
        public virtual int USP_InsertPatientInfo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertPatientInfo");
        }
    }
}
