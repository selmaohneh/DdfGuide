namespace DdfGuide.Core
{
    public class RootPresenter
    {
        public RootPresenter(IRootView rootView, IViewer viewer)
        {
            rootView.ViewDestroyed += (sender, args) => viewer.ShowCurrent();
        }
    }
}
