using System;
using DdfGuide.Core.Searching;

namespace DdfGuide.Core
{
    public class AudioDramaDto : ISearchable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }
        public DateTime ReleaseDate { get; set; }

        public AudioDramaDto(Guid id, string name, int? number, DateTime releaseDate)
        {
            Id = id;
            Name = name;
            Number = number;
            ReleaseDate = releaseDate;
        }

        public override string ToString()
        {
            var dump = string.Empty;

            if (Number.HasValue)
            {
                dump += $"{Number.Value}";
            }
            else
            {
                dump += "NoNumber";
            }

            dump += $" {Name} {ReleaseDate.Date}";
            
            return dump;
        }

        public string ToSearchString()
        {
            var searchString = string.Empty;
            var properties = GetType().GetProperties();

            foreach (var propertyInfo in properties)
            {
                var propertyValue = propertyInfo.GetValue(this);
                searchString += propertyValue?.ToString();
            }

            return searchString;
        }
    }
}
