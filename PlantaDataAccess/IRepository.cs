using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Planta.DataAccess
{
    public interface IRepository<TDocument> where TDocument : IDocument
    {
        Task<TDocument> GetById(string id);

        Task<TDocument> GetOne(Expression<Func<TDocument, bool>> filter);

        Task AddOne(TDocument document);

        Task<bool> UpdateOne(TDocument modifiedDocument);

        Task<long> DeleteOne(TDocument document);

    }
}
