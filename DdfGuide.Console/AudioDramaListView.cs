using System;
using System.Collections.Generic;
using DdfGuide.Core;

namespace DdfGuide.Console
{
    public class AudioDramaListView : IAudioDramaListView
    {
        private IEnumerable<AudioDrama> _audioDramas;
        public event EventHandler<Guid> HeardChanged;

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

                HeardChanged?.Invoke(this, id);
            }
        }

        private void PlotAudioDramas()
        {
            foreach (var audioDrama in _audioDramas)
            {
                System.Console.Write(audioDrama);
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
