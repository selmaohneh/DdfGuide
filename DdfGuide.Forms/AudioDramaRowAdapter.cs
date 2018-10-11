using System;
using DdfGuide.Core;

namespace DdfGuide.Forms
{
    public class AudioDramaRowAdapter
    {
        public Guid Id { get; set; }
        public int? Number { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool Heard { get; set; }
        public bool IsFavorite { get; set; }

        public AudioDramaRowAdapter(AudioDrama audioDrama)
        {
            Id = audioDrama.AudioDramaDto.Id;
            Number = audioDrama.AudioDramaDto.NumberEuropa;
            Name = audioDrama.AudioDramaDto.Title;
            ReleaseDate = audioDrama.AudioDramaDto.ReleaseDate;
            Heard = audioDrama.AudioDramaUserData.Heard;
            IsFavorite = audioDrama.AudioDramaUserData.IsFavorite;
        }
    }
}
