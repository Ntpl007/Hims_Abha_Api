using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABHA_API.ViewModel
{
    public class StatesVo
    {
        public string code { get; set; }
        public string name { get; set; }

        public DistrictsVo[] districts { get; set; }


      

    }
}
