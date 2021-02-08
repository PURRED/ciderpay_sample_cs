using System.Net;
using System.Threading.Tasks;
using ciderpaysample.API.Dto;
using Newtonsoft.Json;
using RestSharp;


namespace ciderpaysample.API
{
    public class CiderpayApi : ICiderpayApi
    {
        private const string API_ROOT = "https://api.ciderpay.com";

        // 테스트 사이트
        // private const string API_ROOT = "https://tapi.ciderpay.com";


        public async Task<CpResponsePayment> RequestPayment(CpRequestPayment requestData)
        {
            var client = new RestClient(API_ROOT);
            var request = new RestRequest("/oapi/payment/request", Method.POST);

            request.AddJsonBody(requestData);

            var response = await client.ExecuteAsync<CpResponsePayment>(request);

            // 성공
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return response.Data;
            }
            
            var err = JsonConvert.DeserializeObject<CpResponseError>(response.Content);

            throw new CiderpayException(err);
        }
    }
}
