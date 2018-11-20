using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DdfGuide.Test
{
    [TestClass]
    public class CachedDtoProviderTests
    {
        private CachedDtoProvider _sut;
        private Mock<ICache<IEnumerable<AudioDramaDto>>> _cache;
        private Mock<IProvider<IEnumerable<AudioDramaDto>>> _live;

        [TestInitialize]
        public void Init()
        {
            _cache = new Mock<ICache<IEnumerable<AudioDramaDto>>>();
            _live = new Mock<IProvider<IEnumerable<AudioDramaDto>>>();

            _sut = new CachedDtoProvider(
                _cache.Object,
                _live.Object);
        }

        [TestMethod]
        public void Default_ReturnItemsFromCache()
        {
            var samples = new SampleDtoProvider().Get().ToList();
            _cache.Setup(x => x.Load()).Returns(samples);

            var dtos = _sut.Get().ToList();

            _cache.Verify(x => x.Load(), Times.Once);
            _live.Verify(x => x.Get(), Times.Never);
            CollectionAssert.AreEqual(samples, dtos);
        }

        [TestMethod]
        public void CacheIsEmpty_ReturnLiveItems()
        {
            var samples = new SampleDtoProvider().Get().ToList();

            _live.Setup(x => x.Get()).Returns(samples);
            _cache.Setup(x => x.Load()).Returns(new List<AudioDramaDto>());

            var dtos = _sut.Get().ToList();

            _cache.Verify(x => x.Load(), Times.Once);
            _live.Verify(x=>x.Get(), Times.Once);
            CollectionAssert.AreEqual(samples, dtos);
        }

        [TestMethod]
        public void CacheIsEmpty_SaveLiveItemsToCache()
        {
            var samples = new SampleDtoProvider().Get().ToList();

            _live.Setup(x => x.Get()).Returns(samples);
            _cache.Setup(x => x.Load()).Returns(new List<AudioDramaDto>());

            _sut.Get();

            _cache.Verify(x => x.Save(samples), Times.Once);
        }
    }
}
