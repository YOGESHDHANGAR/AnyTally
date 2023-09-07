using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bharatplantdesktop.BLL
{
    internal class receiptsBLL
    {
        public int serial { get; set; }
        public string voucher { get; set; }
        public DateTime date { get; set; }
        public int party_id { get; set; }
        public decimal total_amount { get; set; }
        public string narration { get; set; }
        public int added_by { get; set; }
        public DataTable receipts_details { get; set; }
    }
}
