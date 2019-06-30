using System;

namespace Planta.Models
{
    public class ExpenseModel : ModelBase
    {
        public string Description { get; set; }

        public DateTime ExpenseAsOn { get; set; }

        public DateTime CreatedOn { get; set; }

        public decimal Total { get; set; }

        public UserModel User { get; set; }
    }
}