using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Sorting
{
    public class HeardFirstSorter : IAudioDramaSorter
    {
        public EAudioDramaSortMode SortMode => EAudioDramaSortMode.HeardFirst;

        public IEnumerable<AudioDrama> Sort(IEnumerable<AudioDrama> audioDramas)
        {
            return audioDramas.OrderByDescending(x => x.AudioDramaUserData.Heard);
        }
    }
}