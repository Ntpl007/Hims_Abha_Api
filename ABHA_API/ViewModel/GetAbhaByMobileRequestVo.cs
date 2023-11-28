using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABHA_API.ViewModel
{
    public class GetAbhaByMobileRequestVo
    {
        public string dayOfBirth { get;set;}
        public string firstName { get; set; }
        public string gender { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string monthOfBirth { get; set; }
        public string name { get; set; }
        public string otp { get; set; }
        public string status { get; set; }
        public string txnId { get; set; }
        public string yearOfBirth { get; set; }
     
    }
}
