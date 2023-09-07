using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bharatplantdesktop.BLL
{
    internal class purchasesDetailsBLL
    {
        public int id { get; set; }
        public int item_id { get; set; }
        public decimal quantity { get; set; }
        public decimal rate { get; set; }
        public decimal amount { get; set; }
        public int serial { get; set; }
        public int party_id { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }

}
