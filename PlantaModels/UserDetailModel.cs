using System;
using System.Collections.Generic;
using System.Text;

namespace PlantaModels
{
    public class UserDetailModel
    {
        private Int32 _id;

        public Int32 ID
        {
            get { return _id; }
            set { _id = value; }
        }


        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private String _email;

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private String _phone;

        public String Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private String _userName;

        public String UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private List<UserGroupModel> _userGroupModels;

        public List<UserGroupModel> UserGroupModels
        {
            get { return _userGroupModels; }
            set { _userGroupModels = value; }
        }
    }
}
