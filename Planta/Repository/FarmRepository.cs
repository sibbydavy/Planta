using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Planta.Models;

namespace Planta.Repository
{
    public class FarmRepository : RepositoryBase<FarmModel>, IFarmRepository
    {
        public FarmRepository(IMongoDbContext mongoDbContext) : base(mongoDbContext)
        {
        }

        //public void Create(FarmModel entity)
        //{
        //    base.Create(entity);
        //}

        //public void Delete(FarmModel entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<FarmModel> FindAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<FarmModel> FindByCondition(Expression<Func<FarmModel, bool>> expression)
        //{
        //    throw new NotImplementedException();
        //}

        //public FarmModel FindById(string id)
        //{
        //    return base.FindById(id);
        //}

        //public void Save()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(FarmModel entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
