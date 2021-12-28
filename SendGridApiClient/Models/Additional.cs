using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendGridApiClient.Models {
    public class Additional {
        public bool has_known_bounces { get; set; }
        public bool has_suspected_bounces { get; set; }
    }
}
