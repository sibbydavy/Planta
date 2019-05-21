using Planta.DataAccess.Shared;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Planta.DataAccess
{
    public class BaseRepository<TDocument> : IRepository<TDocument> where TDocument : IDocument
    {
        protected IMongoDbContext MongoDbContext;

        protected BaseRepository(IMongoDbContext mongoDbContext)
        {
            MongoDbContext = mongoDbContext;
        }

        public Task AddOne(TDocument document)
        {
            throw new NotImplementedException();
        }

        public Task<long> DeleteOne(TDocument document)
        {
            throw new NotImplementedException();
        }

        public Task<TDocument> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<TDocument> GetOne(Expression<Func<TDocument, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOne(TDocument modifiedDocument)
        {
            throw new NotImplementedException();
        }
    }
}
