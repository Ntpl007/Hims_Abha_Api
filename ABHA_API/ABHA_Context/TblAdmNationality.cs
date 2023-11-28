using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblAdmNationality
    {
        public TblAdmNationality()
        {
            TblPatients = new HashSet<TblPatient>();
        }

        public int NationalityId { get; set; }
        public string NationalityName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual ICollection<TblPatient> TblPatients { get; set; }
    }
}
