using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Sorting
{
    public class NameAscendingSorter :IAudioDramaSorter
    {
        public EAudioDramaSortMode SortMode => EAudioDramaSortMode.NameAscending;

        public IEnumerable<AudioDrama> Sort(IEnumerable<AudioDrama> audioDramas)
        {
            return audioDramas.OrderBy(x => x.AudioDramaDto.Title);
        }
    }
}