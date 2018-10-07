using System.Collections.Generic;

namespace DdfGuide.Core
{
    public class DdfGuide
    {
        private readonly IProvider<IEnumerable<AudioDramaDto>> _dtoProvider;
        private readonly IProvider<IEnumerable<AudioDramaUserData>> _userDataProvider;

        private readonly IAudioDramaListView _audioDramaListView;
        private readonly IAudioDramaView _audioDramaView;

        public DdfGuide(
            IProvider<IEnumerable<AudioDramaDto>> dtoProvider,
            IProvider<IEnumerable<AudioDramaUserData>> userDataProvider,
            IAudioDramaListView audioDramaListView,
            IAudioDramaView audioDramaView)
        {
            _dtoProvider = dtoProvider;
            _userDataProvider = userDataProvider;
            _audioDramaListView = audioDramaListView;
            _audioDramaView = audioDramaView;
        }

        public void Start()
        {
            var dtos = _dtoProvider.Get();
            var userData = _userDataProvider.Get();

            var audioDramaBuilder = new AudioDramaBuilder(
                dtos,
                userData);

            var audioDramas = audioDramaBuilder.Build();

            var viewStack = new Stack<IView>();
            var viewer = new Viewer(viewStack);

            var audioDramaPresenter = new AudioDramaPresenter(_audioDramaView, viewer);

            var filter = new AudioDramaFilter();
            var sorter = new AudioDramaSorter();

            var _ = new AudioDramaListPresenter(
                _audioDramaListView,
                _audioDramaView,
                audioDramas,
                viewer,
                audioDramaPresenter,
                filter,
                sorter
                );

            viewer.Show(_audioDramaListView);
        }
    }
}
