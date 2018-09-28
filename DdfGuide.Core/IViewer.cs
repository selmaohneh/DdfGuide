using DdfGuide.Core.Views;

namespace DdfGuide.Core
{
    public interface IViewer
    {
        void Show(IView view);
        void ShowLast();
    }
}