using System;
using System.Collections.Generic;
using System.Text;

namespace SendGridApiClient.Models {
    public class QueryActivity {
        public QueryActivity(string query) {
            Value = query;
        }
        public string Value { get; set; }


        public static QueryActivity ById(string id) =>
                            new QueryActivity($"msg_id=\"{Uri.EscapeDataString(id)}\"");
        public static QueryActivity ByToEmail(string email) =>
                            new QueryActivity($"to_email=\"{Uri.EscapeDataString(email)}\"");
        public static QueryActivity ByFromEmail(string email) =>
                            new QueryActivity($"from_email=\"{Uri.EscapeDataString(email)}\"");
        public static QueryActivity BySubject(string subject) =>
                            new QueryActivity($"subject=\"{Uri.EscapeDataString(subject)}\"");
        public static QueryActivity ByStatus(string status) =>
                            new QueryActivity($"status=\"{Uri.EscapeDataString(status)}\"");
        public static QueryActivity ByCustomArgs(string key, string value) =>
                            new QueryActivity(Uri.EscapeDataString($"(unique_args['{key}']='{value}')"));

    }
}
