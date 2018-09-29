using System;
using DdfGuide.Core.Models;

namespace DdfGuide.Forms
{
    public class AudioDramaRow
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Heard { get; set; }
        public bool IsFavorite { get; set; }

        public AudioDramaRow(AudioDrama audioDrama)
        {
            Id = audioDrama.AudioDramaDto.Id;
            Name = audioDrama.AudioDramaDto.Name;
            Heard = audioDrama.AudioDramaUserData.Heard;
            IsFavorite = audioDrama.AudioDramaUserData.IsFavorite;
        }
    }
}
