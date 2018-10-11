using System;

namespace DdfGuide.Core
{
    public interface  IInterpreterSelectionView : IView
    {
        event EventHandler DieDreiFragezeichenClicked;
        event EventHandler DieDreiClicked;
        event EventHandler DieDreiFragezeichenKidsClicked;
    }
}
