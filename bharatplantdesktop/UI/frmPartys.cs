using bharatplantdesktop.BLL;
using bharatplantdesktop.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace bharatplantdesktop.UI
{
    public partial class frmPartys : Form
    {
        public frmPartys()
        {
            InitializeComponent();
        }
        partysBLL partysbll = new partysBLL();
        partysDAL partysdal = new partysDAL();
        usersDAL usersdal = new usersDAL();
           

        private void clear()
        {
            txtOpeningBalance.Text = "";
            txtPartyName.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            partysbll.name = txtPartyName.Text.Trim();
            partysbll.opening_balance = decimal.Parse(txtOpeningBalance.Text.Trim());
            partysbll.lena_dena = cmbLenaDena.Text.Trim();
            partysbll.added_date = DateTime.Now;

            int userId = frmLogin.userId;
            partysbll.added_by = userId;

            bool success = partysdal.Insert(partysbll);

            if (success == true)
            {
                MessageBox.Show("User successfully created.");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to add new user");
            }
            DataTable dt = partysdal.Select();
        }

    }
}
