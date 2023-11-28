using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblFacilityDepartment
    {
        public int FacilityDepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public int FacilityId { get; set; }
        public int? StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblFacility Facility { get; set; }
        public virtual TblAdmStatus Status { get; set; }
    }
}
