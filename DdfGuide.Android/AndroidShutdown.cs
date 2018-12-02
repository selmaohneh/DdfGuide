using DdfGuide.Core;

namespace DdfGuide.Android
{
    public class AndroidShutdown : IShutdown
    {
        private readonly MainActivity _mainActivity;

        public AndroidShutdown(MainActivity mainActivity)
        {
            _mainActivity = mainActivity;
        }

        public void Shutdown()
        {
            _mainActivity.Finish();
        }
    }
}