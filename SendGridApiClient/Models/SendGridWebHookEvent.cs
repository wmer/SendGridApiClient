using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SendGridApiClient.Models {
    public class SendGridWebHookEvent {
        public string CampanhaId { get; set; }
        public string MensagemID { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }
        [JsonProperty("__invalid_name__smtp-id")]
        public string InvalidNameSMTPId { get; set; }
        [JsonProperty("event")]
        public string SendGridEvent { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("sg_event_id")]
        public string SGEventId { get; set; }
        [JsonProperty("sg_message_id")]
        public string SGMessageId { get; set; }
        [JsonProperty("response")]
        public string Response { get; set; }
        [JsonProperty("attempt")]
        public string Attempt { get; set; }
        [JsonProperty("useragent")]
        public string Useragent { get; set; }
        [JsonProperty("ip")]
        public string IP { get; set; }
        [JsonProperty("url")]
        public string URL { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("asm_group_id")]
        public int? ASMGroupId { get; set; }
    }
}
