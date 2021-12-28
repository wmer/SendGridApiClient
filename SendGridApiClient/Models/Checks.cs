using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendGridApiClient.Models {
    public class Checks {
        public Domain domain { get; set; }
        public LocalPart local_part { get; set; }
        public Additional additional { get; set; }
    }
}
