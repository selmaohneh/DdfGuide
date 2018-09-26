using DdfGuide.Core.Views;

namespace DdfGuide.Core
{
    public interface IViewer
    {
        IView CurrentView { get; }
        void Show(IView view);
    }
}