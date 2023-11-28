using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABHA_API.ViewModel
{
    public class ReactivateIntiABHARequestVo
    {
        public string authMethod { get; set; }    //": "AADHAAR_OTP",
        public string healthid { get; set; }  // "43-4221-5105-6749"
    }
}
