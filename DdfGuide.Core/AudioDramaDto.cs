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
        public string Description { get; set; }
        public string SpotifyAlbumId { get; set; }
        public IEnumerable<RoleDto> Roles { get; set; }

        [JsonIgnore]
        public Uri SpotifyUri => new Uri($"https://open.spotify.com/album/{SpotifyAlbumId}");

        public AudioDramaDto(Guid id, string title, int? numberEuropa, DateTime releaseDate, string coverUrl, string interpreter, string description, IEnumerable<RoleDto> roles, string spotifyAlbumId)
        {
            Id = id;
            Title = title;
            NumberEuropa = numberEuropa;
            ReleaseDate = releaseDate;
            CoverUrl = coverUrl;
            Interpreter = interpreter;
            Description = description;
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

            foreach (var role in Roles)
            {
                searchString += role.ToSearchString();
            }

            return searchString;
        }
    }
}
