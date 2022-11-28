using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_API.Models
{
    public class Token
    {
        public string access_token { get; set; } = string.Empty;

        public string token_type { get; set; } = string.Empty;

        public int expires_in { get; set; }
    }
}
