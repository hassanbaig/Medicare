//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Medicare.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class HealthProfileProcedure
    {
        public long HealthProfileProcedureId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string BodyLocation { get; set; }
        public string Provider { get; set; }
        public string Note { get; set; }
    
        public virtual User User { get; set; }
    }
}
