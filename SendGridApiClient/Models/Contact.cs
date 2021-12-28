using System;
using System.Collections.Generic;
using System.Text;

namespace SendGridApiClient.Models {
    public class Contact {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}
