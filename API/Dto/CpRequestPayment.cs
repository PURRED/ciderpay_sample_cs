using System;

namespace ciderpaysample.API.Dto
{
    public class CpRequestPayment
    {
        /// <summary>
        /// 회원 아이디
        /// </summary>
        public string memberID { get; set; }

        /// <summary>
        /// 결제 금액
        /// </summary>
        public long price;

        /// <summary>
        /// 과세 금액
        /// </summary>
        public UInt64 taxPrice;

        /// <summary>
        /// 면세 금액
        /// </summary>
        public UInt64 taxFreePrice;

        /// <summary>
        /// 상품명
        /// </summary>
        public string goodName;

        /// <summary>
        /// 고객 휴대폰
        /// </summary>
        public string mobile;

        /// <summary>
        /// 고객명
        /// </summary>
        public string customName;

        /// <summary>
        /// 고객 번호
        /// </summary>
        public string customNo;

        /// <summary>
        /// E-mail
        /// </summary>
        public string email;

        /// <summary>
        /// 피드백 URL
        /// </summary>
        public string feedbackurl;

        /// <summary>
        /// 돌아가기 URL
        /// </summary>
        public string returnurl;

        /// <summary>
        /// 돌아가기 모드
        /// </summary>
        public string returnmode;

        /// <summary>
        /// 임의 변수 1
        /// </summary>
        public string var1;

        /// <summary>
        /// 임의 변수 2
        /// </summary>
        public string var2;

        /// <summary>
        /// SMS 발송 여부
        /// </summary>
        public string smsuse = "Y";

        /// <summary>
        /// 결제 출처
        /// </summary>
        public string whereFrom;

        /// <summary>
        /// 판매자 메모
        /// </summary>
        public string sellerMemo;
    }
}
