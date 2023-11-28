using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblAdmAccountStatus
    {
        public TblAdmAccountStatus()
        {
            TblAccounts = new HashSet<TblAccount>();
        }

        public int AccountStatusId { get; set; }
        public string AccountStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<TblAccount> TblAccounts { get; set; }
    }
}
