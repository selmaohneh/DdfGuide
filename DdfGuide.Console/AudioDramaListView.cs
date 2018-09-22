using System.Collections.Generic;
using DdfGuide.Core;

namespace DdfGuide.Console
{
    public class AudioDramaListView : IAudioDramaListView
    {
        private IEnumerable<AudioDrama> _audioDramas;

        public void Show()
        {
            foreach (var audioDrama in _audioDramas)
            {
                System.Console.WriteLine(audioDrama);
            }
        }

        public void SetAudioDramas(IEnumerable<AudioDrama> audioDramas)
        {
            _audioDramas = audioDramas;
        }
    }
}
