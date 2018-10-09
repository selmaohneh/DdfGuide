using System.Collections.Generic;

namespace DdfGuide.Core.Searching
{
    public class AudioDramaSearcher : IAudioDramaSearcher
    {
        public IEnumerable<AudioDrama> Search(IEnumerable<AudioDrama> audioDramas, string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return audioDramas;
            }

            var foundAudioDramas = new List<AudioDrama>();

            foreach (var audioDrama in audioDramas)
            {
                var normalizedSearchString = audioDrama.ToSearchString().ToLowerInvariant().Replace(" ", "");
                var normalizedSearchText = searchText.ToLowerInvariant().Replace(" ", "");

                if (normalizedSearchString.Contains(normalizedSearchText))
                {
                    foundAudioDramas.Add(audioDrama);
                }
            }

            return foundAudioDramas;
        }
    }
}
