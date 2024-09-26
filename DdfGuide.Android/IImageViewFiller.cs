using Android.Widget;

namespace DdfGuide.Android
{
    public interface IImageViewFiller
    {
        void FillImageViewFromUrl(ImageView imageView, string url);
    }
}