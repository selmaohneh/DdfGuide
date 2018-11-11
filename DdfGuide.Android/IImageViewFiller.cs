using FFImageLoading.Views;

namespace DdfGuide.Android
{
    public interface IImageViewFiller
    {
        void FillImageViewFromUrl(ImageViewAsync imageView, string url);
    }
}