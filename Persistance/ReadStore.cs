namespace Persistance
{
    public class ReadStore<T> : IReadStore<T>
    {

        public bool Write(T Item) => DocumentStoreHolder.Write(Item);

        T? IReadStore<T>.Read() => DocumentStoreHolder.Read<T>();

        IEnumerable<T> IReadStore<T>.ReadAll() => DocumentStoreHolder.ReadAll<T>();
    }
}
