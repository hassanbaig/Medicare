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
    
    public partial class HealthProfileCholestrol
    {
        public long HealthProfileCholestrolId { get; set; }
        public string UserId { get; set; }
        public string LDL { get; set; }
        public string HDL { get; set; }
        public string Triglycerids { get; set; }
        public string TotalCholestrol { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<System.TimeSpan> Time { get; set; }
        public string Note { get; set; }
    
        public virtual User User { get; set; }
    }
}
