using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblProvider
    {
        public TblProvider()
        {
            TblPatientDoctors = new HashSet<TblPatient>();
            TblPatientReferrinGPhysicians = new HashSet<TblPatient>();
        }

        public int ProviderId { get; set; }
        public bool? IsProvider { get; set; }
        public string ListName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string OrganizationName { get; set; }
        public int? FacilityTypeId { get; set; }
        public int? ProviderTypeId { get; set; }
        public string FederalTaxId { get; set; }
        public string FederalTaxIdType { get; set; }
        public int? SpecialityTypeId { get; set; }
        public string Upin { get; set; }
        public string Npi { get; set; }
        public int? NonPaticipatingInsuranceCompanyId { get; set; }
        public string StateLicenseNumber { get; set; }
        public string SpecialityLicenseNumber { get; set; }
        public string AdditionalLicenseNumber { get; set; }
        public string AnesthesiologistLicenseNumber { get; set; }
        public string Ledger { get; set; }
        public string UserId { get; set; }
        public int? StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string SearchIndex { get; set; }
        public string CommissionAmount { get; set; }
        public string DiscountPercentage { get; set; }
        public string ImagePath { get; set; }
        public int? EmployeeId { get; set; }
        public string OverriddenReviewDays { get; set; }
        public string ReviewConsultationsCount { get; set; }
        public bool? IsNocommissions { get; set; }
        public int? IpReviewConsultationsCount { get; set; }
        public string IpReviewDays { get; set; }
        public string ProviderCode { get; set; }
        public string MobileNumber { get; set; }

        public virtual TblAdmFacilityType FacilityType { get; set; }
        public virtual TblAdmProviderType ProviderType { get; set; }
        public virtual TblAdmSpeciality SpecialityType { get; set; }
        public virtual TblAdmStatus Status { get; set; }
        public virtual ICollection<TblPatient> TblPatientDoctors { get; set; }
        public virtual ICollection<TblPatient> TblPatientReferrinGPhysicians { get; set; }
    }
}
