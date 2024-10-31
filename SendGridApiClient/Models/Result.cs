using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendGridApiClient.Models; 
public class Result {
    public string email { get; set; }
    public string verdict { get; set; }
    public double score { get; set; }
    public string local { get; set; }
    public string host { get; set; }
    public Checks checks { get; set; }
    public string source { get; set; }
    public string ip_address { get; set; }
}
