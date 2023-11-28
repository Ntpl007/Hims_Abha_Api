using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABHA_API.ViewModel
{
    public class SearchByMobileResponseVo
    {
        public string[] authMethods { get; set; }
        public string healthId { get; set; }
        public string healthIdNumber { get; set; }
        public string name { get; set; }
        public string status { get; set; }
      
    }
}
