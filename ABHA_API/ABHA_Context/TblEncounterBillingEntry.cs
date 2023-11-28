using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblEncounterBillingEntry
    {
        public string EncounterEntryId { get; set; }
        public long EncounterId { get; set; }
        public long? PatientId { get; set; }
        public int ChargeItemId { get; set; }
        public DateTime? DateOfService { get; set; }
        public int? ProviderId { get; set; }
        public long? AdmissionTransferId { get; set; }
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
        public int? EncounterOrderId { get; set; }
        public int? FacilityId { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public int? AppointmentId { get; set; }
        public bool? OnTheHouse { get; set; }
        public int? RegisterId { get; set; }
        public long? InvoiceId { get; set; }
        public decimal? ReferringPhysicianCommissionAmount { get; set; }
        public decimal? ProviderCommissionAmount { get; set; }
        public int? ReferringPhysicianId { get; set; }
        public long? BillNo { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? Discount { get; set; }
        public int? ChargeGroupId { get; set; }
        public string Mode { get; set; }
        public string LabBillComments { get; set; }
        public int? SequenceNumber { get; set; }
        public decimal? DueAmount { get; set; }
        public bool? IsChargeItemDeleted { get; set; }
        public bool? IsCorporatePaymentForLabs { get; set; }
        public bool? IsFromLabBill { get; set; }
        public long? BloodInventoryEntryId { get; set; }
        public int? PaymentEntryId { get; set; }
        public long? RefBillNo { get; set; }
        public bool? IsAuthorisedPayment { get; set; }
        public decimal? AuthorisedRefundAmount { get; set; }
        public string RefundAgainstBillingEntryId { get; set; }
        public bool? IsInitialPayment { get; set; }
        public bool? IsConcessionAuthorised { get; set; }
        public bool? IsRefundAuthorised { get; set; }
    }
}
