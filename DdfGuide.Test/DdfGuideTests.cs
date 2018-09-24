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
        private Mock<IRepository<AudioDramaDto>> _audioDramaRepository;
        private Mock<IRepository<AudioDramaUserData>> _userDataRepository;
        private IEnumerable<AudioDramaDto> _dtoList;
        private IEnumerable<AudioDramaUserData> _userDataList;
        private AudioDramaDto _dto1;
        private AudioDramaDto _dto2;
        private AudioDramaDto _dto3;
        private AudioDramaUserData _userData1;
        private AudioDramaUserData _userData2;
        private AudioDramaUserData _userData3;
        private AudioDrama _audioDrama1;
        private AudioDrama _audioDrama2;
        private AudioDrama _audioDrama3;
        private List<AudioDrama> _audioDramaList;

        [TestInitialize]
        public void CreateNewDdfGuide()
        {
            _audioDramaRepository = new Mock<IRepository<AudioDramaDto>>();
            _userDataRepository = new Mock<IRepository<AudioDramaUserData>>();
            _view = new Mock<IAudioDramaListView>();

            _dto1 = new AudioDramaDto(Guid.NewGuid());
            _dto2 = new AudioDramaDto(Guid.NewGuid());
            _dto3 = new AudioDramaDto(Guid.NewGuid());
            _dtoList = new List<AudioDramaDto> { _dto1, _dto2, _dto3 };

            _userData1 = new AudioDramaUserData(_dto1.Id, true, false);
            _userData2 = new AudioDramaUserData(_dto2.Id, false, true);
            _userData3 = new AudioDramaUserData(_dto3.Id, true, true);
            _userDataList = new List<AudioDramaUserData> { _userData1, _userData2, _userData3 };

            _audioDrama1 = new AudioDrama(_dto1, _userData1);
            _audioDrama2 = new AudioDrama(_dto2, _userData2);
            _audioDrama3 = new AudioDrama(_dto3, _userData3);
            _audioDramaList = new List<AudioDrama> {_audioDrama1, _audioDrama2, _audioDrama3};

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
                .Returns(Task.FromResult(_dtoList));

            _userDataRepository
                .Setup(x => x.GetAll())
                .Returns(Task.FromResult(_userDataList));

            await _systemUnderTest.Start();

            _view.Verify(x => x.SetAudioDramas(_audioDramaList), Times.Once);
        }

        [TestMethod]
        public async Task Startup_ShowAudioDramaListView()
        {
            await _systemUnderTest.Start();

            _view.Verify(x => x.Show(), Times.Once);
        }

        [TestMethod]
        public async Task HeardChanges_UpdateModel()
        {
            await _systemUnderTest.Start();

            foreach (var audioDramaUserData in _userDataList)
            {
                var currentValue = audioDramaUserData.Heard;
                _view.Raise(x => x.HeardChanged += null, _dto1);
                Assert.AreEqual(!currentValue, _dto1);
            }
        }
    }
}
