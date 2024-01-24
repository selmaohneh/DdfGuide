using DdfGuide.Android;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.AutoMock;
using Newtonsoft.Json;

namespace DdfGuide.Tests
{
    [TestClass]
    public class UserDataImportExportTests
    {
        private AutoMocker _mocker;

        [TestInitialize]
        public void Init()
        {
            _mocker = new AutoMocker();
        }

        [TestMethod]
        public void VerifyJsonGetsSavedInClipboard()
        {
            var mocker = new AutoMocker();

            var userData = new List<AudioDramaUserData>
            {
                new AudioDramaUserData(Guid.Empty, true, false),
                new AudioDramaUserData(Guid.Empty, false, true),
            };

            mocker
                .GetMock<ICache<IEnumerable<AudioDramaUserData>>>()
                .Setup(x => x.Load())
                .Returns(userData);

            var sut = mocker.CreateInstance<UserDataImportExport>();

            sut.ExportUserData();

            mocker.Verify<ICache<IEnumerable<AudioDramaUserData>>>(x => x.Load(), Times.Once);
            mocker.Verify<IYesNoDialog>(x => x.Show(It.IsAny<string>(),
                It.Is<string>(y => y.Contains(": 2") && y.Contains(": 1"))));

            mocker.GetMock<IYesNoDialog>().Raise(x => x.YesClicked += null, this, EventArgs.Empty);

            var json = JsonConvert.SerializeObject(userData);
            mocker.Verify<IClipboardService>(x => x.SetClipboardText(json), Times.Once);
        }

        [TestMethod]
        public void VerifyJsonGetsNotSavedInClipboardWhenUserSaysNo()
        {
            var mocker = new AutoMocker();

            var userData = new List<AudioDramaUserData>
            {
                new AudioDramaUserData(Guid.Empty, true, false),
                new AudioDramaUserData(Guid.Empty, false, true),
            };

            mocker
                .GetMock<ICache<IEnumerable<AudioDramaUserData>>>()
                .Setup(x => x.Load())
                .Returns(userData);

            var sut = mocker.CreateInstance<UserDataImportExport>();

            sut.ExportUserData();

            mocker.GetMock<IYesNoDialog>().Raise(x => x.NoClicked += null, this, EventArgs.Empty);

            var json = JsonConvert.SerializeObject(userData);
            mocker.Verify<IClipboardService>(x => x.SetClipboardText(json), Times.Never);
        }

        [TestMethod]
        public void VerifyNotifyingUserWhenCopiedToClipboard()
        {
            var mocker = new AutoMocker();

            var userData = new List<AudioDramaUserData>
            {
                new AudioDramaUserData(Guid.Empty, true, false),
                new AudioDramaUserData(Guid.Empty, false, true),
            };

            mocker
                .GetMock<ICache<IEnumerable<AudioDramaUserData>>>()
                .Setup(x => x.Load())
                .Returns(userData);

            var sut = mocker.CreateInstance<UserDataImportExport>();

            sut.ExportUserData();

            mocker.GetMock<IYesNoDialog>().Raise(x => x.YesClicked += null, this, EventArgs.Empty);

            mocker.Verify<IUserNotifier>(x => x.Notify(It.IsAny<string>()), Times.Once);
        }

        [TestMethod]
        public void VerifyCacheGetsSaved()
        {
            var sut = CreateSutForImportTests();

            sut.ImportUserData();

            _mocker
                .GetMock<IYesNoDialog>()
                .Raise(x => x.YesClicked += null, this, EventArgs.Empty);

            _mocker
                .Verify<ICache<IEnumerable<AudioDramaUserData>>>(x =>
                    x.Save(It.Is<IEnumerable<AudioDramaUserData>>(y =>
                        y.All(z => z.Heard && z.IsFavorite) && y.Count() == 3)));
        }

        [TestMethod]
        public void VerifyCacheNotSavedWhenDeclined()
        {
            var sut = CreateSutForImportTests();

            sut.ImportUserData();

            _mocker
                .GetMock<IYesNoDialog>()
                .Raise(x => x.NoClicked += null, this, EventArgs.Empty);

            _mocker
                .Verify<ICache<IEnumerable<AudioDramaUserData>>>(x =>
                    x.Save(It.IsAny<IEnumerable<AudioDramaUserData>>()), Times.Never());
        }

        [TestMethod]
        public void VerifyImportEventNotRaisedWhenDeclined()
        {
            var sut = CreateSutForImportTests();

            var raised = false;
            sut.UserDataImported += (sender, args) => raised = true;

            sut.ImportUserData();

            _mocker
                .GetMock<IYesNoDialog>()
                .Raise(x => x.NoClicked += null, this, EventArgs.Empty);

            Assert.IsFalse(raised);
        }

        [TestMethod]
        public void VerifyImportEventGetsRaised()
        {
            var sut = CreateSutForImportTests();

            var raised = false;
            sut.UserDataImported += (sender, args) => raised = true;

            sut.ImportUserData();

            _mocker
                .GetMock<IYesNoDialog>()
                .Raise(x => x.YesClicked += null, this, EventArgs.Empty);

            Assert.IsTrue(raised);
        }

