using System;
using System.Collections.Generic;
using DdfGuide.Core;
using DdfGuide.Core.Models;
using DdfGuide.Core.Views;
using NConsoleMenu;

namespace DdfGuide.Console
{
    public class AudioDramaListView : IAudioDramaListView
    {
        private readonly CMenu _menue;
        private IEnumerable<AudioDrama> _audioDramas;
        public event EventHandler<Guid> HeardChanged;
        public event EventHandler<Guid> IsFavoriteChanged;
        public event EventHandler<Guid> AudioDramaClicked;

        public AudioDramaListView()
        {
            _menue = new CMenu
            {
                {"heard", OnHeardChanged},
                {"favorite", OnIsFavoriteChanged},
                {"click", OnAudioDramaClicked }
            };
        }

        public void Show()
        {
            System.Console.Clear();
            PlotAudioDramas();
            _menue.Run();
        }

        public void Hide()
        {
            _menue.Quit();
            System.Console.Clear();
        }

        private void PlotAudioDramas()
        {
            foreach (var audioDrama in _audioDramas)
            {
                System.Console.Write(audioDrama);
                System.Console.WriteLine();
            }
        }

        public void OnHeardChanged(string idString)
        {
            if (Guid.TryParse(idString, out var id))
            {
                HeardChanged?.Invoke(this, id);
                _menue.Quit();
            }
            else
            {
                System.Console.WriteLine($"Audio drama with id '{idString}' not found.");
            }
        }

        public void OnIsFavoriteChanged(string idString)
        {
            if (Guid.TryParse(idString, out var id))
            {
                IsFavoriteChanged?.Invoke(this, id);
                _menue.Quit();
            }
            else
            {
                System.Console.WriteLine($"Audio drama with id '{idString}' not found.");
            }
        }

        private void OnAudioDramaClicked(string idString)
        {
            if (Guid.TryParse(idString, out var id))
            {
                AudioDramaClicked?.Invoke(this, id);
                _menue.Quit();
            }
            else
            {
                System.Console.WriteLine($"Audio drama with id '{idString}' not found.");
            }
        }

        public void SetAudioDramas(IEnumerable<AudioDrama> audioDramas)
        {
            _audioDramas = audioDramas;
            Show();
        }
    }
}
