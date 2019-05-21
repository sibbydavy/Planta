using System;
using System.Collections.Generic;
using System.Text;

namespace PlantaModels
{
    public class YieldPeriodDetailModel
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

        private String _periodName;
        public String PeriodName
        {
            get { return _periodName; }
            set { _periodName = value; }
        }

        private String _periodStart;
        public String PeriodStart
        {
            get { return _periodStart; }
            set { _periodStart = value; }
        }

        private String _periodEnd;
        public String PeriodEnd
        {
            get { return _periodEnd; }
            set { _periodEnd = value; }
        }

        private Boolean _isCurrent;
        public Boolean IsCurrent
        {
            get { return _isCurrent; }
            set { _isCurrent = value; }
        }

        private Double _totalAmount;
        public Double TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }

        private List<ProductExpenseModel> _productExpenseModels;
        public List<ProductExpenseModel> ProductExpenseModels
        {
            get { return _productExpenseModels; }
            set { _productExpenseModels = value; }
        }

        private List<WorkersExpenseModel> _workersExpenseModels;
        public List<WorkersExpenseModel> WorkersExpenseModels
        {
            get { return _workersExpenseModels; }
            set { _workersExpenseModels = value; }
        }
    }
}
