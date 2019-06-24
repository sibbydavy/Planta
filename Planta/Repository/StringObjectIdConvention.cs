using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planta.Repository
{
    public class StringObjectIdConvention : ConventionBase, IPostProcessingConvention
    {
        public void PostProcess(BsonClassMap classMap)
        {
            var idMap = classMap.IdMemberMap;
            if (idMap != null && idMap.MemberType == typeof(string))
            {
                idMap.SetIdGenerator(StringObjectIdGenerator.Instance);
                idMap.SetSerializer(new StringSerializer(BsonType.ObjectId));
            }
        }
    }
}
