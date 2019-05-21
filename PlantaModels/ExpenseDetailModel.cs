using System;
using System.Collections.Generic;
using System.Text;

namespace PlantaModels
{
    public class ExpenseDetailModel
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

        private DateTime _dateOfEntry;
        public DateTime DateOfEntry
        {
            get { return _dateOfEntry; }
            set { _dateOfEntry = value; }
        }

        private DateTime _dateOfExp;
        public DateTime DateOfExp
        {
            get { return _dateOfExp; }
            set { _dateOfExp = value; }
        }

        private Double _amount;
        public Double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        private UserDetailModel _userDetailModel;
        public UserDetailModel UserDetailModel
        {
            get { return _userDetailModel; }
            set { _userDetailModel = value; }
        }
    }
}
