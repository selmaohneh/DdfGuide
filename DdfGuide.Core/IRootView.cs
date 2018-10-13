using System.Diagnostics.Tracing;

namespace DdfGuide.Core
{
    public interface IRootView : IView
    {
        void Show(IView view);
    }
}