        [TestMethod]
        public void VerifyNotifyingUserOnSuccessfullImport()
        {
            var sut = CreateSutForImportTests();

            sut.ImportUserData();

            _mocker
                .GetMock<IYesNoDialog>()
                .Raise(x => x.YesClicked += null, this, EventArgs.Empty);

            _mocker.Verify<IUserNotifier>(x => x.Notify(It.IsAny<string>()));
        }

        [TestMethod]
        public void VerifyCacheNotSavedAndUserNotifiedWhenClipboardEmpty()
        {
            _mocker
                .GetMock<IClipboardService>()
                .Setup(x => x.GetTextFromClipboard())
                .Returns(string.Empty);

            var sut = _mocker.CreateInstance<UserDataImportExport>();

            sut.ImportUserData();

            _mocker
                .Verify<ICache<IEnumerable<AudioDramaUserData>>>(x =>
                    x.Save(It.IsAny<IEnumerable<AudioDramaUserData>>()), Times.Never());

            _mocker.Verify<IOkDialog>(x => x.Show(It.Is<string>(y => y.Contains("leer")), It.IsAny<string>()));
        }

        [TestMethod]
        public void VerifyCacheNotSavedAndUserNotifiedWhenClipboardContainsNull()
        {
            _mocker
                .GetMock<IClipboardService>()
                .Setup(x => x.GetTextFromClipboard())
                .Returns<string>(null);

            var sut = _mocker.CreateInstance<UserDataImportExport>();

            sut.ImportUserData();

            _mocker
                .Verify<ICache<IEnumerable<AudioDramaUserData>>>(x =>
                    x.Save(It.IsAny<IEnumerable<AudioDramaUserData>>()), Times.Never());

            _mocker.Verify<IOkDialog>(x => x.Show(It.Is<string>(y => y.Contains("leer")), It.IsAny<string>()));
        }

        [TestMethod]
        public void VerifyCacheNotSavedAndUserNotifiedWhenClipboardContainsNoJson()
        {
            _mocker
                .GetMock<IClipboardService>()
                .Setup(x => x.GetTextFromClipboard())
                .Returns("Homer Simpson");

            var sut = _mocker.CreateInstance<UserDataImportExport>();

            sut.ImportUserData();

            _mocker
                .Verify<ICache<IEnumerable<AudioDramaUserData>>>(x =>
                    x.Save(It.IsAny<IEnumerable<AudioDramaUserData>>()), Times.Never());

            _mocker.Verify<IOkDialog>(x => x.Show(It.Is<string>(y => y.Contains("fehlerhaft")), It.IsAny<string>()));
        }

        [TestMethod]
        public void VerifyCacheNotSavedWhenClipboardContainsDuplicates()
        {
            var sut = CreateSutForDuplicateImportTests();

            sut.ImportUserData();

            _mocker
                .Verify<ICache<IEnumerable<AudioDramaUserData>>>(x =>
                    x.Save(It.IsAny<IEnumerable<AudioDramaUserData>>()), Times.Never());
        }

        [TestMethod]
        public void VerifyNotifyingUserWhenClipboardContainsDuplicates()
        {
            var sut = CreateSutForDuplicateImportTests();

            sut.ImportUserData();

            _mocker.Verify<IOkDialog>(x => x.Show(It.Is<string>(y => y.Contains("fehlerhaft")),
                It.Is<string>(y => y.Contains("Duplikate"))));
        }

        private UserDataImportExport CreateSutForImportTests()
        {
            var currentUserData = new List<AudioDramaUserData>
            {
                new AudioDramaUserData(Guid.NewGuid(), false, false),
                new AudioDramaUserData(Guid.NewGuid(), false, false),
                new AudioDramaUserData(Guid.NewGuid(), true, true),
            };

            var newUserData = new List<AudioDramaUserData>
            {
                new AudioDramaUserData(currentUserData[0].Id, true, true),
                new AudioDramaUserData(currentUserData[1].Id, true, true),
            };

            _mocker
                .GetMock<ICache<IEnumerable<AudioDramaUserData>>>()
                .Setup(x => x.Load())
                .Returns(currentUserData);

            _mocker
                .GetMock<IClipboardService>()
                .Setup(x => x.GetTextFromClipboard())
                .Returns(JsonConvert.SerializeObject(newUserData));

            return _mocker.CreateInstance<UserDataImportExport>();
        }

        private UserDataImportExport CreateSutForDuplicateImportTests()
        {
            var currentUserData = new List<AudioDramaUserData>
            {
                new AudioDramaUserData(Guid.NewGuid(), false, false),
                new AudioDramaUserData(Guid.NewGuid(), false, false),
                new AudioDramaUserData(Guid.NewGuid(), true, true),
            };

            var newUserData = new List<AudioDramaUserData>
            {
                new AudioDramaUserData(currentUserData[0].Id, true, true),
                new AudioDramaUserData(currentUserData[1].Id, true, true),
                new AudioDramaUserData(currentUserData[1].Id, true, true),
            };

            _mocker
                .GetMock<ICache<IEnumerable<AudioDramaUserData>>>()
                .Setup(x => x.Load())
                .Returns(currentUserData);

            _mocker
                .GetMock<IClipboardService>()
                .Setup(x => x.GetTextFromClipboard())
                .Returns(JsonConvert.SerializeObject(newUserData));

            return _mocker.CreateInstance<UserDataImportExport>();
        }
    }
}