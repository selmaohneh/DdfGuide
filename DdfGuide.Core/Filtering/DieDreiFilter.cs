using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Filtering
{
    public class DieDreiFilter : IAudioDramaFilter
    {
        public EAudioDramaFilterMode FilterMode => EAudioDramaFilterMode.DieDrei;
        public IEnumerable<AudioDrama> Filter(IEnumerable<AudioDrama> audioDramas)
        {
            var filtered = audioDramas.Where(x => x.AudioDramaDto.Interpreter == "DiE DR3i");
            return filtered;
        }
    }
}
