using System;
using System.Collections.Generic;
using DdfGuide.Core;

namespace DdfGuide.Console
{
    public class AudioDramaListView : IAudioDramaListView
    {
        private IEnumerable<AudioDrama> _audioDramas;
        public event EventHandler<AudioDrama> HeardChanged;

        public void Show()
        {
            System.Console.Clear();

            PlotAudioDramas();
            PlotCommands();

            var command = System.Console.ReadLine();

            if (command != null && command.StartsWith("h "))
            {
                var idString = command.Substring(2, command.Length - 2);
                var id = Guid.Parse(idString);
                var audioDrama = _audioDramas.GetById(id);

                HeardChanged?.Invoke(this, audioDrama);
            }
        }

        private void PlotAudioDramas()
        {
            foreach (var audioDrama in _audioDramas)
            {
                System.Console.Write(audioDrama);

                if (audioDrama.AudioDramaUserData.Heard)
                {
                    System.Console.Write(" heard");
                }

                if (audioDrama.AudioDramaUserData.IsFavorite)
                {
                    System.Console.Write(" favorite");
                }

                System.Console.WriteLine();
            }
        }

        private void PlotCommands()
        {
            System.Console.WriteLine();

            System.Console.WriteLine("h [id] - Change heard flag");
        }

        public void SetAudioDramas(IEnumerable<AudioDrama> audioDramas)
        {
            _audioDramas = audioDramas;
        }
    }
}
