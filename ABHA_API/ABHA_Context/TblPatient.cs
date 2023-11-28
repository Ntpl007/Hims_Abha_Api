using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblPatient
    {
        public long PatienTId { get; set; }
        public string FirstNAme { get; set; }
        public string LastNAme { get; set; }
        public string Prefix { get; set; }
        public int? Sex { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? DoctorId { get; set; }
        public int? ReferrinGPhysicianId { get; set; }
        public int? FacilityId { get; set; }
        public string Occupation { get; set; }
        public int? MaritalStatusId { get; set; }
        public string PatienTMrn { get; set; }
        public string VisitTypeId { get; set; }
        public int? StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string BloodGroup { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public bool? OrganDonOr { get; set; }
        public string IdenTificationMarks { get; set; }
        public string SearchInDex { get; set; }
        public string ImagePath { get; set; }
        public decimal? Age { get; set; }
        public string MobileNUmber { get; set; }
        public string AlternAteMobileNUmber { get; set; }
        public int? AgeMode { get; set; }
        public string Address { get; set; }
        public int? AreaId { get; set; }
        public string PersonBroughtinNAme { get; set; }
        public string PersonBroughtinMobilenO { get; set; }
        public string Allergy { get; set; }
        public int? IdProofId { get; set; }
        public string IdProofImagePath { get; set; }
        public string Remarks { get; set; }
        public string SoWoDo { get; set; }
        public int? RelationType { get; set; }
        public bool? IsServiceAvailed { get; set; }
        public string OverTheCounTer { get; set; }
        public string MotherNAme { get; set; }
        public bool? IsCustomer { get; set; }
        public string Password { get; set; }
        public string RfId { get; set; }
        public string ReferrinGPerson { get; set; }
        public string CustomerMrn { get; set; }
        public string PatienTEmail { get; set; }
        public string AadharNO { get; set; }
        public string PatienTUnIqueId { get; set; }
        public short? TriggerSource { get; set; }
        public int? CorporateId { get; set; }
        public string IdentificationMarks1 { get; set; }
        public string ParenT { get; set; }
        public string Passport { get; set; }
        public string SearchIndex1 { get; set; }
        public int? Religion { get; set; }
        public int? NAtionAlity { get; set; }
        public string Middlename { get; set; }
        public string HealthIdNumber { get; set; }
        public string HealthId { get; set; }

        public virtual TblAdmArea Area { get; set; }
        public virtual TblProvider Doctor { get; set; }
        public virtual TblFacility Facility { get; set; }
        public virtual TblAdmMaritalStatus MaritalStatus { get; set; }
        public virtual TblAdmNationality NAtionAlityNavigation { get; set; }
        public virtual TblProvider ReferrinGPhysician { get; set; }
        public virtual TblAdmReligion ReligionNavigation { get; set; }
        public virtual TblAdmPatientStatus Status { get; set; }
    }
}
