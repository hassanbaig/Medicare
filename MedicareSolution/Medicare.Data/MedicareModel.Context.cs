﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class shiner49_medicareEntities : DbContext
    {
        public shiner49_medicareEntities()
            : base("name=shiner49_medicareEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accreditation> Accreditations { get; set; }
        public virtual DbSet<Affiliation> Affiliations { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Award> Awards { get; set; }
        public virtual DbSet<BillingCurrency> BillingCurrencies { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<College> Colleges { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<FavoriteProvider> FavoriteProviders { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<HealthProfileAllergy> HealthProfileAllergies { get; set; }
        public virtual DbSet<HealthProfileBloodGlucose> HealthProfileBloodGlucoses { get; set; }
        public virtual DbSet<HealthProfileBloodPressure> HealthProfileBloodPressures { get; set; }
        public virtual DbSet<HealthProfileCholestrol> HealthProfileCholestrols { get; set; }
        public virtual DbSet<HealthProfileDiet> HealthProfileDiets { get; set; }
        public virtual DbSet<HealthProfileExercise> HealthProfileExercises { get; set; }
        public virtual DbSet<HealthProfileFamilyHistory> HealthProfileFamilyHistories { get; set; }
        public virtual DbSet<HealthProfileHeight> HealthProfileHeights { get; set; }
        public virtual DbSet<HealthProfileImmunization> HealthProfileImmunizations { get; set; }
        public virtual DbSet<HealthProfileLabTest> HealthProfileLabTests { get; set; }
        public virtual DbSet<HealthProfileMedicalCondition> HealthProfileMedicalConditions { get; set; }
        public virtual DbSet<HealthProfileMedicalDocument> HealthProfileMedicalDocuments { get; set; }
        public virtual DbSet<HealthProfileMedication> HealthProfileMedications { get; set; }
        public virtual DbSet<HealthProfileProcedure> HealthProfileProcedures { get; set; }
        public virtual DbSet<HealthProfileWeight> HealthProfileWeights { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Locality> Localities { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientHealthTopic> PatientHealthTopics { get; set; }
        public virtual DbSet<PatientQuery> PatientQueries { get; set; }
        public virtual DbSet<PatientQueryFollowUp> PatientQueryFollowUps { get; set; }
        public virtual DbSet<PatientQueryPayment> PatientQueryPayments { get; set; }
        public virtual DbSet<PatientQueryProvider> PatientQueryProviders { get; set; }
        public virtual DbSet<Practice> Practices { get; set; }
        public virtual DbSet<PracticeType> PracticeTypes { get; set; }
        public virtual DbSet<Premis> Premises { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<ProviderAccreditation> ProviderAccreditations { get; set; }
        public virtual DbSet<ProviderAffiliation> ProviderAffiliations { get; set; }
        public virtual DbSet<ProviderAvailability> ProviderAvailabilities { get; set; }
        public virtual DbSet<ProviderAward> ProviderAwards { get; set; }
        public virtual DbSet<ProviderContact> ProviderContacts { get; set; }
        public virtual DbSet<ProviderEducation> ProviderEducations { get; set; }
        public virtual DbSet<ProviderExperience> ProviderExperiences { get; set; }
        public virtual DbSet<ProviderFee> ProviderFees { get; set; }
        public virtual DbSet<ProviderInsurance> ProviderInsurances { get; set; }
        public virtual DbSet<ProviderLanguage> ProviderLanguages { get; set; }
        public virtual DbSet<ProviderLocality> ProviderLocalities { get; set; }
        public virtual DbSet<ProviderPhoto> ProviderPhotoes { get; set; }
        public virtual DbSet<ProviderPractice> ProviderPractices { get; set; }
        public virtual DbSet<ProviderPremis> ProviderPremises { get; set; }
        public virtual DbSet<ProviderReview> ProviderReviews { get; set; }
        public virtual DbSet<ProviderService> ProviderServices { get; set; }
        public virtual DbSet<ProviderSpecialty> ProviderSpecialties { get; set; }
        public virtual DbSet<ProviderTiming> ProviderTimings { get; set; }
        public virtual DbSet<ProviderTreatment> ProviderTreatments { get; set; }
        public virtual DbSet<ProviderType> ProviderTypes { get; set; }
        public virtual DbSet<ProviderVideo> ProviderVideos { get; set; }
        public virtual DbSet<RegistrationCouncil> RegistrationCouncils { get; set; }
        public virtual DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<Specialty> Specialties { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserFeedback> UserFeedbacks { get; set; }
        public virtual DbSet<UserFollowDoctor> UserFollowDoctors { get; set; }
        public virtual DbSet<UserFollowPatient> UserFollowPatients { get; set; }
        public virtual DbSet<UserLoginAudit> UserLoginAudits { get; set; }
        public virtual DbSet<UserPrefrence> UserPrefrences { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
    }
}
