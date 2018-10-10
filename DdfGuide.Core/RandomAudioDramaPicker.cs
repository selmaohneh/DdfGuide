using System;
using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class RandomAudioDramaPicker : IRandomAudioDramaPicker
    {
        public AudioDrama Pick(IEnumerable<AudioDrama> audioDramas)
        {
            var audioDramaList = audioDramas.ToList();

            var random = new Random();
            var index = random.Next(audioDramaList.Count);

            return audioDramaList.ElementAt(index);
        }
    }
}
