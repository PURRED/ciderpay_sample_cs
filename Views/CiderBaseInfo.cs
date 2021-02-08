using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciderpaysample.Views
{
    public class CiderBaseInfo
    {
        public string MemberID { get; }

        public string DevID { get; }

        public string DevToken { get; }

        public CiderBaseInfo(string memberId, string devId, string devToken)
        {
            MemberID = memberId;
            DevID = devId;
            DevToken = devToken;
        }
    }
}
