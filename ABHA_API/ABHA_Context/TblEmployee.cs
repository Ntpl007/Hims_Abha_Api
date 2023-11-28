using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblEmployee
    {
        public int EmployeeId { get; set; }
        public int? ProviderId { get; set; }
        public string ListName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public bool? Sex { get; set; }
        public int? EmployeeTypeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DesignationId { get; set; }
        public string UserId { get; set; }
        public string Mobile { get; set; }
        public string WorkPhone { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }
        public string SearchIndex { get; set; }
        public int? StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int FacilityId { get; set; }
        public bool? HasLogin { get; set; }
        public bool? HasScheduleTemplates { get; set; }
        public bool? HasFeeTemplates { get; set; }
        public string EmployeeGroup { get; set; }
        public decimal? MaxDiscountAmount { get; set; }
        public int? FacilityDepartmentId { get; set; }
    }
}
