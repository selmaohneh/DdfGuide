using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public static class AudioDramaUserDataExtensions
    {
        public static bool UserHasHeard(
            this IEnumerable<AudioDramaUserData> audioDramaUserData,
            AudioDrama audioDrama)
        {
            var ids = audioDramaUserData.Where(x=>x.Heard).Select(x => x.Id).ToList();

            return ids.Contains(audioDrama.Id);
        }
    }
}