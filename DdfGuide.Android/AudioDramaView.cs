using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using DdfGuide.Core;
using FFImageLoading;
using FFImageLoading.Views;

namespace DdfGuide.Android
{
    public class AudioDramaView : Fragment, IAudioDramaView
    {
        private View _view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            _view = inflater.Inflate(Resource.Layout.audiodramalayout, container, false);

            var toolbar = _view.FindViewById<Toolbar>(Resource.Id.toolbarsingleview);
            toolbar.SetNavigationIcon(Resource.Mipmap.arrow_back);
            toolbar.NavigationOnClick += (sender, args) => BackClicked?.Invoke(this, EventArgs.Empty);

            return _view;
        }

        public event EventHandler BackClicked;
        public void SetAudioDrama(AudioDrama audioDrama)
        {
            var titleView = _view.FindViewById<TextView>(Resource.Id.textviewtitelsingle);
            titleView.Text = audioDrama.AudioDramaDto.Title;

            var descriptionView = _view.FindViewById<TextView>(Resource.Id.textViewDescription);
            descriptionView.Text = audioDrama.AudioDramaDto.Description;

            var imageView = _view.FindViewById<ImageViewAsync>(Resource.Id.coverviewsingle);
            ImageService.Instance
                .LoadUrl(audioDrama.AudioDramaDto.CoverUrl)
                .IntoAsync(imageView);
        }

        public event EventHandler HeardChanged;
        public event EventHandler IsFavoriteChanged;
    }
}