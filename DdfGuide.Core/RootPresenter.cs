namespace DdfGuide.Core
{
    public class RootPresenter
    {
        public RootPresenter(IRootView rootView, IViewer viewer)
        {
            rootView.BackClicked += (sender, args) => viewer.ShowLast();
            rootView.ViewDestroyed += (sender, args) => viewer.ShowCurrent();
        }
    }
}
