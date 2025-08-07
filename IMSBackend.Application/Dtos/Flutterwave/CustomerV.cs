using IMSBackend.Common.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Annotations;

namespace IMSBackend.Application.Dtos.Flutterwave
{
    public class PaymentStatusResponseDTO
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        public MakePaymentResponseFlutter FlutterwaveResponse { get; set; }
    }
    public class PaymentResponseDTO
    {
        public string PayOutStatus { get; set; }
        public string? Description { get; set; }
        public string? ProviderReferenceId { get; set; }
        public FlutterData FlutterData { get; set; }
    }

    public class PaymentVerification
    {
        public string status { get; set; }
        public string message { get; set; }
        public DataVerification data { get; set; }
    }


    public class DataVerification
    {
        public int id { get; set; }
        public string tx_ref { get; set; }
        public string flw_ref { get; set; }
        public string device_fingerprint { get; set; }
        public decimal amount { get; set; }
        public string currency { get; set; }
        public decimal charged_amount { get; set; }
        public decimal app_fee { get; set; }
        public decimal merchant_fee { get; set; }
        public string processor_response { get; set; }
        public string auth_model { get; set; }
        public string ip { get; set; }
        public string narration { get; set; }
        public string status { get; set; }
        public string payment_type { get; set; }
        public DateTime created_at { get; set; }
        public int account_id { get; set; }
        public Card card { get; set; }
    }


    public class Card
    {
        public string first_6digits { get; set; }
        public string last_4digits { get; set; }
        public string issuer { get; set; }
        public string country { get; set; }
        public string type { get; set; }
        public string token { get; set; }
        public string expiry { get; set; }
    }

    public class VerifyPaymentDto
    {
        public decimal AmountPaid { get; set; }
        public Guid UserId { get; set; }
        public string ReferenceNumber { get; set; }
        public Guid? VoteId { get; set; }
        public Guid? TicketId { get; set; }
        public string Status { get; set; }

    }

   
    public class MakePaymentResponseFlutter
    {
        public string status { get; set; }

        public bool isException { get; set; }
        public string message { get; set; }


        [JsonProperty("reference")]
        public string transactionReference { get; set; }

        [JsonProperty("data")]
        public FlutterData data { get; set; }



        public MakePaymentResponseFlutter()
        {
            isException = false;
        }
    }

    public class FlutterData
    {
        [JsonProperty("id")]
        public long id { get; set; }

        [JsonProperty("reference")]
        public string reference { get; set; }

        [JsonProperty("complete_message")]
        public string complete_message { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }
    }

    public class FlutterwaveRequestModel
    {
        public string account_number { get; set; }
        public string account_bank { get; set; }
    }
    public class FlutterwaveFetchPaymentRequestDTO
    {

        public string tx_ref { get; set; }
    }
    public class FlutterWaveMakePaymentRequest
    {
        [JsonProperty("account_bank")]
        public string AccountBank { get; set; }

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("narration")]
        public string Narration { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

    }

    public class FlutterWaveMakePaymentNGBankRequest : FlutterWaveMakePaymentRequest
    {

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("debit_currency")]
        public string DebitCurrency { get; set; }
    }





    public class FlutterWaveMakePaymentGHBankRequest : FlutterWaveMakePaymentRequest
    {
        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("destination_branch_code")]
        public string DestinationBranchCode { get; set; }

        [JsonProperty("beneficiary_name")]
        public string BeneficiaryName { get; set; }
    }


    public class FlutterWaveMakePaymentGHMobileMoney : FlutterWaveMakePaymentRequest
    {
        [JsonProperty("beneficiary_name")]
        public string BeneficiaryName { get; set; }
    }


    public class FlutterWaveMakePaymentKESBankRequest : FlutterWaveMakePaymentRequest
    {
        [JsonProperty("debit_currency")]
        public string DebitCurrency { get; set; }
        [JsonProperty("beneficiary_name")]
        public string BeneficiaryName { get; set; }
        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }
        [JsonProperty("meta")]
        public List<FlutterWaveMakePaymentKESMeta> Meta { get; set; }
    }

    public class FlutterWaveMakePaymentKESMobileMoney : FlutterWaveMakePaymentRequest
    {
        [JsonProperty("beneficiary_name")]
        public string BeneficiaryName { get; set; }
        [JsonProperty("meta")]
        public List<FlutterWaveMakePaymentKESMeta> Meta { get; set; }
    }

    public class FlutterWaveMakePaymentKESMeta
    {
        [JsonProperty("sender")]
        public string Sender { get; set; }
        [JsonProperty("sender_country")]
        public string SenderCountry { get; set; }
        [JsonProperty("mobile_number")]
        public string MobileNumber { get; set; }
    }


    public class FlutterWaveMakePaymentZARBankRequest : FlutterWaveMakePaymentRequest
    {
        [JsonProperty("debit_currency")]
        public string DebitCurrency { get; set; }
        [JsonProperty("beneficiary_name")]
        public string BeneficiaryName { get; set; }
        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }
        [JsonProperty("meta")]
        public List<FlutterWaveMakePaymentZARMeta> Meta { get; set; }
    }

    public class FlutterWaveMakePaymentZARMeta
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("mobile_number")]
        public string MobileNumber { get; set; }
        [JsonProperty("recipient_address")]
        public string RecipientAddress { get; set; }
    }

    public class FlutterWaveMakePaymentEGPBankRequest : FlutterWaveMakePaymentRequest
    {
        [JsonProperty("beneficiary_name")]
        public string BeneficiaryName { get; set; }
        [JsonProperty("meta")]
        public List<FlutterWaveMakePaymentEGPMeta> Meta { get; set; }
    }

    public class FlutterWaveMakePaymentEGPMeta
    {
        [JsonProperty("sender")]
        public string Sender { get; set; }
        [JsonProperty("sender_id_expiry")]
        public string SenderIdExpiry { get; set; }
        [JsonProperty("sender_id_number")]
        public string SenderIdNumber { get; set; }
        [JsonProperty("sender_date_of_birth")]
        public string SenderDateOfBirth { get; set; }
        [JsonProperty("sender_id_type")]
        public string SenderIdType { get; set; }
        [JsonProperty("beneficiary_address")]
        public string BeneficiaryAddress { get; set; }
        [JsonProperty("beneficiary_id_number")]
        public string BeneficiaryIdNumber { get; set; }
        [JsonProperty("is_cash_pickup")]
        public bool IsCashPickup { get; set; }
        [JsonProperty("transfer_purpose")]
        public string TransferPurpose { get; set; }
    }


    public class FlutterWaveMakePaymentXOFXAFSenegalMobileMoney : FlutterWaveMakePaymentRequest
    {
        [JsonProperty("beneficiary_name")]
        public string BeneficiaryName { get; set; }
        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }
        [JsonProperty("debit_currency")]
        public string DebitCurrency { get; set; }

    }

    public class FlutterWaveMakePaymentGenericMobileMoney : FlutterWaveMakePaymentRequest
    {
        [JsonProperty("beneficiary_name")]
        public string BeneficiaryName { get; set; }

    }
    public class FlutterwaveModelData
    {
        public string account_number { get; set; }
        public string account_name { get; set; }
    }

    public class FlutterwaveModelResponse
    {
        public string status { get; set; }
        public string message { get; set; }
        public FlutterwaveModelData data { get; set; }
    }

}
