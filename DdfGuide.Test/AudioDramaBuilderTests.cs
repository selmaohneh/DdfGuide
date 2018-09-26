using System;
using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaBuilderTests
    {
        [TestMethod]
        public void TestCorrectBuilding()
        {
            var id1 = Guid.NewGuid();
            var id2 = Guid.NewGuid();

            var dto1 = new AudioDramaDto(id1, string.Empty);
            var dto2 = new AudioDramaDto(id2, string.Empty);
            var dtoList = new List<AudioDramaDto> {dto1, dto2};

            var userData1 = new AudioDramaUserData(id1, true, false);
            var userData2 = new AudioDramaUserData(id2, false, true);
            var userDataList = new List<AudioDramaUserData> {userData1, userData2};
            
            var audioDrama1 = new AudioDrama(dto1, userData1);
            var audioDrama2 = new AudioDrama(dto2, userData2);
            var audioDramaList = new List<AudioDrama> {audioDrama1, audioDrama2};

            var builder = new AudioDramaBuilder(dtoList, userDataList);
            var buildResult = builder.Build().ToList();
            
            CollectionAssert.AreEqual(audioDramaList, buildResult);
        }
    }
}
