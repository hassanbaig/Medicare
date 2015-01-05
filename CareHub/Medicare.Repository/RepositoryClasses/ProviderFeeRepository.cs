﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareHub.Data;
using CareHub.Factory.Factories;

namespace CareHub.Repository.RepositoryClasses
{
    public class ProviderFeeRepository : IRepository
    {
        public ProviderFeeRepository()
        {

        }
       private shiner49_CareHubEntities _context;
        public shiner49_CareHubEntities DataContext
        {
            set { _context = value; }
        }
        public ProviderFeeRepository(shiner49_CareHubEntities context)
        {
            _context = context;
        }       
        public void Update(ProviderFee entity)
        {
            var providerFee = (from proFee in _context.ProviderFees
                               where proFee.ProviderId == entity.ProviderId
                               select proFee).FirstOrDefault();
            if (providerFee != null)
            {
                providerFee.ProviderId = entity.ProviderId;
                providerFee.Fee = entity.Fee;
                providerFee.Duration = entity.Duration;
                providerFee.Type = "paid";
                providerFee.Currency = "PKR";
            }
            else
            {
                _context.ProviderFees.Add(entity);
            }
        }
    }
}