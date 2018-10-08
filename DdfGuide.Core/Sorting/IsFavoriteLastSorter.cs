using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Sorting
{
    public class IsFavoriteLastSorter : IAudioDramaSorter
    {
        public EAudioDramaSortMode SortMode => EAudioDramaSortMode.IsFavoriteLast;

        public IEnumerable<AudioDrama> Sort(IEnumerable<AudioDrama> audioDramas)
        {
            return audioDramas.OrderBy(x => x.AudioDramaUserData.IsFavorite);
        }
    }
}