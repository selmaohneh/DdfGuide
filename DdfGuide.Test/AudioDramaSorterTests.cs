using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaSorterTests
    {
        private AudioDramaSorter _sut;
        private List<AudioDrama> _audioDramas;

        [TestInitialize]
        public void Init()
        {
            var provider = new MultipleAudioDramaProvider();
            _audioDramas = provider.Get().ToList();

            _sut = new AudioDramaSorter();
        }

        [TestMethod]
        public void DefaultSortMode_SortByReleaseDateDescending()
        {
            Assert.AreEqual(EAudioDramaSortMode.ReleaseDateDescending, _sut.SortMode);
        }

        [TestMethod]
        public void SortByReleaseDateDescending()
        {
            _sut.SortMode = EAudioDramaSortMode.ReleaseDateDescending;
            var expectedSort = _audioDramas.OrderByDescending(x => x.AudioDramaDto.ReleaseDate).ToList();

            var sort = _sut.Sort(_audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }

        [TestMethod]
        public void SortByReleaseDateAscending()
        {
            _sut.SortMode = EAudioDramaSortMode.ReleaseDateAscending;
            var expectedSort = _audioDramas.OrderBy(x => x.AudioDramaDto.ReleaseDate).ToList();

            var sort = _sut.Sort(_audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }

        [TestMethod]
        public void SortByNumberDescending()
        {
            _sut.SortMode = EAudioDramaSortMode.NumberDescending;
            var expectedSort = _audioDramas.OrderByDescending(x => x.AudioDramaDto.Number).ToList();

            var sort = _sut.Sort(_audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }

        [TestMethod]
        public void SortByNumberAscending()
        {
            _sut.SortMode = EAudioDramaSortMode.NumberAscending;
            var expectedSort = _audioDramas.OrderBy(x => x.AudioDramaDto.Number).ToList();

            var sort = _sut.Sort(_audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }

        [TestMethod]
        public void SortByNameDescending()
        {
            _sut.SortMode = EAudioDramaSortMode.NameDescending;
            var expectedSort = _audioDramas.OrderByDescending(x => x.AudioDramaDto.Name).ToList();

            var sort = _sut.Sort(_audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }

        [TestMethod]
        public void SortByNameAscending()
        {
            _sut.SortMode = EAudioDramaSortMode.NameAscending;
            var expectedSort = _audioDramas.OrderBy(x => x.AudioDramaDto.Name).ToList();

            var sort = _sut.Sort(_audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }

        [TestMethod]
        public void SortByHeardFirst()
        {
            _sut.SortMode = EAudioDramaSortMode.HeardFirst;
            var expectedSort = _audioDramas.OrderByDescending(x => x.AudioDramaUserData.Heard).ToList();

            var sort = _sut.Sort(_audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }

        [TestMethod]
        public void SortByHeardLast()
        {
            _sut.SortMode = EAudioDramaSortMode.HeardLast;
            var expectedSort = _audioDramas.OrderBy(x => x.AudioDramaUserData.Heard).ToList();

            var sort = _sut.Sort(_audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }

        [TestMethod]
        public void SortByIsFavoriteFirst()
        {
            _sut.SortMode = EAudioDramaSortMode.IsFavoriteFirst;
            var expectedSort = _audioDramas.OrderByDescending(x => x.AudioDramaUserData.IsFavorite).ToList();

            var sort = _sut.Sort(_audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }

        [TestMethod]
        public void SortByIsFavoriteLast()
        {
            _sut.SortMode = EAudioDramaSortMode.IsFavoriteLast;
            var expectedSort = _audioDramas.OrderBy(x => x.AudioDramaUserData.IsFavorite).ToList();

            var sort = _sut.Sort(_audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }
    }
}
