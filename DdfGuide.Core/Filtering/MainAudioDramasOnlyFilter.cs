using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Filtering
{
    public class MainAudioDramasOnlyFilter : IAudioDramaFilter
    {
        public EAudioDramaFilterMode FilterMode => EAudioDramaFilterMode.MainAudioDramasOnly;

        public IEnumerable<AudioDrama> Filter(IEnumerable<AudioDrama> audioDramas)
        {
            var filtered = audioDramas.Where(x => x.AudioDramaDto.Number.HasValue);

            return filtered;
        }
    }
}
