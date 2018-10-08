using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Sorting
{
    public class ReleaseDateDescendingSorter : IAudioDramaSorter
    {
        public EAudioDramaSortMode SortMode => EAudioDramaSortMode.ReleaseDateDescending;

        public IEnumerable<AudioDrama> Sort(IEnumerable<AudioDrama> audioDramas)
        {
            return audioDramas.OrderByDescending(x => x.AudioDramaDto.ReleaseDate);
        }
    }
}