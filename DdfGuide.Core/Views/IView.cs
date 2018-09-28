using System;

namespace DdfGuide.Core.Views
{
    public interface IView
    {
        void Show();
        void Hide();
        event EventHandler BackClicked;
    }
}
