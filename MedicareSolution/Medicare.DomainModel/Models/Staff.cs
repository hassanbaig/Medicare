﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Medicare.Factory.Factories;
using System.Reflection;
namespace Medicare.DomainModel.Models
{
    public class Staff:AbstractDomainModel
    {
        public Staff()
        {
             
        }
        
        #region Properties  
        public int OperationType { get; set; }        
        public string UserId { get; set; }        
        public long ProviderId { get; set; }
        public long RemoveProviderId { get; set; }                
        public string ResponseMessage { get; set; }
        public Staff StaffInfo { get; set; }        
        public List<Medicare.DataModel.Models.Provider> PracticeDoctors { get; set; }
        public List<Medicare.DataModel.Models.Provider> PracticeStaff { get; set; }
        #endregion        
    
        public override void Fill(System.Collections.Hashtable dataTable)
        {           
            base.FillModel(this.GetType(), dataTable);        
        }
    }
}
