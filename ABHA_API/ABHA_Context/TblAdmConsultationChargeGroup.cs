using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblAdmConsultationChargeGroup
    {
        public int ConsultationChargeGroupId { get; set; }
        public string ConsultationChargeGroup { get; set; }
        public int? StatusId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual TblAdmStatus Status { get; set; }
    }
}
