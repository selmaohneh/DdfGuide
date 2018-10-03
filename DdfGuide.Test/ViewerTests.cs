using System.Collections.Generic;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DdfGuide.Test
{
    [TestClass]
    public class ViewerTests
    {
        private Viewer _viewer;

        [TestInitialize]
        public void Init()
        {
            var viewStack = new Stack<IView>();
            _viewer = new Viewer(viewStack);
        }

        [TestMethod]
        public void ChangeView_HideOldView_ShowNewView()
        {
            var oldView = new Mock<IView>();
            _viewer.Show(oldView.Object);

            var newView = new Mock<IView>();
            _viewer.Show(newView.Object);

            oldView.Verify(x=>x.Hide());
            newView.Verify(x=>x.Show());
        }

        [TestMethod]
        public void ShowLastView_HideCurrentView_ShowOldView()
        {
            var currentView = new Mock<IView>();
            var oldView = new Mock<IView>();

            _viewer.Show(oldView.Object);
            _viewer.Show(currentView.Object);

            currentView.Invocations.Clear();
            oldView.Invocations.Clear();

            _viewer.ShowLast();

            currentView.Verify(x => x.Hide(), Times.Once);
            oldView.Verify(x => x.Show(), Times.Once);
        }

        [TestMethod]
        public void ShowLastView_MultipleTimes()
        {
            var view1 = new Mock<IView>();
            var view2 = new Mock<IView>();
            var view3 = new Mock<IView>();

            _viewer.Show(view1.Object);
            _viewer.Show(view2.Object);
            _viewer.Show(view3.Object);
            
            view1.Invocations.Clear();
            view2.Invocations.Clear();
            view3.Invocations.Clear();

            _viewer.ShowLast();
            view3.Verify(x => x.Hide(), Times.Once);
            view2.Verify(x => x.Show(), Times.Once);

            _viewer.ShowLast();
            view2.Verify(x => x.Hide(), Times.Once);
            view1.Verify(x => x.Show(), Times.Once);
        }

        [TestMethod]
        public void ShowLastView_IsFirstView_OnlyHide()
        {
            var singleView = new Mock<IView>();

            _viewer.Show(singleView.Object);
            _viewer.ShowLast();

            singleView.Verify(x => x.Hide(), Times.Once);
        }

        [TestMethod]
        public void ShowLastView_MultipleTimes_AlthoughLastViewReached()
        {
            var singleView = new Mock<IView>();

            _viewer.Show(singleView.Object);

            _viewer.ShowLast();
            _viewer.ShowLast();
            _viewer.ShowLast();
        }
    }
}
