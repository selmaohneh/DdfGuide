using System;
using Com.Wdullaer.Swipeactionadapter;

namespace DdfGuide.Android
{
    public class SwipeActionListener : Java.Lang.Object, SwipeActionAdapter.ISwipeActionListener
    {
        public event EventHandler<int> LeftSwiped;
        public event EventHandler<int> RightSwiped;

        public bool HasActions(int position, SwipeDirection direction)
        {
            return true;
        }

        public void OnSwipe(int[] positions, SwipeDirection[] directions)
        {
            for (var index = 0; index < directions.Length; index++)
            {
                var swipeDirection = directions[index];
                var position = positions[index];

                if (swipeDirection == SwipeDirection.DirectionFarLeft ||
                    swipeDirection == SwipeDirection.DirectionNormalLeft)
                {
                    LeftSwiped?.Invoke(this, position);
                }
                else if (swipeDirection == SwipeDirection.DirectionFarRight ||
                         swipeDirection == SwipeDirection.DirectionNormalRight)
                {
                    RightSwiped?.Invoke(this, position);
                }
            }
        }

        public bool ShouldDismiss(int position, SwipeDirection direction)
        {
            return false;
        }
    }
}