using System;

namespace DdfGuide.Core.Filtering
{
    public class AudioDramaFilterFactory : IAudioDramaFilterFactory
    {
        public IAudioDramaFilter Create(EAudioDramaFilterMode audioDramaFilterMode)
        {
            switch (audioDramaFilterMode)
            {
                case EAudioDramaFilterMode.MainAudioDramasOnly:
                    return new MainAudioDramasOnlyFilter();

                case EAudioDramaFilterMode.AllAudioDramas:
                    return new AllAudioDramasFilter();

                default:
                    throw new ArgumentOutOfRangeException(nameof(audioDramaFilterMode), audioDramaFilterMode, null);
            }
        }
    }
}
