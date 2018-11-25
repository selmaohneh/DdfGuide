using System;

namespace DdfGuide.Core
{
    public interface ISource<out T>
    {
        event EventHandler Updated;
        T Get();
    }
}