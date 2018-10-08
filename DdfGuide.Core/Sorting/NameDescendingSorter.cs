using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Sorting
{
    public class NameDescendingSorter : IAudioDramaSorter
    {
        public EAudioDramaSortMode SortMode => EAudioDramaSortMode.NameDescending;

        public IEnumerable<AudioDrama> Sort(IEnumerable<AudioDrama> audioDramas)
        {
            return audioDramas.OrderByDescending(x => x.AudioDramaDto.Name);
        }
    }
}