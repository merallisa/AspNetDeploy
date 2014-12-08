//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetDeploy.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Environment
    {
        public Environment()
        {
            this.Machines = new HashSet<Machine>();
            this.Publications = new HashSet<Publication>();
            this.Properties = new HashSet<EnvironmentProperty>();
            this.PreviousEnvironment = new HashSet<Environment>();
            this.NextEnvironment = new HashSet<Environment>();
            this.DataFieldValues = new HashSet<DataFieldValue>();
            this.ApprovedPackages = new HashSet<PackageApprovedOnEnvironment>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Machine> Machines { get; set; }
        public virtual ICollection<Publication> Publications { get; set; }
        public virtual ICollection<EnvironmentProperty> Properties { get; set; }
        public virtual ICollection<Environment> PreviousEnvironment { get; set; }
        public virtual ICollection<Environment> NextEnvironment { get; set; }
        public virtual ICollection<DataFieldValue> DataFieldValues { get; set; }
        public virtual ICollection<PackageApprovedOnEnvironment> ApprovedPackages { get; set; }
    }
}