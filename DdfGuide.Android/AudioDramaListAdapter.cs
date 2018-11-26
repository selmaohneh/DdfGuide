using System.Collections.Generic;
using System.Linq;
using Android.App;
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
        private IEnumerable<AudioDrama> _audioDramas;

        public AudioDramaListAdapter(Activity context, IImageViewFiller imageViewFiller)
        {
            _context = context;
            _imageViewFiller = imageViewFiller;
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

            view.FindViewById<TextView>(Resource.Id.titleview).Text = audioDrama.AudioDramaDto.ToString();
         
            var imageView = view.FindViewById<ImageViewAsync>(Resource.Id.coverview);
            _imageViewFiller.FillImageViewFromUrl(imageView, audioDrama.AudioDramaDto.CoverUrl);

            return view;
        }

        public override int Count => _audioDramas.Count();

        public override AudioDrama this[int position] => _audioDramas.ElementAt(position);
    }
}