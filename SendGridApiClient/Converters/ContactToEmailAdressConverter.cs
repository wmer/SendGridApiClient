using SendGrid.Helpers.Mail;
using SendGridApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendGridApiClient.Converters {
    public static class ContactToEmailAdressConverter {
        public static EmailAddress ToEmailAdress(this Contact contact) {
            return new EmailAddress(contact.Email, contact.Name);
        }

        public static List<EmailAddress> ToListEmailAdress(this List<Contact> contacts) {
            var list = new List<EmailAddress>();

            foreach (var contact in contacts) {
                list.Add(contact.ToEmailAdress());
            }

            return list;
        }
    }
}
