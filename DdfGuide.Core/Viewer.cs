using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class Viewer : IViewer
    {
        private IView _currentView;
        private readonly Stack<IView> _recentViewsStack;

        public Viewer(Stack<IView> recentViewsStack)
        {
            _recentViewsStack = recentViewsStack;
        }

        public void Show(IView view)
        {
            if (_currentView != null)
            {
                _recentViewsStack.Push(_currentView);
                _currentView.Hide();
            }
            
            _currentView = view;
            _currentView.Show();
        }

        public void ShowLast()
        {
            _currentView?.Hide();

            if (_recentViewsStack.Any())
            {
                _currentView = _recentViewsStack.Pop();
                _currentView.Show();
            }

        }
    }
}
