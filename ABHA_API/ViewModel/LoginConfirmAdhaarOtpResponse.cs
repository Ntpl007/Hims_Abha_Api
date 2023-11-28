using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABHA_API.ViewModel
{
    public class LoginConfirmAdhaarOtpResponse
    {
        public int expiresIn { get; set; }
        public int refreshExpiresIn { get; set; }
        public string refreshToken { get; set; }
        public string token { get; set; }
       
    }
}
