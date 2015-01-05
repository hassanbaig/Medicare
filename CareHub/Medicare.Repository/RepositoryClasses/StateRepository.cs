﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareHub.Data;
using CareHub.Factory.Factories;

namespace CareHub.Repository.RepositoryClasses
{
    public class StateRepository : IRepository
    {
        public StateRepository()
        {

        }

        private shiner49_CareHubEntities _context;
        public shiner49_CareHubEntities DataContext
        {
            set { _context = value; }
        }      
        public List<CareHub.DataModel.Models.State> GetAll()
        {
            var data = (from sta in _context.States
                        select new CareHub.DataModel.Models.State
                        {
                            CountryId = sta.CountryId,
                            StateId = sta.StateId,
                            Name = sta.Name
                        }).ToList();
            return data;
        }
    }
}