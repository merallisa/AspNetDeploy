﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebUI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AspNetDeployEntities : DbContext
    {
        public AspNetDeployEntities()
            : base("name=AspNetDeployEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Environment> Environment { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Machine> Machine { get; set; }
        public virtual DbSet<MachineRole> MachineRole { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectConfigurationField> ProjectConfigurationField { get; set; }
        public virtual DbSet<ProjectConfigurationValue> ProjectConfigurationValue { get; set; }
        public virtual DbSet<SourceControl> SourceControl { get; set; }
        public virtual DbSet<SourceControlProperty> SourceControlProperty { get; set; }
    }
}
