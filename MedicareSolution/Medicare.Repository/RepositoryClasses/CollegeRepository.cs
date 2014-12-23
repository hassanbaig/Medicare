﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Medicare.Data;
using Medicare.Factory.Factories;

namespace Medicare.Repository.RepositoryClasses
{
    public class CollegeRepository : IRepository
    {
        public CollegeRepository()
        {

        }
       private shiner49_medicareEntities _context;
        public shiner49_medicareEntities DataContext
        {
            set { _context = value; }
        }
        public CollegeRepository(shiner49_medicareEntities context)
        {
            _context = context;
        }
        public List<Medicare.DataModel.Models.College> GetAll()
        {
            var colleges = (from col in _context.Colleges
                             select new Medicare.DataModel.Models.College
                             {
                                 CollegeId = col.CollegeId,
                                 Name = col.Name,
                                 CreationDate = col.CreationDate
                             }).ToList();
            return colleges;
        }
    }
}
