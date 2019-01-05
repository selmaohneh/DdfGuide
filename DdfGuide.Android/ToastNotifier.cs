using Android.Content;
using Android.Widget;
using DdfGuide.Core;

namespace DdfGuide.Android
{
    public class ToastNotifier : IUserNotifier
    {
        private readonly Context _context;

        public ToastNotifier(Context context)
        {
            _context = context;
        }

        public void Notify(string message)
        {
            var toast = Toast.MakeText(_context, message, ToastLength.Long);
            toast.Show();
        }
    }
}