using System;
using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class AudioDramaSorter : IAudioDramaSorter
    {
        public EAudioDramaSortMode SortMode { get; set; }

        public IEnumerable<AudioDrama> Sort(IEnumerable<AudioDrama> audioDramas)
        {
            IOrderedEnumerable<AudioDrama> sorted;
            switch (SortMode)
            {
                case EAudioDramaSortMode.ReleaseDateDescending:
                    sorted = audioDramas.OrderByDescending(x => x.AudioDramaDto.ReleaseDate);
                    break;

                case EAudioDramaSortMode.ReleaseDateAscending:
                    sorted = audioDramas.OrderBy(x => x.AudioDramaDto.ReleaseDate);
                    break;

                case EAudioDramaSortMode.NumberDescending:
                    sorted = audioDramas.OrderByDescending(x => x.AudioDramaDto.Number);
                    break;

                case EAudioDramaSortMode.NumberAscending:
                    sorted = audioDramas.OrderBy(x => x.AudioDramaDto.Number);
                    break;

                case EAudioDramaSortMode.NameDescending:
                    sorted = audioDramas.OrderByDescending(x => x.AudioDramaDto.Name);
                    break;

                case EAudioDramaSortMode.NameAscending:
                    sorted = audioDramas.OrderBy(x => x.AudioDramaDto.Name);
                    break;

                case EAudioDramaSortMode.HeardFirst:
                    sorted = audioDramas.OrderByDescending(x => x.AudioDramaUserData.Heard);
                    break;

                case EAudioDramaSortMode.HeardLast:
                    sorted = audioDramas.OrderBy(x => x.AudioDramaUserData.Heard);
                    break;

                case EAudioDramaSortMode.IsFavoriteFirst:
                    sorted = audioDramas.OrderByDescending(x => x.AudioDramaUserData.IsFavorite);
                    break;

                case EAudioDramaSortMode.IsFavoriteLast:
                    sorted = audioDramas.OrderBy(x => x.AudioDramaUserData.IsFavorite);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            return sorted;
        }
    }
}
