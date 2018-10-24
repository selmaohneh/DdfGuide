using System;
using Android.App;
using Android.OS;
using Android.Views;
using DdfGuide.Core;

namespace DdfGuide.Android.Resources
{
    public class AudioDramaView : Fragment, IAudioDramaView
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.audiodramalayout, container, false);
        }

        public event EventHandler BackClicked;
        public void SetAudioDrama(AudioDrama audioDrama)
        {
            // todo
        }

        public event EventHandler HeardClicked;
        public event EventHandler IsFavoriteClicked;
    }
}