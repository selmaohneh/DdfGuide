namespace DdfGuide.Core
{
    public class DdfGuide
    {
        private readonly IEpisodeListView _episodeListView;

        public DdfGuide(IEpisodeListView episodeListView)
        {
            _episodeListView = episodeListView;
        }

        public void Start()
        {
            _episodeListView.Show();
        }
    }
}
