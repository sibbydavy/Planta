using Planta.DBActions;
using Planta.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Planta.DTOObjects.DTOObjectAction
{
   
    public class UserGroupModelAction : IDbAction// IDbAdaptor
    {
         IDbAdaptor _iAction;
      //  IDbAction _iAction;
        public UserGroupModelAction(IDbAdaptor iAction)
        {
            _iAction = iAction;
        }

        public UserGroupModel Get<UserGroupModel>(int recordId, string fileName)
        {
            return _iAction.Get<UserGroupModel>(recordId, "UserGroup");
        }

        public UserGroupModel Insert<UserGroupModel>(UserGroupModel record, string fileName)
        {
            return _iAction.Insert<UserGroupModel>(record, "UserGroup");
            //return _iAction.Insert<UserGroupModel>(record, "UserGroup");

        }
    }
}
