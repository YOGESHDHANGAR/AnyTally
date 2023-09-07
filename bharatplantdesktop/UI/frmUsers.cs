using bharatplantdesktop.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bharatplantdesktop.UI
{
    public partial class frmUsers : Form
    {
        usersDAL usersdal = new usersDAL();
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = usersdal.Select();
            dgvUsers.DataSource = dt;
        }
    }
}
