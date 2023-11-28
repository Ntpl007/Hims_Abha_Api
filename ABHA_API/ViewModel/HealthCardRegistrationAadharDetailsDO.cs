using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABHA_API.ViewModel
{
    public class HealthCardRegistrationAadharDetailsDO
    {
        public string email { get; set; }
        //  public string firstName { get; set; }
        public string healthId { get; set; } = null;
     //   public string lastName { get; set; }
     //   public string middleName { get; set; }
        public string password { get; set; }
    //    public string profilePhoto { get; set; } 
        
        public string txnId { get; set; }
    }
}
