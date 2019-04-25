using System;

namespace DdfGuide.Android
{
    public interface IOkDialog
    {
        event EventHandler OkClicked;
        void Show(string title, string message);
    }
}