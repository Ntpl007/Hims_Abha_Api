using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblAdmChargeItem
    {
        public int ChargeItemId { get; set; }
        public string ChargeItem { get; set; }
        public int ChargeTypeId { get; set; }
        public int? ChargeGroupId { get; set; }
        public int? DepartmentId { get; set; }
        public int FromAccountId { get; set; }
        public int ToAccountId { get; set; }
        public int? ServiceDuration { get; set; }
        public decimal UnitCost { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? DoctorAmount { get; set; }
        public decimal? RefDoctorAmount { get; set; }
        public decimal? AnesthesianCharges { get; set; }
        public bool IsBillable { get; set; }
        public bool IsPayment { get; set; }
        public bool? IsBundle { get; set; }
        public bool? IsEditable { get; set; }
        public string ShortName { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? RoomTypeId { get; set; }
        public bool? IsFrequentlyUsedLab { get; set; }
        public string ChargeItemDisplayName { get; set; }
        public bool? IsLabBill { get; set; }
        public bool? IsOpConsultation { get; set; }
        public int? NumberOfUnitsPerDay { get; set; }
        public decimal? RadiologyCharges { get; set; }
        public decimal? RefDoctorPercentage { get; set; }
        public string TaxPercentage { get; set; }
        public bool? InclusiveCharges { get; set; }
        public bool? InclusiveDiscounts { get; set; }
    }
}
