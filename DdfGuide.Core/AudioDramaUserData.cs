using System;
using Repository.Interfaces;

namespace DdfGuide.Core
{
    public class AudioDramaUserData : RepositoryItem
    {
        public bool Heard { get; set; }
        public bool IsFavorite { get; set; }

        public AudioDramaUserData(Guid id, bool heard, bool isFavorite) : base(id)
        {
            Heard = heard;
            IsFavorite = isFavorite;
        }

        public override string ToString()
        {
            return $"Heard: {Heard}, IsFavorite: {IsFavorite}";
        }
    }
}
