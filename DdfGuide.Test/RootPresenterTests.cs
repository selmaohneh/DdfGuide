using System;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.AutoMock;

namespace DdfGuide.Test
{
    [TestClass]
    public class RootPresenterTests
    {
        [TestMethod]
        public void WhenBackClickedOnRootView_ShowLastView()
        {
            var mocker = new AutoMocker();
            mocker.CreateInstance<RootPresenter>();

            var rootView = mocker.GetMock<IRootView>();
            rootView.Raise(x => x.BackClicked += null, this, EventArgs.Empty);

            mocker.Verify<IViewer>(x => x.ShowLast());
        }

        [TestMethod]
        public void WhenViewDestroyed_ReShowCurrentView()
        {
            var mocker = new AutoMocker();
            mocker.CreateInstance<RootPresenter>();

            var rootView = mocker.GetMock<IRootView>();
            rootView.Raise(x => x.ViewDestroyed += null, this, EventArgs.Empty);

            mocker.Verify<IViewer>(x => x.ShowCurrent(), Times.Once);
        }
    }
}
