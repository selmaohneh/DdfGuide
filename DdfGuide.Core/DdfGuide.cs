using System.Collections.Generic;

namespace DdfGuide.Core
{
    public class DdfGuide
    {
        private readonly IProvider<IEnumerable<AudioDramaDto>> _dtoProvider;
        private readonly IProvider<IEnumerable<AudioDramaUserData>> _userDataProvider;

        private readonly IAudioDramaListView _audioDramaListView;

        public DdfGuide(
            IProvider<IEnumerable<AudioDramaDto>> dtoProvider,
            IProvider<IEnumerable<AudioDramaUserData>> userDataProvider,
            IAudioDramaListView audioDramaListView)
        {
            _dtoProvider = dtoProvider;
            _userDataProvider = userDataProvider;
            _audioDramaListView = audioDramaListView;
        }

        public void Start()
        {
            var dtos = _dtoProvider.Get();
            var userData = _userDataProvider.Get();

            var audioDramaBuilder = new AudioDramaBuilder(
                dtos,
                userData);

            var audioDramas = audioDramaBuilder.Build();

            var _ = new AudioDramaListViewPresenter(
                _audioDramaListView,
                audioDramas);

            _audioDramaListView.Show();
        }
    }
}
