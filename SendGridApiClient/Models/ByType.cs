using System;
using System.Collections.Generic;
using System.Text;

namespace SendGridApiClient.Models {
    public class ByType {
        private ByType(string value) { Value = value; }

        public string Value { get; set; }

        public static ByType Country { get { return new ByType("geo"); } }
        public static ByType Device { get { return new ByType("devices"); } }
        public static ByType EmailClient { get { return new ByType("clients"); } }
        public static ByType Browser { get { return new ByType("browsers"); } }
    }
}
