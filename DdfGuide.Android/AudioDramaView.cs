using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using DdfGuide.Core;

namespace DdfGuide.Android
{
    public class AudioDramaView : Fragment, IAudioDramaView
    {
        private View _view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            _view = inflater.Inflate(Resource.Layout.audiodramalayout, container, false);
            return _view;
        }

        public event EventHandler BackClicked;
        public void SetAudioDrama(AudioDrama audioDrama)
        {
            var titleView = _view.FindViewById<TextView>(Resource.Id.textviewtitel);
            titleView.Text = audioDrama.AudioDramaDto.Title;
        }

        public event EventHandler HeardChanged;
        public event EventHandler IsFavoriteChanged;
    }
}