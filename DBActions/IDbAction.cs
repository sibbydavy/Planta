using System;
using System.Collections.Generic;
using System.Text;

namespace Planta.DBActions
{
    public interface IDbAction
    {
        T Insert<T>(T record, string fileName);
        T Get<T>(Int32 recordId, string fileName);
    }
}
