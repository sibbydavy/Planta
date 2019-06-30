using LiteDB;
using Planta.DBActions;
using System;

namespace LiteDBFactory
{
    public  class DatabaseFactory : IDbAdaptor 
    {
        public readonly string _dbConnectionString;

        public DatabaseFactory(string dbPath)
        {
            string currentExePath = dbPath;
            _dbConnectionString = currentExePath + @"\Planta.db";
        }



        public  T Insert<T>(T record, string fileName)
        {
          //  Int32 newDocumentId = 0;
            try
            {
                using (var db = new LiteDatabase(_dbConnectionString))
                {

                    var file = db.GetCollection<T>(fileName);
                    var newDocumentId = file.Insert(record);

                    var file1 = db.GetCollection<T>(fileName);
                    record = file1.FindById(newDocumentId);
                }
            }
            catch (Exception ex)
            {

                throw;
            }          
          
            return record;
        }

        public T Get<T>(Int32 recordId, string fileName)
        {
            T record = default(T);
            using (var db = new LiteDatabase(_dbConnectionString))
            {
                // Get a collection (or create, if doesn't exist)
                if (db.CollectionExists(fileName))
                {
                    var file = db.GetCollection<T>(fileName);
                    record = file.FindById(recordId);

                }
            }
            return record;
        }
    }
}
