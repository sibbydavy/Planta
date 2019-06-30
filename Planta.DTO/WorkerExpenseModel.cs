using System.Collections.Generic;

namespace Planta.Models
{
    public class WorkerExpenseModel : ModelBase
    {
        public string Description { get; set; }

        public decimal NumOfEmp { get; set; }

        public EmployeeType EmpType { get; set; }

        public decimal Total { get; set; }

        public List<ExpenseModel> Expenses { get; set; }
    }
}