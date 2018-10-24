using System;
using System.Linq;
using Android.App;
using Android.OS;
using Android.Text;
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

            var checkBoxHeard = _view.FindViewById<CheckBox>(Resource.Id.checkboxheard);
            checkBoxHeard.Click += (sender, args) =>
            {
                HeardClicked?.Invoke(this, EventArgs.Empty);
            };

            var checkBoxIsFavorite = _view.FindViewById<CheckBox>(Resource.Id.checkboxfavorite);
            checkBoxIsFavorite.Click += (sender, args) => IsFavoriteClicked?.Invoke(this, EventArgs.Empty);

            return _view;
        }

        public event EventHandler BackClicked;
        public void SetAudioDrama(AudioDrama audioDrama)
        {
            var titleView = _view.FindViewById<TextView>(Resource.Id.textviewtitelsingle);
            titleView.Text = audioDrama.AudioDramaDto.Title;

            var descriptionView = _view.FindViewById<TextView>(Resource.Id.textViewDescription);
            descriptionView.Text = audioDrama.AudioDramaDto.Description;

            var rolesView = _view.FindViewById<ListView>(Resource.Id.listViewRoles);
            rolesView.SetScrollContainer(true);
            var adapter = new RoleListAdapter(Activity);
            adapter.SetRoles(audioDrama.AudioDramaDto.Roles);
            rolesView.Adapter = adapter;

            var heardCheckbox = _view.FindViewById<CheckBox>(Resource.Id.checkboxheard);
            heardCheckbox.Checked = audioDrama.AudioDramaUserData.Heard;

            var favoriteCheckbox = _view.FindViewById<CheckBox>(Resource.Id.checkboxfavorite);
            favoriteCheckbox.Checked = audioDrama.AudioDramaUserData.IsFavorite;

            var imageView = _view.FindViewById<ImageViewAsync>(Resource.Id.coverviewsingle);
            ImageService.Instance
                .LoadUrl(audioDrama.AudioDramaDto.CoverUrl)
                .IntoAsync(imageView);
        }

        public event EventHandler HeardClicked;
        public event EventHandler IsFavoriteClicked;
    }
}