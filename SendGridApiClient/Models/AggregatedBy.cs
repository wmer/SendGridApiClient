using System;
using System.Collections.Generic;
using System.Text;

namespace SendGridApiClient.Models {
    public class AggregatedBy {
        private AggregatedBy(string value) { Value = value; }

        public string Value { get; set; }

        public static AggregatedBy Day { get { return new AggregatedBy("day"); } }
        public static AggregatedBy Week { get { return new AggregatedBy("week"); } }
        public static AggregatedBy Month { get { return new AggregatedBy("month"); } }
    }


}
