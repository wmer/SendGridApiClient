using System;
using System.Collections.Generic;
using System.Text;

namespace SendGridApiClient.Models; 
public class Stats {
    public string date { get; set; }
    public List<Stat> stats { get; set; }
}
