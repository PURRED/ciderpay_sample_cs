using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciderpaysample.API.Dto
{
    public class CpDevInfo
    {
        public string DevID { get; }

        public string DevToken { get; }

        public CpDevInfo(string devId, string devToken)
        {
            DevID = devId;
            DevToken = devToken;
        }
    }
}
