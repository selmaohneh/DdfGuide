using System.Collections.Generic;
using DdfGuide.Core;

namespace DdfGuide.Android
{
    public class AndroidUserDataProvider : IProvider<IEnumerable<AudioDramaUserData>>
    {
        public IEnumerable<AudioDramaUserData> Get()
        {
            return new List<AudioDramaUserData>();
        }
    }
}