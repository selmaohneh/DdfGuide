using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Filtering
{
    public class MainAudioDramasOnlyFilter : IAudioDramaFilter
    {
        public EAudioDramaFilterMode FilterMode => EAudioDramaFilterMode.MainsOnly;

        public IEnumerable<AudioDrama> Filter(IEnumerable<AudioDrama> audioDramas)
        {
            var filtered = audioDramas.Where(x => x.AudioDramaDto.NumberEuropa.HasValue);

            return filtered;
        }
    }
}
