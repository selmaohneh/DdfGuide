using System;

namespace DdfGuide.Core
{
    public class AudioDramaDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public AudioDramaDto(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
