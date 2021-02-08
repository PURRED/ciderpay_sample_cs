using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ciderpaysample.API.Dto;

namespace ciderpaysample.API
{
    public interface ICiderpayApi
    {
        /// <summary>
        /// 사이다 페이 결제 요청
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        Task<CpResponsePayment> RequestPayment(CpRequestPayment requestData);
    }
}
