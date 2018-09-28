using System;

namespace DdfGuide.Core.Models
{
    public class AudioDramaUserData
    {
        public Guid Id { get; set; }
        public bool Heard { get; set; }
        public bool IsFavorite { get; set; }

        public AudioDramaUserData(Guid id, bool heard, bool isFavorite)
        {
            Id = id;
            Heard = heard;
            IsFavorite = isFavorite;
        }

        public override string ToString()
        {
            var dump = string.Empty;

            if (Heard)
            {
                dump += "h(x)";
            }
            else
            {
                dump += "h( )";
            }

            if (IsFavorite)
            {
                dump += " f(x)";
            }
            else
            {
                dump += " f( )";
            }

            return dump;
        }
    }
}
