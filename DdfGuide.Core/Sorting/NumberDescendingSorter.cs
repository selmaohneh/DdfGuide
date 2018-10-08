using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Sorting
{
    public class NumberDescendingSorter : IAudioDramaSorter
    {
        public EAudioDramaSortMode SortMode => EAudioDramaSortMode.NumberDescending;

        public IEnumerable<AudioDrama> Sort(IEnumerable<AudioDrama> audioDramas)
        {
            return audioDramas.OrderByDescending(x => x.AudioDramaDto.Number);
        }
    }
}