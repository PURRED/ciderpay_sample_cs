using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciderpaysample.API.Dto
{
    public class CpRequestMpToken
    {
        /// <summary>
        /// 회원 아이디
        /// </summary>
        public string memberID { get; set; }

        /// <summary>
        /// 고객 이름
        /// </summary>
        public string customName { get; set; }

        /// <summary>
        /// 고객 핸드폰
        /// </summary>
        public string customMobile { get; set; }

        /// <summary>
        /// 고객 번호
        /// </summary>
        public string customNo { get; set; }

        /// <summary>
        /// 상품명
        /// </summary>
        public string goodName { get; set; }

        /// <summary>
        /// 사유
        /// </summary>
        public string reason { get; set; }

        /// <summary>
        /// 문자 발송 여부
        /// </summary>
        public string sendSms { get; set; }

        /// <summary>
        /// 최초 1회 결제 상품명
        /// </summary>
        public string oneJustPayGoodName { get; set; }

        /// <summary>
        /// 최초 1회 결제 금액
        /// </summary>
        public long oneJustPayPrice { get; set; }
    }
}
