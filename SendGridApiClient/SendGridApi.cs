using ManyHelpers.API;
using SendGrid;
using SendGridApiClient.Converters;
using SendGridApiClient.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendGridApiClient {
    public class SendGridApi {
        private string _apiKey;
        private string _apiKeyValidation;
        private SendGridClient _client;
        private CosumingHelper _consumingApiHelper;

        public SendGridClient Cliente { get; private set; }

        public SendGridApi(string apiKey) : this(apiKey, null) {
        }

        public SendGridApi(string apiKey, string apiValidationKey) {
            _apiKey = apiKey;
            _apiKeyValidation = apiValidationKey;
            _client = new SendGridClient(apiKey);
            _consumingApiHelper = new CosumingHelper("https://api.sendgrid.com/v3")
                                            .AddcontentType();

            Cliente = _client;
        }

        public async Task<Response> SendSingleEmail(Email email, Dictionary<string, string> customArgs = null, params string[] files) {
            var msg = email.ToSendGridMessageToSingleRecipient();
            if (files != null) { 
                foreach (var file in files) {
                    if (!string.IsNullOrEmpty(file)) {
                        var fileInfo = new FileInfo(file);
                        using (var fileStream = File.OpenRead(file)) {
                            await msg.AddAttachmentAsync(fileInfo.Name, fileStream);
                        }
                    }
                }

            }

            if (customArgs != null && customArgs.Count() > 0) {
                foreach (var arg in customArgs) {
                    msg.AddCustomArg(arg.Key, arg.Value);
                }
            }
            return await _client.SendEmailAsync(msg);
        }

        public async Task<Response> SendToMultipleRecipients(Email email, Dictionary<string, string> customArgs = null, params string[] files) {
            var msg = email.ToSendGridMessageToMultipleRecipients();
            if (files != null) {
                foreach (var file in files) {
                    if (!string.IsNullOrEmpty(file)) {
                        var fileInfo = new FileInfo(file);
                        using (var fileStream = File.OpenRead(file)) {
                            await msg.AddAttachmentAsync(fileInfo.Name, fileStream);
                        }
                    }
                }
                return await _client.SendEmailAsync(msg);
            }

            if (customArgs != null && customArgs.Count() > 0) {
                foreach (var arg in customArgs) {
                    msg.AddCustomArg(arg.Key, arg.Value);
                }
            }

            return await _client.SendEmailAsync(msg);
        }

        public async Task<List<Stats>> GetStats(string startDate, string endDate = null, AggregatedBy aggregatedBy = null, ByType byType = null) {
            var endpoint = $"/stats?start_date={startDate}";
            if (!string.IsNullOrEmpty(endDate)) {
                endpoint = $"{endpoint}&end_date={endDate}";
            }
            if (aggregatedBy != null) {
                endpoint = $"/stats?aggregated_by={aggregatedBy.Value}&start_date={startDate}";
            }
            if (aggregatedBy != null && !string.IsNullOrEmpty(endDate)) {
                endpoint = $"/stats?aggregated_by={aggregatedBy.Value}&start_date={startDate}&end_date={endDate}";
            }

            if (byType != null) {
                endpoint = $"/{byType.Value}{endpoint}";
            }

            var (result, statusCode, message) = await _consumingApiHelper
                                                            .AddBearerAuthentication(_apiKey)
                                                            .GetAssync<List<Stats>>(endpoint);
            return result;
        }

        public async Task<EmailActivity> GetEmailActivity(QueryActivity query = null, int limit = 1000) {
            var endpoint = $"/messages?limit={limit}";
            if (query != null) {
                endpoint = $"/messages?query={query.Value}&limit={limit}";
            }

            var (result, statusCode, message) = await _consumingApiHelper
                                                            .AddBearerAuthentication(_apiKey)
                                                            .GetAssync<EmailActivity>(endpoint);
            return result;
        }

        public async Task<Result> ValidateEmail(EmailValidation emailValidation) {
            var (result, statusCode, message) = await _consumingApiHelper
                                                            .AddBearerAuthentication(_apiKeyValidation)
                                                            .PostAsync<EmailValidation, EmailInfo>("/validations/email", emailValidation);
            return result.result;
        }
    }
}
