using System;

namespace DdfGuide.Core
{
    public class AudioDramaDto
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
    }
}
