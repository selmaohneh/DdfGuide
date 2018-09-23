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
        private Mock<IRepository<AudioDrama>> _localRepository;

        [TestInitialize]
        public void CreateNewDdfGuide()
        {
            _localRepository = new Mock<IRepository<AudioDrama>>();

            _view = new Mock<IAudioDramaListView>();

            _systemUnderTest = new Core.DdfGuide(
                _localRepository.Object,
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
            var audioDrama1 = new AudioDrama(Guid.NewGuid());
            var audioDrama2 = new AudioDrama(Guid.NewGuid());
            var audioDrama3 = new AudioDrama(Guid.NewGuid());
            var audioDramaList = new List<AudioDrama> {audioDrama1, audioDrama2, audioDrama3};
            
            _localRepository
                .Setup(x => x.GetAll())
                .Returns(Task.FromResult<IEnumerable<AudioDrama>>(audioDramaList));

            await _systemUnderTest.Start();

            _view.Verify(x => x.SetAudioDramas(audioDramaList), Times.Once);
        }

        [TestMethod]
        public async Task Startup_ShowEpisodeListView()
        {
            await _systemUnderTest.Start();

            _view.Verify(x => x.Show(), Times.Once);
        }
    }
}
