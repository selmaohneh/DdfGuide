using Android.Content;
using DdfGuide.Core;

namespace DdfGuide.Android
{
    public class ClipboardService : IClipboardService
    {
        private readonly ClipboardManager _clipboardManager;

        public ClipboardService(Context context)
        {
            _clipboardManager = context.GetSystemService(Context.ClipboardService) as ClipboardManager;
        }

        public string GetTextFromClipboard()
        {
            var text = _clipboardManager.PrimaryClip?.GetItemAt(0)?.Text ?? string.Empty;

            return text;
        }

        public void SetClipboardText(string text)
        {
            _clipboardManager.PrimaryClip = ClipData.NewPlainText("ddfguide_user_data", text);
        }
    }
}