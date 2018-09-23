using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.Interfaces;

namespace DdfGuide.Test
{
    [TestClass]
    public class DdfGuideTests
    {
        private Mock<IAudioDramaListView> _view;
        private Core.DdfGuide _systemUnderTest;
        private Mock<IRepository<AudioDrama>> _audioDramaRepository;
        private Mock<IRepository<AudioDramaUserData>> _userDataRepository;
        private IEnumerable<AudioDrama> _audioDramaList;
        private IEnumerable<AudioDramaUserData> _audioDramaUserData;

        [TestInitialize]
        public void CreateNewDdfGuide()
        {
            _audioDramaRepository = new Mock<IRepository<AudioDrama>>();
            _userDataRepository = new Mock<IRepository<AudioDramaUserData>>();
            _view = new Mock<IAudioDramaListView>();

            var audioDrama1 = new AudioDrama(Guid.NewGuid());
            var audioDrama2 = new AudioDrama(Guid.NewGuid());
            var audioDrama3 = new AudioDrama(Guid.NewGuid());
            _audioDramaList = new List<AudioDrama> { audioDrama1, audioDrama2, audioDrama3 };

            var userData1 = new AudioDramaUserData(audioDrama1.Id, true);
            var userData2 = new AudioDramaUserData(audioDrama2.Id, false);
            var userData3 = new AudioDramaUserData(audioDrama3.Id, true);
            _audioDramaUserData = new List<AudioDramaUserData> { userData1, userData2, userData3 };

            _systemUnderTest = new Core.DdfGuide(
                _audioDramaRepository.Object,
                _userDataRepository.Object,
                _view.Object);
        }

        [TestMethod]
        public void CreationSuccessfull()
        {
            Assert.IsNotNull(_systemUnderTest);
        }

        [TestMethod]
        public async Task Startup_FillWithAudioDramas()
        {
            _audioDramaRepository
                .Setup(x => x.GetAll())
                .Returns(Task.FromResult(_audioDramaList));

            await _systemUnderTest.Start();

            _view.Verify(x => x.SetAudioDramas(_audioDramaList), Times.Once);
        }

        [TestMethod]
        public async Task Startup_FillWithUserData()
        {
            _userDataRepository
                .Setup(x => x.GetAll())
                .Returns(Task.FromResult(_audioDramaUserData));

            await _systemUnderTest.Start();

            _view.Verify(x => x.SetAudioDramaUserData(_audioDramaUserData), Times.Once);
        }

        [TestMethod]
        public async Task Startup_ShowAudioDramaListView()
        {
            await _systemUnderTest.Start();

            _view.Verify(x => x.Show(), Times.Once);
        }
    }
}
