using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendGridApiClient.Models {
    public class Domain {
        public bool has_valid_address_syntax { get; set; }
        public bool has_mx_or_a_record { get; set; }
        public bool is_suspected_disposable_address { get; set; }
    }
}
