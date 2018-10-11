using System.Collections.Generic;
using DdfGuide.Core.Searching;

namespace DdfGuide.Core
{
    public class AudioDrama : ISearchable
    {
        public AudioDramaDto AudioDramaDto { get; }
        public AudioDramaUserData AudioDramaUserData { get; }

        public AudioDrama(AudioDramaDto audioDramaDto, AudioDramaUserData audioDramaUserData)
        {
            AudioDramaDto = audioDramaDto;
            AudioDramaUserData = audioDramaUserData;
        }

        public override string ToString()
        {
            return $"{AudioDramaDto} {AudioDramaUserData}";
        }
        
        public string ToSearchString()
        {
            return AudioDramaDto.ToSearchString();
        }

        #region equality stuff
        public override bool Equals(object obj)
        {
            if (!(obj is AudioDrama audioDrama))
            {
                return false;
            }

            return Equals(audioDrama);
        }

        public bool Equals(AudioDrama other)
        {
            var dtoEqual = AudioDramaDto.Equals(other.AudioDramaDto);
            var userDataEqual = AudioDramaUserData.Equals(other.AudioDramaUserData);
            var bothEqual = dtoEqual && userDataEqual;

            return bothEqual;
        }

        public override int GetHashCode()
        {
            var hashCode = 967148944;
            hashCode = hashCode * -1521134295 + EqualityComparer<AudioDramaDto>.Default.GetHashCode(AudioDramaDto);
            hashCode = hashCode * -1521134295 + EqualityComparer<AudioDramaUserData>.Default.GetHashCode(AudioDramaUserData);
            return hashCode;
        }

        #endregion
    }
}
