using System;
using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class CachedDtoProvider : IProvider<IEnumerable<AudioDramaDto>>
    {
        private readonly ICache<IEnumerable<AudioDramaDto>> _cache;
        private readonly IProvider<IEnumerable<AudioDramaDto>> _liveProvider;

        public CachedDtoProvider(
            ICache<IEnumerable<AudioDramaDto>> cache, 
            IProvider<IEnumerable<AudioDramaDto>> liveProvider)
        {
            _cache = cache;
            _liveProvider = liveProvider;
        }

        public IEnumerable<AudioDramaDto> Get()
        {
            var cachedItems = _cache.Load().ToList();
            if (cachedItems.Any())
            {
                return cachedItems;
            }

            var liveItems = _liveProvider.Get().ToList();

            _cache.Save(liveItems);

            return liveItems;
        }
    }
}
