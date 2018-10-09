using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Filtering
{
    public class SpecialAudioDramasOnlyFilter :IAudioDramaFilter
    {
        public EAudioDramaFilterMode FilterMode => EAudioDramaFilterMode.SpecialsOnly;

        public IEnumerable<AudioDrama> Filter(IEnumerable<AudioDrama> audioDramas)
        {
            var filtered = audioDramas.Where(x => x.AudioDramaDto.NumberEuropa.HasValue == false);
            return filtered;
        }
    }
}
