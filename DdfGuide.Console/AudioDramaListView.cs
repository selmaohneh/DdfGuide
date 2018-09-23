using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;

namespace DdfGuide.Console
{
    public class AudioDramaListView : IAudioDramaListView
    {
        private IEnumerable<AudioDrama> _audioDramas;
        private IEnumerable<AudioDramaUserData> _audioDramaUserData;

        public void Show()
        {
            System.Console.Clear();

            for (var i = 0; i < _audioDramas.Count(); i++)
            {
                System.Console.Write(i + " ");
                System.Console.Write(_audioDramas.ElementAt(i));

                if (_audioDramaUserData.UserHasHeard(_audioDramas.ElementAt(i)))
                {
                    System.Console.Write(" heard");
                }

                if (_audioDramaUserData.IsUsersFavorite(_audioDramas.ElementAt(i)))
                {
                    System.Console.Write(" favorite");
                }

                System.Console.WriteLine();
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
