using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using DdfGuide.Core;
using FFImageLoading.Views;

namespace DdfGuide.Android
{
    public class AudioDramaListAdapter : BaseAdapter<AudioDrama>
    {
        private readonly Activity _context;
        private readonly IImageViewFiller _imageViewFiller;
        private readonly IReleaseDateService _releaseDateService;
        private IEnumerable<AudioDrama> _audioDramas;

        public AudioDramaListAdapter(
            Activity context, 
            IImageViewFiller imageViewFiller,
            IReleaseDateService releaseDateService)
        {
            _context = context;
            _imageViewFiller = imageViewFiller;
            _releaseDateService = releaseDateService;
            _audioDramas = new List<AudioDrama>();
        }

        public void SetAudioDramas(IEnumerable<AudioDrama> audioDramas)
        {
            _audioDramas = audioDramas;
            NotifyDataSetChanged();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var audioDrama = _audioDramas.ElementAt(position);
            var view = convertView ?? _context.LayoutInflater.Inflate(Resource.Layout.audiodramalistitem, null);

            var titleView = view.FindViewById<TextView>(Resource.Id.titleview);
            titleView.Text = audioDrama.AudioDramaDto.ToString();
         
            var imageView = view.FindViewById<ImageViewAsync>(Resource.Id.coverview);
            _imageViewFiller.FillImageViewFromUrl(imageView, audioDrama.AudioDramaDto.CoverUrl);

            var heardView = view.FindViewById<CheckBox>(Resource.Id.listcheckboxheard);
            heardView.Checked = audioDrama.AudioDramaUserData.Heard;

            var favoriteView = view.FindViewById<CheckBox>(Resource.Id.listcheckboxfavorite);
            favoriteView.Checked = audioDrama.AudioDramaUserData.IsFavorite;

            view.SetBackgroundColor(_releaseDateService.IsReleased(audioDrama.AudioDramaDto)
                ? Color.White
                : Color.LightGray);

            return view;
        }

        public override int Count => _audioDramas.Count();

        public override AudioDrama this[int position] => _audioDramas.ElementAt(position);
    }
}