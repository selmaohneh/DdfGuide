using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DdfGuide.Core.Filtering
{
    public class AudioDramaFilterFactory : IAudioDramaFilterFactory
    {
        private readonly IEnumerable<IAudioDramaFilter> _audioDramaFilters;

        public AudioDramaFilterFactory()
        {
            var interfaceType = typeof(IAudioDramaFilter);
            _audioDramaFilters = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => interfaceType.IsAssignableFrom(x) && !x.IsInterface)
                .Select(Activator.CreateInstance)
                .Select(x => (IAudioDramaFilter) x);
        }

        public IAudioDramaFilter Create(EAudioDramaFilterMode audioDramaFilterMode)
        {
            var filter = _audioDramaFilters.Single(x => x.FilterMode == audioDramaFilterMode);
            return filter;
        }
    }
}
