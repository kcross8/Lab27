using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27.Models
{
    public class RedditPost
    {
        public string title { get; set; }
        public string thumbnail { get; set; } //this is the image 
        public string permalink { get; set; }
        public Data data { get; set; }
        public string url { get; set; }

    }
    public class Data
    {
        public string modhash { get; set; }
        public int dist { get; set; }
        public Child[] children { get; set; }
        public string after { get; set; }
        public object before { get; set; }
    }
    public class Child
    {
        public string kind { get; set; }
        public RedditPost data { get; set; }
    }
    
}
