using bharatplantdesktop.BLL;
using bharatplantdesktop.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace bharatplantdesktop.UI
{
    public partial class frmEmployees : Form
    {
        employeesDAL employeesdal = new employeesDAL();
        employeesBLL employeesbll = new employeesBLL();
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            int nextId = employeesdal.GetLatestId() + 1;
            txtId.Text = nextId.ToString();

            DataTable dt = employeesdal.Select();
            dgvEmployees.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            employeesbll.id = int.Parse(txtId.Text);
            employeesbll.name = txtName.Text.Trim();
            employeesbll.added_date = DateTime.Now;
            employeesbll.added_by = frmLogin.userId;

            bool success = employeesdal.Insert(employeesbll);

            if (success == true)
            {
                MessageBox.Show("User successfully created.");

                DataTable dt = employeesdal.Select();
                dgvEmployees.DataSource = dt;

                int nextId = employeesdal.GetLatestId() + 1;
                txtId.Text = nextId.ToString();

                txtName.Text = "";

            }
            else
            {
                MessageBox.Show("Failed to add new user");
            }
        }
    }
}
