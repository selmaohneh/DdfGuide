using System.Collections.Generic;
using DdfGuide.Core;
using DdfGuide.Core.Views;
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
        public void Construct_CurrentViewIsNull()
        {
            Assert.IsNull(_viewer.CurrentView);
        }

        [TestMethod]
        public void ShowView_UpdateCurrentViewProperty()
        {
            var view = new Mock<IView>();
            _viewer.Show(view.Object);

            Assert.AreEqual(view.Object, _viewer.CurrentView);
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
        public void ShowLastView_UpdateCurrentView()
        {
            var currentView = new Mock<IView>();
            var oldView = new Mock<IView>();

            _viewer.Show(oldView.Object);
            _viewer.Show(currentView.Object);

            Assert.AreEqual(currentView.Object, _viewer.CurrentView);

            _viewer.ShowLastView();

            Assert.AreEqual(oldView.Object, _viewer.CurrentView);
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

            _viewer.ShowLastView();

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

            Assert.AreEqual(view3.Object, _viewer.CurrentView);
            
            _viewer.ShowLastView();
            Assert.AreEqual(view2.Object, _viewer.CurrentView);

            _viewer.ShowLastView();
            Assert.AreEqual(view1.Object, _viewer.CurrentView);
        }
    }
}
