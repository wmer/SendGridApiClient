using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SendGridApiClient.Models {
    public class SendGridEvents {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }
        [JsonProperty("uid")]
        public int UID { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("sendgrid_event_id")]
        public string SendGridEventId { get; set; }
        [JsonProperty("sg_message_id")]
        public string SGMessageId { get; set; }
        [JsonProperty("sendgrid_event")] 
        public string SendGridEvent { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("url")]
        public string URL { get; set; }
        [JsonProperty("useragent")]
        public string UserAgent { get; set; }
        [JsonProperty("ip")]
        public string IP { get; set; }
    }
}
