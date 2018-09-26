using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DdfGuide.Test
{
    [TestClass]
    public class ViewerTests
    {
        [TestMethod]
        public void Construct_CurrentViewIsNull()
        {
            var viewer = new Viewer();

            Assert.IsNull(viewer.CurrentView);
        }

        [TestMethod]
        public void ShowView_UpdateCurrentViewProperty()
        {
            var viewer = new Viewer();
            var view = new Mock<IView>();
            viewer.Show(view.Object);

            Assert.AreEqual(view.Object, viewer.CurrentView);
        }

        [TestMethod]
        public void ChangeView_HideOldView_ShowNewView()
        {
            var viewer = new Viewer();
            var oldView = new Mock<IView>();
            viewer.Show(oldView.Object);

            var newView = new Mock<IView>();
            viewer.Show(newView.Object);

            oldView.Verify(x=>x.Hide());
            newView.Verify(x=>x.Show());
        }
    }
}
