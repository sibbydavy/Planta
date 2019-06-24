using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Planta.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected IMongoDbContext MongoDbContext;

        protected IMongoCollection<T> Collection =>
            MongoDbContext.GetCollection<T>("Farms");


        protected RepositoryBase(IMongoDbContext mongoDbContext)
        {
            MongoDbContext = mongoDbContext;
        }

        //public IEnumerable<T> FindAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        //{
        //    throw new NotImplementedException();
        //}

        public T FindById(string id)
        {

            var filter = Builders<T>.Filter.Eq("Id", id);
            return  Collection.Find(filter).FirstOrDefault();
        }
        public void Create(T entity)
        {
            try
            {
                //    var a = MongoDbContext.GetCollection<T>("Farms");
                //    a.InsertOne(entity);
                Collection.InsertOne(entity);
            }
            catch(Exception ex)
            {

            }
           
        }
        
        //public void Update(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Save()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
