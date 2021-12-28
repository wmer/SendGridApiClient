using SendGrid.Helpers.Mail;
using SendGridApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendGridApiClient.Converters {
    public static class EmailToSendGridMessageConverter {
        public static SendGridMessage ToSendGridMessageToMultipleRecipients(this Email email) {
            return MailHelper.CreateSingleEmailToMultipleRecipients(email.From.ToEmailAdress(),
                                                                       email.To.ToListEmailAdress(),
                                                                       email.Subject,
                                                                       email.PlainTextContent,
                                                                       email.HtmlContent,
                                                                       email.ShowAllRecipients);
        }

        public static SendGridMessage ToSendGridMessageToSingleRecipient(this Email email) {
            return MailHelper.CreateSingleEmail(email.From.ToEmailAdress(),
                                                    email.To[0].ToEmailAdress(),
                                                    email.Subject,
                                                    email.PlainTextContent,
                                                    email.HtmlContent);
        }
    }
}
