using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblEncounter
    {
        public long EncounterId { get; set; }
        public string OpId { get; set; }
        public string OpLabId { get; set; }
        public long PatientId { get; set; }
        public int? DoctorId { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int SpecialityId { get; set; }
        public int FacilityId { get; set; }
        public string Notes { get; set; }
        public int StatusId { get; set; }
        public int? AppointmentId { get; set; }
        public string PatientEncounterId { get; set; }
        public bool? IsAdmission { get; set; }
        public int? AdmissionId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsShownInProgressnote { get; set; }
        public int? FacilitySpecialityLinkId { get; set; }
        public int? DischargeConfirmedBy { get; set; }
        public DateTime? DischargeDate { get; set; }
        public string DischargeNotes { get; set; }
        public decimal? ServiceTaxPercentage { get; set; }
        public decimal? TotalBilledAmount { get; set; }
        public int? SequenceNumber { get; set; }
        public bool? IsArogyasree { get; set; }
        public string ArogyasreeId { get; set; }
        public int? CorporateId { get; set; }
        public bool? IsEmergencyRegistration { get; set; }
        public bool? IsConvertedToAdmission { get; set; }
        public long? InvoiceId { get; set; }
        public long? ConvertToIp { get; set; }
        public bool? IsReview { get; set; }
        public DateTime? ConsultationDate { get; set; }
        public bool? IsFreeConsultation { get; set; }
        public string Mode { get; set; }
        public int? OpSpecialityId { get; set; }
        public int? ConsultationTypeId { get; set; }
        public int? ConsultationChargeGroupId { get; set; }
        public bool? IsOpLabBill { get; set; }
        public int? OpConsultationStatusId { get; set; }
        public int? OpLabStatusId { get; set; }
        public bool? IdFromAmbulance { get; set; }
        public int? AmbulanceTripId { get; set; }
        public int? LabAdmissionId { get; set; }
        public int? ReviewCount { get; set; }
        public DateTime? LastDateOfChargedVisit { get; set; }
        public bool? IsLabReportDelivered { get; set; }
        public bool? CasualityDischargeStatusId { get; set; }
        public bool? IsFromCasuality { get; set; }
        public int? CasualityPatShiftedTypeId { get; set; }
        public long? CasualityLabEncounterId { get; set; }
        public int? BillTypeId { get; set; }
        public int? MarketingEmployeeId { get; set; }
        public int? LabId { get; set; }
        public bool? IsHealthCheckupDone { get; set; }
        public DateTime? ClosingDate { get; set; }
        public long? CrossRefEncounterId { get; set; }
        public string ReferingPerson { get; set; }
        public int? ReferralSourceId { get; set; }
        public int? ReferralSourceNameId { get; set; }
        public string ChamberNo { get; set; }
        public bool? IsCoupon { get; set; }
    }
}
