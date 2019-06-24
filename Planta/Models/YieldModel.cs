using System;
using System.Collections.Generic;

namespace Planta.Models
{
    public class YieldModel : ModelBase
    {
        public string Name { get; set; }

        public DateTime YieldStart { get; set; }

        public DateTime YieldEnd { get; set; }

        public bool IsCurrent { get; set; }

        public decimal TotalExpense { get; set; }

        public decimal TotalIncome { get; set; }

        public  List<ProductExpenseModel> ProductExpenses { get; set; }

        public List<WorkerExpenseModel> WorkerExpenses { get; set; }

    }
}