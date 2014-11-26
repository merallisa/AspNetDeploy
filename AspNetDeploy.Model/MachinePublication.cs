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
    
    public partial class MachinePublication
    {
        public MachinePublication()
        {
            this.Log = new HashSet<MachinePublicationLog>();
            this.Properties = new HashSet<MachinePublicationProperty>();
        }
    
        public int Id { get; set; }
        public int PublicationId { get; set; }
        public int MachineId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public MachinePublicationState State { get; set; }
        public Nullable<System.DateTime> CompletedDate { get; set; }
    
        public virtual Machine Machine { get; set; }
        public virtual Publication Publication { get; set; }
        public virtual ICollection<MachinePublicationLog> Log { get; set; }
        public virtual ICollection<MachinePublicationProperty> Properties { get; set; }
    }
}