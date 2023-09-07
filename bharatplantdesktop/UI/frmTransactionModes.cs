using bharatplantdesktop.BLL;
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
    public partial class frmTransactionModes : Form
    {
        public frmTransactionModes()
        {
            InitializeComponent();
        }
        transactionModesBLL payment_modesbll = new transactionModesBLL();
        transactionModesDAL payment_modesdal = new transactionModesDAL();
        usersDAL usersdal = new usersDAL();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            payment_modesbll.name = txtPaymentMode.Text;
            payment_modesbll.added_date = DateTime.Now;

            int userId = frmLogin.userId;

            payment_modesbll.added_by = userId;

            bool success = payment_modesdal.Insert(payment_modesbll);

            if (success == true)
            {
                MessageBox.Show("Product Added Successfully");
                Clear();
                DataTable dt = payment_modesdal.Select();
                dgvPaymentModes.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Add New Product");
            }
        }
        public void Clear()
        {
            dgvPaymentModes.Text = "";
        }

    }
}
