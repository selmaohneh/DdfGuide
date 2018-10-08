using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Sorting
{
    public class IsFavoriteFirstSorter : IAudioDramaSorter
    {
        public EAudioDramaSortMode SortMode => EAudioDramaSortMode.IsFavoriteFirst;

        public IEnumerable<AudioDrama> Sort(IEnumerable<AudioDrama> audioDramas)
        {
            return audioDramas.OrderByDescending(x => x.AudioDramaUserData.IsFavorite);
        }
    }
}