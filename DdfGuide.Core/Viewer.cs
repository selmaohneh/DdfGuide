using System.Collections.Generic;
using System.Linq;

namespace DdfGuide.Core
{
    public class Viewer : IViewer
    {
        private IView _currentView;
        private readonly IRootView _rootView;
        private readonly Stack<IView> _recentViewsStack;

        public Viewer(IRootView rootView, Stack<IView> recentViewsStack)
        {
            _rootView = rootView;
            _recentViewsStack = recentViewsStack;
        }

        public void Show(IView view)
        {
            if (_currentView != null)
            {
                _recentViewsStack.Push(_currentView);
            }
            
            _currentView = view;
            _rootView.Show(_currentView);
        }

        public void ShowCurrent()
        {
            _rootView.Show(_currentView);
        }

        public void ShowLast()
        {
            if (_recentViewsStack.Any())
            {
                _currentView = _recentViewsStack.Pop();
                _rootView.Show(_currentView);
            }

        }
    }
}
