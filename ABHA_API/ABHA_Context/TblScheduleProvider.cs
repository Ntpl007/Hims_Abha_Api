using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblScheduleProvider
    {
        public int ScheduleProviderId { get; set; }
        public int ProviderId { get; set; }
        public int ScheduleId { get; set; }
        public int? StatusId { get; set; }
        public bool? IsDefaultSchedule { get; set; }
    }
}
