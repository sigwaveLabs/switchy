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
    
    public partial class FlowElement
    {
        public int ID { get; set; }
        public Nullable<int> FlowElementTypeID { get; set; }
        public Nullable<int> MakeID { get; set; }
        public Nullable<int> ModelID { get; set; }
        public Nullable<int> SizeID { get; set; }
    
        public virtual FlowElementMake FlowElementMake { get; set; }
        public virtual FlowElementType FlowElementType { get; set; }
    }
}
