using IMSBackend.Application.Dtos.Flutterwave;
using IMSBackend.Application.Contracts;
using IMSBackend.Common;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;
using HOPRIDESOLUTION.Infrastructure.Settings;
using IMSBackend.Domain.Shared;
using IMSBackend.Domain.Entities.Award;
using IMSBackend.Common.Enums;
using IMSBackend.Domain.Entities.Transactions;

namespace IMSBackend.Application.Services
{
    public class PaymentService : IPaymentService
    {
        private IHttpClientFactory _httpClientFactory;
        private readonly IUnitOfWork _unitOfWork;
        private HttpClient _httpClient;
        private FlutterwaveSettings _flutterwaveSettings;
        public PaymentService(HttpClient httpClient, IOptions<FlutterwaveSettings> options, IHttpClientFactory httpClientFactory, IUnitOfWork unitOfWork)
        {
            _httpClient = httpClient;
            _flutterwaveSettings = options.Value;
            _httpClientFactory = httpClientFactory;
        }
    
        public async Task<PaymentVerification> GetTransactionStatus(string tx_ref)
        {
            string result = string.Empty;
            try
            {
                var httpRequest = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"{_flutterwaveSettings.BaseUrl}transactions/verify_by_reference?tx_ref={tx_ref}"),
                    Headers =
                    {
                        { "accept", "application/json" },
                        { "Authorization", $"Bearer {_flutterwaveSettings.SecretKey}" }
                    },
                };
                var responseStream = await _httpClient.SendAsync(httpRequest);
                if (!responseStream.IsSuccessStatusCode)
                {
                    result = await responseStream.Content.ReadAsStringAsync();
                    return new PaymentVerification();
                }
                result = await responseStream.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<PaymentVerification>(result)!;
                return response;
            }
            catch (Exception ex)
            {
                return new PaymentVerification();
            }
        }

    }
}
