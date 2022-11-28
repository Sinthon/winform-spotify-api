using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_API.Models
{
    public class SpotifyArtist
    {
        public string ArtistId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Followers { get; set; } = string.Empty;
        public string Popularity { get; set; } = string.Empty;
    }
}
