using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblAdmAppointmentType
    {
        public int AppointmentTypeId { get; set; }
        public string AppointmentType { get; set; }
        public int AppointmentDuration { get; set; }
        public int AppointmentTypeCategoryId { get; set; }
        public string AppointmentTypeColor { get; set; }
        public string Notes { get; set; }
        public bool ShowPopup { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblAdmAppointmentTypeCategory AppointmentTypeCategory { get; set; }
        public virtual TblAdmStatus Status { get; set; }
    }
}
