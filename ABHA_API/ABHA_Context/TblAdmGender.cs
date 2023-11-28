using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblAdmGender
    {
        public int GenderId { get; set; }
        public string Gender { get; set; }
        public int? StatusId { get; set; }
        public string CreationBy { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
