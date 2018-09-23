using System;
using System.Collections.Generic;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaUserDataExtensionsTests
    {
        private AudioDrama _audioDrama1;
        private AudioDrama _audioDrama2;
        private AudioDrama _audioDrama3;
        private List<AudioDramaUserData> _audioDramaUserDatas;

        [TestInitialize]
        public void Init()
        {
            _audioDrama1 = new AudioDrama(Guid.NewGuid());
            _audioDrama2 = new AudioDrama(Guid.NewGuid());
            _audioDrama3 = new AudioDrama(Guid.NewGuid());

            var userData1 = new AudioDramaUserData(_audioDrama1.Id, true, false);
            var userData2 = new AudioDramaUserData(_audioDrama2.Id, false, true);
            var userData3 = new AudioDramaUserData(_audioDrama3.Id, true, true);
            _audioDramaUserDatas = new List<AudioDramaUserData>
            {
                userData1,
                userData2,
                userData3
            };
        }

        [TestMethod]
        public void UserHasHeard()
        {
            Assert.IsTrue(_audioDramaUserDatas.UserHasHeard(_audioDrama1));
            Assert.IsFalse(_audioDramaUserDatas.UserHasHeard(_audioDrama2));
            Assert.IsTrue(_audioDramaUserDatas.UserHasHeard(_audioDrama3));
        }

        [TestMethod]
        public void UserHasHeard_NoUserData_ReturnFalse()
        {
            var audioDrama = new AudioDrama(Guid.NewGuid());
            var userData = new List<AudioDramaUserData>();

            Assert.IsFalse(userData.UserHasHeard(audioDrama));
        }

        [TestMethod]
        public void IsUsersFavorite()
        {
            Assert.IsFalse(_audioDramaUserDatas.IsUsersFavorite(_audioDrama1));
            Assert.IsTrue(_audioDramaUserDatas.IsUsersFavorite(_audioDrama2));
            Assert.IsTrue(_audioDramaUserDatas.IsUsersFavorite(_audioDrama3));
        }

        [TestMethod]
        public void IsUsersFavorite_NoUserData_ReturnFalse()
        {
            var audioDrama = new AudioDrama(Guid.NewGuid());
            var userData = new List<AudioDramaUserData>();

            Assert.IsFalse(userData.IsUsersFavorite(audioDrama));
        }
    }
}
