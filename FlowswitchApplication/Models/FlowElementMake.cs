//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlowswitchApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FlowElementMake
    {
        public FlowElementMake()
        {
            this.FlowElementModels = new HashSet<FlowElementModel>();
            this.FlowElements = new HashSet<FlowElement>();
        }
    
        public int ID { get; set; }
        public string Make { get; set; }
    
        public virtual ICollection<FlowElementModel> FlowElementModels { get; set; }
        public virtual ICollection<FlowElement> FlowElements { get; set; }
    }
}
