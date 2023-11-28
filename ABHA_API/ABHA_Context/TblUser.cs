using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class TblUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public long? MobileNumber { get; set; }
        public string Password { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string EncryptedPassword { get; set; }
        public string EncryptedKey { get; set; }
        public string EncryptedIv { get; set; }
        public int? FacilityId { get; set; }
        public int? OrganizationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
