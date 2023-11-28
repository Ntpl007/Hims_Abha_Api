using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblAdmState
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Createdby { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Updatedby { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
