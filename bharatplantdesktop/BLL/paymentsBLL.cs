using System;
using System.Data;

namespace bharatplantdesktop.BLL
{
    internal class paymentsBLL
    {
        public int serial { get; set; }
        public string voucher { get; set; }
        public DateTime date { get; set; }
        public int party_id { get; set; }
        public decimal total_amount { get; set; }
        public string narration { get; set; }
        public int added_by { get; set; }
        public DataTable payments_details { get; set; }

    }

}
