//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CareHub.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProviderPractice
    {
        public long ProviderPracticeId { get; set; }
        public long ProviderId { get; set; }
        public long PracticeId { get; set; }
    
        public virtual Practice Practice { get; set; }
        public virtual Provider Provider { get; set; }
    }
}