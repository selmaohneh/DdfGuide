using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Filtering
{
    public class DieDreiFragezeichenKidsFilter : IAudioDramaFilter
    {
        public EAudioDramaFilterMode FilterMode => EAudioDramaFilterMode.DieDreiFragezeichenKids;
        public IEnumerable<AudioDrama> Filter(IEnumerable<AudioDrama> audioDramas)
        {
            return audioDramas.Where(x => x.AudioDramaDto.Interpreter == "Die drei ??? Kids");
        }
    }
}
