using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblEncounterBillingEntryHistory
    {
        public long EncounterEntryHistoryId { get; set; }
        public string EncounterEntryId { get; set; }
        public int FacilityId { get; set; }
        public long EncounterId { get; set; }
        public int PatientId { get; set; }
        public int ChargeItemId { get; set; }
        public DateTime? DateOfService { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public int? ProviderId { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal UnitPrice { get; set; }
        public string RoomNo { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? NoOfDays { get; set; }
        public float NoOfUnits { get; set; }
        public bool PaymentChargeInd { get; set; }
        public decimal? ChargeAmount { get; set; }
        public decimal? PaymentAmount { get; set; }
        public int? PaymentModeId { get; set; }
        public string PaymentRefCode { get; set; }
        public string ChequeNo { get; set; }
        public long? DrugId { get; set; }
        public int? PerOralId { get; set; }
        public string BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Comments { get; set; }
        public string OverrideUser { get; set; }
        public string OverrideComment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? AppointmentId { get; set; }
        public string ActionPerformed { get; set; }
        public DateTime ChangedDate { get; set; }
        public decimal? Discount { get; set; }
    }
}
