using System;

namespace DdfGuide.Core
{
    public interface ISource<T>
    {
        event EventHandler<T> Updated;
        T Get();
    }
}