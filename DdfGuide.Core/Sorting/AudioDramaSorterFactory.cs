using System;

namespace DdfGuide.Core.Sorting
{
    public class AudioDramaSorterFactory : IAudioDramaSorterFactory
    {
        public IAudioDramaSorter Create(EAudioDramaSortMode audioDramaSortMode)
        {
            switch (audioDramaSortMode)
            {
                case EAudioDramaSortMode.ReleaseDateDescending:
                    return new ReleaseDateDescendingSorter();

                case EAudioDramaSortMode.ReleaseDateAscending:
                    return new ReleaseDateAscendingSorter();

                case EAudioDramaSortMode.NumberDescending:
                    return new NumberDescendingSorter();

                case EAudioDramaSortMode.NumberAscending:
                    return new NumberAscendingSorter();

                case EAudioDramaSortMode.NameDescending:
                    return new NameDescendingSorter();

                case EAudioDramaSortMode.NameAscending:
                    return new NameAscendingSorter();

                case EAudioDramaSortMode.HeardFirst:
                    return new HeardFirstSorter();

                case EAudioDramaSortMode.HeardLast:
                    return new HeardLastSorter();

                case EAudioDramaSortMode.IsFavoriteFirst:
                    return new IsFavoriteFirstSorter();

                case EAudioDramaSortMode.IsFavoriteLast:
                    return new IsFavoriteLastSorter();

                default:
                    throw new ArgumentOutOfRangeException(nameof(audioDramaSortMode), audioDramaSortMode, null);
            }
        }
    }
}
