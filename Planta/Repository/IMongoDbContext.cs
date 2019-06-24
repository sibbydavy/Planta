using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace Planta.Repository
{
    public interface IMongoDbContext
    {
        IMongoClient Client { get; }

        IMongoDatabase Database { get; }

        IMongoCollection<TDocument> GetCollection<TDocument>(string collectionName);

        void DropCollection<TDocument>(string partitionKey = null);

        ConventionPack ConventionPack { get; }

        void EnsureIndexes();

        void ApplyConventionPacks();

    }
}