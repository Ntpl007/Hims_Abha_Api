using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblAdmAppointmentStatus
    {
        public int AppointmentStatusId { get; set; }
        public string AppointmentStatus { get; set; }
        public int StatusId { get; set; }
        public string AppointmentStatusColor { get; set; }
        public string AppointmentStatusCategory { get; set; }
        public string AppointmentStatusNotes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblAdmStatus Status { get; set; }
    }
}
