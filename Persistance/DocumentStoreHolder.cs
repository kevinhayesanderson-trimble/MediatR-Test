using Raven.Client.Documents;

namespace Persistance
{
    public class DocumentStoreHolder
    {
        private static Lazy<IDocumentStore> store = new Lazy<IDocumentStore>(CreateStore);

        public static IDocumentStore Store => store.Value;

        internal static T? Read<T>() => ReadAll<T>().FirstOrDefault();

        internal static IEnumerable<T> ReadAll<T>()
        {
            using var session = Store.OpenSession();
            return session.Advanced.LoadStartingWith<T>("Items/");
        }

        internal static bool Write<T>(T? item)
        {
            using var session = Store.OpenSession();
            session.Store(item);
            session.SaveChanges();
            return true;
        }

        private static IDocumentStore CreateStore()
        {
            IDocumentStore store = new DocumentStore()
            {
                Urls = [ "http://raven1:8080"],

                Conventions =
            {
                MaxNumberOfRequestsPerSession = 10,
                UseOptimisticConcurrency = true
            },

                Database = "ItemsReadDb",

            }.Initialize();

            return store;
        }
    }
}
