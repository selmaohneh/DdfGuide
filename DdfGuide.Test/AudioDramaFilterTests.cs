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
            _sut = new AudioDramaFilter(_audioDramas);
        }

        [TestMethod]
        public void Default_FilterNoItems()
        {
            var filtered = _sut.Filter().ToList();

            CollectionAssert.AreEqual(_audioDramas, filtered);
        }

        [TestMethod]
        public void FilterMainAudioDramas_true()
        {
            _sut.FilterMainAudioDramas = true;

            var filtered = _sut.Filter().ToList();
            var special = _audioDramas.Where(x => !x.AudioDramaDto.Number.HasValue).ToList();

            CollectionAssert.AreEqual(special, filtered);
        }

        [TestMethod]
        public void FilterMainAudioDramas_false()
        {
            _sut.FilterMainAudioDramas = false;

            var filtered = _sut.Filter().ToList();

            CollectionAssert.AreEqual(_audioDramas, filtered);
        }
    }
}
