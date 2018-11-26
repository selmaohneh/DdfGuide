using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Sorting
{
    public class NumberAscendingSorter : IAudioDramaSorter
    {
        public EAudioDramaSortMode SortMode => EAudioDramaSortMode.NumberAscending;

        public IEnumerable<AudioDrama> Sort(IEnumerable<AudioDrama> audioDramas)
        {
            return audioDramas.OrderBy(x => x.AudioDramaDto.NumberEuropa);
        }
    }
}