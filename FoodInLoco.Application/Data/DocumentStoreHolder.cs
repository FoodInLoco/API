using Raven.Client.Documents;
using Raven.Client.Http;
using System.Security.Cryptography.X509Certificates;

namespace FoodInLoco.Application.Data
{
    // The `DocumentStoreHolder` class holds a single Document Store instance.
    public class DocumentStoreHolder
    {
        // Use Lazy<IDocumentStore> to initialize the document store lazily. 
        // This ensures that it is created only once - when first accessing the public `Store` property.
        private static readonly Lazy<IDocumentStore> store = new(CreateStore);

        public static IDocumentStore Store => store.Value;

        private static IDocumentStore CreateStore()
        {
            X509Certificate2 clientCertificate = new("Certificates/free.pedrotech.client.certificate.with.password.pfx", "1AF642C81EDBFF2AB77F3852A8446B6", X509KeyStorageFlags.MachineKeySet);
            return new DocumentStore()
            {
                // Define the cluster node URLs (required)
                Urls = new[] { "https://a.free.pedrotech.ravendb.cloud", 
                           /*some additional nodes of this cluster*/ },

                Certificate = clientCertificate,
                Conventions =
                {
                    UseOptimisticConcurrency = true,
                    AggressiveCache =
                    {
                        Duration = TimeSpan.FromMinutes(5),
                        Mode = AggressiveCacheMode.TrackChanges
                    }
                },
                Database = "FoodInLoco"

            }.Initialize();
        }
    }
}
