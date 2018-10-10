using System.Collections.Generic;

namespace DdfGuide.Core
{
    public interface IRandomAudioDramaPicker
    {
        AudioDrama Pick(IEnumerable<AudioDrama> audioDramas);
    }
}