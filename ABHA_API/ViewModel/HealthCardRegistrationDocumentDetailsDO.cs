using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABHA_API.ViewModel
{
    public class HealthCardRegistrationDocumentDetailsDO
    {
      
    public string dayOfBirth { get; set; }
        public string documentNumber { get; set; }
        public string documentType { get; set; }
        public string firstName { get; set; }
        public string gender { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string monthOfBirth { get; set; }
        public string yearOfBirth { get; set; }
    }
}
