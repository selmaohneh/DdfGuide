using System;

namespace DdfGuide.Core
{
    public interface IRootView : IView
    {
        void Show(IView view);
        event EventHandler ViewDestroyed;
    }
}