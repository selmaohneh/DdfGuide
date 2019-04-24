using System;
using Android.Content;
using DdfGuide.Core;

namespace DdfGuide.Android
{
    public class UriInvoker : IUriInvoker
    {
        private readonly Context _context;

        public UriInvoker(Context context)
        {
            _context = context;
        }

        public void Invoke(Uri uri)
        {
            var intent = new Intent(Intent.ActionView, global::Android.Net.Uri.Parse(uri.ToString()));
            _context.StartActivity(intent);
        }
    }
}