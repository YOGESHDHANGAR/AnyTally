using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bharatplantdesktop.BLL
{
    internal class expensesBLL
    {
        public int serial { get; set; }
        public DateTime date { get; set; }
        public string expense_type { get; set; }
        public decimal amount { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
