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
    
    public partial class Technician
    {
        public Technician()
        {
            this.CalibrationRecords = new HashSet<CalibrationRecord>();
        }
    
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Username { get; set; }
        public int Active { get; set; }
    
        public virtual ICollection<CalibrationRecord> CalibrationRecords { get; set; }
    }
}