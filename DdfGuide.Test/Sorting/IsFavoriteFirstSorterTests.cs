﻿using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Sorting
{
    [TestClass]
    public class IsFavoriteFirstSorterTests
    {
        [TestMethod]
        public void CorrectMode()
        {
            var sorter = new IsFavoriteFirstSorter();
            Assert.AreEqual(EAudioDramaSortMode.IsFavoriteFirst, sorter.SortMode);
        }

        [TestMethod]
        public void SortByIsFavoriteFirst()
        {
            var provider = new MultipleAudioDramaProvider();
            var sorter = new IsFavoriteFirstSorter();
            var audioDramas = provider.Get().ToList();
            var expectedSort = audioDramas.OrderByDescending(x => x.AudioDramaUserData.IsFavorite).ToList();

            var sort = sorter.Sort(audioDramas).ToList();

            CollectionAssert.AreEqual(expectedSort, sort);
        }
    }
}