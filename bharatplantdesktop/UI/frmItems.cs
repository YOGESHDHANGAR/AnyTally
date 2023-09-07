using bharatplantdesktop.BLL;
using bharatplantdesktop.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace bharatplantdesktop.UI
{
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }

        itemsBLL itemsbll = new itemsBLL();
        itemsDAL itemsdal = new itemsDAL();
        usersDAL usersdal = new usersDAL();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            itemsbll.name = txtItemName.Text;
            itemsbll.unit = cmbItemUnit.Text;
            itemsbll.added_date = DateTime.Now;

            int userId = frmLogin.userId;

            itemsbll.added_by = userId;

            bool success = itemsdal.Insert(itemsbll);

            if (success == true)
            {
                MessageBox.Show("Product Added Successfully");
                Clear();
                DataTable dt = itemsdal.Select();
                dgvItems.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Add New Product");
            }
        }
        public void Clear()
        {
            txtItemName.Text = "";
            cmbItemUnit.Text = "";
        }
    }
}
