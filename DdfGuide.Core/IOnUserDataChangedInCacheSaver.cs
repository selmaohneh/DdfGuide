using System.Collections.Generic;

namespace DdfGuide.Core
{
    public interface IOnUserDataChangedInCacheSaver
    {
        void SetObservedUserDatas(IEnumerable<AudioDramaUserData> userDatas);
    }
}