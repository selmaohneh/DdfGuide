using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using DdfGuide.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.AutoMock;

namespace DdfGuide.Test
{
    [TestClass]
    public class NavigatorTests
    {
        private Navigator _navigator;
        private AutoMocker _mocker;
        private List<AudioDrama> _audioDramas;

        [TestInitialize]
        public void Init()
        {
            _mocker = new AutoMocker();

            _audioDramas = new SampleAudioDramaProvider().Get().ToList();

            _mocker
                .Setup<IPresenter<IAudioDramaView, AudioDrama>, IAudioDramaView>(x => x.GetView())
                .Returns(_mocker.Get<IAudioDramaView>());

            _mocker.Setup<IPresenter<IAudioDramaListView, IEnumerable<AudioDrama>>, IAudioDramaListView>(x =>
                    x.GetView())
                .Returns(_mocker.Get<IAudioDramaListView>());

            _mocker.Use(typeof(IEnumerable<AudioDrama>), _audioDramas);

            _mocker
                .Setup<ISource<IEnumerable<AudioDrama>>, IEnumerable<AudioDrama>>(x => x.Get())
                .Returns(_audioDramas);

            _navigator = _mocker.CreateInstance<Navigator>();
        }

        [TestMethod]
        public void WhenViewDestroyed_ReShowCurrentView()
        {
            var rootView = _mocker.GetMock<IRootView>();
            rootView.Raise(x => x.ViewDestroyed += null, this, EventArgs.Empty);

            rootView.Verify(x => x.Show(It.IsAny<IView>()), Times.Once);
        }

        [TestMethod]
        public void AudioDramaClicked_OpenAudioDramaView()
        {
            _mocker
                .GetMock<IAudioDramaListView>()
                .Raise(x => x.AudioDramaClicked += null, this, _audioDramas.First().AudioDramaDto.Id);

            _mocker.Verify<IRootView>(x => x.Show(It.IsAny<IAudioDramaView>()), Times.Once);
        }

        [TestMethod]
        public void AudioDramaView_BackClickedOnRootView_GoBackToListView()
        {
            _mocker
                .GetMock<IAudioDramaListView>()
                .Raise(x => x.AudioDramaClicked += null, this, _audioDramas.First().AudioDramaDto.Id);

            var rootView = _mocker.GetMock<IRootView>();
            rootView.Invocations.Clear();
                
            rootView.Raise(x => x.BackClicked += null, this, EventArgs.Empty);

            rootView.Verify(x => x.Show(It.IsAny<IAudioDramaListView>()), Times.Once);
        }

        [TestMethod]
        public void RandomAudioDramaRequested_PickRandomFromExplorer_ShowAudioDramaView_SetRandomToView()
        {
            var listView = _mocker.GetMock<IAudioDramaListView>();
            listView.Raise(x => x.RandomClicked += null, this, EventArgs.Empty);

            _mocker.Verify<IAudioDramaExplorer>(x => x.GetMatchingAudioDramas(It.IsAny<IEnumerable<AudioDrama>>()),
                Times.Once);

            _mocker.Verify<IRandomAudioDramaPicker>(x => x.Pick(It.IsAny<IEnumerable<AudioDrama>>()),
                Times.Once);

            _mocker.Verify<IPresenter<IAudioDramaView, AudioDrama>>(x => x.SetModel(It.IsAny<AudioDrama>()),
                Times.Once);

            _mocker.Verify<IRootView>(x => x.Show(It.IsAny<IAudioDramaView>()), Times.Once);
        }

        [TestMethod]
        public void Navigation_MakeSureViewGetsShownBeforeSettingModel()
        {
            var order = 1;
            _mocker
                .GetMock<IRootView>().Setup(x => x.Show(It.IsAny<IAudioDramaView>())).Callback(() =>
                {
                if (order++ != 1)
                {
                    Assert.Fail("View needs to be shown first.");
                }
            });

            _mocker
                .GetMock<IPresenter<IAudioDramaView, AudioDrama>>()
                .Setup(x => x.SetModel(It.IsAny<AudioDrama>())).Callback(() =>
            {
                if (order++ != 2)
                {
                    Assert.Fail("Audio drama can only be set AFTER the view is shown.");
                }
            });

            _mocker.GetMock<IAudioDramaListView>().Raise(x => x.AudioDramaClicked += null, this,
                _audioDramas.First().AudioDramaDto.Id);

            order = 1;
            _mocker.GetMock<IAudioDramaListView>().Raise(x => x.RandomClicked += null, this,
                EventArgs.Empty);
        }

        [TestMethod]
        public void StartView_MakeSureViewGetsShownBeforeSettingModel()
        {
            var order = 1;
            _mocker
                .GetMock<IRootView>().Setup(x => x.Show(It.IsAny<IAudioDramaListView>())).Callback(() =>
                {
                    if (order++ != 1)
                    {
                        Assert.Fail("View needs to be shown first.");
                    }
                });

            _mocker
                .GetMock<IPresenter<IAudioDramaListView, IEnumerable<AudioDrama>>>()
                .Setup(x => x.SetModel(It.IsAny<IEnumerable<AudioDrama>>())).Callback(() =>
                {
                    if (order++ != 2)
                    {
                        Assert.Fail("Audio dramas can only be set AFTER the view is shown.");
                    }
                });

            _navigator.ShowStartView();
        }
    }
}
