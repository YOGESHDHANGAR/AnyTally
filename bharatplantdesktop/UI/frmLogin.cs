using bharatplantdesktop.BLL;
using bharatplantdesktop.DAL;
using bharatplantdesktop.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace bharatplantdesktop.UI
{
    public partial class frmLogin : Form
    {
        public Dictionary<int, string> userData;
        public Dictionary<int, string> allUsersData;
        public static int userId;
        public static string userName;

        usersBLL usersbll = new usersBLL();
        usersDAL usersdal = new usersDAL();
        public frmLogin()
        {
            InitializeComponent();
            ControlsCustomization(this);
            SetupAutoComplete();
        }

        #region
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                Control activeControl = this.ActiveControl;
                if (activeControl != null)
                {
                    if (activeControl is Button)
                    {
                        ((Button)activeControl).PerformClick();
                    }
                    else
                    {
                        this.SelectNextControl(activeControl, true, true, true, true);
                    }
                    return true;
                }
            }
            else if (keyData == Keys.Escape)
            {
                ShowExitConfirmation();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void ShowExitConfirmation()
        {
            var result = MessageBox.Show("Quit ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region
        private void ControlsCustomization(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                    if (control is TextBox textBox)
                    {
                        textBox.Enter += (sender, e) =>
                        {
                            textBox.BackColor = Color.Black;
                            textBox.ForeColor = Color.White;
                        };

                        textBox.Leave += (sender, e) =>
                        {
                            textBox.BackColor = Color.White;
                            textBox.ForeColor = Color.Black;
                        };

                    }

                if (control.Controls.Count > 0)
                {
                    ControlsCustomization(control);
                }
            }
        }
        #endregion


        #region Autopcomplete
        private void SetupAutoComplete()
        {
            allUsersData = usersdal.SelectAllforAutoSuggestion();
            AutoCompleteStringCollection autoCompleteDataforUser = new AutoCompleteStringCollection();

            autoCompleteDataforUser.AddRange(allUsersData.Values.ToArray());
            txtUsername.AutoCompleteCustomSource = autoCompleteDataforUser;
        }
        #endregion

        #region
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            string userInput = txtUsername.Text;
            if (userInput == "" || allUsersData.ContainsValue(userInput))
            {

            }
            else
            {
                MessageBox.Show("Invalid user name. Please select a name from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            usersbll.username = txtUsername.Text.Trim();
            usersbll.password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(usersbll.username))
            {
                MessageBox.Show("Username is required!");
                txtUsername.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(usersbll.password))
            {
                MessageBox.Show("Password is required!");
                txtPassword.Focus();
                return;
            }

            var loginCheckResult = usersdal.loginCheck(usersbll);

            bool isSuccess = loginCheckResult.Item1;

            if (isSuccess == true)
            {
                MessageBox.Show("Login Successful!");

                userData = loginCheckResult.Item2;
                userId = userData.Keys.First();
                userName = userData[userId];

                frmDashboard dashboard = new frmDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed.Try Again");
                txtUsername.Focus();
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            usersbll.name = txtName.Text;
            usersbll.username = txtRegisterUsername.Text;
            usersbll.password = txtRegisterPassword.Text;
            usersbll.confirm_password = txtRegisterConfirmPassword.Text;

            if (string.IsNullOrEmpty(usersbll.name))
            {
                MessageBox.Show("Name is required!");
                txtName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(usersbll.username))
            {
                MessageBox.Show("Create your own username is required!");
                txtRegisterUsername.Focus();
                return;
            } 
            else if (string.IsNullOrEmpty(usersbll.password)) {
                MessageBox.Show("Password is required!");
                txtRegisterPassword.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(usersbll.confirm_password))
            {
                MessageBox.Show("Confirm Password is required!");
                txtRegisterConfirmPassword.Focus();
                return;
            }
            if (usersbll.password != usersbll.confirm_password) {
                MessageBox.Show("Password and confirm password does not match!");
                txtPassword.Focus();
                return;
            }

            usersbll.added_date = DateTime.Now;

            bool success = usersdal.Insert(usersbll);

            if (success == true)
            {
                MessageBox.Show("User successfully created.");
                clear();
                SetupAutoComplete();
                tabControlLoginAndRegister.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Failed to add new user");
                txtName.Focus();
            }
        }
        private void clear()
        {
            txtName.Clear();
            txtRegisterUsername.Clear();
            txtRegisterPassword.Clear();
            txtRegisterConfirmPassword.Clear();
        }
        private void lblOrRegister_Click(object sender, EventArgs e)
        {
            tabControlLoginAndRegister.SelectedIndex = 1;
        }
        private void lblOrLogin_Click(object sender, EventArgs e)
        {
            tabControlLoginAndRegister.SelectedIndex = 0;
        }
        private void tabControlLoginAndRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlLoginAndRegister.SelectedIndex == 0)
            {
                txtUsername.Focus();
            }
            else if (tabControlLoginAndRegister.SelectedIndex == 1) {
                txtName.Focus();
            }
        }
    }
}
