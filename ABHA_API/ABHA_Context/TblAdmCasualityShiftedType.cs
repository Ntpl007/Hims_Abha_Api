using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblAdmCasualityShiftedType
    {
        public int CasualityShiftedTypeId { get; set; }
        public string CasualityShiftedType { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblAdmStatus Status { get; set; }
    }
}
