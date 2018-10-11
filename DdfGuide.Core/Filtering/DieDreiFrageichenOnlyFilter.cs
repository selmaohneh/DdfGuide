using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Filtering
{
    public class DieDreiFrageichenOnlyFilter : IAudioDramaFilter
    {
        public EAudioDramaFilterMode FilterMode => EAudioDramaFilterMode.DieDreiFragezeichen;

        public IEnumerable<AudioDrama> Filter(IEnumerable<AudioDrama> audioDramas)
        {
            var filtered = audioDramas.Where(x => x.AudioDramaDto.Interpreter == "Die drei ???");
            return filtered;
        }
    }
}
