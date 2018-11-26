namespace DdfGuide.Core
{
    public interface ISource<out T>
    {
        T Get();
    }
}