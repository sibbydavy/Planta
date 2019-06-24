using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planta.Repository
{
    public class LowerCaseConvention : IMemberMapConvention
    {
        public string Name { get; }
        public void Apply(BsonMemberMap memberMap)
        {
            memberMap.SetElementName(memberMap.MemberName.ToLower());
        }
    }
}
