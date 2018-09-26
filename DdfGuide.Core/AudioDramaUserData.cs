using System;

namespace DdfGuide.Core
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
            var dumper = new Dumper();
            var dump = dumper.Dump(this);

            return dump;
        }
    }
}
