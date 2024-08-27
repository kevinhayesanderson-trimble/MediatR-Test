namespace Persistance
{
    public interface IReadStore<T>
    {
        public T? Read();

        public IEnumerable<T> ReadAll();

        public bool Write(T Item);
    }
}