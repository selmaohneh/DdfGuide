namespace DdfGuide.Core.Sorting
{
    public interface IAudioDramaSorterFactory
    {
        IAudioDramaSorter Create(EAudioDramaSortMode audioDramaSortMode);
    }
}