using System;

namespace DdfGuide.Core
{
    public interface INotifyChanged
    {
        event EventHandler Changed;
    }
}
