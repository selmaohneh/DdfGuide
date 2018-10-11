using System.Collections.Generic;
using DdfGuide.Core.Filtering;

namespace DdfGuide.Core
{
    public class InterpreterSelectionPresenter
    {
        public InterpreterSelectionPresenter(
            IInterpreterSelectionView view, 
            IViewer viewer,
            IAudioDramaListView audioDramaListView,
            IAudioDramaListPresenter audioDramaListPresenter,
            IEnumerable<AudioDrama> audioDramas,
            IAudioDramaFilterFactory filterFactory)
        {
            view.DieDreiFragezeichenClicked += (sender, args) =>
            {
                var filter = filterFactory.Create(EAudioDramaFilterMode.DieDreiFragezeichen);
                var filtered = filter.Filter(audioDramas);

                audioDramaListPresenter.SetAudioDramas(filtered);
                viewer.Show(audioDramaListView);
            };
        }
    }
}
