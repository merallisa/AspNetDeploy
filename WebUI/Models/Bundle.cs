//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Bundle
    {
        public Bundle()
        {
            this.Projects = new HashSet<Project>();
            this.DeploymentSteps = new HashSet<DeploymentStep>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<DeploymentStep> DeploymentSteps { get; set; }
    }
}