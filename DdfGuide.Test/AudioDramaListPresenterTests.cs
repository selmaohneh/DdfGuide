using System;
using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DdfGuide.Test
{
    [TestClass]
    public class AudioDramaListPresenterTests
    {
        private Mock<IAudioDramaListView> _listView;
        private Mock<IAudioDramaView> _view;
        private MultipleAudioDramaProvider _audioDramaProvider;
        private Mock<IViewer> _viewer;
        private Mock<IAudioDramaPresenter> _audioDramaPresenter;
        private List<AudioDrama> _audioDramas;
        private Mock<IAudioDramaSorterFactory> _sorterFactory;
        private Mock<IAudioDramaFilterFactory> _filterFactory;
        private Mock<IAudioDramaSorter> _sorter;
        private Mock<IAudioDramaFilter> _filter;

        [TestInitialize]
        public void Init()
        {
            _audioDramaProvider = new MultipleAudioDramaProvider();
            _audioDramas = _audioDramaProvider.Get().ToList();

            _listView = new Mock<IAudioDramaListView>();
            _view = new Mock<IAudioDramaView>();
            _viewer = new Mock<IViewer>();
            _audioDramaPresenter = new Mock<IAudioDramaPresenter>();

            _sorter = new Mock<IAudioDramaSorter>();
            _filter = new Mock<IAudioDramaFilter>();

            _sorterFactory = new Mock<IAudioDramaSorterFactory>();
            _filterFactory = new Mock<IAudioDramaFilterFactory>();

            _sorterFactory
                .Setup(x => x.Create(It.IsAny<EAudioDramaSortMode>()))
                .Returns(_sorter.Object);

            _filterFactory
                .Setup(x => x.Create(It.IsAny<EAudioDramaFilterMode>()))
                .Returns(_filter.Object);

            _sorter
                .Setup(x => x.Sort(It.IsAny<IEnumerable<AudioDrama>>()))
                .Returns<IEnumerable<AudioDrama>>(x => x);

            _filter
                .Setup(x => x.Filter(It.IsAny<IEnumerable<AudioDrama>>()))
                .Returns<IEnumerable<AudioDrama>>(x => x);

            var _ = new AudioDramaListPresenter(
                _listView.Object,
                _view.Object,
                _audioDramas,
                _viewer.Object,
                _audioDramaPresenter.Object,
                _filterFactory.Object,
                _sorterFactory.Object
            );
        }
        

        [TestMethod]
        public void Construct_FillWithAudioDramas()
        {
            _listView.Verify(x => x.SetAudioDramaInfos(_audioDramas), Times.Once);
        }

        [TestMethod]
        public void Construct_FillWithDefaultFilterInfos()
        {
            _listView.Verify(x => x.SetFilterInfos(EAudioDramaFilterMode.AllAudioDramas), Times.Once);
        }

        [TestMethod]
        public void Construct_FillWithDefaultSortInfos()
        {
            _listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.ReleaseDateDescending), Times.Once);
        }

        [TestMethod]
        public void Construct_DefaultFilter_All()
        {
            _filterFactory.Verify(x => x.Create(EAudioDramaFilterMode.AllAudioDramas), Times.Once());
            _filterFactory.Verify(
                x => x.Create(It.Is<EAudioDramaFilterMode>(y => y != EAudioDramaFilterMode.AllAudioDramas)),
                Times.Never);
        }

        [TestMethod]
        public void HeardChanged_UpdateModel()
        {
            Assert.IsFalse(_audioDramas.First().AudioDramaUserData.Heard);

            _listView.Raise(x => x.HeardChanged += null, this, _audioDramas.First().AudioDramaUserData.Id);
            Assert.IsTrue(_audioDramas.First().AudioDramaUserData.Heard);

            _listView.Raise(x => x.HeardChanged += null, this, _audioDramas.First().AudioDramaUserData.Id);
            Assert.IsFalse(_audioDramas.First().AudioDramaUserData.Heard);
        }

        [TestMethod]
        public void HeardChanged_UpdateView()
        {
            _listView.Invocations.Clear();

            Assert.IsFalse(_audioDramas.First().AudioDramaUserData.Heard);
            _listView.Raise(x => x.HeardChanged += null, this, _audioDramas.First().AudioDramaUserData.Id);

            _listView.Verify(
                x => x.SetAudioDramaInfos(It.Is<IEnumerable<AudioDrama>>(y => y.First().AudioDramaUserData.Heard)),
                Times.Once);
        }

        [TestMethod]
        public void IsFavoriteChanged_UpdateModel()
        {
            Assert.IsFalse(_audioDramas.First().AudioDramaUserData.IsFavorite);

            _listView.Raise(x => x.IsFavoriteChanged += null, this, _audioDramas.First().AudioDramaUserData.Id);
            Assert.IsTrue(_audioDramas.First().AudioDramaUserData.IsFavorite);

            _listView.Raise(x => x.IsFavoriteChanged += null, this, _audioDramas.First().AudioDramaUserData.Id);
            Assert.IsFalse(_audioDramas.First().AudioDramaUserData.IsFavorite);
        }

        [TestMethod]
        public void IsFavoriteChanged_UpdateView()
        {
            _listView.Invocations.Clear();

            Assert.IsFalse(_audioDramas.First().AudioDramaUserData.IsFavorite);
            _listView.Raise(x => x.IsFavoriteChanged += null, this, _audioDramas.First().AudioDramaUserData.Id);

            _listView.Verify(
                x => x.SetAudioDramaInfos(It.Is<IEnumerable<AudioDrama>>(y => y.First().AudioDramaUserData.IsFavorite)),
                Times.Once);
        }

        [TestMethod]
        public void AudioDramaClicked_OpenAudioDramaView()
        {
            _listView.Raise(x => x.AudioDramaClicked += null, this, _audioDramas.First().AudioDramaDto.Id);
            
            _viewer.Verify(x => x.Show(_view.Object), Times.Once);
        }

        [TestMethod]
        public void UserDataChanged_UpdateView()
        {
            _listView.Invocations.Clear();

            _listView.Verify(x => x.SetAudioDramaInfos(_audioDramas), Times.Never);

            _audioDramas.First().AudioDramaUserData.Heard = !_audioDramas.First().AudioDramaUserData.Heard;
            _listView.Verify(x => x.SetAudioDramaInfos(_audioDramas), Times.Once);

            _audioDramas.First().AudioDramaUserData.IsFavorite = !_audioDramas.First().AudioDramaUserData.IsFavorite;
            _listView.Verify(x => x.SetAudioDramaInfos(_audioDramas), Times.Exactly(2));
        }

        [TestMethod]
        public void OrderByHeardFirstClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorterFactory.Invocations.Clear();
            _sorter.Invocations.Clear();

            _listView.Raise(x => x.OrderByHeardFirstClicked += null, this, EventArgs.Empty);

            _sorterFactory.Verify(x => x.Create(It.IsAny<EAudioDramaSortMode>()), Times.Once);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);
            _listView.Verify(x=>x.SetSelectedSortMode(It.IsAny<EAudioDramaSortMode>()), Times.Once);
        }

        [TestMethod]
        public void OrderByHeardLastClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorterFactory.Invocations.Clear();
            _sorter.Invocations.Clear();

            _listView.Raise(x => x.OrderByHeardLastClicked += null, this, EventArgs.Empty);

            _sorterFactory.Verify(x => x.Create(It.IsAny<EAudioDramaSortMode>()), Times.Once);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);
            _listView.Verify(x => x.SetSelectedSortMode(It.IsAny<EAudioDramaSortMode>()), Times.Once);
        }

        [TestMethod]
        public void OrderByIsFavoriteFirstClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorterFactory.Invocations.Clear();
            _sorter.Invocations.Clear();

            _listView.Raise(x => x.OrderByIsFavoriteFirstClicked += null, this, EventArgs.Empty);

            _sorterFactory.Verify(x => x.Create(It.IsAny<EAudioDramaSortMode>()), Times.Once);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);
            _listView.Verify(x => x.SetSelectedSortMode(It.IsAny<EAudioDramaSortMode>()), Times.Once);
        }

        [TestMethod]
        public void OrderIsFavoriteLastClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorterFactory.Invocations.Clear();
            _sorter.Invocations.Clear();

            _listView.Raise(x => x.OrderByIsFavoriteLastClicked += null, this, EventArgs.Empty);

            _sorterFactory.Verify(x => x.Create(It.IsAny<EAudioDramaSortMode>()), Times.Once);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);
            _listView.Verify(x => x.SetSelectedSortMode(It.IsAny<EAudioDramaSortMode>()), Times.Once);
        }

        [TestMethod]
        public void OrderByNumberAscendingClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorterFactory.Invocations.Clear();
            _sorter.Invocations.Clear();

            _listView.Raise(x => x.OrderByNumberAscendingClicked += null, this, EventArgs.Empty);

            _sorterFactory.Verify(x => x.Create(It.IsAny<EAudioDramaSortMode>()), Times.Once);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);
            _listView.Verify(x => x.SetSelectedSortMode(It.IsAny<EAudioDramaSortMode>()), Times.Once);
        }

        [TestMethod]
        public void OrderByNumberDescendingClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorterFactory.Invocations.Clear();
            _sorter.Invocations.Clear();

            _listView.Raise(x => x.OrderByNumberDescendingClicked += null, this, EventArgs.Empty);

            _sorterFactory.Verify(x => x.Create(It.IsAny<EAudioDramaSortMode>()), Times.Once);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);
            _listView.Verify(x => x.SetSelectedSortMode(It.IsAny<EAudioDramaSortMode>()), Times.Once);
        }

        [TestMethod]
        public void OrderByReleaseDateAscendingClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorterFactory.Invocations.Clear();
            _sorter.Invocations.Clear();

            _listView.Raise(x => x.OrderByReleaseDateAscendingClicked += null, this, EventArgs.Empty);

            _sorterFactory.Verify(x => x.Create(It.IsAny<EAudioDramaSortMode>()), Times.Once);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);
            _listView.Verify(x => x.SetSelectedSortMode(It.IsAny<EAudioDramaSortMode>()), Times.Once);
        }

        [TestMethod]
        public void OrderByReleaseDateDescendingClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorterFactory.Invocations.Clear();
            _sorter.Invocations.Clear();

            _listView.Raise(x => x.OrderByReleaseDateDescendingClicked += null, this, EventArgs.Empty);

            _sorterFactory.Verify(x => x.Create(It.IsAny<EAudioDramaSortMode>()), Times.Once);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);
            _listView.Verify(x => x.SetSelectedSortMode(It.IsAny<EAudioDramaSortMode>()), Times.Once);
        }

        [TestMethod]
        public void OrderByNameAscendingClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorterFactory.Invocations.Clear();
            _sorter.Invocations.Clear();

            _listView.Raise(x => x.OrderByNameAscendingClicked += null, this, EventArgs.Empty);

            _sorterFactory.Verify(x => x.Create(It.IsAny<EAudioDramaSortMode>()), Times.Once);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);
            _listView.Verify(x => x.SetSelectedSortMode(It.IsAny<EAudioDramaSortMode>()), Times.Once);
        }

        [TestMethod]
        public void OrderByNameDescendingClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorterFactory.Invocations.Clear();
            _sorter.Invocations.Clear();

            _listView.Raise(x => x.OrderByNameDescendingClicked += null, this, EventArgs.Empty);

            _sorterFactory.Verify(x => x.Create(It.IsAny<EAudioDramaSortMode>()), Times.Once);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);
            _listView.Verify(x => x.SetSelectedSortMode(It.IsAny<EAudioDramaSortMode>()), Times.Once);
        }

        [TestMethod]
        public void FilterMainAudioDramasChanged_ChangeFilter_UpdateView()
        {
            _listView.Invocations.Clear();
            _filterFactory.Invocations.Clear();
            _filter.Invocations.Clear();

            _listView.Raise(x => x.MainAudioDramasOnlyClicked += null, this, EventArgs.Empty);

            _filterFactory.Verify(x => x.Create(It.IsAny<EAudioDramaFilterMode>()), Times.Once);
            _filter.Verify(x => x.Filter(_audioDramas), Times.Once);
            _listView.Verify(x => x.SetFilterInfos(It.IsAny<EAudioDramaFilterMode>()), Times.Once);
        }
      }
}
