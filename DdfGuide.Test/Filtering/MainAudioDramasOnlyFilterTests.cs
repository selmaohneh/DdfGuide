using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Filtering;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test.Filtering
{
    [TestClass]
    public class MainAudioDramasOnlyFilterTests
    {
        private MainAudioDramasOnlyFilter _sut;
        private List<AudioDrama> _audioDramas;

        [TestInitialize]
        public void Init()
        {
            var provider = new MultipleAudioDramaProvider();
            _audioDramas = provider.Get().ToList();
            _sut = new MainAudioDramasOnlyFilter();
        }

        [TestMethod]
        public void Filter_OnlyMainAudioDramas()
        {
            var filtered = _sut.Filter(_audioDramas).ToList();

            Assert.IsTrue(filtered.All(x => x.AudioDramaDto.Number.HasValue));
        }

        [TestMethod]
        public void CorrectMode()
        {
            Assert.AreEqual(EAudioDramaFilterMode.MainsOnly, _sut.FilterMode);
        }
    }
}
