using System;
using System.Collections.Generic;
using DdfGuide.Core.Searching;
using Newtonsoft.Json;

namespace DdfGuide.Core
{
    public class AudioDramaDto : ISearchable
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int? NumberEuropa { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CoverUrl { get; set; }
        public string Interpreter { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string SpotifyAlbumId { get; set; }
        public IEnumerable<RoleDto> Roles { get; set; }

        [JsonIgnore]
        public Uri SpotifyUri => new Uri($"https://open.spotify.com/album/{SpotifyAlbumId}");

        [JsonIgnore]
        public Uri AmazonBuyUri => new Uri($"https://www.amazon.de/gp/product/B01CURZRWG/ref=as_li_tl?ie=UTF8&camp=1638&creative=6742&creativeASIN={AmazonBuyUri}&linkCode=as2&tag=selmaohneh-21&linkId=7f31d23d30f02218a552f5642ac40dc9");

        public AudioDramaDto(Guid id,
                             string title,
                             int? numberEuropa,
                             DateTime releaseDate,
                             string coverUrl,
                             string interpreter,
                             string description,
                             IEnumerable<RoleDto> roles,
                             string spotifyAlbumId,
                             string author)
        {
            Id = id;
            Title = title;
            NumberEuropa = numberEuropa;
            ReleaseDate = releaseDate;
            CoverUrl = coverUrl;
            Interpreter = interpreter;
            Description = description;
            Author = author;
            SpotifyAlbumId = spotifyAlbumId;
            Roles = roles ?? new List<RoleDto>();
        }

        public override string ToString()
        {
            var dump = string.Empty;

            if (NumberEuropa.HasValue)
            {
                dump += $"{NumberEuropa.Value} / ";
            }

            dump += $"{Title}";

            return dump;
        }

        public string ToSearchString()
        {
            var searchString = string.Empty;
            searchString += Title;
            searchString += NumberEuropa;
            searchString += ReleaseDate.ToString("dd.MM.yyyy");
            searchString += Interpreter;
            searchString += Description;
            searchString += Author;

            foreach (var role in Roles)
            {
                searchString += role.ToSearchString();
            }

            return searchString;
        }
    }
}