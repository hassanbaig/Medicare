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
    
    public partial class PatientQueryFollowUp
    {
        public long PatientQueryFollowUpID { get; set; }
        public long PatientQueryId { get; set; }
        public string Description { get; set; }
        public int FollowUpRemaining { get; set; }
        public System.DateTime QueryCreationDateTime { get; set; }
    
        public virtual PatientQuery PatientQuery { get; set; }
    }
}
