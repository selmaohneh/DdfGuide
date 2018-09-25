namespace DdfGuide.Core
{
    public interface IProvider<out T>
    {
        T Get();
    }
}
