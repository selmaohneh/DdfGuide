using System;
using Repository.Interfaces;

namespace DdfGuide.Core
{
    public class AudioDramaDto : RepositoryItem
    {
        public AudioDramaDto(Guid id) : base(id)
        {
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
