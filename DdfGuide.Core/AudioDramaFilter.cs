using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class AudioDramaFilter
    {
        public bool FilterMainAudioDramas { get; set; }

        private readonly IEnumerable<AudioDrama> _audioDramas;

        public AudioDramaFilter(IEnumerable<AudioDrama> audioDramas)
        {
            _audioDramas = audioDramas;
        }
        
        public IEnumerable<AudioDrama> Filter()
        {
            var filtered = _audioDramas;

            if (FilterMainAudioDramas)
            {
                filtered = filtered.Where(x => x.AudioDramaDto.Number.HasValue == false);
            }

            return filtered;
        }
    }
}
