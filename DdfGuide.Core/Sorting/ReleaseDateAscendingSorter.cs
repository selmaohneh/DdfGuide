using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Sorting
{
    public class ReleaseDateAscendingSorter : IAudioDramaSorter
    {
        public EAudioDramaSortMode SortMode => EAudioDramaSortMode.ReleaseDateAscending;

        public IEnumerable<AudioDrama> Sort(IEnumerable<AudioDrama> audioDramas)
        {
            return audioDramas.OrderBy(x => x.AudioDramaDto.ReleaseDate);
        }
    }
}