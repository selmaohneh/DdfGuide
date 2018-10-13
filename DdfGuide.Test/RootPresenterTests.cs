using System;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var sut = mocker.CreateInstance<RootPresenter>();

            var rootView = mocker.GetMock<IRootView>();
            rootView.Raise(x => x.BackClicked += null, this, EventArgs.Empty);

            mocker.Verify<IViewer>(x => x.ShowLast());
        }
    }
}
