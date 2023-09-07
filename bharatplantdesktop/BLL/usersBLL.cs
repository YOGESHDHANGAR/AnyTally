using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bharatplantdesktop.BLL
{
    internal class usersBLL
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string confirm_password { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
