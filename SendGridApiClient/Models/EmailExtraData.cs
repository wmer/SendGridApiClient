using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendGridApiClient.Models; 
public class EmailExtraData {
    public EmailAddress Email { get; set; }
    public string? Subject { get; set; }
    public Dictionary<string, string> Substitutions { get; set; }
    public Dictionary<string, string> CustomArgs { get; set; }
}
 