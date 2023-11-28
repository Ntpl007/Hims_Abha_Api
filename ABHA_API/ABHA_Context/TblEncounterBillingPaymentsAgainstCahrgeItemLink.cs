using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblEncounterBillingPaymentsAgainstCahrgeItemLink
    {
        public string PaymentBillingEntryId { get; set; }
        public string PaymentAgainstBillingEntryId { get; set; }
        public int ChargeItemId { get; set; }
        public long EncounterId { get; set; }
        public decimal? PaidAmount { get; set; }
    }
}
