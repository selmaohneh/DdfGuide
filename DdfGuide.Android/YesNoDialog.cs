using System;
using Android.App;
using Android.Content;
using DdfGuide.Core;

namespace DdfGuide.Android
{
    public class YesNoDialog : IYesNoDialog
    {
        private readonly Context _context;

        public YesNoDialog(Context context)
        {
            _context = context;
        }

        public event EventHandler YesClicked;
        public event EventHandler NoClicked;

        public void Show(string title, string message)
        {
            var builder = new AlertDialog.Builder(_context);

            builder
                .SetMessage(message)
                .SetTitle(title)
                .SetPositiveButton("Ja", (sender, args) => YesClicked?.Invoke(this, EventArgs.Empty))
                .SetNegativeButton("Nein", (sender, args) => NoClicked?.Invoke(this, EventArgs.Empty))
                .Show();
        }
    }
}