using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblAdmFacility
    {
        public int FacilityId { get; set; }
        public string FacilityName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Createdby { get; set; }
    }
}
