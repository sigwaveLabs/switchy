//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SwitchyMobileService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FlowswitchModel
    {
        public FlowswitchModel()
        {
            this.Flowswitches = new HashSet<Flowswitch>();
        }
    
        public int ID { get; set; }
        public int FlowSwitchMakeID { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Flowswitch> Flowswitches { get; set; }
        public virtual FlowswitchMake FlowswitchMake { get; set; }
    }
}