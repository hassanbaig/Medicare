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
    
    public partial class HealthProfileImmunization
    {
        public long HealthProfileImmunizationId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Nullable<System.DateTime> DateGiven { get; set; }
        public string NumberOfSequence { get; set; }
        public string WhereOnBody { get; set; }
        public string Method { get; set; }
        public string Note { get; set; }
    
        public virtual User User { get; set; }
    }
}