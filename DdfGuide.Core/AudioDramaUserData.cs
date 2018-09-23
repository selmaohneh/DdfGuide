using System;
using Repository.Interfaces;

namespace DdfGuide.Core
{
    public class AudioDramaUserData : RepositoryItem
    {
        public bool Heard { get; set; }

        public AudioDramaUserData(Guid id, bool heard) : base(id)
        {
            Heard = heard;
        }
    }
}
