using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblFacilityMapping
    {
        public int FacilityMappingId { get; set; }
        public int? FacilityId { get; set; }
        public int? OrganizationId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Createdby { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Modifiedby { get; set; }
    }
}
