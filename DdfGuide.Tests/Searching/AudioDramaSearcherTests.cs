using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Searching;
using DdfGuide.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Searching
{
    [TestClass]
    public class AudioDramaSearcherTests
    {
        private List<AudioDrama> _audioDramas;
        private AudioDramaSearcher _searcher;

        [TestInitialize]
        public void Init()
        {
            var provider = new SampleAudioDramaProvider();
            _audioDramas = provider.Get().ToList();
            _searcher = new AudioDramaSearcher();
        }

        [TestMethod]
        public void WhenNoSearchTextIsGivenTheSearcherFindsAllAudioDramas()
        {
            var searchResult = _searcher.Search(_audioDramas, "").ToList();
            CollectionAssert.AreEqual(_audioDramas, searchResult);

            searchResult = _searcher.Search(_audioDramas, string.Empty).ToList();
            CollectionAssert.AreEqual(_audioDramas, searchResult);

            searchResult = _searcher.Search(_audioDramas, "  ").ToList();
            CollectionAssert.AreEqual(_audioDramas, searchResult);

            searchResult = _searcher.Search(_audioDramas, "   ").ToList();
            CollectionAssert.AreEqual(_audioDramas, searchResult);

            searchResult = _searcher.Search(_audioDramas, null).ToList();
            CollectionAssert.AreEqual(_audioDramas, searchResult);
        }

        [TestMethod]
        public void SearchForPartOfNameReturnsAllAudioDramasThatContainThatPart()
        {
            const string searchText = "super";
            var searchResult = _searcher.Search(_audioDramas, searchText).ToList();

            Assert.AreEqual(2, searchResult.Count);
            Assert.IsTrue(searchResult.Select(x=>x.AudioDramaDto.NumberEuropa).Contains(1));
            Assert.IsTrue(searchResult.Select(x => x.AudioDramaDto.NumberEuropa).Contains(3));
        }

        [TestMethod]
        public void SearchForPartOfNameWithMixedCasing_SearchShouldStillReturnSameResult()
        {
            const string searchText = "sUPeR";
            var searchResult = _searcher.Search(_audioDramas, searchText).ToList();

            Assert.AreEqual(2, searchResult.Count);
            Assert.IsTrue(searchResult.Select(x => x.AudioDramaDto.NumberEuropa).Contains(1));
            Assert.IsTrue(searchResult.Select(x => x.AudioDramaDto.NumberEuropa).Contains(3));
        }
    }
}
