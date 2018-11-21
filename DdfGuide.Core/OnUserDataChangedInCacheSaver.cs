using System;
using System.Collections.Generic;

namespace DdfGuide.Core
{
    public class OnUserDataChangedInCacheSaver
    {
        private readonly IEnumerable<AudioDramaUserData> _userDatas;
        private readonly ICache<IEnumerable<AudioDramaUserData>> _cache;

        public OnUserDataChangedInCacheSaver(
            IEnumerable<AudioDramaUserData> userDatas, 
            ICache<IEnumerable<AudioDramaUserData>> cache)
        {
            _userDatas = userDatas;
            _cache = cache;
            foreach (var userData in _userDatas)
            {
                userData.Changed += OnUserDataChanged();
            }
        }

        private EventHandler OnUserDataChanged()
        {
            return (sender, args) => { _cache.Save(_userDatas); };
        }
    }
}