namespace DdfGuide.Core
{
    public interface IClipboardService
    {
        string GetTextFromClipboard();
        void SetClipboardText(string text);
    }
}
