using System;
using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.AutoMock;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaListPresenterTests
    {
        private SampleAudioDramaProvider _sampleAudioDramaProvider;
        private List<AudioDrama> _audioDramas;
        private AutoMocker _mocker;

        [TestInitialize]
        public void Init()
        {
            _mocker = new AutoMocker();

            _sampleAudioDramaProvider = new SampleAudioDramaProvider();
            _audioDramas = _sampleAudioDramaProvider.Get().ToList();

            _mocker.Use<IEnumerable<AudioDrama>>(_audioDramas);

            var _ = _mocker.CreateInstance<AudioDramaListPresenter>();
        }
        

        [TestMethod]
        public void Construct_FillWithAudioDramas()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()), Times.Once);
        }

        [TestMethod]
        public void HeardChanged_UpdateModel()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();

            Assert.IsFalse(_audioDramas.First().AudioDramaUserData.Heard);

            listView.Raise(x => x.HeardChanged += null, this, _audioDramas.First().AudioDramaUserData.Id);
            Assert.IsTrue(_audioDramas.First().AudioDramaUserData.Heard);

            listView.Raise(x => x.HeardChanged += null, this, _audioDramas.First().AudioDramaUserData.Id);
            Assert.IsFalse(_audioDramas.First().AudioDramaUserData.Heard);
        }

        [TestMethod]
        public void HeardChanged_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();

            listView.Invocations.Clear();

            var id = _audioDramas.First().AudioDramaUserData.Id;

            var oldValue = _audioDramas.Single(x => x.AudioDramaDto.Id == id).AudioDramaUserData.Heard;

            listView.Raise(x => x.HeardChanged += null, this, id);

            var newValue = _audioDramas.Single(x => x.AudioDramaDto.Id == id).AudioDramaUserData.Heard;

            Assert.AreNotEqual(oldValue, newValue);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()), Times.Once);
        }

        [TestMethod]
        public void IsFavoriteChanged_UpdateModel()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();

            Assert.IsFalse(_audioDramas.First().AudioDramaUserData.IsFavorite);

            listView.Raise(x => x.IsFavoriteChanged += null, this, _audioDramas.First().AudioDramaUserData.Id);
            Assert.IsTrue(_audioDramas.First().AudioDramaUserData.IsFavorite);

            listView.Raise(x => x.IsFavoriteChanged += null, this, _audioDramas.First().AudioDramaUserData.Id);
            Assert.IsFalse(_audioDramas.First().AudioDramaUserData.IsFavorite);
        }

        [TestMethod]
        public void IsFavoriteChanged_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();

            listView.Invocations.Clear();

            var id = _audioDramas.First().AudioDramaUserData.Id;
            var oldValue = _audioDramas.Single(x => x.AudioDramaDto.Id == id).AudioDramaUserData.IsFavorite;

            listView.Raise(x => x.IsFavoriteChanged += null, this, id);

            var newValue = _audioDramas.Single(x => x.AudioDramaDto.Id == id).AudioDramaUserData.IsFavorite;

            Assert.AreNotEqual(oldValue, newValue);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()), Times.Once);
        }

        [TestMethod]
        public void AudioDramaClicked_OpenAudioDramaView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var viewer = _mocker.GetMock<IViewer>();
            var view = _mocker.GetMock<IAudioDramaView>();

            listView.Raise(x => x.AudioDramaClicked += null, this, _audioDramas.First().AudioDramaDto.Id);
            
            viewer.Verify(x => x.Show(view.Object), Times.Once);
        }

        [TestMethod]
        public void UserDataChanged_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();

            listView.Invocations.Clear();

            _audioDramas.First().AudioDramaUserData.Heard = !_audioDramas.First().AudioDramaUserData.Heard;
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()), Times.Once);

            _audioDramas.First().AudioDramaUserData.IsFavorite = !_audioDramas.First().AudioDramaUserData.IsFavorite;
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()), Times.Exactly(2));
        }

        [TestMethod]
        public void OrderByHeardFirstClicked_UpdateExplorer_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.OrderByHeardFirstClicked += null, this, EventArgs.Empty);
            
            explorer.Verify(x => x.SetSortMode(EAudioDramaSortMode.HeardFirst), Times.Once);
            listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.HeardFirst), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void OrderByHeardLastClicked_UpdateExplorer_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.OrderByHeardLastClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetSortMode(EAudioDramaSortMode.HeardLast), Times.Once);
            listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.HeardLast), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void OrderByIsFavoriteFirstClicked_UpdateExplorer_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.OrderByIsFavoriteFirstClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetSortMode(EAudioDramaSortMode.IsFavoriteFirst), Times.Once);
            listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.IsFavoriteFirst), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void OrderIsFavoriteLastClicked_UpdateExplorer_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.OrderByIsFavoriteLastClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetSortMode(EAudioDramaSortMode.IsFavoriteLast), Times.Once);
            listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.IsFavoriteLast), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void OrderByNumberAscendingClicked_UpdateExplorer_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.OrderByNumberAscendingClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetSortMode(EAudioDramaSortMode.NumberAscending), Times.Once);
            listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.NumberAscending), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void OrderByNumberDescendingClicked_UpdateExplorer_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.OrderByNumberDescendingClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetSortMode(EAudioDramaSortMode.NumberDescending), Times.Once);
            listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.NumberDescending), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void OrderByReleaseDateAscendingClicked_UpdateExplorer_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.OrderByReleaseDateAscendingClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetSortMode(EAudioDramaSortMode.ReleaseDateAscending), Times.Once);
            listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.ReleaseDateAscending), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void OrderByReleaseDateDescendingClicked_UpdateExplorer_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.OrderByReleaseDateDescendingClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetSortMode(EAudioDramaSortMode.ReleaseDateDescending), Times.Once);
            listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.ReleaseDateDescending), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void OrderByNameAscendingClicked_UpdateExplorer_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.OrderByNameAscendingClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetSortMode(EAudioDramaSortMode.NameAscending), Times.Once);
            listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.NameAscending), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void OrderByNameDescendingClicked_UpdateExplorer_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.OrderByNameDescendingClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetSortMode(EAudioDramaSortMode.NameDescending), Times.Once);
            listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.NameDescending), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void MainAudioDramasOnlyClicked_UpdateExplorer_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.MainsOnlyClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetFilterMode(EAudioDramaFilterMode.MainsOnly), Times.Once);
            listView.Verify(x => x.SetFilterInfos(EAudioDramaFilterMode.MainsOnly), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void AllAudioDramasClicked_UpdateExplorer_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.AllClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetFilterMode(EAudioDramaFilterMode.All), Times.Once);
            listView.Verify(x => x.SetFilterInfos(EAudioDramaFilterMode.All), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void FavoritesOnlyClicked_UpdateExplorer_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.FavoritesOnlyClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetFilterMode(EAudioDramaFilterMode.FavoritesOnly), Times.Once);
            listView.Verify(x => x.SetFilterInfos(EAudioDramaFilterMode.FavoritesOnly), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void UnheardOnlyClicked_UpdateExplorer_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.UnheardOnlyClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetFilterMode(EAudioDramaFilterMode.UnheardOnly), Times.Once);
            listView.Verify(x => x.SetFilterInfos(EAudioDramaFilterMode.UnheardOnly), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void SpecialsOnlyClicked_UpdateExplorer_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.SpecialsOnlyClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetFilterMode(EAudioDramaFilterMode.SpecialsOnly), Times.Once);
            listView.Verify(x => x.SetFilterInfos(EAudioDramaFilterMode.SpecialsOnly), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void SearchRequested_GetCurrentSearchText_UpdateExplorer_UpdateView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Setup(x => x.GetCurrentSearchText()).Returns("Homer Simpson");

            listView.Raise(x => x.SearchTextChanged += null, this, EventArgs.Empty);
            
            explorer.Verify(x => x.SetSearchText("Homer Simpson"), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }
    }
}
