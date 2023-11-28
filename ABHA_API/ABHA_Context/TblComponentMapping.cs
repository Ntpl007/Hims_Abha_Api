using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblComponentMapping
    {
        public int ComponentMappingId { get; set; }
        public string MappingUrl { get; set; }
        public int? Roleid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Createdby { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Modifiedby { get; set; }
    }
}
