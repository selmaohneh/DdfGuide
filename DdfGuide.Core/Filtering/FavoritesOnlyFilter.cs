using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core.Filtering
{
    public class FavoritesOnlyFilter :IAudioDramaFilter
    {
        public EAudioDramaFilterMode FilterMode => EAudioDramaFilterMode.FavoritesOnly;

        public IEnumerable<AudioDrama> Filter(IEnumerable<AudioDrama> audioDramas)
        {
            var favorites = audioDramas.Where(x => x.AudioDramaUserData.IsFavorite);
            return favorites;
        }
    }
}
