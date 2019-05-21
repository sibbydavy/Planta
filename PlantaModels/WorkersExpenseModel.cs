using System;
using System.Collections.Generic;
using System.Text;

namespace PlantaModels
{
    public class WorkersExpenseModel
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

        private Int32 _numberOfEmp;
        public Int32 NumberOfEmp
        {
            get { return _numberOfEmp; }
            set { _numberOfEmp = value; }
        }

        private Int32 _empType;
        public Int32 EmpType
        {
            get { return _empType; }
            set { _empType = value; }
        }

        private List<ExpenseDetailModel> _expenseDetailModel;
        public List<ExpenseDetailModel> ExpenseDetailModel
        {
            get { return _expenseDetailModel; }
            set { _expenseDetailModel = value; }
        }
    }
}
