using System;
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
        private Mock<IRootView> _rootView;

        [TestInitialize]
        public void Init()
        {
            _rootView = new Mock<IRootView>();
            var viewStack = new Stack<IView>();
            _viewer = new Viewer(_rootView.Object, viewStack);
        }

        [TestMethod]
        public void ChangeView_HideOldView_ShowNewView()
        {
            var oldView = new Mock<IView>();
            _viewer.Show(oldView.Object);

            var newView = new Mock<IView>();
            _viewer.Show(newView.Object);

            _rootView.Verify(x => x.Show(newView.Object));
        }

        [TestMethod]
        public void ShowLastView_ShowOldView()
        {
            var currentView = new Mock<IView>();
            var oldView = new Mock<IView>();

            _viewer.Show(oldView.Object);
            _viewer.Show(currentView.Object);

            _rootView.Invocations.Clear();

            _viewer.ShowLast();
            
            _rootView.Verify(x => x.Show(oldView.Object), Times.Once);
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
            
            _rootView.Invocations.Clear();
            
            _viewer.ShowLast();

            _rootView.Verify(x => x.Show(view2.Object), Times.Once);

            _viewer.ShowLast();
            _rootView.Verify(x => x.Show(view1.Object), Times.Once);
        }

        [TestMethod]
        public void ShowLastView_IsFirstView_NoException()
        {
            var singleView = new Mock<IView>();

            _viewer.Show(singleView.Object);

            try
            {
                _viewer.ShowLast();
            }
            catch (Exception)
            {
                Assert.Fail("No exception expected when going back from first view.");
            }
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

        [TestMethod]
        public void ShowCurrentView_ShowCorrectView()
        {
            var singleView = new Mock<IView>();

            _viewer.Show(singleView.Object);

            _rootView.Invocations.Clear();

            _rootView.Verify(x => x.Show(singleView.Object), Times.Once);
        }
    }
}
