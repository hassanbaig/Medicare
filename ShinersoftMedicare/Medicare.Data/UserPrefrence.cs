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
    
    public partial class UserPrefrence
    {
        public long UserPrefrencesId { get; set; }
        public string UserId { get; set; }
        public Nullable<bool> WeeklyHealthEmail { get; set; }
        public Nullable<bool> DoctorReplyEmail { get; set; }
        public Nullable<bool> QuestionNotificationEmail { get; set; }
        public Nullable<bool> PatientFollowEmail { get; set; }
    
        public virtual User User { get; set; }
    }
}