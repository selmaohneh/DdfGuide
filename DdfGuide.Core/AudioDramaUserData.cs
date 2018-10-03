using System;

namespace DdfGuide.Core
{
    public class AudioDramaUserData :INotifyChanged
    {
        public Guid Id { get; }
        public event EventHandler Changed;


        private bool _heard;
        public bool Heard
        {
            get => _heard;
            set
            {
                if (_heard == value) return;

                _heard = value;
                Changed?.Invoke(this, EventArgs.Empty);
            }
        }

        private bool _isFavorite;
        public bool IsFavorite
        {
            get => _isFavorite;
            set
            {
                if (_isFavorite == value) return;

                _isFavorite = value;
                Changed?.Invoke(this, EventArgs.Empty);
            }
        }

        public AudioDramaUserData(Guid id, bool heard, bool isFavorite)
        {
            Id = id;
            Heard = heard;
            IsFavorite = isFavorite;
        }

        public override string ToString()
        {
            var dump = string.Empty;

            if (Heard)
            {
                dump += "h(x)";
            }
            else
            {
                dump += "h( )";
            }

            if (IsFavorite)
            {
                dump += " f(x)";
            }
            else
            {
                dump += " f( )";
            }

            return dump;
        }

    }
}
