using System;
using System.Collections.Generic;

namespace Planta.Models
{
    public class ProductExpenseModel : ModelBase
    {
        public string Description { get; set; }

        public decimal Quantity { get; set; }

        public decimal UOM { get; set; }

        public decimal Price { get; set; }

        public decimal Tax { get; set; }

        public  decimal Total { get; set; }

        public List<ExpenseModel> Expenses { get; set; }
     
    }
}