using FFImageLoading;
using FFImageLoading.Views;
using FFImageLoading.Work;

namespace DdfGuide.Android
{
    public class ImageViewFiller : IImageViewFiller
    {
        public void FillImageViewFromUrl(ImageViewAsync imageView, string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                ImageService.Instance
                    .LoadCompiledResource("ic_launcher")
                    .IntoAsync(imageView);
            }
            else
            {
                ImageService.Instance
                    .LoadUrl(url)
                    .LoadingPlaceholder("ic_launcher", ImageSource.CompiledResource)
                    .ErrorPlaceholder("ic_launcher", ImageSource.CompiledResource)
                    .IntoAsync(imageView);
            }
        }
    }
}