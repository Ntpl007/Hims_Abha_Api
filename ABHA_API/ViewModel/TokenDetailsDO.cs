using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABHA_API.ViewModel
{
    public class TokenDetailsDO
    {
        public string accessToken { get; set; }
        public string tokenType { get; set; }
        public int expiresIn { get; set; }
        public int refreshExpiresIn { get; set; }
        public string refreshToken { get; set; }
        public string txnId { get; set; }
        public string token { get; set; }
        public string HealthId { get; set; }
        public string photo { get; set; }
        public string status { get; set; }
    }
}
