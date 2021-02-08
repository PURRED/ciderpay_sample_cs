using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciderpaysample.API.Dto
{
    public class CpResponsePayment
    {
        /// <summary>
        /// 성공 여부
        /// </summary>
        public bool success { get; set; }

        /// <summary>
        /// 결제 URL
        /// </summary>
        public string payUrl { get; set; }

        /// <summary>
        /// 결제 요청 번호
        /// </summary>
        public string payUniqueNo { get; set; }

        public override string ToString()
        {
            return $"{nameof(success)}: {success}, {nameof(payUrl)}: {payUrl}, {nameof(payUniqueNo)}: {payUniqueNo}";
        }
    }
}
