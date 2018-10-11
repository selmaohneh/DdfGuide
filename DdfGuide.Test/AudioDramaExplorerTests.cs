﻿using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Searching;
using DdfGuide.Core.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaExplorerTests
    {
        private AudioDramaExplorer _explorer;
        private List<AudioDrama> _audioDramas;

        [TestInitialize]
        public void Init()
        {
            var searcher = new AudioDramaSearcher();
            var sorterFactory = new AudioDramaSorterFactory();
            var filterFactory = new AudioDramaFilterFactory();
            _explorer = new AudioDramaExplorer(searcher, filterFactory, sorterFactory);
            var provider = new SampleAudioDramaProvider();
            _audioDramas = provider.Get().ToList();
        }

        [TestMethod]
        public void ExplorerReturnsAllAudioDramasInReleaseDataDesceningByDefault()
        {
            var result = _explorer.GetMatchingAudioDramas(_audioDramas).ToList();

            var expectedResult = _audioDramas.OrderByDescending(x => x.AudioDramaDto.ReleaseDate).ToList();

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ExplorerFiltersWhenAFilterWasSet()
        {
            _explorer.SetFilterMode(EAudioDramaFilterMode.SpecialsOnly);
            var result = _explorer.GetMatchingAudioDramas(_audioDramas).ToList();
            
            var expectedResult = _audioDramas
                .Where(x => x.AudioDramaDto.NumberEuropa.HasValue == false)
                .OrderByDescending(x => x.AudioDramaDto.ReleaseDate).ToList();

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ExplorerSearchesWhenASearchTextWasSet()
        {
            _explorer.SetSearchText("Papagei");
            var result = _explorer.GetMatchingAudioDramas(_audioDramas).ToList();

            var expectedResult = _audioDramas
                .Where(x => x.AudioDramaDto.Title.Contains("Papagei"))
                .OrderByDescending(x => x.AudioDramaDto.ReleaseDate).ToList();

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ExplorerSortsWhenASortModeWasSet()
        {
            _explorer.SetSortMode(EAudioDramaSortMode.ReleaseDateAscending);
            var result = _explorer.GetMatchingAudioDramas(_audioDramas).ToList();

            var expectedResult = _audioDramas.OrderBy(x => x.AudioDramaDto.ReleaseDate).ToList();

            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}