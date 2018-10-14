using System;
using System.Collections.Generic;
using DdfGuide.Core.Searching;

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
        public IEnumerable<RoleDto> Roles { get; set; }

        public AudioDramaDto(Guid id, string title, int? numberEuropa, DateTime releaseDate, string coverUrl, string interpreter, string description, IEnumerable<RoleDto> roles)
        {
            Id = id;
            Title = title;
            NumberEuropa = numberEuropa;
            ReleaseDate = releaseDate;
            CoverUrl = coverUrl;
            Interpreter = interpreter;
            Description = description;
            Roles = roles;
        }

        public override string ToString()
        {
            var dump = string.Empty;

            if (NumberEuropa.HasValue)
            {
                dump += $"{NumberEuropa.Value}";
            }
            else
            {
                dump += "NoNumber";
            }

            dump += $" {Title} {ReleaseDate.Date:dd.MM.yyyy}";
            
            return dump;
        }

        public string ToSearchString()
        {
            var searchString = string.Empty;
            searchString += Title;
            searchString += NumberEuropa;
            searchString += ReleaseDate;
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
