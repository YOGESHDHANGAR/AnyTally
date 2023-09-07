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
using System.Xml.Linq;

namespace bharatplantdesktop.UI
{
    public partial class frmExpenses : Form
    {
        expensesDAL expensesdal = new expensesDAL();
        expensesBLL expensesbll = new expensesBLL();

        public frmExpenses()
        {
            InitializeComponent();
        }

        private void frmExpenses_Load(object sender, EventArgs e)
        {
            txtExpenseType.Focus();
            int nextSerial = expensesdal.GetLatestSerial() + 1;
            txtSerial.Text = nextSerial.ToString();

            DataTable dt = expensesdal.Select();
            dgvExpenses.DataSource = dt;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            expensesbll.serial = int.Parse(txtSerial.Text);
            expensesbll.date = dtpDate.Value;
            expensesbll.expense_type = txtExpenseType.Text;
            expensesbll.amount = decimal.Parse(txtAmount.Text);
            expensesbll.added_date = DateTime.Now;
            expensesbll.added_by = frmLogin.userId;

            bool success = expensesdal.Insert(expensesbll);

            if (success == true)
            {
                MessageBox.Show("User successfully created.");

                DataTable dt = expensesdal.Select();
                dgvExpenses.DataSource = dt;

                int nextId = expensesdal.GetLatestSerial() + 1;
                txtSerial.Text = nextId.ToString();

                txtExpenseType.Text = "";
                txtAmount.Text = "";

                txtExpenseType.Focus();
            }
            else
            {
                MessageBox.Show("Failed to add new user");
            }
        }
    }
}
