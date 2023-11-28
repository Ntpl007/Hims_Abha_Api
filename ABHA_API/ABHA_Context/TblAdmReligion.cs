using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblAdmReligion
    {
        public TblAdmReligion()
        {
            TblPatients = new HashSet<TblPatient>();
        }

        public int ReligionId { get; set; }
        public string ReligionName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual ICollection<TblPatient> TblPatients { get; set; }
    }
}
