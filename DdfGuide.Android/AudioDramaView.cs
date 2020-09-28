using System;
using System.Linq;
using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Text;
using Android.Views;
using Android.Widget;
using DdfGuide.Core;
using FFImageLoading.Views;

namespace DdfGuide.Android
{
    public class UpdatingView : Fragment, IUpdatingView
    {
        private View _view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            _view = inflater.Inflate(Resource.Layout.updatinglayout, container, false);

            return _view;
        }
    }

    public class AudioDramaView : Fragment, IAudioDramaView
    {
        private readonly IImageViewFiller _imageViewFiller;
        private View _view;

        /// <summary>
        /// Fragments need a default constructor. Needed for old android versions.
        /// </summary>
        public AudioDramaView()
        {
            _imageViewFiller = new ImageViewFiller();
        }

        public AudioDramaView(IImageViewFiller imageViewFiller)
        {
            _imageViewFiller = imageViewFiller;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            _view = inflater.Inflate(Resource.Layout.audiodramalayout, container, false);

            SetupToolbar();
            SetupHeardCheckbox();
            SetupIsFavoriteCheckbox();
            SetupPlayButton();

            return _view;
        }

        private void SetupPlayButton()
        {
            var playButton = _view.FindViewById<Button>(Resource.Id.buttonplay);
            playButton.Click += (sender, args) => PlayClicked?.Invoke(this, EventArgs.Empty);
        }

        private void SetupIsFavoriteCheckbox()
        {
            var checkBoxIsFavorite = _view.FindViewById<CheckBox>(Resource.Id.checkboxfavorite);
            checkBoxIsFavorite.Click += (sender, args) => IsFavoriteClicked?.Invoke(this, EventArgs.Empty);
        }

        private void SetupHeardCheckbox()
        {
            var checkBoxHeard = _view.FindViewById<CheckBox>(Resource.Id.checkboxheard);
            checkBoxHeard.Click += (sender, args) => { HeardClicked?.Invoke(this, EventArgs.Empty); };
        }

        private void SetupToolbar()
        {
            var toolbar = _view.FindViewById<Toolbar>(Resource.Id.toolbarsingleview);
            toolbar.SetNavigationIcon(Resource.Mipmap.arrow_back);
            toolbar.NavigationIcon.SetColorFilter(Resources.GetColor(Resource.Color.ddfWhite), PorterDuff.Mode.SrcAtop);

            toolbar.NavigationOnClick += (sender, args) => BackClicked?.Invoke(this, EventArgs.Empty);
        }

        public void SetAudioDrama(AudioDrama audioDrama)
        {
            var interpreterView = _view.FindViewById<TextView>(Resource.Id.textviewinterpreter);
            interpreterView.Text = audioDrama.AudioDramaDto.Interpreter;

            var titleView = _view.FindViewById<TextView>(Resource.Id.textviewtitelsingle);
            titleView.Text = audioDrama.AudioDramaDto.ToString();

            var descriptionView = _view.FindViewById<TextView>(Resource.Id.textViewDescription);
            descriptionView.Text = string.Empty;
            if (audioDrama.AudioDramaDto.Description != null)
            {
                // Deprecated method is just due to old android versions.
                descriptionView.Append(Html.FromHtml(audioDrama.AudioDramaDto.Description));
            }

            var releaseDateView = _view.FindViewById<TextView>(Resource.Id.textviewreleasesingle);
            releaseDateView.Text = audioDrama.AudioDramaDto.ReleaseDate.ToShortDateString();

            var heardCheckbox = _view.FindViewById<CheckBox>(Resource.Id.checkboxheard);
            heardCheckbox.Checked = audioDrama.AudioDramaUserData.Heard;

            var favoriteCheckbox = _view.FindViewById<CheckBox>(Resource.Id.checkboxfavorite);
            favoriteCheckbox.Checked = audioDrama.AudioDramaUserData.IsFavorite;

            var playButton = _view.FindViewById<Button>(Resource.Id.buttonplay);
            playButton.Visibility = audioDrama.AudioDramaDto.SpotifyAlbumId != null ? ViewStates.Visible : ViewStates.Invisible;

            var imageView = _view.FindViewById<ImageViewAsync>(Resource.Id.coverviewsingle);

            _imageViewFiller.FillImageViewFromUrl(imageView, audioDrama.AudioDramaDto.CoverUrl);
           
            var rolesView = _view.FindViewById<TextView>(Resource.Id.textViewRoles);

            rolesView.Text = string.Empty;
            foreach (var roleDto in audioDrama.AudioDramaDto.Roles)
            {
                // Deprecated method is just due to old android versions.
                rolesView.Append(Html.FromHtml($"<b>{roleDto.Character}:</b><br>"));
                rolesView.Append(Html.FromHtml($"{roleDto.Speaker}"));

                if (roleDto != audioDrama.AudioDramaDto.Roles.Last())
                {
                    rolesView.Append(Html.FromHtml("<br><br>"));
                }
            }
        }
        
        public event EventHandler BackClicked;
        public event EventHandler HeardClicked;
        public event EventHandler IsFavoriteClicked;
        public event EventHandler PlayClicked;
    }
}