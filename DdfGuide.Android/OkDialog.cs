using System;
using Android.App;
using Android.Content;

namespace DdfGuide.Android
{
    public class OkDialog : IOkDialog
    {
        private readonly Context _context;

        public OkDialog(Context context)
        {
            _context = context;
        }

        public event EventHandler OkClicked;

        public void Show(string title, string message)
        {
            var builder = new AlertDialog.Builder(_context);

            builder
                .SetMessage(message)
                .SetTitle(title)
                .SetNeutralButton("OK", (sender, args) => { OkClicked?.Invoke(this, EventArgs.Empty); })
                .Show();
        }
    }
}