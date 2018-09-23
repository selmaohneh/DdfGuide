using System.Collections.Generic;
using DdfGuide.Core;

namespace DdfGuide.Console
{
    public class AudioDramaListView : IAudioDramaListView
    {
        private IEnumerable<AudioDrama> _audioDramas;
        private IEnumerable<AudioDramaUserData> _audioDramaUserData;

        public void Show()
        {
            foreach (var audioDrama in _audioDramas)
            {
                System.Console.Write(audioDrama);

                if (_audioDramaUserData.UserHasHeard(audioDrama))
                {
                    System.Console.WriteLine(" heard");
                }
                else
                {
                    System.Console.WriteLine();
                }
            }
        }

        public void SetAudioDramas(IEnumerable<AudioDrama> audioDramas)
        {
            _audioDramas = audioDramas;
        }

        public void SetAudioDramaUserData(IEnumerable<AudioDramaUserData> audioDramaUserData)
        {
            _audioDramaUserData = audioDramaUserData;
        }
    }
}
