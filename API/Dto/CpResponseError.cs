using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciderpaysample.API.Dto
{
    public class CpResponseError
    {
        /// <summary>
        /// 에러 코드
        /// </summary>
        public string errCode { get; set; }

        /// <summary>
        /// 에러 메시지
        /// </summary>
        public string message { get; set; }
    }
}
