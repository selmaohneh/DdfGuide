using System;

namespace DdfGuide.Core
{
    public interface IView
    {
        void Show();
        void Hide();
        event EventHandler BackClicked;
    }
}
