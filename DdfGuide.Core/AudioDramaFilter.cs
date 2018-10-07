using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class AudioDramaFilter : IAudioDramaFilter
    {
        public bool IncludeMainAudioDramas { get; set; } = true;
        
        public IEnumerable<AudioDrama> Filter(IEnumerable<AudioDrama> audioDramas)
        {
            var filtered = audioDramas;

            if (!IncludeMainAudioDramas)
            {
                filtered = filtered.Where(x => x.AudioDramaDto.Number.HasValue == false);
            }

            return filtered;
        }
    }
}
