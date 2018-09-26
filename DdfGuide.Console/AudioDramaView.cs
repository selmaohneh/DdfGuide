using System;
using DdfGuide.Core.Models;
using DdfGuide.Core.Views;
using NConsoleMenu;

namespace DdfGuide.Console
{
    public class AudioDramaView : IAudioDramaView
    {
        private AudioDrama _audioDrama;
        private readonly CMenu _menue;

        public event EventHandler HeardChanged;
        public event EventHandler IsFavoriteChanged;

        public AudioDramaView()
        {
            _menue = new CMenu
            {
                {"heard", x => OnHeardChanged()},
                {"favorite", x => OnIsFavoriteChanged()}
            };
        }

        public void Show()
        {
            System.Console.Clear();
            System.Console.WriteLine(_audioDrama);
            _menue.Run();
        }

        public void Hide()
        {
            _menue.Quit();
            System.Console.Clear();
        }

        public void SetAudioDrama(AudioDrama audioDrama)
        {
            _audioDrama = audioDrama;
            Show();
        }

        private void OnHeardChanged()
        {
            HeardChanged?.Invoke(this, EventArgs.Empty);
            _menue.Quit();
        }

        private void OnIsFavoriteChanged()
        {
            IsFavoriteChanged?.Invoke(this, EventArgs.Empty);
            _menue.Quit();
        }
    }
}
