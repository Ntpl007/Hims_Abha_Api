using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblAdmStatus
    {
        public TblAdmStatus()
        {
            TblAdmAccountTypes = new HashSet<TblAdmAccountType>();
            TblAdmAppointmentStatuses = new HashSet<TblAdmAppointmentStatus>();
            TblAdmAppointmentTypeCategories = new HashSet<TblAdmAppointmentTypeCategory>();
            TblAdmAppointmentTypes = new HashSet<TblAdmAppointmentType>();
            TblAdmAreas = new HashSet<TblAdmArea>();
            TblAdmCasualityShiftedTypes = new HashSet<TblAdmCasualityShiftedType>();
            TblAdmChargeGroups = new HashSet<TblAdmChargeGroup>();
            TblAdmCompanies = new HashSet<TblAdmCompany>();
            TblAdmConsultationChargeGroups = new HashSet<TblAdmConsultationChargeGroup>();
            TblAdmConsultationTypes = new HashSet<TblAdmConsultationType>();
            TblAdmDepartments = new HashSet<TblAdmDepartment>();
            TblAdmEmployeeDepartments = new HashSet<TblAdmEmployeeDepartment>();
            TblAdmEmployeeDesignations = new HashSet<TblAdmEmployeeDesignation>();
            TblAdmEmployeeTypes = new HashSet<TblAdmEmployeeType>();
            TblAdmFacilityTypes = new HashSet<TblAdmFacilityType>();
            TblAdmMaritalStatuses = new HashSet<TblAdmMaritalStatus>();
            TblAdmPatientStatuses = new HashSet<TblAdmPatientStatus>();
            TblAdmProviderTypes = new HashSet<TblAdmProviderType>();
            TblAdmReferralSourceNames = new HashSet<TblAdmReferralSourceName>();
            TblAdmReferralSources = new HashSet<TblAdmReferralSource>();
            TblAdmSpecialities = new HashSet<TblAdmSpeciality>();
            TblAdmWmRoomTypes = new HashSet<TblAdmWmRoomType>();
            TblCorporates = new HashSet<TblCorporate>();
            TblFacilities = new HashSet<TblFacility>();
            TblFacilityDepartments = new HashSet<TblFacilityDepartment>();
            TblProviders = new HashSet<TblProvider>();
        }

        public int StatusId { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<TblAdmAccountType> TblAdmAccountTypes { get; set; }
        public virtual ICollection<TblAdmAppointmentStatus> TblAdmAppointmentStatuses { get; set; }
        public virtual ICollection<TblAdmAppointmentTypeCategory> TblAdmAppointmentTypeCategories { get; set; }
        public virtual ICollection<TblAdmAppointmentType> TblAdmAppointmentTypes { get; set; }
        public virtual ICollection<TblAdmArea> TblAdmAreas { get; set; }
        public virtual ICollection<TblAdmCasualityShiftedType> TblAdmCasualityShiftedTypes { get; set; }
        public virtual ICollection<TblAdmChargeGroup> TblAdmChargeGroups { get; set; }
        public virtual ICollection<TblAdmCompany> TblAdmCompanies { get; set; }
        public virtual ICollection<TblAdmConsultationChargeGroup> TblAdmConsultationChargeGroups { get; set; }
        public virtual ICollection<TblAdmConsultationType> TblAdmConsultationTypes { get; set; }
        public virtual ICollection<TblAdmDepartment> TblAdmDepartments { get; set; }
        public virtual ICollection<TblAdmEmployeeDepartment> TblAdmEmployeeDepartments { get; set; }
        public virtual ICollection<TblAdmEmployeeDesignation> TblAdmEmployeeDesignations { get; set; }
        public virtual ICollection<TblAdmEmployeeType> TblAdmEmployeeTypes { get; set; }
        public virtual ICollection<TblAdmFacilityType> TblAdmFacilityTypes { get; set; }
        public virtual ICollection<TblAdmMaritalStatus> TblAdmMaritalStatuses { get; set; }
        public virtual ICollection<TblAdmPatientStatus> TblAdmPatientStatuses { get; set; }
        public virtual ICollection<TblAdmProviderType> TblAdmProviderTypes { get; set; }
        public virtual ICollection<TblAdmReferralSourceName> TblAdmReferralSourceNames { get; set; }
        public virtual ICollection<TblAdmReferralSource> TblAdmReferralSources { get; set; }
        public virtual ICollection<TblAdmSpeciality> TblAdmSpecialities { get; set; }
        public virtual ICollection<TblAdmWmRoomType> TblAdmWmRoomTypes { get; set; }
        public virtual ICollection<TblCorporate> TblCorporates { get; set; }
        public virtual ICollection<TblFacility> TblFacilities { get; set; }
        public virtual ICollection<TblFacilityDepartment> TblFacilityDepartments { get; set; }
        public virtual ICollection<TblProvider> TblProviders { get; set; }
    }
}
