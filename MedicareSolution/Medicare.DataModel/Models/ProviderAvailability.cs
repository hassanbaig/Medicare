﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicare.DataModel.Models
{
   public partial class ProviderAvailability
    {
       public ProviderAvailability()
       {

       }
        #region Properties
       public long ProviderAvailabilityId { get; set; }
       public long ProviderId { get; set; }
       public DateTime? StartTime1 { get; set; }
       public DateTime? StartTime2 { get; set; }
       public DateTime? EndTime1 { get; set; }
       public DateTime? EndTime2 { get; set; }
       public string DayoftheWeek { get; set; }
        #endregion
             
    }
}
