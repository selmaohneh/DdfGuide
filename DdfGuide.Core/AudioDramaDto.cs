using System;

namespace DdfGuide.Core
{
    public class AudioDramaDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }

        public AudioDramaDto(Guid id, string name, int? number)
        {
            Id = id;
            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            var dump = $"{Id} {Name}";

            if (Number.HasValue)
            {
                dump += $" {Number.Value}";
            }
            else
            {
                dump += " NoNumber";
            }

            return dump;
        }
    }
}
