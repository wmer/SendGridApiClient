using System;
using System.Collections.Generic;
using System.Text;

namespace SendGridApiClient.Models; 
public class Message {
    public string from_email { get; set; }
    public string msg_id { get; set; }
    public string subject { get; set; }
    public string to_email { get; set; }
    public string status { get; set; }
    public int opens_count { get; set; }
    public int clicks_count { get; set; }
    public DateTime last_event_time { get; set; }
}
