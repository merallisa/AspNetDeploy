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
    
    public partial class MachinePublicationLog
    {
        public int Id { get; set; }
        public int MachinePublicationId { get; set; }
        public MachinePublicationLogEvent Event { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> DeploymentStepId { get; set; }
    
        public virtual MachinePublication MachinePublication { get; set; }
    }
}