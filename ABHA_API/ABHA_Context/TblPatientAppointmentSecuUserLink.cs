using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblPatientAppointmentSecuUserLink
    {
        public int AppointmentSecurityUserLinkId { get; set; }
        public int AppointmentId { get; set; }
        public long EncounterId { get; set; }
        public string SecurityUserId { get; set; }
        public int? ProviderId { get; set; }
        public int? ResourceId { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
