using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblFacility
    {
        public TblFacility()
        {
            TblFacilityDepartments = new HashSet<TblFacilityDepartment>();
            TblPatients = new HashSet<TblPatient>();
        }

        public int FacilityId { get; set; }
        public string FacilityName { get; set; }
        public string ListName { get; set; }
        public bool? IsCentralFacility { get; set; }
        public string FacilityDescription { get; set; }
        public int? FacilityTypeId { get; set; }
        public string FederalTaxId { get; set; }
        public int? FederalTaxIdType { get; set; }
        public string Npi { get; set; }
        public string StateLicenseNumber { get; set; }
        public string SpecialityLicenseNumber { get; set; }
        public string AdditionalLicenseNumber { get; set; }
        public string TicketNumberPrefix { get; set; }
        public int? DefaultCompanyId { get; set; }
        public int? PlaceOfServiceId { get; set; }
        public string Ledger { get; set; }
        public int? SpecialityId { get; set; }
        public string TypeOfBill { get; set; }
        public string TaxRate { get; set; }
        public string ColorCode { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? DischargeProcessId { get; set; }

        public virtual TblAdmCompany DefaultCompany { get; set; }
        public virtual TblAdmFacilityType FacilityType { get; set; }
        public virtual TblAdmSpeciality Speciality { get; set; }
        public virtual TblAdmStatus Status { get; set; }
        public virtual ICollection<TblFacilityDepartment> TblFacilityDepartments { get; set; }
        public virtual ICollection<TblPatient> TblPatients { get; set; }
    }
}
