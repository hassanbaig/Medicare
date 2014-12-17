﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Medicare.Data;
using Medicare.Factory.Factories;
using Medicare.UnitOfWork.Base;
using Medicare.DomainModel.Models;
using Medicare.Repository.RepositoryClasses;
using Medicare.Core.Enumerations;
namespace Medicare.UnitOfWork
{
    public class ChangePasswordUOW : BaseUnitOfWork,IUnitOfWork
    {        
        private UserRepository userRepository;
        private ChangePassword changePassword;        
        public ChangePasswordUOW ():base()
	    {            
            if (base.Context == null)
            {
                throw new ArgumentNullException("Context was not supplied");
            }
            else
            {
                ((IUnitOfWork)this).InitializeRepositories();
            }
        }
        public ChangePasswordUOW(MedicareDevEntities context)
            : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("Context was not supplied");
            }
            else
            {
                ((IUnitOfWork)this).InitializeRepositories();
            }
        } 

        void IUnitOfWork.InitializeRepositories()
        {            
            userRepository = (UserRepository)base.Factory.RepositoryFactory.CreateRepository(typeof(UserRepository));            
            userRepository.DataContext = base.Context;            
        }
      
        
         void IUnitOfWork.Save(AbstractDomainModel domainModel)
         {
             throw new NotImplementedException();     
         }

         void IUnitOfWork.SaveAll()
         {
             throw new NotImplementedException();
         }

         void IUnitOfWork.Delete(AbstractDomainModel domainModel)
         {
             throw new NotImplementedException();
         }

         void IUnitOfWork.Update(AbstractDomainModel domainModel)
         {
             try
             {
                 changePassword = (ChangePassword)domainModel;
                 userRepository.Update(changePassword.UserId, Medicare.Core.Common.Encryption.Encrypt("#", changePassword.CurrentPassword),
                     Medicare.Core.Common.Encryption.Encrypt("#", changePassword.NewPassword));                 
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         void IUnitOfWork.Commit()
         {
             base.Commit(); 
         }

         void IUnitOfWork.Add(AbstractDomainModel domainModel)
         {
             base.Add(domainModel);
         }

         void IUnitOfWork.Remove(AbstractDomainModel domainModel)
         {
             base.Remove(domainModel);
         }


         public AbstractDomainModel Get(AbstractDomainModel domainModel)
         {
             throw new NotImplementedException();
         }

         public AbstractDomainModel GetAll(SearchCriteriaEnum searchCriteria)
         {
             throw new NotImplementedException();
         }
    }
}