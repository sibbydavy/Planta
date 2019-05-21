using System;
using System.Collections.Generic;
using System.Text;

namespace PlantaModels
{
    public class ProductExpenseModel
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

        private Double _qty;
        public Double Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }

        private string _uom;
        public string Uom
        {
            get { return _uom; }
            set { _uom = value; }
        }

        private Double _price;
        public Double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private Double _tax;
        public Double Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }

        private Double _total;
        public Double Total
        {
            get { return _total; }
            set { _total = value; }
        }

        private List<ExpenseDetailModel> _expenseDetailModel;
        public List<ExpenseDetailModel> ExpenseDetailModel
        {
            get { return _expenseDetailModel; }
            set { _expenseDetailModel = value; }
        }
    }
}
