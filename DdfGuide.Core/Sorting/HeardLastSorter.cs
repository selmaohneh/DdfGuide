using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Sorting
{
    public class HeardLastSorter : IAudioDramaSorter
    {
        public EAudioDramaSortMode SortMode => EAudioDramaSortMode.HeardLast;

        public IEnumerable<AudioDrama> Sort(IEnumerable<AudioDrama> audioDramas)
        {
            return audioDramas.OrderBy(x => x.AudioDramaUserData.Heard);
        }
    }
}