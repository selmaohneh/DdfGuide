using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DdfGuide.Test
{
    [TestClass]
    public class OnUserDataChangedInCacheSaverTest
    {
        private List<AudioDramaUserData> _userDatas;
        private Mock<ICache<IEnumerable<AudioDramaUserData>>> _cache;

        [TestInitialize]
        public void Init()
        {
            _userDatas = new SampleUserDataProvider().Get().ToList();
            _cache = new Mock<ICache<IEnumerable<AudioDramaUserData>>>();

            var sut = new OnUserDataChangedInCacheSaver(_cache.Object);
            sut.SetObservedUserDatas(_userDatas);
        }

        [TestMethod]
        public void OnFavoriteChanged_SaveInCache()
        {
            var currentValue = _userDatas.First().IsFavorite;
            _userDatas.First().IsFavorite = !currentValue;
            _cache.Verify(x => x.Save(_userDatas), Times.Once);

            currentValue = _userDatas.Last().IsFavorite;
            _userDatas.Last().IsFavorite = !currentValue;
            _cache.Verify(x => x.Save(_userDatas), Times.Exactly(2));
        }

        [TestMethod]
        public void OnHeardChanged_SaveInCache()
        {
            var currentValue = _userDatas.First().Heard;
            _userDatas.First().Heard = !currentValue;
            _cache.Verify(x => x.Save(_userDatas), Times.Once);

            currentValue = _userDatas.Last().Heard;
            _userDatas.Last().Heard = !currentValue;
            _cache.Verify(x => x.Save(_userDatas), Times.Exactly(2));
        }
    }
}
