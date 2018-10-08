namespace DdfGuide.Core.Filtering
{
    public interface IAudioDramaFilterFactory
    {
        IAudioDramaFilter Create(EAudioDramaFilterMode audioDramaFilterMode);
    }
}