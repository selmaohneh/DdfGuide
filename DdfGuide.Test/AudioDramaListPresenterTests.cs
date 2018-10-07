using System;
using System.Collections.Generic;
using System.Linq;
using DdfGuide.Core;
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

            _sorter
                .Setup(x => x.Sort(It.IsAny<IEnumerable<AudioDrama>>()))
                .Returns(_audioDramas);

            _filter
                .Setup(x => x.Filter(It.IsAny<IEnumerable<AudioDrama>>()))
                .Returns(_audioDramas);

            var _ = new AudioDramaListPresenter(
                _listView.Object,
                _view.Object,
                _audioDramas,
                _viewer.Object,
                _audioDramaPresenter.Object,
                _filter.Object,
                _sorter.Object
            );
        }
        

        [TestMethod]
        public void Construct_FillWithAudioDramas()
        {
            _listView.Verify(x => x.SetAudioDramaInfos(_audioDramas), Times.Once);
        }

        [TestMethod]
        public void Construct_FillWithFilterInfos()
        {
            _listView.Verify(x => x.SetFilterInfos(_filter.Object), Times.Once);
        }

        [TestMethod]
        public void Construct_FillWithSortInfos()
        {
            _listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.ReleaseDateDescending), Times.Once);
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
            _sorter.Invocations.Clear();
            _sorter.SetupAllProperties();

            _listView.Raise(x => x.OrderByHeardFirstClicked += null, this, EventArgs.Empty);
            
            _sorter.VerifySet(x=>x.SortMode = EAudioDramaSortMode.HeardFirst);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);

            _listView.Verify(x => x.SetAudioDramaInfos(_audioDramas), Times.Once());
            _listView.Verify(x=>x.SetSelectedSortMode(EAudioDramaSortMode.HeardFirst), Times.Once);
        }

        [TestMethod]
        public void OrderByHeardLastClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorter.Invocations.Clear();
            _sorter.SetupAllProperties();

            _listView.Raise(x => x.OrderByHeardLastClicked += null, this, EventArgs.Empty);

            _sorter.VerifySet(x => x.SortMode = EAudioDramaSortMode.HeardLast);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);

            _listView.Verify(x => x.SetAudioDramaInfos(_audioDramas), Times.Once());
            _listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.HeardLast), Times.Once);
        }

        [TestMethod]
        public void OrderByIsFavoriteFirstClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorter.Invocations.Clear();
            _sorter.SetupAllProperties();

            _listView.Raise(x => x.OrderByIsFavoriteFirstClicked += null, this, EventArgs.Empty);

            _sorter.VerifySet(x => x.SortMode = EAudioDramaSortMode.IsFavoriteFirst);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);

            _listView.Verify(x => x.SetAudioDramaInfos(_audioDramas), Times.Once());
            _listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.IsFavoriteFirst), Times.Once);
        }

        [TestMethod]
        public void OrderIsFavoriteLastClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorter.Invocations.Clear();
            _sorter.SetupAllProperties();

            _listView.Raise(x => x.OrderByIsFavoriteLastClicked += null, this, EventArgs.Empty);

            _sorter.VerifySet(x => x.SortMode = EAudioDramaSortMode.IsFavoriteLast);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);

            _listView.Verify(x => x.SetAudioDramaInfos(_audioDramas), Times.Once());
            _listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.IsFavoriteLast), Times.Once);
        }

        [TestMethod]
        public void OrderByNumberAscendingClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorter.Invocations.Clear();
            _sorter.SetupAllProperties();

            _listView.Raise(x => x.OrderByNumberAscendingClicked += null, this, EventArgs.Empty);

            _sorter.VerifySet(x => x.SortMode = EAudioDramaSortMode.NumberAscending);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);

            _listView.Verify(x => x.SetAudioDramaInfos(_audioDramas), Times.Once());
            _listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.NumberAscending), Times.Once);
        }

        [TestMethod]
        public void OrderByNumberDescendingClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorter.Invocations.Clear();
            _sorter.SetupAllProperties();

            _listView.Raise(x => x.OrderByNumberDescendingClicked += null, this, EventArgs.Empty);

            _sorter.VerifySet(x => x.SortMode = EAudioDramaSortMode.NumberDescending);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);

            _listView.Verify(x => x.SetAudioDramaInfos(_audioDramas), Times.Once());
            _listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.NumberDescending), Times.Once);
        }

        [TestMethod]
        public void OrderByReleaseDateAscendingClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorter.Invocations.Clear();
            _sorter.SetupAllProperties();

            _listView.Raise(x => x.OrderByReleaseDateAscendingClicked += null, this, EventArgs.Empty);

            _sorter.VerifySet(x => x.SortMode = EAudioDramaSortMode.ReleaseDateAscending);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);

            _listView.Verify(x => x.SetAudioDramaInfos(_audioDramas), Times.Once());
            _listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.ReleaseDateAscending), Times.Once);
        }

        [TestMethod]
        public void OrderByReleaseDateDescendingClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorter.Invocations.Clear();
            _sorter.SetupAllProperties();

            _listView.Raise(x => x.OrderByReleaseDateDescendingClicked += null, this, EventArgs.Empty);

            _sorter.VerifySet(x => x.SortMode = EAudioDramaSortMode.ReleaseDateDescending);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);

            _listView.Verify(x => x.SetAudioDramaInfos(_audioDramas), Times.Once());
            _listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.ReleaseDateDescending), Times.Once);
        }

        [TestMethod]
        public void OrderByNameAscendingClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorter.Invocations.Clear();
            _sorter.SetupAllProperties();

            _listView.Raise(x => x.OrderByNameAscendingClicked += null, this, EventArgs.Empty);

            _sorter.VerifySet(x => x.SortMode = EAudioDramaSortMode.NameAscending);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);

            _listView.Verify(x => x.SetAudioDramaInfos(_audioDramas), Times.Once());
            _listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.NameAscending), Times.Once);
        }

        [TestMethod]
        public void OrderByNameDescendingClicked_CallSorter_UpdateView()
        {
            _listView.Invocations.Clear();
            _sorter.Invocations.Clear();
            _sorter.SetupAllProperties();

            _listView.Raise(x => x.OrderByNameDescendingClicked += null, this, EventArgs.Empty);

            _sorter.VerifySet(x => x.SortMode = EAudioDramaSortMode.NameDescending);
            _sorter.Verify(x => x.Sort(_audioDramas), Times.Once);

            _listView.Verify(x => x.SetAudioDramaInfos(_audioDramas), Times.Once());
            _listView.Verify(x => x.SetSelectedSortMode(EAudioDramaSortMode.NameDescending), Times.Once);
        }

        [TestMethod]
        public void FilterMainAudioDramasChanged_ChangeFilter_UpdateView()
        {
            _filter.Invocations.Clear();
            _listView.Invocations.Clear();

            _filter.Setup(x => x.IncludeMainAudioDramas).Returns(false);
            _filter.Setup(x => x.Filter(It.IsAny<IEnumerable<AudioDrama>>())).Returns(_audioDramas);

            _listView.Raise(x => x.FilterMainAudioDramasChanged += null, this, EventArgs.Empty);

            _filter.VerifySet(x => x.IncludeMainAudioDramas = true, Times.Once);

            _listView.Verify(x => x.SetFilterInfos(_filter.Object), Times.Once);
            _listView.Verify(x => x.SetAudioDramaInfos(_audioDramas), Times.Once());
        }
      }
}
