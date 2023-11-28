using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblAccount
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountDescription { get; set; }
        public int AccountTypeId { get; set; }
        public int AccountStatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblAdmAccountStatus AccountStatus { get; set; }
        public virtual TblAdmAccountType AccountType { get; set; }
    }
}
