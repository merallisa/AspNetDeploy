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
    
    public partial class BundleVersion
    {
        public BundleVersion()
        {
            this.DeploymentStep = new HashSet<DeploymentStep>();
            this.ProjectVersions = new HashSet<ProjectVersion>();
            this.Package = new HashSet<Package>();
        }
    
        public int Id { get; set; }
        public int BundleId { get; set; }
        public string Name { get; set; }
    
        public virtual Bundle Bundle { get; set; }
        public virtual ICollection<DeploymentStep> DeploymentStep { get; set; }
        public virtual ICollection<ProjectVersion> ProjectVersions { get; set; }
        public virtual ICollection<Package> Package { get; set; }
    }
}