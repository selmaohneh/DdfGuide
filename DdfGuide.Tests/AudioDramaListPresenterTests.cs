using DdfGuide.Core;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.AutoMock;

namespace DdfGuide.Tests
{
    [TestClass]
    public class AudioDramaListPresenterTests
    {
        private SampleAudioDramaProvider _sampleAudioDramaProvider;
        private List<AudioDrama> _audioDramas;
        private AutoMocker _mocker;
        private AudioDramaListPresenter _sut;

        [TestInitialize]
        public void Init()
        {
            _mocker = new AutoMocker();

            _sampleAudioDramaProvider = new SampleAudioDramaProvider();
            _audioDramas = _sampleAudioDramaProvider.Get().ToList();

            _mocker.Use<IEnumerable<AudioDrama>>(_audioDramas);

            _mocker
                .Setup<ISource<IEnumerable<AudioDrama>>, IEnumerable<AudioDrama>>(x => x.Get())
                .Returns(_audioDramas);

            _sut = _mocker.CreateInstance<AudioDramaListPresenter>();
            _sut.SetModel(_audioDramas);
        }


        [TestMethod]
        public void SetNewModel_UpdateAudioDramasOnView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            listView.Invocations.Clear();

            _sut.SetModel(_audioDramas);

            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()), Times.Once);
        }

        [TestMethod]
        public void SetNewModel_UpdateSortInformationOnView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            listView.Invocations.Clear();

            _sut.SetModel(_audioDramas);

            listView.Verify(x => x.SetSelectedSortMode(It.IsAny<EAudioDramaSortMode>()), Times.Once);
        }

        [TestMethod]
        public void SetNewModel_UpdateFilterInformationOnView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            listView.Invocations.Clear();

            _sut.SetModel(_audioDramas);

            listView.Verify(x => x.SetFilterInfos(It.IsAny<EAudioDramaFilterMode>()), Times.Once);
        }

        [TestMethod]
        public void OrderByHeardFirstClicked_UpdateExplorer_UpdateAudioDramaOnView_UpdateSortModeOnView()
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
        public void OrderByHeardLastClicked_UpdateExplorer_UpdateAudioDramasOnView_UpdateSortModeOnView()
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
        public void OrderByIsFavoriteFirstClicked_UpdateExplorer_UpdateAudioDramasOnView_UpdateSortModeOnView()
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
        public void OrderIsFavoriteLastClicked_UpdateExplorer_UpdateAudioDramasOnView_UpdateSortModeOnView()
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
        public void OrderByNumberAscendingClicked_UpdateExplorer_UpdateAudioDramasOnView_UpdateSortModeOnView()
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
        public void OrderByNumberDescendingClicked_UpdateExplorer_UpdateAudioDramasOnView_UpdateSortModeOnView()
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
        public void OrderByReleaseDateAscendingClicked_UpdateExplorer_UpdateAudioDramasOnView_UpdateSortModeOnView()
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
        public void OrderByReleaseDateDescendingClicked_UpdateExplorer_UpdateAudioDramasOnView_UpdateSortModeOnView()
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
        public void OrderByNameAscendingClicked_UpdateExplorer_UpdateAudioDramasOnView_UpdateSortModeOnView()
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
        public void OrderByNameDescendingClicked_UpdateExplorer_UpdateAudioDramasOnView_UpdateSortModeOnView()
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
        public void MainAudioDramasOnlyClicked_UpdateExplorer_UpdateAudioDramasOnView_UpdateFilterModeOnView()
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
        public void AllAudioDramasClicked_UpdateExplorer_UpdateAudioDramasOnView_UpdateFilterModeOnView()
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
        public void FavoritesOnlyClicked_UpdateExplorer_UpdateAudioDramasOnView_UpdateFilterModeOnView()
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
        public void UnheardOnlyClicked_UpdateExplorer_UpdateAudioDramasOnView_UpdateFilterModeOnView()
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
        public void SpecialsOnlyClicked_UpdateExplorer_UpdateAudioDramasOnView_UpdateFilterModeOnView()
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
        public void DieDreiFragezeichenClicked_UpdateExplorer_UpdateSelectedInterpreterOnView_UpdateAudioDramasOnView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.DieDreiFragezeichenClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetInterpreterFilter(EAudioDramaFilterMode.DieDreiFragezeichen), Times.Once);
            listView.Verify(x => x.SetSelectedInterpreter(EAudioDramaFilterMode.DieDreiFragezeichen), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void
            DieDreiFragezeichenKidsClicked_UpdateExplorer_UpdateSelectedInterpreterOnView_UpdateAudioDramasOnView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.DieDreiFragezeichenKidsClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetInterpreterFilter(EAudioDramaFilterMode.DieDreiFragezeichenKids), Times.Once);
            listView.Verify(x => x.SetSelectedInterpreter(EAudioDramaFilterMode.DieDreiFragezeichenKids), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void HelpClicked_CallGithubUrl()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var uriInvoker = _mocker.GetMock<IUriInvoker>();

            listView.Raise(x => x.ContributeClicked += null, this, EventArgs.Empty);

            uriInvoker.Verify(x => x.Invoke(new Uri(@"https://github.com/selmaohneh/DdfGuide")), Times.Once);
        }

        [TestMethod]
        public void ExportClicked_StartExportLogic()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var importExport = _mocker.GetMock<IUserDataImportExport>();

            listView.Raise(x => x.ExportClicked += null, this, EventArgs.Empty);

            importExport.Verify(x => x.ExportUserData(), Times.Once);
        }

        [TestMethod]
        public void ImportClicked_StartImportLogic()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var importExport = _mocker.GetMock<IUserDataImportExport>();

            listView.Raise(x => x.ImportClicked += null, this, EventArgs.Empty);

            importExport.Verify(x => x.ImportUserData(), Times.Once);
        }

        [TestMethod]
        public void HeardClicked_ModelGetsUpdated()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();

            var heard = _audioDramas[0].AudioDramaUserData.Heard;

            listView.Raise(x => x.HeardClicked += null, this, _audioDramas[0].AudioDramaDto.Id);
            Assert.AreNotEqual(heard, _audioDramas[0].AudioDramaUserData.Heard);

            listView.Raise(x => x.HeardClicked += null, this, _audioDramas[0].AudioDramaDto.Id);
            Assert.AreEqual(heard, _audioDramas[0].AudioDramaUserData.Heard);
        }

        [TestMethod]
        public void HeardClicked_ViewGetsUpdated()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();

            listView.Invocations.Clear();

            listView.Raise(x => x.HeardClicked += null, this, _audioDramas[0].AudioDramaDto.Id);

            listView.Verify(
                x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()), Times.Once());
        }

        [TestMethod]
        public void IsFavoriteClicked_ModelGetsUpdated()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();

            var favorite = _audioDramas[0].AudioDramaUserData.IsFavorite;

            listView.Raise(x => x.IsFavoriteClicked += null, this, _audioDramas[0].AudioDramaDto.Id);
            Assert.AreNotEqual(favorite, _audioDramas[0].AudioDramaUserData.IsFavorite);

            listView.Raise(x => x.IsFavoriteClicked += null, this, _audioDramas[0].AudioDramaDto.Id);
            Assert.AreEqual(favorite, _audioDramas[0].AudioDramaUserData.IsFavorite);
        }

        [TestMethod]
        public void IsFavoriteClicked_ViewGetsUpdated()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();

            listView.Invocations.Clear();

            listView.Raise(x => x.IsFavoriteClicked += null, this, _audioDramas[0].AudioDramaDto.Id);

            listView.Verify(
                x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()), Times.Once());
        }

        [TestMethod]
        public void DieDreiClicked_UpdateExplorer_UpdateSelectedInterpreterOnView_UpdateAudioDramasOnView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            var explorer = _mocker.GetMock<IAudioDramaExplorer>();

            listView.Invocations.Clear();
            explorer.Invocations.Clear();

            listView.Raise(x => x.DieDreiClicked += null, this, EventArgs.Empty);

            explorer.Verify(x => x.SetInterpreterFilter(EAudioDramaFilterMode.DieDrei), Times.Once);
            listView.Verify(x => x.SetSelectedInterpreter(EAudioDramaFilterMode.DieDrei), Times.Once);
            listView.Verify(x => x.SetAudioDramaInfos(It.IsAny<IEnumerable<AudioDrama>>()));
        }

        [TestMethod]
        public void SearchRequested_GetCurrentSearchText_UpdateExplorer_UpdateAudioDramasOnView()
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

        /// <summary>
        /// When going back from the single audio drama view the selected tab, filters, and sort modes were wrong.
        /// This is because the layout gets inflated again. So we have to make sure to
        /// update it every time the view gets shown.
        /// </summary>
        [TestMethod]
        public void OnGetView_Update_SelectedTab_SelectedFilter_SelectedSortMode()
        {
            var view = _mocker.GetMock<IAudioDramaView>();
            view.Raise(x => x.BackClicked += null, this, EventArgs.Empty);

            _mocker.Verify<IAudioDramaListView>(x => x.SetSelectedInterpreter(It.IsAny<EAudioDramaFilterMode>()),
                Times.Once);

            _mocker.Verify<IAudioDramaListView>(x => x.SetFilterInfos(It.IsAny<EAudioDramaFilterMode>()),
                Times.Once);

            _mocker.Verify<IAudioDramaListView>(x => x.SetSelectedSortMode(It.IsAny<EAudioDramaSortMode>()),
                Times.Once);
        }
    }
}