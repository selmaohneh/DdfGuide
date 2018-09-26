namespace DdfGuide.Core
{
    public class Viewer : IViewer
    {
        public IView CurrentView { get; private set; }

        public void Show(IView view)
        {
            CurrentView?.Hide();
            CurrentView = view;
            CurrentView.Show();
        }
    }
}
