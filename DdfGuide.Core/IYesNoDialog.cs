using System;

namespace DdfGuide.Core
{
    public interface IYesNoDialog
    {
        event EventHandler YesClicked;
        event EventHandler NoClicked;

        void Show(string title, string message);
    }
}