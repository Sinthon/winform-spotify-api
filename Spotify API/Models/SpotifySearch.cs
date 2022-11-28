using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_API.Models
{
    public class SpotifySearch
    {
        public class ExternalUrls
        {
            public string spotify { get; set; } = string.Empty;
        }

        public class Followers
        {
            public object href { get; set; } = string.Empty;
            public int total { get; set; }
        }

        public class ImageSP
        {
            public int width { get; set; }
            public string url { get; set; } = string.Empty;
            public int height { get; set; }
        }

        public class Item
        {
            public ExternalUrls external_urls { get; set; } = new ExternalUrls();
            public Followers followers { get; set; } = new Followers();
            public List<string> genres { get; set; } = new List<string>();
            public string href { get; set; } = string.Empty;
            public string id { get; set; } = string.Empty;
            public List<ImageSP> images { get; set; } = new List<ImageSP>();
            public string name { get; set; } = string.Empty;
            public int popularity { get; set; }
            public string type { get; set; } = string.Empty;
            public string uri { get; set; } = string.Empty;
        }

        public class Artists
        {
            public string href { get; set; } = string.Empty;
            public List<Item> items { get; set; } = new List<Item>();
            public int limit { get; set; }
            public string next { get; set; } = string.Empty;
            public int offset { get; set; }
            public object previous { get; set; } = new object();
            public int total { get; set; }
        }

        public class SpotifyResult
        {
            public Artists artists { get; set; } = new Artists();
        }
    }
}
