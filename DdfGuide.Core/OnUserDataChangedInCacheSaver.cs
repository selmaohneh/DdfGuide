using System;
using System.Collections.Generic;

namespace DdfGuide.Core
{
    public class OnUserDataChangedInCacheSaver
    {
        private readonly ICache<IEnumerable<AudioDramaUserData>> _cache;
        private IEnumerable<AudioDramaUserData> _userDatas;

        public OnUserDataChangedInCacheSaver(ICache<IEnumerable<AudioDramaUserData>> cache)
        {
            _cache = cache;
        }

        public void SetObservedUserDatas(IEnumerable<AudioDramaUserData> userDatas)
        {
            _userDatas = userDatas;

            foreach (var userData in _userDatas)
            {
                userData.Changed -= OnUserDataChanged();
                userData.Changed += OnUserDataChanged();
            }
        }

        private EventHandler OnUserDataChanged()
        {
            return (sender, args) => { _cache.Save(_userDatas); };
        }
    }
}