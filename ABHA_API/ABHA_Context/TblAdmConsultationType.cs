using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblAdmConsultationType
    {
        public int ConsultationTypeId { get; set; }
        public string ConsultationType { get; set; }
        public int? StatusId { get; set; }

        public virtual TblAdmStatus Status { get; set; }
    }
}
