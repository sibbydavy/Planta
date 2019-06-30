using LiteDBFactory;
using Planta.DTOObjects.DTOObjectAction;
using Planta.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Planta.DBActions
{
    //public interface IDbAda : IDbAdaptor// IDbAction
    //{
    //    // T Insert<T>(T record);
    //}
    public class DbAdaptorManager : IDbAdaptor
    {

        readonly IDbAction _dbAction;
        readonly IDbAdaptor _iDbAdaptor;
        public DbAdaptorManager(string dbPath)
        {
            _iDbAdaptor = new DatabaseFactory(dbPath);
        }

     
        public T Get<T>(int recordId, string fileName)
        {
            var record = _iDbAdaptor.Get<T>(recordId, fileName);
            return (T)(object)record;
            //UserGroupModelAction userGroupModelAction = new UserGroupModelAction(_iDbAdaptor);
            //var record = userGroupModelAction.Get<T>(recordId, "UserGroup");
            //return (T)(object)record;
        }


        //public  ModelBase Insert<T>(T record)
        //{
        //    UserGroupModelAction userGroupModelAction = new UserGroupModelAction(_iDbAdaptor);
        //    userGroupModelAction.Insert<T>(record, "UserGroup");
        //    return (ModelBase)(object)record;
        //}

        //public T Insert<T>(T record)
        //{
        //    UserGroupModelAction userGroupModelAction = new UserGroupModelAction(_iDbAdaptor);
        //    userGroupModelAction.Insert<T>(record, "UserGroup");
        //    return (T)(object)record;
        //}

        public T Insert<T>(T record, string fileName)
        {           
            record = _iDbAdaptor.Insert<T>(record, fileName);
            //UserGroupModelAction userGroupModelAction = new UserGroupModelAction(_iDbAdaptor);
            //userGroupModelAction.Insert<T>(record, "UserGroup");
            return (T)(object)record;
        }
    }
}
