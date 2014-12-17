﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Medicare.UnitOfWork.Base;
using Medicare.Factory.Factories;
using Medicare.UnitOfWork;
using Medicare.Core.Enumerations;
namespace Medicare.DomainService
{
    public class PracticesDomainService : AbstractDomainService
    {

        private IUnitOfWork unitOfWork;
        private DomainModel.Models.PracticeEditDetails practiceEditDetails;
        public override AbstractDomainModel Save(AbstractDomainModel domainModel, Medicare.Factory.Enumerations.DomainModelEnum domainModelType)
        {
            DomainModel.Models.PracticeEditDetails practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
            try
            {
                if (domainModel != null)
                {
                    switch (domainModelType)
                    {
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_DETAILS:
                            if (practiceEditDetails.PracticeDetailsPracticeName == null || practiceEditDetails.PracticeDetailsPracticeName.Length <= 0)
                            { practiceEditDetails.ResponseMessage = "Name is required."; }
                            else
                            {
                                FactoryFacade factory = new FactoryFacade();
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Save(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Practice is added successfully.";
                            }
                            break;

                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_LANGUAGES:
                            if (practiceEditDetails.PracticeLanguagesLanguageName == null || practiceEditDetails.PracticeLanguagesLanguageName.Length <= 0)
                            { practiceEditDetails.ResponseMessage = "Name is required."; }
                            else
                            {
                                FactoryFacade factory = new FactoryFacade();
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Save(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Practice Language is added successfully.";
                            }
                            break;

                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_PREMISES:
                            if (practiceEditDetails.PracticePremisesPremisName == null || practiceEditDetails.PracticePremisesPremisName.Length <= 0)
                            { practiceEditDetails.ResponseMessage = "Name is required."; }
                            else
                            {
                                FactoryFacade factory = new FactoryFacade();
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Save(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Practice Premis is added successfully.";
                            }
                            break;

                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_ACCREDITATIONS:
                            if (practiceEditDetails.PracticeAccreditationsAccreditationName == null || practiceEditDetails.PracticeAccreditationsAccreditationName.Length <= 0)
                            { practiceEditDetails.ResponseMessage = "Name is required."; }
                            else
                            {
                                FactoryFacade factory = new FactoryFacade();
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Save(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Practice Accreditation is added successfully.";
                            }
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_INSURANCES:
                            if (practiceEditDetails.PracticeInsurancesInsuranceName == null || practiceEditDetails.PracticeInsurancesInsuranceName.Length <= 0)
                            { practiceEditDetails.ResponseMessage = "Name is required."; }
                            else
                            {
                                FactoryFacade factory = new FactoryFacade();
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Save(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Practice Insurance is added successfully.";
                            }
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_SERVICES:
                            if (practiceEditDetails.PracticeServicesServiceName == null || practiceEditDetails.PracticeServicesServiceName.Length <= 0)
                            { practiceEditDetails.ResponseMessage = "Name is required."; }
                            else
                            {
                                FactoryFacade factory = new FactoryFacade();
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Save(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Practice Service is added successfully.";
                            }
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TRAVEL_SERVICES:
                            if (practiceEditDetails.PracticeServicesTravelServiceName == null || practiceEditDetails.PracticeServicesTravelServiceName.Length <= 0)
                            { practiceEditDetails.ResponseMessage = "Name is required."; }
                            else
                            {
                                FactoryFacade factory = new FactoryFacade();
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Save(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Practice Travel Service is added successfully.";
                            }
                            break;

                        default:
                            break;
                    }
                }

                else
                {
                    switch (domainModelType)
                    {
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_DETAILS:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;

                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_LANGUAGES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;

                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_PREMISES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;

                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_ACCREDITATIONS:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_INSURANCES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_SERVICES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TRAVEL_SERVICES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;

                        default:
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                switch (domainModelType)
                {
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_DETAILS:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_LANGUAGES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_PREMISES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_ACCREDITATIONS:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_INSURANCES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_SERVICES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TRAVEL_SERVICES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                  
                    default:
                        break;
                }

            }
            switch (domainModelType)
            {
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_DETAILS:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_LANGUAGES:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_PREMISES:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_ACCREDITATIONS:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_INSURANCES:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_SERVICES:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TRAVEL_SERVICES:
                    return practiceEditDetails;               
                default:
                    break;
            }

            return null;
        }
        public override AbstractDomainModel Update(AbstractDomainModel domainModel, Medicare.Factory.Enumerations.DomainModelEnum domainModelType)
        {
            DomainModel.Models.PracticeEditDetails practiceEditDetails = null;
            try
            {
                if (domainModel != null)
                {
                    switch (domainModelType)
                    {
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_LANGUAGES:
                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.PracticeLanguagesLanguageId == 0)
                            { practiceEditDetails.ResponseMessage = "Language id is required"; }
                            else
                            {
                                FactoryFacade factory = new FactoryFacade();
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Update(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Information has been added successfully.";
                            }
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_PREMISES:
                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.PracticePremisesPremisId == 0)
                            { practiceEditDetails.ResponseMessage = "Premises id is required"; }
                            else
                            {
                                FactoryFacade factory = new FactoryFacade();
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Update(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Information has been added successfully.";
                            }
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_ACCREDITATIONS:
                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.PracticeAccreditationsAccreditationId == 0)
                            { practiceEditDetails.ResponseMessage = "Accreditation id is required"; }
                            else
                            {
                                FactoryFacade factory = new FactoryFacade();
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Update(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Information has been added successfully.";
                            }
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_INSURANCES:
                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.PracticeInsurancesInsuranceId == 0)
                            { practiceEditDetails.ResponseMessage = "Insurance id is required"; }
                            else
                            {        

                        FactoryFacade factory = new FactoryFacade();
                        unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                        unitOfWork.Update(practiceEditDetails);
                        unitOfWork.Commit();
                        practiceEditDetails.ResponseMessage = "Information has been added successfully.";
                            }
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_SERVICES:
                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.PracticeServicesServiceId == 0)
                            { practiceEditDetails.ResponseMessage = "Service id is required"; }
                            else
                            {

                                FactoryFacade factory = new FactoryFacade();
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                        unitOfWork.Update(practiceEditDetails);
                        unitOfWork.Commit();
                        practiceEditDetails.ResponseMessage = "Information has been added successfully.";
                            }
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_TRAVEL_SERVICES:
                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.PracticeServicesTravelServiceId == 0)
                            { practiceEditDetails.ResponseMessage = "Service id is required"; }
                            else
                            {

                                FactoryFacade factory = new FactoryFacade();
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Update(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Information has been added successfully.";
                            }
                            break;
                        default:
                            break;
                    }        
                                    
                }
                else
                {
                    switch (domainModelType)
                    {
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_LANGUAGES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_PREMISES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_ACCREDITATIONS:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_INSURANCES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_SERVICES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_TRAVEL_SERVICES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                switch (domainModelType)
                {
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_LANGUAGES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_PREMISES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_ACCREDITATIONS:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_INSURANCES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_SERVICES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_TRAVEL_SERVICES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    default:
                        break;
                }
            }
            switch (domainModelType)
            {
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_LANGUAGES:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_PREMISES:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_ACCREDITATIONS:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_INSURANCES:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_SERVICES:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_TO_TRAVEL_SERVICES:
                    return practiceEditDetails;
                   default:
                    break;
            }
            return null;
        }


        public override AbstractDomainModel Delete(AbstractDomainModel domainModel, Medicare.Factory.Enumerations.DomainModelEnum domainModelType)
        {
            DomainModel.Models.PracticeEditDetails practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
            try
            {
                if (domainModel != null)
                {
                    FactoryFacade factory = new FactoryFacade();
                    switch (domainModelType)
                    {
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_LANGUAGES:
                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.PracticeLanguagesLanguageId == 0)
                            { practiceEditDetails.ResponseMessage = "Language id is required"; }
                            else
                            {                               
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Delete(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Information has been removed successfully.";
                            }
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_PREMISES:
                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.PracticePremisesPremisId == 0)
                            { practiceEditDetails.ResponseMessage = "Premises id is required"; }
                            else
                            {                                
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Delete(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Information has been removed successfully.";
                            }
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_ACCREDITATIONS:
                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.PracticeAccreditationsAccreditationId == 0)
                            { practiceEditDetails.ResponseMessage = "Accreditation id is required"; }
                            else
                            {                             
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Delete(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Information has been removed successfully.";
                            }
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_INSURANCES:
                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.PracticeInsurancesInsuranceId == 0)
                            { practiceEditDetails.ResponseMessage = "Insurance id is required"; }
                            else
                            {                                
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Delete(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Information has been removed successfully.";
                            }
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_SERVICES:
                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.PracticeServicesServiceId == 0)
                            { practiceEditDetails.ResponseMessage = "Service id is required"; }
                            else
                            {                               
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Delete(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Information has been removed successfully.";
                            }
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_TRAVEL_SERVICES:
                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.PracticeServicesTravelServiceId == 0)
                            { practiceEditDetails.ResponseMessage = "Travel service id is required"; }
                            else
                            {                               
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                unitOfWork.Delete(practiceEditDetails);
                                unitOfWork.Commit();
                                practiceEditDetails.ResponseMessage = "Information has been removed successfully.";
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (domainModelType)
                    {
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_LANGUAGES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_PREMISES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_ACCREDITATIONS:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_INSURANCES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_SERVICES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_TRAVEL_SERVICES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model.";
                            break;
                        default:
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                switch (domainModelType)
                {
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_LANGUAGES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_PREMISES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_ACCREDITATIONS:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_INSURANCES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_SERVICES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_TRAVEL_SERVICES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    default:
                        break;
                }
            }
            switch (domainModelType)
            {
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_LANGUAGES:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_PREMISES:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_ACCREDITATIONS:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_INSURANCES:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_SERVICES:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_REMOVE_FROM_TRAVEL_SERVICES:
                    return practiceEditDetails; 
                default:
                    break;
            }

            return null;

        }
        public override AbstractDomainModel Query(AbstractDomainModel domainModel, Medicare.Factory.Enumerations.DomainModelEnum domainModelType)
        {
            DomainModel.Models.PracticeEditDetails practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
            try
            {
                if (domainModel != null)
                {
                    FactoryFacade factory = new FactoryFacade();
                    switch (domainModelType)
                    {
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_DETAILS:
                            unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)unitOfWork.Get(practiceEditDetails);
                            practiceEditDetails.ResponseMessage = "Valid domain model";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_LANGUAGES:

                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.UserId == null || practiceEditDetails.UserId.Length <= 0)
                            {
                                practiceEditDetails.ResponseMessage = "User id is required";
                            }
                            else if (practiceEditDetails.ProviderId <= 0)
                            {
                                practiceEditDetails.ResponseMessage = "Provider id is required";
                            }
                            else
                            {                              
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                practiceEditDetails = (DomainModel.Models.PracticeEditDetails)unitOfWork.Get(practiceEditDetails);
                                practiceEditDetails.ResponseMessage = "Valid";
                            }
                            break;
                            case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_PREMISES:

                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.UserId == null || practiceEditDetails.UserId.Length <= 0)
                            {
                                practiceEditDetails.ResponseMessage = "User id is required";
                            }
                            else if (practiceEditDetails.ProviderId <= 0)
                            {
                                practiceEditDetails.ResponseMessage = "Provider id is required";
                            }
                            else
                            {                              
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                practiceEditDetails = (DomainModel.Models.PracticeEditDetails)unitOfWork.Get(practiceEditDetails);
                                practiceEditDetails.ResponseMessage = "Valid";
                            }
                            break;

                            case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_ACCREDITATIONS:

                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.UserId == null || practiceEditDetails.UserId.Length <= 0)
                            {
                                practiceEditDetails.ResponseMessage = "User id is required";
                            }
                            else if (practiceEditDetails.ProviderId <= 0)
                            {
                                practiceEditDetails.ResponseMessage = "Provider id is required";
                            }
                            else
                            {
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                practiceEditDetails = (DomainModel.Models.PracticeEditDetails)unitOfWork.Get(practiceEditDetails);
                                practiceEditDetails.ResponseMessage = "Valid";
                            }
                            break;
                            
                            case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_INSURANCES:

                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.UserId == null || practiceEditDetails.UserId.Length <= 0)
                            {
                                practiceEditDetails.ResponseMessage = "User id is required";
                            }
                            else if (practiceEditDetails.ProviderId <= 0)
                            {
                                practiceEditDetails.ResponseMessage = "Provider id is required";
                            }
                            else
                            {
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                practiceEditDetails = (DomainModel.Models.PracticeEditDetails)unitOfWork.Get(practiceEditDetails);
                                practiceEditDetails.ResponseMessage = "Valid";
                            }
                            break;

                            case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_SERVICES:

                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.UserId == null || practiceEditDetails.UserId.Length <= 0)
                            {
                                practiceEditDetails.ResponseMessage = "User id is required";
                            }
                            else if (practiceEditDetails.ProviderId <= 0)
                            {
                                practiceEditDetails.ResponseMessage = "Provider id is required";
                            }
                            else
                            {
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                practiceEditDetails = (DomainModel.Models.PracticeEditDetails)unitOfWork.Get(practiceEditDetails);
                                practiceEditDetails.ResponseMessage = "Valid";
                            }
                            break;

                            case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_TRAVEL_SERVICES:

                            practiceEditDetails = (DomainModel.Models.PracticeEditDetails)domainModel;
                            if (practiceEditDetails.UserId == null || practiceEditDetails.UserId.Length <= 0)
                            {
                                practiceEditDetails.ResponseMessage = "User id is required";
                            }
                            else if (practiceEditDetails.ProviderId <= 0)
                            {
                                practiceEditDetails.ResponseMessage = "Provider id is required";
                            }
                            else
                            {
                                unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                                practiceEditDetails = (DomainModel.Models.PracticeEditDetails)unitOfWork.Get(practiceEditDetails);
                                practiceEditDetails.ResponseMessage = "Valid";
                            }
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    switch (domainModelType)
                    {
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_DETAILS:
                            practiceEditDetails.ResponseMessage = "Invalid domain model";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_LANGUAGES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_PREMISES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_ACCREDITATIONS:
                            practiceEditDetails.ResponseMessage = "Invalid domain model";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_INSURANCES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_SERVICES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model";
                            break;
                        case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_TRAVEL_SERVICES:
                            practiceEditDetails.ResponseMessage = "Invalid domain model";
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                switch (domainModelType)
                {
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_DETAILS:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_LANGUAGES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_PREMISES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_ACCREDITATIONS:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_INSURANCES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_SERVICES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_TRAVEL_SERVICES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    default:
                        break;
                }
            }
            switch (domainModelType)
            {
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_ADD_DETAILS:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_LANGUAGES:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_PREMISES:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_ACCREDITATIONS:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_INSURANCES:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_SERVICES:
                    return practiceEditDetails;
                case Medicare.Factory.Enumerations.DomainModelEnum.PRACTICE_EDIT_DETAILS_GET_ADDED_TRAVEL_SERVICES:
                    return practiceEditDetails;
                default:
                    break;
            }
            return null;
        }

        public override AbstractDomainModel Query(AbstractDomainModel domainModel, Factory.Enumerations.DomainModelEnum domainModelType, SearchCriteriaEnum searchCriteria)
        {
            throw new NotImplementedException();
        }

        public override AbstractDomainModel Query(SearchCriteriaEnum searchCriteria)
        {
            practiceEditDetails = new DomainModel.Models.PracticeEditDetails();
            FactoryFacade factory = new FactoryFacade();
            try
            {
                switch (searchCriteria)
                {
                    case SearchCriteriaEnum.GET_COUNTRIES:
                        unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                        practiceEditDetails = (DomainModel.Models.PracticeEditDetails)unitOfWork.GetAll(searchCriteria);
                        break;
                    case SearchCriteriaEnum.GET_LANGUAGES:
                        unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                        practiceEditDetails = (DomainModel.Models.PracticeEditDetails)unitOfWork.GetAll(searchCriteria);
                        break;
                    case SearchCriteriaEnum.GET_PREMISES:
                        unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                        practiceEditDetails = (DomainModel.Models.PracticeEditDetails)unitOfWork.GetAll(searchCriteria);
                        break;
                    case SearchCriteriaEnum.GET_ACCREDITATIONS:
                        unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                        practiceEditDetails = (DomainModel.Models.PracticeEditDetails)unitOfWork.GetAll(searchCriteria);
                        break;
                    case SearchCriteriaEnum.GET_INSURANCES:
                        unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                        practiceEditDetails = (DomainModel.Models.PracticeEditDetails)unitOfWork.GetAll(searchCriteria);
                        break;
                     case SearchCriteriaEnum.GET_SERVICES:
                        unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                        practiceEditDetails = (DomainModel.Models.PracticeEditDetails)unitOfWork.GetAll(searchCriteria);
                        break;
                    case SearchCriteriaEnum.GET_TRAVEL_SERVICES:
                        unitOfWork = factory.UnitOfWorkFactory.CreateUnitOfWork(typeof(Medicare.UnitOfWork.PracticeEditDetailsUOW));
                        practiceEditDetails = (DomainModel.Models.PracticeEditDetails)unitOfWork.GetAll(searchCriteria);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                switch (searchCriteria)
                {
                    case SearchCriteriaEnum.GET_COUNTRIES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case SearchCriteriaEnum.GET_LANGUAGES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case SearchCriteriaEnum.GET_PREMISES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case SearchCriteriaEnum.GET_ACCREDITATIONS:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case SearchCriteriaEnum.GET_INSURANCES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case SearchCriteriaEnum.GET_SERVICES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    case SearchCriteriaEnum.GET_TRAVEL_SERVICES:
                        practiceEditDetails.ResponseMessage = ex.Message;
                        break;
                    default:
                        break;
                }
            }
            finally
            {
                factory = null;
            }
            switch (searchCriteria)
            {
                case SearchCriteriaEnum.GET_COUNTRIES:
                    return practiceEditDetails;
                case SearchCriteriaEnum.GET_LANGUAGES:
                    return practiceEditDetails;
                case SearchCriteriaEnum.GET_PREMISES:
                    return practiceEditDetails;
                case SearchCriteriaEnum.GET_ACCREDITATIONS:
                    return practiceEditDetails;
                case SearchCriteriaEnum.GET_INSURANCES:
                    return practiceEditDetails;
                case SearchCriteriaEnum.GET_SERVICES:
                    return practiceEditDetails;
                case SearchCriteriaEnum.GET_TRAVEL_SERVICES:
                    return practiceEditDetails;
                default:
                    break;
            }
            return null;
        }
    }
}
