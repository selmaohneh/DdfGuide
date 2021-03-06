﻿using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaUserDataExtensionsTests
    {
        private IEnumerable<AudioDrama> _audioDramas;

        [TestInitialize]
        public void Init()
        {
            var audioDramaProvider = new SampleAudioDramaProvider();
            _audioDramas = audioDramaProvider.Get();
        }

        [TestMethod]
        public void GetById()
        {
            var expectedAudioDrama = _audioDramas.First();
            var actualAudioDrama = _audioDramas.GetById(expectedAudioDrama.AudioDramaDto.Id);
            Assert.AreEqual(expectedAudioDrama, actualAudioDrama);

            expectedAudioDrama = _audioDramas.Last();
            actualAudioDrama = _audioDramas.GetById(expectedAudioDrama.AudioDramaDto.Id);
            Assert.AreEqual(expectedAudioDrama, actualAudioDrama);
        }
    }
}
