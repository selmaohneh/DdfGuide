using System;

namespace DdfGuide.Core
{
    public class AudioDramaDto
    {
        public Guid Id { get; set; }

        public AudioDramaDto(Guid id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
