using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblCorporate
    {
        public int CorporateId { get; set; }
        public string CorporateName { get; set; }
        public string ListName { get; set; }
        public bool? IncludeAllTestsForOrders { get; set; }
        public string FederalTaxId { get; set; }
        public int? FederalTaxIdType { get; set; }
        public int? InsuranceCarrierId { get; set; }
        public string GroupNumber { get; set; }
        public int? AllocationSetId { get; set; }
        public int? FinancialClassId { get; set; }
        public decimal? PrepaidMinAmount { get; set; }
        public int? StatusId { get; set; }
        public string CorporateState { get; set; }
        public string TypeOfContract { get; set; }
        public DateTime? ContractFrom { get; set; }
        public DateTime? ContractTo { get; set; }
        public int? PaymentDate { get; set; }
        public int? AppNoOfRegMonth { get; set; }
        public decimal? CreditLimit { get; set; }
        public decimal? DiscountPer { get; set; }
        public string CommisionState { get; set; }
        public decimal? PerCommision { get; set; }
        public string CommPaymentType { get; set; }
        public string BankAccNo { get; set; }
        public string OtherDetails { get; set; }
        public short? ContractDuration { get; set; }
        public string BillingAddress { get; set; }
        public decimal? RegAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public string EmailAddress { get; set; }
        public string WebUserid { get; set; }
        public string WebPassword { get; set; }
        public string PayVisitwise { get; set; }
        public string ReportType { get; set; }
        public string City { get; set; }
        public byte? PricelistId { get; set; }
        public string AutoReport { get; set; }
        public string IsSmsRequired { get; set; }
        public string PaymentMode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsFree { get; set; }
        public bool? IsOverrideCorporate { get; set; }
        public string SponsorName { get; set; }
        public string InsurRefLetterNo { get; set; }
        public DateTime? InsurRefLetterDate { get; set; }
        public DateTime? InsurRefStartDate { get; set; }
        public DateTime? InsurRefEndDate { get; set; }
        public string InsurEmpCode { get; set; }
        public string InsurEmpRelation { get; set; }
        public string InsurEmpName { get; set; }
        public decimal? InsurBasicSalary { get; set; }
        public bool? IsCredit { get; set; }

        public virtual TblAdmStatus Status { get; set; }
    }
}
