using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DdfGuide.Core.Sorting
{
    public class AudioDramaSorterFactory : IAudioDramaSorterFactory
    {
        private readonly IEnumerable<IAudioDramaSorter> _audioDramaSorters;

        public AudioDramaSorterFactory()
        {
            var interfaceType = typeof(IAudioDramaSorter);
            _audioDramaSorters = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => interfaceType.IsAssignableFrom(x) && !x.IsInterface)
                .Select(Activator.CreateInstance)
                .Select(x => (IAudioDramaSorter)x);
        }

        public IAudioDramaSorter Create(EAudioDramaSortMode audioDramaSortMode)
        {
            var sorter = _audioDramaSorters.Single(x => x.SortMode == audioDramaSortMode);
            return sorter;
        }
    }
}
