using System.Collections.Generic;

namespace DdfGuide.Core.Filtering
{
    public class AllAudioDramasFilter: IAudioDramaFilter
    {
        public EAudioDramaFilterMode FilterMode => EAudioDramaFilterMode.AllAudioDramas;

        public IEnumerable<AudioDrama> Filter(IEnumerable<AudioDrama> audioDramas)
        {
            return audioDramas;
        }
    }
}
