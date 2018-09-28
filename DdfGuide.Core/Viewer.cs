using System.Collections.Generic;
using DdfGuide.Core.Views;

namespace DdfGuide.Core
{
    public class Viewer : IViewer
    {
        public IView CurrentView { get; private set; }

        private readonly Stack<IView> _viewStack;

        public Viewer(Stack<IView> viewStack)
        {
            _viewStack = viewStack;
        }

        public void Show(IView view)
        {
            _viewStack.Push(CurrentView);

            CurrentView?.Hide();
            CurrentView = view;
            CurrentView.Show();
        }

        public void ShowLastView()
        {
            CurrentView?.Hide();
            CurrentView = _viewStack.Pop();
            CurrentView.Show();
        }
    }
}
