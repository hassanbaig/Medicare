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
    
    public partial class ProviderInsurance
    {
        public long ProviderInsuranceId { get; set; }
        public long ProviderId { get; set; }
        public long InsuranceId { get; set; }
    
        public virtual Insurance Insurance { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
