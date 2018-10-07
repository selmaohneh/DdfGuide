using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaFilterTests
    {
        private AudioDramaFilter _sut;
        private List<AudioDrama> _audioDramas;

        [TestInitialize]
        public void Init()
        {
            var provider = new MultipleAudioDramaProvider();
            _audioDramas = provider.Get().ToList();
            _sut = new AudioDramaFilter();
        }

        [TestMethod]
        public void Default_IncludeAllItems()
        {
            var filtered = _sut.Filter(_audioDramas).ToList();

            CollectionAssert.AreEqual(_audioDramas, filtered);
        }

        [TestMethod]
        public void IncludeMainAudioDramas_true()
        {
            _sut.IncludeMainAudioDramas = true;

            var filtered = _sut.Filter(_audioDramas).ToList();
           
            CollectionAssert.AreEqual(_audioDramas, filtered);
        }

        [TestMethod]
        public void IncludeMainAudioDramas_false()
        {
            _sut.IncludeMainAudioDramas = false;
            var special = _audioDramas.Where(x => !x.AudioDramaDto.Number.HasValue).ToList();

            var filtered = _sut.Filter(_audioDramas).ToList();

            CollectionAssert.AreEqual(special, filtered);
        }
    }
}
