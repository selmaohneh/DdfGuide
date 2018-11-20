namespace DdfGuide.Core
{
    public interface ICache<T>
    {
        T Load();
        void Save(T items);
    }
}
