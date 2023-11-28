using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblPatientAppointment
    {
        public int PatientAppointmentId { get; set; }
        public int? ScheduleId { get; set; }
        public bool? IsProviderAppointment { get; set; }
        public long PatientId { get; set; }
        public int FacilityId { get; set; }
        public int? ResourceId { get; set; }
        public int? DoctorId { get; set; }
        public int? ReferringPhysicianId { get; set; }
        public int? PatientTicketNo { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int AppointmentTypeId { get; set; }
        public int? AppointmentStatusId { get; set; }
        public string PatientAppointmentDescription { get; set; }
        public int? WaitinglistId { get; set; }
        public string RoomNo { get; set; }
        public int? ChainId { get; set; }
        public int? CaseId { get; set; }
        public int? SetId { get; set; }
        public int? RecallId { get; set; }
        public int? CompanyId { get; set; }
        public int? ReferalsourceId { get; set; }
        public string SpecificSource { get; set; }
        public string AppointmentNotes { get; set; }
        public string PatientSpecificNotes { get; set; }
        public string CaseNotes { get; set; }
        public string AppointmentTypeNotes { get; set; }
        public DateTime? CheckinDate { get; set; }
        public DateTime? CheckoutDate { get; set; }
        public bool? IsMedicoLegalCase { get; set; }
        public string NameOfTheInforment { get; set; }
        public string PoliceStation { get; set; }
        public string PcNo { get; set; }
        public string PcWhoIsBrought { get; set; }
        public int? StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
