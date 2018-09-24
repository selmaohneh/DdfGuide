using System;
using System.Collections.Generic;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaUserDataExtensionsTests
    {
        private AudioDramaDto _dto1;
        private AudioDramaDto _dto2;
        private AudioDramaDto _dto3;
        private IEnumerable<AudioDrama> _audioDramas;
        private AudioDramaUserData _userData1;
        private AudioDramaUserData _userData2;
        private AudioDramaUserData _userData3;
        private AudioDrama _audioDrama1;
        private AudioDrama _audioDrama2;
        private AudioDrama _audioDrama3;

        [TestInitialize]
        public void Init()
        {
            _dto1 = new AudioDramaDto(Guid.NewGuid());
            _dto2 = new AudioDramaDto(Guid.NewGuid());
            _dto3 = new AudioDramaDto(Guid.NewGuid());

            _userData1 = new AudioDramaUserData(_dto1.Id, true, false);
            _userData2 = new AudioDramaUserData(_dto2.Id, false, true);
            _userData3 = new AudioDramaUserData(_dto3.Id, true, true);

            _audioDrama1 = new AudioDrama(_dto1, _userData1);
            _audioDrama2 = new AudioDrama(_dto2, _userData2);
            _audioDrama3 = new AudioDrama(_dto3, _userData3);

            _audioDramas = new List<AudioDrama> {_audioDrama1, _audioDrama2, _audioDrama3};
        }

        [TestMethod]
        public void GetById()
        {
            var audioDrama1 = _audioDramas.GetById(_dto1.Id);
            Assert.AreEqual(_dto1, audioDrama1.AudioDramaDto);
            Assert.AreEqual(_userData1, audioDrama1.AudioDramaUserData);
            Assert.AreEqual(_audioDrama1, audioDrama1);

            var audioDrama2 = _audioDramas.GetById(_dto2.Id);
            Assert.AreEqual(_dto2, audioDrama2.AudioDramaDto);
            Assert.AreEqual(_userData2, audioDrama2.AudioDramaUserData);
            Assert.AreEqual(_audioDrama2, audioDrama2);

            var audioDrama3 = _audioDramas.GetById(_dto3.Id);
            Assert.AreEqual(_dto3, audioDrama3.AudioDramaDto);
            Assert.AreEqual(_userData3, audioDrama3.AudioDramaUserData);
            Assert.AreEqual(_audioDrama3, audioDrama3);
        }
    }
}
