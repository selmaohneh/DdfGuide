using DdfGuide.Core.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Sorting
{
    [TestClass]
    public class AudioDramaSorterFactoryTests
    {
        private AudioDramaSorterFactory _sut;

        [TestInitialize]
        public void Init()
        {
            _sut = new AudioDramaSorterFactory();
        }

        [TestMethod]
        public void HeardFirst()
        {
            var sorter = _sut.Create(EAudioDramaSortMode.HeardFirst);
            Assert.IsInstanceOfType(sorter, typeof(HeardFirstSorter));
        }

        [TestMethod]
        public void HeardLast()
        {
            var sorter = _sut.Create(EAudioDramaSortMode.HeardLast);
            Assert.IsInstanceOfType(sorter, typeof(HeardLastSorter));
        }

        [TestMethod]
        public void ReleaseDateDescending()
        {
            var sorter = _sut.Create(EAudioDramaSortMode.ReleaseDateDescending);
            Assert.IsInstanceOfType(sorter, typeof(ReleaseDateDescendingSorter));
        }

        [TestMethod]
        public void ReleaseDateAscending()
        {
            var sorter = _sut.Create(EAudioDramaSortMode.ReleaseDateAscending);
            Assert.IsInstanceOfType(sorter, typeof(ReleaseDateAscendingSorter));
        }

        [TestMethod]
        public void IsFavoriteFirst()
        {
            var sorter = _sut.Create(EAudioDramaSortMode.IsFavoriteFirst);
            Assert.IsInstanceOfType(sorter, typeof(IsFavoriteFirstSorter));
        }

        [TestMethod]
        public void IsFavoriteLast()
        {
            var sorter = _sut.Create(EAudioDramaSortMode.IsFavoriteLast);
            Assert.IsInstanceOfType(sorter, typeof(IsFavoriteLastSorter));
        }

        [TestMethod]
        public void NameAscending()
        {
            var sorter = _sut.Create(EAudioDramaSortMode.NameAscending);
            Assert.IsInstanceOfType(sorter, typeof(NameAscendingSorter));
        }

        [TestMethod]
        public void NameDescending()
        {
            var sorter = _sut.Create(EAudioDramaSortMode.NameDescending);
            Assert.IsInstanceOfType(sorter, typeof(NameDescendingSorter));
        }
    }
}
