using bharatplantdesktop.UI;
using bharatplantdesktop.Utils;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace bharatplantdesktop
{
    public partial class frmDashboard : Form
    {
        private int borderSize = 2;
        private Size formSize = new Size(1157, 649);
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private string loggedInUser = frmLogin.userName;

        public frmDashboard()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(15, 60);
            pnlMenu.Controls.Add(leftBorderBtn);
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            txtLoggedInUser.Text = "Logged In:" + loggedInUser;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standard Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        private void frmMain_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {

            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    this.Padding = new Padding(borderSize);
                    break;
            }
        }

        #region
        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximise_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {

                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            ShowExitConfirmation();
        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Prevent the form from closing immediately.
                ShowExitConfirmation(); // Ask for user confirmation to close the application.
            }
        }

        private void ShowExitConfirmation()
        {
            // Display a confirmation dialog to ask the user if they want to exit the application.
            var result = MessageBox.Show("Are you sure you want to logout!?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }

        #endregion
        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        private void CollapseMenu()
        {
            if (this.pnlMenu.Width > 200)
            {
                pnlMenu.Width = 100;
                btnLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in pnlMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                pnlMenu.Width = 250;
                btnLogo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in pnlMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);

                }
            }
        }

        #region Shortcut keys for dashboard
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Alt | Keys.G:
                    btnSettings.PerformClick();
                    return true;
                case Keys.Control | Keys.N:
                    txtCalculator.Visible = !txtCalculator.Visible;
                    if (txtCalculator.Visible)
                    {
                        txtCalculator.Focus();
                    }
                    return true;
                case Keys.Escape:
                    if (currentChildForm == null)
                    {
                        ShowExitConfirmation();
                    }
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        #endregion

        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = ThemeColors.ChangeColorBrightness(ThemeColors.pnlMenuClr, -0.5);
                currentBtn.ForeColor = ThemeColors.PrimaryColor;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = ThemeColors.PrimaryColor;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border
                leftBorderBtn.BackColor = ThemeColors.PrimaryColor;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildFormIcon.IconChar = currentBtn.IconChar;
                iconCurrentChildFormIcon.IconColor = ThemeColors.PrimaryColor;
                lblTitleChildForm.ForeColor = ThemeColors.PrimaryColor;
                btnLogo.BackColor = ThemeColors.ChangeColorBrightness(ThemeColors.pnlMenuClr, -0.2);
                btnMenu.BackColor = btnLogo.BackColor;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = ThemeColors.pnlMenuClr;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnLogo.BackColor = ThemeColors.pnlMenuClr;
                btnMenu.BackColor = ThemeColors.pnlMenuClr;

                if (this.pnlMenu.Width > 200)
                {
                    currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                }

                lblTitleChildForm.ForeColor = Color.FromArgb(64, 64, 64);
                leftBorderBtn.Visible = false;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.FormClosed += ChildForm_FormClosed;
            childForm.BackColor = ThemeColors.PrimaryColor;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Size = pnlDesktop.Size;
            childForm.Dock = DockStyle.None;
            pnlDesktop.Controls.Add(childForm);

            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisableButton();
            currentChildForm = null;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildFormIcon.IconChar = IconChar.ChartBar;
            iconCurrentChildFormIcon.IconColor = Color.Gray;
            lblTitleChildForm.Text = "DASHBOARD";
        }
        private void btnLogo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            if (currentChildForm is frmSales)
            {
                return;
            }
            ThemeColors.PrimaryColor = ThemeColors.color5;
            OpenChildForm(new frmSales());
            ActiveButton(sender);
        }
        private void btnPurchases_Click(object sender, EventArgs e)
        {
            if (currentChildForm is frmPurchases)
            {
                return;
            }
            ThemeColors.PrimaryColor = ThemeColors.color1;
            OpenChildForm(new frmPurchases());
            ActiveButton(sender);
        }
        private void btnReceipts_Click(object sender, EventArgs e)
        {
            if (currentChildForm is frmReceipts)
            {
                return;
            }
            ThemeColors.PrimaryColor = ThemeColors.color2;
            OpenChildForm(new frmReceipts());
            ActiveButton(sender);
        }
        private void btnPayments_Click(object sender, EventArgs e)
        {
            if (currentChildForm is frmPayments)
            {
                return;
            }
            ThemeColors.PrimaryColor = ThemeColors.color3;
            OpenChildForm(new frmPayments());
            ActiveButton(sender);
        }
        private void btnPartys_Click(object sender, EventArgs e)
        {
            if (currentChildForm is frmPartys)
            {
                return;
            }
            ThemeColors.PrimaryColor = ThemeColors.color4;
            OpenChildForm(new frmPartys());
            ActiveButton(sender);
        }
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            if (currentChildForm is frmEmployees)
            {
                return;
            }
            ThemeColors.PrimaryColor = ThemeColors.color5;
            OpenChildForm(new frmEmployees());
            ActiveButton(sender);
        }
        private void btnLedgers_Click(object sender, EventArgs e)
        {
            if (currentChildForm is frmLedgers)
            {
                return;
            }
            ThemeColors.PrimaryColor = ThemeColors.color6;
            OpenChildForm(new frmLedgers());
            ActiveButton(sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (currentChildForm is frmUsers)
            {
                return;
            }
            ThemeColors.PrimaryColor = ThemeColors.color1;
            OpenChildForm(new frmUsers());
            ActiveButton(sender);
        }
        private void btnItems_Click(object sender, EventArgs e)
        {
            if (currentChildForm is frmItems)
            {
                return;
            }
            ThemeColors.PrimaryColor = ThemeColors.color2;
            OpenChildForm(new frmItems());
            ActiveButton(sender);
        }
        private void btnExpenses_Click(object sender, EventArgs e)
        {
            if (currentChildForm is frmExpenses)
            {
                return;
            }
            ThemeColors.PrimaryColor = ThemeColors.color3;
            OpenChildForm(new frmExpenses());
            ActiveButton(sender);
        }

        private void btnTransactionModes_Click(object sender, EventArgs e)
        {
            if (currentChildForm is frmExpenses)
            {
                return;
            }
            ThemeColors.PrimaryColor = ThemeColors.color6;
            OpenChildForm(new frmTransactionModes());
            ActiveButton(sender);
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (currentChildForm is frmSettings)
            {
                return;
            }
            ThemeColors.PrimaryColor = ThemeColors.color4;
            OpenChildForm(new frmSettings());
            ActiveButton(sender);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            ShowExitConfirmation();
        }

       
        private string EvaluateExpression(string expression)
        {
            try
            {
                var dataTable = new System.Data.DataTable();
                var result = dataTable.Compute(expression, "");
                return Convert.ToDecimal(result).ToString();
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        private void txtCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift) // Check if Shift key is pressed
                {
                    // Allow the default behavior of Enter key (add a new line)
                    // This is for Shift+Enter, where no calculation is needed
                    return;
                }

                e.Handled = true; // Prevent the Enter key from adding a new line

                // Get the current line being edited
                int selectionStart = txtCalculator.SelectionStart;
                int lineIndex = txtCalculator.GetLineFromCharIndex(selectionStart);

                // Check if the lineIndex is within the valid range
                if (lineIndex >= 0 && lineIndex < txtCalculator.Lines.Length)
                {
                    string currentLine = txtCalculator.Lines[lineIndex];

                    // Trim the line to remove any leading or trailing whitespace
                    currentLine = currentLine.Trim();

                    // Evaluate the expression and get the result
                    string result = EvaluateExpression(currentLine);

                    // Check if the current line is empty or not
                    if (string.IsNullOrWhiteSpace(currentLine))
                    {
                        // Replace the empty line with the result
                        txtCalculator.SelectionStart = txtCalculator.GetFirstCharIndexFromLine(lineIndex);
                        txtCalculator.SelectionLength = currentLine.Length;
                        txtCalculator.SelectedText = result;
                    }
                    else
                    {
                        // Append the result to the next line
                        txtCalculator.AppendText("\r\n" + result);
                    }

                    // Set the cursor at the end of the newly added line
                    txtCalculator.SelectionStart = txtCalculator.TextLength;
                    txtCalculator.ScrollToCaret();
                }
            }
        }

    }
}
