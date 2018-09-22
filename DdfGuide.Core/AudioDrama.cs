using System;
using Repository.Interfaces;

namespace DdfGuide.Core
{
    public class AudioDrama : RepositoryItem
    {
        public AudioDrama(Guid id) : base(id)
        {
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
