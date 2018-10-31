using System;
using System.Collections.Generic;
using DdfGuide.Core.Filtering;
using DdfGuide.Core.Sorting;

namespace DdfGuide.Core
{
    public interface IAudioDramaListView : IView
    {
        void SetAudioDramaInfos(IEnumerable<AudioDrama> audioDramas);
        void SetFilterInfos(EAudioDramaFilterMode selectedFilterMode);
        void SetSelectedSortMode(EAudioDramaSortMode selectedSortMode);

        event EventHandler<Guid> HeardChanged;
        event EventHandler<Guid> IsFavoriteChanged;
        event EventHandler<Guid> AudioDramaClicked;
        event EventHandler OrderByHeardFirstClicked;
        event EventHandler OrderByHeardLastClicked;
        event EventHandler OrderByIsFavoriteFirstClicked;
        event EventHandler OrderByIsFavoriteLastClicked;
        event EventHandler OrderByNumberAscendingClicked;
        event EventHandler OrderByNumberDescendingClicked;
        event EventHandler OrderByReleaseDateAscendingClicked;
        event EventHandler OrderByReleaseDateDescendingClicked;
        event EventHandler OrderByNameAscendingClicked;
        event EventHandler OrderByNameDescendingClicked;

        event EventHandler AllClicked;
        event EventHandler MainsOnlyClicked;
        event EventHandler SpecialsOnlyClicked;
        event EventHandler FavoritesOnlyClicked;
        event EventHandler UnheardOnlyClicked;

        event EventHandler DieDreiFragezeichenClicked;
        event EventHandler DieDreiFragezeichenKidsClicked;
        event EventHandler DieDreiClicked;

        string GetCurrentSearchText();
        event EventHandler SearchTextChanged;

        event EventHandler RandomClicked;
    }
}
