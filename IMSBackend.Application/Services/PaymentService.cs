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
            try
            {
                var url = $"https://api.flutterwave.com/v3/transactions/verify_by_reference?tx_ref={Uri.EscapeDataString(tx_ref)}";

                var httpRequest = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(url),
                    Headers =
            {
                { "accept", "application/json" },
                { "Authorization", $"Bearer FLWSECK_TEST-ad4dffd9eb56d6c5b05fd394c8b99245-X" }
            },
                };

                var responseStream = await _httpClient.SendAsync(httpRequest);

                var result = await responseStream.Content.ReadAsStringAsync();

                if (!responseStream.IsSuccessStatusCode)
                {
                    // Optional: log result here for debugging
                    return new PaymentVerification();
                }

                return JsonConvert.DeserializeObject<PaymentVerification>(result)!;
            }
            catch (Exception ex)
            {
                // Optional: log exception
                return new PaymentVerification();
            }
        }


    }
}
