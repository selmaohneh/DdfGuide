using System;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class UserDataChangedEventTests
    {
        private AudioDramaUserData _sut;

        [TestInitialize]
        public void Init()
        {
            _sut = new AudioDramaUserData(Guid.NewGuid(), false, false);
        }

        [TestMethod]
        public void HeardChanged_RaiseChangedEvent()
        {
            var raised = false;
            _sut.Changed += (sender, args) => { raised = true; };

            Assert.IsFalse(_sut.Heard);
            _sut.Heard = true;
            Assert.IsTrue(raised);
        }

        [TestMethod]
        public void HeardChanged_ValueNotNew_DontRaiseChangedEvent()
        {
            var raised = false;
            _sut.Changed += (sender, args) => { raised = true; };

            Assert.IsFalse(_sut.Heard);
            _sut.Heard = false;
            Assert.IsFalse(raised);
        }

        [TestMethod]
        public void IsFavoriteChanged_RaiseChangedEvent()
        {
            var raised = false;
            _sut.Changed += (sender, args) => { raised = true; };

            Assert.IsFalse(_sut.IsFavorite);
            _sut.IsFavorite = true;
            Assert.IsTrue(raised);
        }

        [TestMethod]
        public void IsFavoriteChanged_ValueNotNew_DontRaiseChangedEvent()
        {
            var raised = false;
            _sut.Changed += (sender, args) => { raised = true; };

            Assert.IsFalse(_sut.IsFavorite);
            _sut.IsFavorite = false;
            Assert.IsFalse(raised);
        }
    }
}
