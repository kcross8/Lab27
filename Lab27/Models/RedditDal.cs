using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lab27.Models
{
    public class RedditDal
    {
        //API calls break in 2 common spots:
        //1: Setting up the request - url
        //2: Deserialization/Serialization (both break easily)
        public string GetAPIJson(string subreddit)
        {
            string url = $"https://www.reddit.com/r/{subreddit}/.json";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader sr = new StreamReader(response.GetResponseStream());
            string output = sr.ReadToEnd();
            return output;
        }
        public RedditPost GetPost(string subreddit)
        {
            string output = GetAPIJson(subreddit);
            JObject json = JObject.Parse(output);
            //jobject is special object designed to work with JSON, lets you manually go in and filter out your JSON
            List<JToken> modelData = json["data"]["children"].ToList();

            //filtered down to data, down to children, go into children, select particular set of data
            //narrowed down to what's relevant for the model
            RedditPost rp = JsonConvert.DeserializeObject<RedditPost>(modelData[3]["data"].ToString());
            return rp;
        }

        public RedditPost GetPosts(string subreddit)
        {
            string data = GetAPIJson(subreddit);
            RedditPost aww = JsonConvert.DeserializeObject<RedditPost>(data);
            return aww;
        }
    }
}
