using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblAdmWmRoomType
    {
        public int RoomTypeId { get; set; }
        public string RoomType { get; set; }
        public string RoomTypeDescription { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ConsultationChargeItemId { get; set; }

        public virtual TblAdmStatus Status { get; set; }
    }
}
