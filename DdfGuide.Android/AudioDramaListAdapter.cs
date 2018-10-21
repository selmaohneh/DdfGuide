using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Views;
using Android.Widget;
using DdfGuide.Core;
using FFImageLoading;
using FFImageLoading.Views;

namespace DdfGuide.Android
{
    public class AudioDramaListAdapter : BaseAdapter<AudioDrama>
    {
        private readonly Activity _context;
        private IEnumerable<AudioDrama> _audioDramas;

        public AudioDramaListAdapter(Activity context)
        {
            _context = context;
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
            var view = convertView;

            if (view == null)
            {
                view = _context.LayoutInflater.Inflate(Resource.Layout.audiodramalistitem, null);
            }

            view.FindViewById<TextView>(Resource.Id.titleview).Text = audioDrama.AudioDramaDto.ToString();
         
            var imageView = view.FindViewById<ImageViewAsync>(Resource.Id.coverview);

            var image = ImageService.Instance
                .LoadUrl(audioDrama.AudioDramaDto.CoverUrl)
                .Into(imageView);
            
            return view;
        }

        public override int Count => _audioDramas.Count();

        public override AudioDrama this[int position] => _audioDramas.ElementAt(position);
    }
}