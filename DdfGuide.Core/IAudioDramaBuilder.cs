using System.Collections.Generic;

namespace DdfGuide.Core
{
    public interface IAudioDramaBuilder
    {
        IEnumerable<AudioDrama> Build(IEnumerable<AudioDramaDto> dtos, IEnumerable<AudioDramaUserData> userDatas);
    }
}