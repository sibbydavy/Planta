using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using MongoDB.Driver.Core.Events;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planta.Repository
{
    public class MongoDbContext : IMongoDbContext
    {
        private readonly DatabaseConfiguration _databaseConfiguration;
        public static readonly string[] NotTrackedCommands = { "ismaster", "buildinfo", "getlasterror", "saslstart", "saslcontinue" };
        public ConventionPack ConventionPack { get; private set; }

        public MongoDbContext(IOptions<DatabaseConfiguration> mongoConfig)// (ILogger<MongoDbContext> logger, IOptions<DatabaseConfiguration> mongoConfig)
        {
            _databaseConfiguration = mongoConfig.Value;
           
            Client = CreateClient(_databaseConfiguration);
        }

        public IMongoClient Client { get; }

        public IMongoDatabase Database => Client.GetDatabase(_databaseConfiguration.DatabaseName);

       // public ConventionPack ConventionPack => throw new NotImplementedException();

        public IMongoCollection<TDocument> GetCollection<TDocument>(string collectionName)
        {
            return Database.GetCollection<TDocument>(collectionName);
        }

        //public void DropCollection<TDocument>(string partitionKey = null)
        //{
        //    throw new NotImplementedException();
        //}

        private static MongoClient CreateClient(DatabaseConfiguration mongoConfig) //(ILogger<MongoDbContext> logger, DatabaseConfiguration mongoConfig)
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl(mongoConfig.ConnectionString));
            settings.SslSettings = new SslSettings() { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
            if (mongoConfig.EnableMongoQueryLogging)
            {
                settings.ClusterConfigurator = clusterConfigurator =>
                {
                    clusterConfigurator.Subscribe<CommandStartedEvent>(e =>
                    {
                        if (e.Command != null && NotTrackedCommands.All(c => c != e.CommandName.ToLower()))
                        {
                           // logger.LogTrace("{RequestId} : Mongo executed the {Command", e.Command.ToString(), e.RequestId);
                        }
                    });
                };
            }
            return new MongoClient(settings);
        }
 

        public void DropCollection<TDocument>(string partitionKey = null)
        {
            throw new NotImplementedException();
        }

        public void EnsureIndexes()
        {
            throw new NotImplementedException();
        }


        public void ApplyConventionPacks()
        {
            ConventionPack = new ConventionPack
            {
                new LowerCaseConvention(),
                new IgnoreExtraElementsConvention(true),
                new IgnoreIfNullConvention(true),
                new StringObjectIdConvention()
            };
            ConventionRegistry.Register("BilagosConventions", ConventionPack, t => true);
        }
    }
}
