using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Filtering
{
    public class UnheardOnlyFilter : IAudioDramaFilter
    {
        public EAudioDramaFilterMode FilterMode => EAudioDramaFilterMode.UnheardOnly;

        public IEnumerable<AudioDrama> Filter(IEnumerable<AudioDrama> audioDramas)
        {
            var filtered = audioDramas.Where(x => x.AudioDramaUserData.Heard == false);
            return filtered;
        }
    }
}
