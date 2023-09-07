using bharatplantdesktop.BLL;
using bharatplantdesktop.DAL;
using bharatplantdesktop.Utils;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using Control = System.Windows.Forms.Control;
using Font = System.Drawing.Font;
using Rectangle = System.Drawing.Rectangle;
using TextBox = System.Windows.Forms.TextBox;
using System.IO;

namespace bharatplantdesktop.UI
{
    public partial class frmSales : Form
    {
        #region
        private Dictionary<int, string> allPartyData;
        private Dictionary<int, (string Name, string Unit)> allItemsData;
        private Dictionary<int, string> allSalesData;
        private Dictionary<int, string> allUsersData;
        private SuggestionListUserControl suggestionList;

        private DataTable dt;
        private DataTable removedRowsTable;
        private DataView dataView;
        private BindingSource bindingSource;

        private bool isSecondPage = false;
        private bool isFirstPage = true;

        DateTime dateValueforDatabase;
        DateTime filterPeriodFromforDatabase = DateTime.Parse("01-Apr-2001");
        DateTime filterPeriodToforDatabase = DateTime.Parse("31-Mar-2099");

        private Color PrimaryColor = ThemeColors.ChangeColorBrightness(ThemeColors.PrimaryColor, 0.9);
        private bool saleDetailsOpened = false;
        private string selectedSortBy = "Date";
        private int entryTableRowSelectedForUpdate = -1;
        private string textForUpdateInBtnDgvHandler = "Update";
        private string textForAddMoreInBtnDgvHandler = "ADD MORE";
        private string textForAddInBtnDgvHandler = "ADD";
        private string sortOrder = " ASC, Serial ASC";

        private int loggedInUserId = frmLogin.userId;
        private int latestSerial;
        private string unitOfItemSelected = "";
        private int selectedPartyId = 0;
        private int selectedFilterPartyId = 0;
        private int selectedFilterUserId = 0;
        private int itemId = 0;

        DataTable salesDT = new DataTable();

        partysDAL partysdal = new partysDAL();
        itemsDAL itemsdal = new itemsDAL();
        salesDAL salesdal = new salesDAL();
        salesDetailsDAL salesdetailsdal = new salesDetailsDAL();
        usersDAL usersdal = new usersDAL();
        #endregion

        #region
        public frmSales()
        {
            InitializeComponent();
            InitializeDateFormats();
            SetupAutoComplete();
            ControlsCustomization(this);
            SetCustomeColors();
            PreparingSalesDT();
            loadReportDataTable();
            HidingUnwantedTabPages();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            txtVoucher.Focus();
            this.KeyPreview = true;

            latestSerial = salesdal.GetLatestSerial() + 1;
            txtSerial.Text = latestSerial.ToString();

            txtCustomeDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            txtDay.Text = DateTime.Now.ToString("dddd");

            txtFilterPeriodFrom.Text = filterPeriodFromforDatabase.ToString("dd-MMM-yyyy");
            txtFilterPeriodTo.Text = filterPeriodToforDatabase.ToString("dd-MMM-yyyy");

        }
        #endregion

        #region
        private void RemoveSelectedRow()
        {
            if (dgvSales.SelectedRows.Count > 0)
            {
                DataRowView rowView = dgvSales.SelectedRows[0].DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    // Store the removed row in the removedRowsTable
                    DataRow removedRow = removedRowsTable.NewRow();
                    removedRow.ItemArray = rowView.Row.ItemArray;
                    removedRowsTable.Rows.Add(removedRow);

                    // Remove the row from the DataView
                    dataView.Delete(dgvSales.SelectedRows[0].Index);
                }
            }
        }
        private void RestoreLastRemovedRow()
        {
            if (removedRowsTable.Rows.Count > 0)
            {
                // Get the last removed row from the removedRowsTable
                DataRow lastRemovedRow = removedRowsTable.Rows[removedRowsTable.Rows.Count - 1];

                // Add the row back to the original DataTable
                dataView.Table.Rows.Add(lastRemovedRow.ItemArray);

                // Remove the row from the removedRowsTable
                removedRowsTable.Rows.RemoveAt(removedRowsTable.Rows.Count - 1);

            }
        }
        private void loadReportDataTable()
        {
            bindingSource = new BindingSource();
            dgvSales.DataSource = bindingSource;

            dt = salesdal.Select(filterPeriodFromforDatabase, filterPeriodToforDatabase, selectedFilterPartyId, selectedFilterUserId);
            removedRowsTable = dt.Clone(); //cloning structure not data
            dataView = dt.DefaultView;  //it references the same DataTable (dt), so any changes made to the DataView will also affect the original DataTable, and vice versa. 
            dataView.Sort = selectedSortBy + sortOrder;
            bindingSource.DataSource = dataView;

            DisplayTotalCount();
            CalculateAndDisplayCurrentTotal();
            bindingSource.ListChanged += BindingSource_ListChanged;
            ThemeColors.SetColumnWidthsInPercentage(dgvSales, 9, 9, 32, 8, 22, 12, 8);
            PopulateSortColumns();
        }

        private void dgvSales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSales.Columns[e.ColumnIndex].Name == "Date")
            {
                if (e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime dateValue))
                {
                    e.Value = dateValue.ToString("dd-MMM-yyyy");
                    e.FormattingApplied = true;
                }
            }
        }
        private void cmbSortingOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string columnName = cmbSortingOptions.SelectedItem.ToString();
            selectedSortBy = columnName;

            DataView dataView = (DataView)bindingSource.DataSource;
            dataView.Sort = selectedSortBy + sortOrder;

            bindingSource.DataSource = dataView;
        }
        private void PopulateSortColumns()
        {
            bool serialAdded = false;

            foreach (DataGridViewColumn column in dgvSales.Columns)
            {
                cmbSortingOptions.Items.Add(column.HeaderText);

                if (column.HeaderText == selectedSortBy)
                {
                    cmbSortingOptions.SelectedItem = column.HeaderText;
                    serialAdded = true;
                }
            }

            if (!serialAdded && cmbSortingOptions.Items.Count > 0)
            {
                cmbSortingOptions.SelectedIndex = 0;
            }
        }

        #endregion

        #region

        private void DisplayTotalCount() {

            txtSalesCount.Text = "Total Count:  " + bindingSource.Count.ToString();

        }

        private void CalculateAndDisplayCurrentTotal()
        {
            decimal totalCurrentAmount = 0;
            foreach (DataRowView rowView in bindingSource)
            {
                DataRow row = rowView.Row;
                // Check for DBNull before converting to decimal
                if (!Convert.IsDBNull(row[6]))
                {
                    decimal amount = Convert.ToDecimal(row[6]);
                    totalCurrentAmount += amount;
                }
            }

            #region
            NumberFormatInfo indianNumberFormat = new CultureInfo("en-IN").NumberFormat;
            indianNumberFormat.NumberGroupSizes = new[] { 3, 2 };
            indianNumberFormat.NumberGroupSeparator = ",";
            indianNumberFormat.NumberDecimalDigits = 2; // Set the number  decimal places
            txtDgvCurrentTotal.Text = totalCurrentAmount.ToString("#,##,##0.00", indianNumberFormat);
            #endregion
        }
        private void BindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            DisplayTotalCount();
            CalculateAndDisplayCurrentTotal();
        }
        #endregion

        #region
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    if (btnDGVhandler.Text == textForUpdateInBtnDgvHandler)
                    {
                        txtItemName.Clear();
                        txtQuantity.Clear();
                        txtRate.Clear();
                        txtUnit.Clear();
                        txtAmount.Clear();
                        btnDGVhandler.Text = textForAddMoreInBtnDgvHandler;
                    }
                    else if (saleDetailsOpened)
                    {
                        tabControlSales.SelectedIndex = 1;
                        dgvSales.Focus();
                        clear(true);
                        saleDetailsOpened = false;
                    }
                    else if (this.ActiveControl is TextBox textBox)
                    {
                        if (!string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            textBox.Text = string.Empty;
                        }
                        else
                        {
                            ShowExitConfirmation();
                        }
                    }
                    else if (this.ActiveControl is DataGridView dataGridView)
                    {
                        dataGridView.ClearSelection();
                        dataGridView.Parent.Focus();
                    }
                    else
                    {
                        ShowExitConfirmation();
                    }
                    return true;

                case Keys.Enter:
                    Control activeControl = this.ActiveControl;
                    if (activeControl != null)
                    {
                        switch (activeControl)
                        {
                            case Button button:
                                button.PerformClick();
                                break;

                            case CheckBox checkBox:
                                checkBox.Checked = !checkBox.Checked;
                                break;

                            default:
                                if (activeControl == dgvSales && dgvSales.CurrentRow != null)
                                {
                                    DataGridViewRow selectedRow = dgvSales.CurrentRow;
                                    HandDgvSalesleRowSelection(selectedRow);
                                }
                                else if (activeControl == dgvAddedItems && dgvAddedItems.CurrentRow != null)
                                {
                                    DataGridViewRow selectedRow = dgvAddedItems.CurrentRow;
                                    HandleDgvAddedItemsRowSelection(selectedRow);
                                }
                                else
                                {
                                    this.SelectNextControl(activeControl, true, true, true, true);
                                }
                                break;
                        }
                        return true;
                    }
                    break;
                case Keys.Control | Keys.F:
                    if (!isSecondPage) return true;
                    txtFilterSearch.Focus();
                    return true;
                case Keys.Control | Keys.OemPeriod:
                    if (!isFirstPage) return true;
                    btnNext.PerformClick();
                    return true;
                case Keys.Control | Keys.Oemcomma:
                    if (!isFirstPage) return true;
                    btnPrev.PerformClick();
                    return true;
                case Keys.Control | Keys.R:
                    if (!isFirstPage) return true;
                    btnRefresh.PerformClick();
                    return true;
                case Keys.Control | Keys.A:
                    if (!isFirstPage) return true;
                    btnSave.PerformClick();
                    return true;
                case Keys.Alt | Keys.D:
                    if (isFirstPage)
                    {
                        btnDelete.PerformClick();
                    }
                    else if (isSecondPage)
                    {
                        DeleteFunctionalityUsingShortcut();
                    }
                    return true;
                case Keys.Alt | Keys.F2:
                    if (!isSecondPage) return true;
                    txtFilterPeriodFrom.Focus();
                    return true;
                case Keys.Alt | Keys.R:
                    RemoveSelectedRow();
                    return true;
                case Keys.Alt | Keys.U:
                    RestoreLastRemovedRow();
                    return true;
                case Keys.Alt | Keys.A:
                    CeratingVoucherUsingShortCut();
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ShowExitConfirmation()
        {
            var result = MessageBox.Show("Quit ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region
        private void clear(bool updateSerialToLatestSerial)
        {
            if (updateSerialToLatestSerial)
            {
                txtSerial.Text = latestSerial.ToString();
            }
            txtVoucher.Clear();
            txtVoucher.Focus();
            txtCustomeDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            txtDay.Text = DateTime.Now.ToString("dddd");
            txtPartyName.Clear();
            if (dgvAddedItems.DataSource is DataTable dataTable)
            {
                dataTable.Clear();
            }
            dgvAddedItems.Rows.Clear();
            txtItemName.Clear();
            txtQuantity.Clear();
            txtRate.Clear();
            txtUnit.Clear();
            txtAmount.Clear();
            txtNarration.Clear();
            txtTotalAmount.Clear();
            lblCreatedByName.Visible = false;
            txtCreatedByName.Clear();
            txtCreatedByName.Visible = false;

        }
        #endregion

        #region
        private void SetCustomeColors()
        {
            btnPrev.BackColor = Color.Gray;
            btnPrev.ForeColor = Color.White;
            btnNext.BackColor = Color.Gray;
            btnNext.ForeColor = Color.White;
            SetButtonCustomColors(btnDGVhandler, Color.FromArgb(35, 39, 43));
            SetButtonCustomColors(btnProceed, Color.FromArgb(19, 132, 150));
            SetButtonCustomColors(btnSave, Color.FromArgb(33, 136, 56));
            SetButtonCustomColors(btnUpdate, Color.FromArgb(0, 105, 217));
            SetButtonCustomColors(btnDelete, Color.FromArgb(200, 35, 51));
            SetButtonCustomColors(btnRefresh, Color.FromArgb(90, 98, 104));
        }
        private void SetButtonCustomColors(Button button, Color buttonColor)
        {
            Color originalBackColor = button.BackColor;
            Color originalForeColor = button.ForeColor;
            button.ForeColor = buttonColor;
            button.FlatAppearance.BorderColor = buttonColor;

            button.Enter += (sender, e) =>
            {
                button.BackColor = buttonColor;
                button.ForeColor = Color.White;
            };

            button.Leave += (sender, e) =>
            {
                button.BackColor = originalBackColor;
                button.ForeColor = originalForeColor;
            };

            button.MouseEnter += (sender, e) =>
            {
                button.BackColor = buttonColor;
                button.ForeColor = Color.White;
            };

            button.MouseLeave += (sender, e) =>
            {
                if (!button.Focused)
                {
                    button.BackColor = originalBackColor;
                    button.ForeColor = originalForeColor;
                }
            };
        }
        #endregion

        #region
        private void ControlsCustomization(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                    button.Enter += (sender, e) =>
                    {
                        UpdateBtnDGVHandlerText(button);
                    };

                    button.Leave += (sender, e) =>
                    {
                        UpdateBtnDGVHandlerText(button);
                    };
                }
                else
                {
                    control.BackColor = PrimaryColor;
                    if (control is TextBox textBox)
                    {
                        textBox.BackColor = textBox.Enabled ? PrimaryColor : Color.LightGray;

                        textBox.Enter += (sender, e) =>
                        {
                            textBox.BackColor = Color.Black;
                            textBox.ForeColor = Color.White;
                            UpdateBtnDGVHandlerText(textBox);
                        };

                        textBox.Leave += (sender, e) =>
                        {
                            textBox.BackColor = PrimaryColor;
                            textBox.ForeColor = Color.Black;
                            UpdateBtnDGVHandlerText(textBox);
                        };

                        textBox.MouseEnter += (sender, e) =>
                        {
                            if (!textBox.Focused)
                            {
                                textBox.BackColor = ThemeColors.ChangeColorBrightness(Color.Black, 0.8);
                            }
                        };

                        textBox.MouseLeave += (sender, e) =>
                        {
                            if (!textBox.Focused)
                            {
                                textBox.BackColor = PrimaryColor;
                            }
                        };

                        textBox.EnabledChanged += (sender, e) =>
                        {
                            if (!textBox.Enabled)
                            {
                                textBox.BackColor = Color.LightGray;
                            }
                            else
                            {
                                textBox.BackColor = PrimaryColor;
                                textBox.ForeColor = Color.Black;
                            }
                        };

                    }
                    else if (control is DataGridView dataGridView)
                    {
                        dataGridView.BackgroundColor = PrimaryColor;
                        dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ThemeColors.ChangeColorBrightness(ThemeColors.PrimaryColor, -0.1);
                        dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView.ColumnHeadersDefaultCellStyle.BackColor;
                        dataGridView.AlternatingRowsDefaultCellStyle.BackColor = PrimaryColor;
                    }
                    else if (control is CheckBox checkBox)
                    {
                        checkBox.Enter += (sender, e) =>
                        {
                            checkBox.BackColor = Color.Black;
                            checkBox.ForeColor = Color.White;
                        };

                        checkBox.Leave += (sender, e) =>
                        {
                            checkBox.BackColor = Color.White;
                            checkBox.ForeColor = Color.Black;
                        };
                    }
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.Enter += (sender, e) =>
                        {
                            comboBox.BackColor = Color.Black;
                            comboBox.ForeColor = Color.White;
                        };

                        comboBox.Leave += (sender, e) =>
                        {
                            comboBox.BackColor = PrimaryColor;
                            comboBox.ForeColor = Color.Black;
                        };

                        comboBox.MouseEnter += (sender, e) =>
                        {
                            if (!comboBox.Focused)
                            {
                                comboBox.BackColor = ThemeColors.ChangeColorBrightness(Color.Black, 0.8);
                            }
                        };

                        comboBox.MouseLeave += (sender, e) =>
                        {
                            if (!comboBox.Focused)
                            {
                                comboBox.BackColor = PrimaryColor;
                            }
                        };
                    }

                }

                if (control.Controls.Count > 0)
                {
                    ControlsCustomization(control);
                }
            }
        }

        private void UpdateBtnDGVHandlerText(Control control)
        {
            if (btnDGVhandler.Text == textForUpdateInBtnDgvHandler)
            {
                return;
            }
            if (control.TabIndex < btnDGVhandler.TabIndex)
            {
                btnDGVhandler.Text = textForAddInBtnDgvHandler;
            }
            else if (control.TabIndex == btnDGVhandler.TabIndex)
            {

            }
            else
            {
                btnDGVhandler.Text = textForAddMoreInBtnDgvHandler;
            }
        }
        #endregion


        #region Customer date picker
        private string[] combinedFormats;

        private void InitializeDateFormats()
        {
            string[] allFormats = CultureInfo.CurrentCulture.DateTimeFormat.GetAllDateTimePatterns();
            string[] customFormats = new string[] { "dd-MMM-yyyy", "dd.MM.yyyy", "d.MM.yyyy", "dd.M.yyyy", "d.M.yyyy" };
            combinedFormats = allFormats.Concat(customFormats).ToArray();
        }

        private void ValidateDateTextBox(TextBox textBox, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                txtDay.Clear();
            }
            else if (!DateTime.TryParseExact(textBox.Text, combinedFormats, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces | DateTimeStyles.AssumeLocal, out DateTime parsedDate))
            {
                e.Cancel = true;
            }
            else
            {
                DisplayChosenDate(parsedDate, textBox);

                if (textBox == txtCustomeDate)
                {
                    dateValueforDatabase = parsedDate;
                    txtDay.Text = parsedDate.ToString("dddd");
                }
                else if (textBox == txtFilterPeriodFrom)
                {
                    filterPeriodFromforDatabase = parsedDate;

                }
                else if (textBox == txtFilterPeriodTo)
                {
                    filterPeriodToforDatabase = parsedDate;
                }
            }
        }

        private void txtCustomeDate_Validating(object sender, CancelEventArgs e)
        {
            ValidateDateTextBox(txtCustomeDate, e);
        }

        private void txtFilterPeriodFrom_Validating(object sender, CancelEventArgs e)
        {
            ValidateDateTextBox(txtFilterPeriodFrom, e);
        }

        private void txtFilterPeriodTo_Validating(object sender, CancelEventArgs e)
        {
            ValidateDateTextBox(txtFilterPeriodTo, e);
        }

        private void DisplayChosenDate(DateTime? date, TextBox textBox)
        {
            if (date.HasValue)
            {
                textBox.Text = date.Value.ToString("dd-MMM-yyyy");

                if (textBox == txtCustomeDate)
                {
                    dateValueforDatabase = date.Value;
                    txtDay.Text = date.Value.ToString("dddd");
                }
            }
        }

        #endregion

        #region Autopcomplete
        private void SetupAutoComplete()
        {
            allPartyData = partysdal.SelectAllforAutoSuggestion();
            allItemsData = itemsdal.SelectAllforAutoSuggestion();
            allSalesData = salesdal.SelectAllforAutoSuggestion();
            allUsersData = usersdal.SelectAllforAutoSuggestion();

            AutoCompleteStringCollection autoCompleteDataforParty = new AutoCompleteStringCollection();
            autoCompleteDataforParty.AddRange(allPartyData.Values.ToArray());
            txtPartyName.AutoCompleteCustomSource = autoCompleteDataforParty;
            txtFilterPartyName.AutoCompleteCustomSource = autoCompleteDataforParty;

            AutoCompleteStringCollection autoCompleteDataforItems = new AutoCompleteStringCollection();
            foreach (var itemsData in allItemsData.Values)
            {
                autoCompleteDataforItems.Add(itemsData.Name);
            }
            txtItemName.AutoCompleteCustomSource = autoCompleteDataforItems;

            AutoCompleteStringCollection autoCompleteDataforNarration = new AutoCompleteStringCollection();
            autoCompleteDataforNarration.AddRange(allSalesData.Values.ToArray());
            txtNarration.AutoCompleteCustomSource = autoCompleteDataforNarration;

            AutoCompleteStringCollection autoCompleteDataforUsers = new AutoCompleteStringCollection();
            autoCompleteDataforUsers.AddRange(allUsersData.Values.ToArray());
            txtFilterCreatedBy.AutoCompleteCustomSource = autoCompleteDataforUsers;

        }
        #endregion

        #region
        private void ClearDataGridViewUnwantedRowSelections()
        {
            dgvAddedItems.ClearSelection();
        }
        private void HidingUnwantedTabPages()
        {
            foreach (TabPage tabPage in tabControlSales.TabPages)
            {
                if (tabPage != tabControlSales.SelectedTab)
                {
                    foreach (Control control in tabPage.Controls)
                    {
                        control.Visible = false;
                    }
                }
            }

            foreach (Control control in tabControlSales.SelectedTab.Controls)
            {
                control.Visible = true;
            }

            ClearDataGridViewUnwantedRowSelections();
        }

        private void tabControlSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            HidingUnwantedTabPages();
            if (tabControlSales.SelectedIndex == 0)
            {
                txtVoucher.Focus();
            }
            else if (tabControlSales.SelectedIndex == 1)
            {
                txtFilterSearch.Focus();
            }
            isFirstPage = tabControlSales.SelectedIndex == 0;
            isSecondPage = tabControlSales.SelectedIndex == 1;
        }
        private void tabControlSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (isSecondPage && !dgvSales.ContainsFocus && e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                dgvSales.Focus();
            }
            else if (isFirstPage && !dgvAddedItems.ContainsFocus && e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                dgvAddedItems.Focus();
            }
        }
        #endregion

        #region
        private void dgvSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSales.Rows.Count)
            {
                HandDgvSalesleRowSelection(dgvSales.Rows[e.RowIndex]);
            }
        }
        private void HandDgvSalesleRowSelection(DataGridViewRow selectedRow)
        {
            if (int.TryParse(selectedRow.Cells["Serial"].Value.ToString(), out int serial))
            {
                SingleSelectWithNextAndPrev(serial, 0);
                tabControlSales.SelectedIndex = 0;
                saleDetailsOpened = true;
            }
            else
            {
                return;
            }
        }
        #endregion

        #region
        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            bool isValidSerial = int.TryParse(txtSerial.Text, out int currentSerial);
            if (!isValidSerial)
            {
                return;
            }
            btnSave.Enabled = currentSerial >= latestSerial;
            btnUpdate.Enabled = currentSerial < latestSerial;
            btnDelete.Enabled = currentSerial < latestSerial;

            btnPrev.Enabled = currentSerial > 1;
            btnNext.Enabled = currentSerial < latestSerial;
        }
        private void UpdateUIFromSaleData(DataTable saleData, int newSerial)
        {
            bool condition = saleData != null && saleData.Rows.Count > 0;
            btnUpdate.Enabled = condition;
            btnDelete.Enabled = condition;
            if (condition)
            {
                txtVoucher.Text = saleData.Rows[0]["voucher"].ToString();

                #region
                string dateStringFromDatabase = saleData.Rows[0]["date"].ToString();
                if (DateTime.TryParseExact(dateStringFromDatabase, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces | DateTimeStyles.AssumeLocal, out DateTime parsedDate))
                {
                    DisplayChosenDate(parsedDate, txtCustomeDate);
                }
                #endregion

                #region day text maintain
                string dateStr = (saleData.Rows[0]["date"].ToString());
                DateTime date;
                if (DateTime.TryParse(dateStr, out date))
                {
                    txtDay.Text = date.ToString("dddd");
                }
                #endregion

                #region
                partysBLL partysbll = new partysBLL();
                int partyId;
                if (int.TryParse(saleData.Rows[0]["party_id"].ToString(), out partyId))
                {
                    partysbll.id = partyId;
                    DataTable partyData = partysdal.SingleSelect(partysbll);
                    if (partyData != null && partyData.Rows.Count > 0)
                    {
                        txtPartyName.Text = partyData.Rows[0]["name"].ToString();
                    }
                }
                #endregion

                #region
                salesDetailsBLL salesdetailsbll = new salesDetailsBLL();
                salesdetailsbll.serial = newSerial;
                DataTable saleDetailData = salesdetailsdal.SingleSelect(salesdetailsbll);
                if (saleDetailData != null && saleDetailData.Rows.Count > 0)
                {
                    dgvAddedItems.Rows.Clear();
                    foreach (DataRow row in saleDetailData.Rows)
                    {
                        object[] rowData = row.ItemArray;

                        dgvAddedItems.Rows.Add(rowData);
                    }
                }
                #endregion

                txtTotalAmount.Text = saleData.Rows[0]["total_amount"].ToString();
                txtNarration.Text = saleData.Rows[0]["narration"].ToString();
                listBoxNarration.Visible = false;

                #region
                usersBLL usersbll = new usersBLL();
                int userId;
                if (int.TryParse(saleData.Rows[0]["added_by"].ToString(), out userId))
                {
                    usersbll.id = userId;
                    DataTable userData = usersdal.SingleSelect(usersbll);
                    txtCreatedByName.Visible = true;
                    lblCreatedByName.Visible = true;
                    if (userData != null && userData.Rows.Count > 0)
                    {
                        txtCreatedByName.Text = userData.Rows[0]["name"].ToString();
                    }
                    else
                    {
                        txtCreatedByName.Text = "Not Found";
                    }
                }
                #endregion
            }
            else
            {
                clear(false);
                txtCustomeDate.Clear();
                txtDay.Clear();
            }
        }

        private void SingleSelectWithNextAndPrev(int serial, int serialIncrement)
        {
            clear(false);
            int newSerial = serial + serialIncrement;

            if (newSerial <= 0 || newSerial >= latestSerial)
            {
                if (newSerial >= latestSerial)
                {
                    clear(true);
                }
                return;
            }

            salesBLL salesbll = new salesBLL();
            salesbll.serial = newSerial;
            txtSerial.Text = newSerial.ToString();

            DataTable saleData = salesdal.SingleSelect(salesbll);
            UpdateUIFromSaleData(saleData, newSerial);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            bool isValidSerial = int.TryParse(txtSerial.Text, out int serial);

            if (!isValidSerial)
            {
                MessageBox.Show("Invalid Serial");
                return;
            }
            SingleSelectWithNextAndPrev(serial, -1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bool isValidSerial = int.TryParse(txtSerial.Text, out int serial);

            if (!isValidSerial)
            {
                MessageBox.Show("Invalid Serial");
                return;
            }
            SingleSelectWithNextAndPrev(serial, 1);
        }
        #endregion

        private void txtFilterPeriodTo_Validated(object sender, EventArgs e)
        {
            DataTable dt = salesdal.Select(filterPeriodFromforDatabase, filterPeriodToforDatabase, selectedFilterPartyId, selectedFilterUserId);
            removedRowsTable.Clear();
            dataView = dt.DefaultView;
            dataView.Sort = selectedSortBy + sortOrder;
            bindingSource.DataSource = dataView;
        }
        private void txtPartyName_Validating(object sender, CancelEventArgs e)
        {
            string userInput = txtPartyName.Text;
            if (string.IsNullOrEmpty(userInput) || allPartyData.ContainsValue(userInput))
            {
                selectedPartyId = allPartyData.FirstOrDefault(x => x.Value == userInput).Key;
            }
            else
            {
                MessageBox.Show("Invalid party name. Please select a name from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
        #region
        private void txtFilterPartyName_Validating(object sender, CancelEventArgs e)
        {
            string userInput = txtFilterPartyName.Text;
            if (string.IsNullOrEmpty(userInput) || allPartyData.ContainsValue(userInput))
            {
                selectedFilterPartyId = allPartyData.FirstOrDefault(x => x.Value == userInput).Key;
            }
            else
            {
                MessageBox.Show("Invalid party name. Please select a name from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void checkBoxFilterPartyName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFilterPartyName.Checked)
            {
                txtFilterPartyName.Enabled = true;
                txtFilterPartyName.Focus();
            }
            else
            {
                txtFilterPartyName.Clear();
                txtFilterPartyName.Enabled = false;
                selectedFilterPartyId = 0;

                DataTable dt = salesdal.Select(filterPeriodFromforDatabase, filterPeriodToforDatabase, selectedFilterPartyId, selectedFilterUserId);
                removedRowsTable.Clear();
                dataView = dt.DefaultView;
                dataView.Sort = selectedSortBy + sortOrder;
                bindingSource.DataSource = dataView;
            }
        }

        private void txtFilterPartyName_Validated(object sender, EventArgs e)
        {
            DataTable dt = salesdal.Select(filterPeriodFromforDatabase, filterPeriodToforDatabase, selectedFilterPartyId, selectedFilterUserId);
            removedRowsTable.Clear();
            dataView = dt.DefaultView;
            dataView.Sort = selectedSortBy + sortOrder;
            bindingSource.DataSource = dataView;
        }
        #endregion

        #region
        private void txtFilterCreatedBy_Validating(object sender, CancelEventArgs e)
        {
            string userInput = txtFilterCreatedBy.Text;
            if (string.IsNullOrEmpty(userInput) || allUsersData.ContainsValue(userInput))
            {
                selectedFilterUserId = allUsersData.FirstOrDefault(x => x.Value == userInput).Key;
            }
            else
            {
                MessageBox.Show("Invalid user name. Please select a name from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
        private void checkBoxFilterCreatedBy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFilterCreatedBy.Checked)
            {
                txtFilterCreatedBy.Enabled = true;
                txtFilterCreatedBy.Focus();
            }
            else
            {
                txtFilterCreatedBy.Clear();
                txtFilterCreatedBy.Enabled = false;
                selectedFilterUserId = 0;

                DataTable dt = salesdal.Select(filterPeriodFromforDatabase, filterPeriodToforDatabase, selectedFilterPartyId, selectedFilterUserId);
                removedRowsTable.Clear();
                dataView = dt.DefaultView;
                dataView.Sort = selectedSortBy + sortOrder;
                bindingSource.DataSource = dataView;
            }
        }
        private void txtFilterCreatedBy_Validated(object sender, EventArgs e)
        {
            DataTable dt = salesdal.Select(filterPeriodFromforDatabase, filterPeriodToforDatabase, selectedFilterPartyId, selectedFilterUserId);
            removedRowsTable.Clear();
            dataView = dt.DefaultView;
            dataView.Sort = selectedSortBy + sortOrder;
            bindingSource.DataSource = dataView;
        }
        #endregion

        private void txtItemName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string userInputForItemName = txtItemName.Text.Trim();

            if (string.IsNullOrEmpty(txtItemName.Text) || allItemsData.Values.Any(itemData => itemData.Name == userInputForItemName))
            {
                var selectedItemData = allItemsData.Values.FirstOrDefault(itemData => itemData.Name == userInputForItemName);

                if (!selectedItemData.Equals(default))
                {
                    itemId = allItemsData.FirstOrDefault(x => x.Value.Name == userInputForItemName).Key;
                    unitOfItemSelected = selectedItemData.Unit;
                }
            }
            else
            {
                MessageBox.Show("Invalid item name. Please select a name from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;

            }
        }
        private void txtQuantity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool isValidQuantity = decimal.TryParse(txtQuantity.Text, out decimal quantity);
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
            }
            else if (!isValidQuantity)
            {
                e.Cancel = true;
            }
        }
        private void txtRate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool isValidRate = decimal.TryParse(txtRate.Text, out decimal rate);
            if (string.IsNullOrEmpty(txtRate.Text))
            {
            }
            else if (!isValidRate)
            {
                e.Cancel = true;
            }
        }
        private void txtRate_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtItemName.Text))
            {
                txtUnit.Text = unitOfItemSelected;
            }
            else
            {
                txtUnit.Clear();
            }
        }
        private void CalculateAmount()
        {
            bool isValidQuantity = decimal.TryParse(txtQuantity.Text, out decimal quantity);
            bool isValidRate = decimal.TryParse(txtRate.Text, out decimal rate);
            bool isValidAmount = decimal.TryParse(txtAmount.Text, out decimal amount);

            if (isValidQuantity && isValidRate)
            {
                amount = Math.Round(Math.Round(quantity, 2) * Math.Round(rate, 2), 2);
                txtAmount.Text = amount.ToString();
            }
        }
        private void txtRate_Leave(object sender, EventArgs e)
        {
            CalculateAmount();
        }
        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            CalculateAmount();
        }
        private void txtAmount_Leave(object sender, EventArgs e)
        {
            bool isValidQuantity = decimal.TryParse(txtQuantity.Text, out decimal quantity);
            bool isValidRate = decimal.TryParse(txtRate.Text, out decimal rate);
            bool isValidAmount = decimal.TryParse(txtAmount.Text, out decimal amount);

            if (isValidQuantity && isValidRate)
            {
                amount = Math.Round(Math.Round(quantity, 2) * Math.Round(rate, 2), 2);
                txtAmount.Text = amount.ToString();
            }
            else if (isValidQuantity && isValidAmount)
            {
                rate = Math.Round(Math.Round(amount, 2) / Math.Round(quantity, 2));
                txtRate.Text = rate.ToString();
            }
            else if (!isValidQuantity && !isValidRate && isValidAmount)
            {
                txtQuantity.Clear();
                txtRate.Clear();
                txtUnit.Clear();
            }
            else if (isValidQuantity && !isValidRate && !isValidAmount)
            {
                txtRate.Clear();
                txtUnit.Clear();
                txtAmount.Clear();
            }
            else
            {
                txtQuantity.Clear();
                txtRate.Clear();
                txtUnit.Clear();
                txtAmount.Clear();
            }
        }
        private void btnProceed_Click(object sender, EventArgs e)
        {
            txtNarration.Focus();
        }

        #region
        private void CalculateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgvAddedItems.Rows)
            {
                if (row.Cells[5].Value != null && decimal.TryParse(row.Cells[5].Value.ToString(), out decimal amount))
                {
                    totalAmount += amount;
                }
            }

            txtTotalAmount.Text = totalAmount.ToString();
        }
        private void dgvAddedItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateTotalAmount();
        }
        private void dgvAddedItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateTotalAmount();
        }
        #endregion

        #region
        private void HandleDgvAddedItemsRowSelection(DataGridViewRow row)
        {
            if (row != null)
            {
                entryTableRowSelectedForUpdate = row.Index;
                txtItemName.Text = dgvAddedItems.Rows[entryTableRowSelectedForUpdate].Cells[1].Value.ToString();
                txtQuantity.Text = dgvAddedItems.Rows[entryTableRowSelectedForUpdate].Cells[2].Value.ToString();
                txtRate.Text = dgvAddedItems.Rows[entryTableRowSelectedForUpdate].Cells[3].Value.ToString();
                txtUnit.Text = dgvAddedItems.Rows[entryTableRowSelectedForUpdate].Cells[4].Value.ToString();
                txtAmount.Text = dgvAddedItems.Rows[entryTableRowSelectedForUpdate].Cells[5].Value.ToString();
                txtItemName.Focus();
                btnDGVhandler.Text = textForUpdateInBtnDgvHandler;
            }
        }
        private void dgvAddedItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvAddedItems.Rows[e.RowIndex];
                HandleDgvAddedItemsRowSelection(selectedRow);
            }
        }
        private void dgvAddedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int deleteColumnIndex = -1;
            int updateColumnIndex = -1;
            foreach (DataGridViewColumn column in dgvAddedItems.Columns)
            {
                if (column.HeaderText == "Delete")
                {
                    deleteColumnIndex = column.Index;
                    if (btnDGVhandler.Text == textForUpdateInBtnDgvHandler)
                    {
                        btnDGVhandler.Text = textForAddInBtnDgvHandler;
                    }
                }
                else if (column.HeaderText == "Update")
                {
                    updateColumnIndex = column.Index;
                }
            }

            if (updateColumnIndex != -1 && e.RowIndex >= 0 && e.RowIndex < dgvAddedItems.Rows.Count && e.ColumnIndex == updateColumnIndex)
            {
                DataGridViewRow selectedRow = dgvAddedItems.Rows[e.RowIndex];
                HandleDgvAddedItemsRowSelection(selectedRow);
            }
            else if (deleteColumnIndex != -1 && e.RowIndex >= 0 && e.RowIndex < dgvAddedItems.Rows.Count && e.ColumnIndex == deleteColumnIndex)
            {
                int rowIndex = e.RowIndex;
                dgvAddedItems.Rows.RemoveAt(rowIndex);
            }
        }

        private void PreparingSalesDT()
        {
            DataGridViewTextBoxColumn itemIdColumn = new DataGridViewTextBoxColumn();
            itemIdColumn.HeaderText = "Item_Id";
            itemIdColumn.Visible = false;

            DataGridViewTextBoxColumn itemNameColumn = new DataGridViewTextBoxColumn();
            itemNameColumn.HeaderText = "Item_Name";

            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
            quantityColumn.HeaderText = "Quantity";
            quantityColumn.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn rateColumn = new DataGridViewTextBoxColumn();
            rateColumn.HeaderText = "Rate";
            rateColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            rateColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            rateColumn.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn unitColumn = new DataGridViewTextBoxColumn();
            unitColumn.HeaderText = "per";
            unitColumn.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.HeaderText = "Amount";

            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.HeaderText = "Update";
            updateButtonColumn.Text = "Update";
            updateButtonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;


            DataGridViewTextBoxColumn blank = new DataGridViewTextBoxColumn();


            dgvAddedItems.Columns.Add(itemIdColumn);
            dgvAddedItems.Columns.Add(itemNameColumn);
            dgvAddedItems.Columns.Add(quantityColumn);
            dgvAddedItems.Columns.Add(rateColumn);
            dgvAddedItems.Columns.Add(unitColumn);
            dgvAddedItems.Columns.Add(amountColumn);
            dgvAddedItems.Columns.Add(updateButtonColumn);
            dgvAddedItems.Columns.Add(deleteButtonColumn);
            dgvAddedItems.Columns.Add(blank);

            itemIdColumn.DataPropertyName = "Item_Id";
            itemNameColumn.DataPropertyName = "Item_Name";
            quantityColumn.DataPropertyName = "Quantity";
            rateColumn.DataPropertyName = "Rate";
            unitColumn.DataPropertyName = "per";
            amountColumn.DataPropertyName = "Amount";

            ThemeColors.SetColumnWidthsInPercentage(dgvAddedItems, 0, 50, 9, 9, 8, 14, 6, 6, 0);

        }
        private void btnDGVhandler_Click(object sender, EventArgs e)
        {
            btnDGVhandler.BackColor = Color.FromArgb(35, 39, 43);
            btnDGVhandler.ForeColor = Color.White;

            if (btnDGVhandler.Text == textForAddInBtnDgvHandler || btnDGVhandler.Text == textForUpdateInBtnDgvHandler)
            {
                string itemName = txtItemName.Text;
                bool isValidQuantity = decimal.TryParse(txtQuantity.Text, out decimal quantity);
                if (isValidQuantity)
                {
                    quantity = Math.Round(quantity, 2);
                }
                bool isValidRate = decimal.TryParse(txtRate.Text, out decimal rate);
                if (isValidRate)
                {
                    rate = Math.Round(rate, 2);
                }
                string unit = txtUnit.Text;
                bool isValidAmount = decimal.TryParse(txtAmount.Text, out decimal amount);
                if (isValidAmount)
                {
                    amount = Math.Round(amount, 2);
                }

                if (btnDGVhandler.Text == textForUpdateInBtnDgvHandler && entryTableRowSelectedForUpdate != -1)
                {
                    dgvAddedItems.Rows[entryTableRowSelectedForUpdate].Cells[0].Value = itemId;
                    dgvAddedItems.Rows[entryTableRowSelectedForUpdate].Cells[1].Value = itemName;
                    dgvAddedItems.Rows[entryTableRowSelectedForUpdate].Cells[2].Value = quantity.ToString("N2");
                    dgvAddedItems.Rows[entryTableRowSelectedForUpdate].Cells[3].Value = rate.ToString("N2");
                    dgvAddedItems.Rows[entryTableRowSelectedForUpdate].Cells[4].Value = unit;
                    dgvAddedItems.Rows[entryTableRowSelectedForUpdate].Cells[5].Value = amount.ToString("N2");
                    entryTableRowSelectedForUpdate = -1;
                    CalculateTotalAmount();
                    txtItemName.Clear();
                    txtQuantity.Clear();
                    txtRate.Clear();
                    txtUnit.Clear();
                    txtAmount.Clear();
                    btnDGVhandler.Text = textForAddMoreInBtnDgvHandler;
                    return;
                }

                DataGridViewRow newRow = new DataGridViewRow();

                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = itemId });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = itemName });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = quantity.ToString("N2") });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = rate.ToString("N2") });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = unit });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = amount.ToString("N2") });

                foreach (DataGridViewCell cell in newRow.Cells)
                {
                    cell.Style.Font = new Font("Arial", 12, FontStyle.Regular);
                }

                if (!string.IsNullOrEmpty(itemName))
                {
                    dgvAddedItems.Rows.Add(newRow);
                    newRow.Height = 30;
                    dgvAddedItems.ClearSelection();

                    txtItemName.Clear();
                    txtQuantity.Clear();
                    txtRate.Clear();
                    txtUnit.Clear();
                    txtAmount.Clear();
                    btnDGVhandler.Text = textForAddMoreInBtnDgvHandler;
                }
                else
                {
                    MessageBox.Show("Invalid");
                    txtItemName.Focus();
                    return;
                }

            }
            else if (btnDGVhandler.Text == textForAddMoreInBtnDgvHandler)
            {
                txtItemName.Focus();
            }
        }
        #endregion

        #region

        private void CeratingVoucherUsingShortCut()
        {
            if (tabControlSales.SelectedIndex != 1) {
                return;
            }
            tabControlSales.SelectedIndex = 0;
            if (dgvSales.SelectedRows.Count > 0)
            {
                CancelEventArgs cancelEventArgs = new CancelEventArgs();

                txtCustomeDate.Text = dgvSales.SelectedRows[0].Cells[1].Value.ToString();
                ValidateDateTextBox(txtCustomeDate, cancelEventArgs);

                txtPartyName.Text = dgvSales.SelectedRows[0].Cells[2].Value.ToString();
                txtFilterPartyName_Validating(txtPartyName, cancelEventArgs);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ShowSaveConfirmation() == false)
            {
                return;
            }
            salesBLL salesbll = new salesBLL();

            bool isValidTotalAmount = decimal.TryParse(txtTotalAmount.Text, out decimal totalAmount);

            if (string.IsNullOrEmpty(txtCustomeDate.Text))
            {
                MessageBox.Show("Date is required");
                txtCustomeDate.Focus();
                return;

            }
            if (string.IsNullOrEmpty(txtPartyName.Text))
            {
                MessageBox.Show("Party name is required");
                txtPartyName.Focus();
                return;
            }
            else if (!isValidTotalAmount)
            {
                MessageBox.Show("Invalid Total Amount");
                txtItemName.Focus();
                return;
            }

            salesbll.voucher = txtVoucher.Text;
            salesbll.date = dateValueforDatabase;
            salesbll.party_id = selectedPartyId;
            salesbll.total_amount = Math.Round(totalAmount, 2);
            salesbll.narration = txtNarration.Text;
            salesbll.added_by = loggedInUserId;
            salesbll.sales_details = salesDT;

            bool success = false;

            using (TransactionScope scope = new TransactionScope())
            {
                int salesSerial = -1;
                bool x = salesdal.Insert(salesbll, out salesSerial);

                foreach (DataGridViewRow row in dgvAddedItems.Rows)
                {
                    salesDetailsBLL salesdetailsbll = new salesDetailsBLL();

                    salesdetailsbll.item_id = int.Parse(row.Cells[0].Value?.ToString());
                    salesdetailsbll.quantity = decimal.Parse(row.Cells[2].Value?.ToString());
                    salesdetailsbll.rate = decimal.Parse(row.Cells[3].Value?.ToString());
                    salesdetailsbll.amount = Math.Round(decimal.Parse(row.Cells[5].Value?.ToString()), 2);
                    salesdetailsbll.serial = salesSerial;
                    salesdetailsbll.party_id = selectedPartyId;
                    salesdetailsbll.added_date = DateTime.Now;
                    salesdetailsbll.added_by = loggedInUserId;

                    bool y = salesdetailsdal.Insert(salesdetailsbll);

                    success = x && y;
                }
                if (success == true)
                {
                    DataTable dt = salesdal.Select(filterPeriodFromforDatabase, filterPeriodToforDatabase, selectedFilterPartyId, selectedFilterUserId);
                    removedRowsTable.Clear();
                    dataView = dt.DefaultView;
                    dataView.Sort = selectedSortBy + sortOrder;
                    bindingSource.DataSource = dataView;

                    scope.Complete();
                    MessageBox.Show("Transaction Successfull");

                    latestSerial = salesSerial + 1;
                    txtSerial.Text = (salesSerial + 1).ToString();
                    txtVoucher.Clear();
                    txtVoucher.Focus();
                    txtPartyName.Clear();
                    dgvAddedItems.Rows.Clear();
                    txtItemName.Clear();
                    txtQuantity.Clear();
                    txtRate.Clear();
                    txtUnit.Clear();
                    txtAmount.Clear();
                    txtNarration.Clear();
                    txtTotalAmount.Clear();
                }
                else
                {
                    MessageBox.Show("Transaction Failed");
                }
            }
        }
        private bool ShowSaveConfirmation()
        {
            var result = MessageBox.Show("Are you sure want to save?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
        #endregion

        #region
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ShowUpdateConfirmation() == false) {
                return;
            }
            salesBLL salesbll = new salesBLL();
            salesDetailsBLL salesdetailsbll = new salesDetailsBLL();

            bool isValidSerial = int.TryParse(txtSerial.Text, out int serial);
            bool isValidTotalAmount = decimal.TryParse(txtTotalAmount.Text, out decimal totalAmount);

            if (!isValidSerial)
            {
                MessageBox.Show("Serial is not valid");
                return;
            }
            if (string.IsNullOrEmpty(txtCustomeDate.Text))
            {
                MessageBox.Show("Date is required");
                txtCustomeDate.Focus();
                return;

            }
            if (string.IsNullOrEmpty(txtPartyName.Text))
            {
                MessageBox.Show("Party name is required");
                txtPartyName.Focus();
                return;
            }
            if (!isValidTotalAmount)
            {
                MessageBox.Show("Invalid Total Amount");
                txtItemName.Focus();
                return;
            }

            salesbll.voucher = txtVoucher.Text;
            salesbll.date = dateValueforDatabase;
            salesbll.party_id = selectedPartyId;
            salesbll.total_amount = Math.Round(totalAmount, 2);
            salesbll.narration = txtNarration.Text;
            salesbll.added_by = loggedInUserId;
            salesbll.serial = serial;

            bool success = false;

            using (TransactionScope scope = new TransactionScope())
            {
                bool x = salesdal.Update(salesbll);

                salesdetailsbll.serial = serial;
                bool y = salesdetailsdal.Delete(salesdetailsbll);

                foreach (DataGridViewRow row in dgvAddedItems.Rows)
                {
                    salesdetailsbll.item_id = int.Parse(row.Cells[0].Value?.ToString());
                    salesdetailsbll.quantity = decimal.Parse(row.Cells[2].Value?.ToString());
                    salesdetailsbll.rate = decimal.Parse(row.Cells[3].Value?.ToString());
                    salesdetailsbll.amount = Math.Round(decimal.Parse(row.Cells[5].Value?.ToString()), 2);
                    salesdetailsbll.serial = serial;
                    salesdetailsbll.party_id = selectedPartyId;
                    salesdetailsbll.added_date = DateTime.Now;
                    salesdetailsbll.added_by = loggedInUserId;

                    bool z = salesdetailsdal.Insert(salesdetailsbll);

                    success = x && y && z;
                }
                if (success == true)
                {
                    DataTable dt = salesdal.Select(filterPeriodFromforDatabase, filterPeriodToforDatabase, selectedFilterPartyId, selectedFilterUserId);
                    removedRowsTable.Clear();
                    dataView = dt.DefaultView;
                    dataView.Sort = selectedSortBy + sortOrder;
                    bindingSource.DataSource = dataView;

                    scope.Complete();
                    MessageBox.Show("Updated Successfully");
                    txtVoucher.Focus();
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }
        }
        private bool ShowUpdateConfirmation()
        {
            var result = MessageBox.Show("Are you sure want to update?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
        #endregion

        #region

        private void DeleteFunctionality(int serial)
        {
            if (ShowDeleteConfirmation() == false)
            {
                return;
            }

            salesBLL salesbll = new salesBLL();
            salesDetailsBLL salesdetailsbll = new salesDetailsBLL();

            salesbll.serial = serial;

            bool success = false;

            using (TransactionScope scope = new TransactionScope())
            {
                bool x = salesdal.Delete(salesbll);

                salesdetailsbll.serial = salesbll.serial; // Use the same serial for deletion in both tables

                bool y = salesdetailsdal.Delete(salesdetailsbll);

                success = x && y;

                if (success)
                {
                    // Refresh the DataGridView after successful deletion
                    DataTable dt = salesdal.Select(filterPeriodFromforDatabase, filterPeriodToforDatabase, selectedFilterPartyId, selectedFilterUserId);
                    removedRowsTable.Clear();
                    dataView = dt.DefaultView;
                    dataView.Sort = selectedSortBy + sortOrder;
                    bindingSource.DataSource = dataView;

                    scope.Complete();
                    MessageBox.Show("Deleted Successfully");

                    // Clear controls or perform any other necessary operations after deletion
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;

                    txtVoucher.Clear();
                    txtVoucher.Focus();
                    txtCustomeDate.Clear();
                    txtPartyName.Clear();
                    dgvAddedItems.Rows.Clear();
                    txtItemName.Clear();
                    txtQuantity.Clear();
                    txtRate.Clear();
                    txtUnit.Clear();
                    txtAmount.Clear();
                    txtNarration.Clear();
                    txtTotalAmount.Clear();
                    txtCreatedByName.Clear();
                }
                else
                {
                    MessageBox.Show("Delete Failed");
                }
            }
        }

        private void DeleteFunctionalityUsingShortcut()
        {
            if (dgvSales.SelectedRows.Count > 0)
            {
                int serialColumnIndex = 0;
                bool isValidSerial = int.TryParse(dgvSales.SelectedRows[0].Cells[serialColumnIndex].Value.ToString(), out int serial);
                if (!isValidSerial)
                {
                    MessageBox.Show("Serial is not valid");
                    return;
                }
                DeleteFunctionality(serial);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool isValidSerial = int.TryParse(txtSerial.Text, out int serial);
            if (!isValidSerial)
            {
                MessageBox.Show("Serial is not valid");
                return;
            }

            DeleteFunctionality(serial);
        }

        private bool ShowDeleteConfirmation()
        {
            var result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
        #endregion
        private void txtNarration_TextChanged(object sender, EventArgs e)
        {
            string userInput = txtNarration.Text;

            listBoxNarration.Items.Clear();
            listBoxNarration.Visible = !string.IsNullOrEmpty(userInput);

            if (!string.IsNullOrEmpty(userInput))
            {
                string[] suggestions = allSalesData.Values
                    .Where(s => s.IndexOf(userInput, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToArray();

                listBoxNarration.Items.AddRange(suggestions);
            }
        }
        private void listBoxNarration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNarration.SelectedIndex >= 0)
            {
                txtNarration.Text = listBoxNarration.SelectedItem.ToString();
                listBoxNarration.Visible = false;
                txtNarration.Focus();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clear(true);
        }

        #region

        private void txtFilterSearch_TextChanged(object sender, EventArgs e)
        {
            FilterData(txtFilterSearch.Text);
            DisplayTotalCount();
        }
        private void FilterData(string keyword)
        {
            bindingSource.Filter = "";

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                List<string> filterExpressions = new List<string>();
                foreach (DataGridViewColumn column in dgvSales.Columns)
                {
                    if (column.ValueType == typeof(string))
                    {
                        filterExpressions.Add($"{column.DataPropertyName} LIKE '%{keyword}%'");
                    }
                    else if (IsNumericType(column.ValueType))
                    {
                        filterExpressions.Add($"Convert({column.DataPropertyName}, 'System.String') LIKE '%{keyword}%'");
                    }
                }
                string filterExpression = string.Join(" OR ", filterExpressions);

                bindingSource.Filter = filterExpression;
            }
        }

        private bool IsNumericType(Type type)
        {
            return type == typeof(int) || type == typeof(decimal) || type == typeof(double) || type == typeof(float);
        }
        #endregion


        #region
        private void printDgvSales_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintDataGridView(dgvSales, e.Graphics, new Rectangle(100, 100, 500, 300));
        }
        public static void PrintDataGridView(DataGridView dataGridView, Graphics graphics, Rectangle printArea)
        {
            int rowCount = dataGridView.Rows.Count;
            int columnCount = dataGridView.Columns.Count;
            float x = printArea.X;
            float y = printArea.Y;

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    object cellValue = dataGridView[col, row].Value;
                    string cellText = (cellValue != null) ? cellValue.ToString() : "";
                    graphics.DrawString(cellText, dataGridView.Font, Brushes.Black, x, y);
                    x += printArea.Width / columnCount;
                }
                x = printArea.X;
                y += printArea.Height / rowCount;
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<int> columnsToShow = new List<int> { 0, 1, 2, 6 };
            List<float> columnWidths = new List<float> { 20, 20, 20, 40 };
            float tableLeftMargin = 10;
            float tableRightMargin = 10;
            GenerateAndDownloadPDF(dgvSales, columnsToShow, columnWidths, tableLeftMargin, tableRightMargin);
        }

        private void GenerateAndDownloadPDF(DataGridView dataGridView, List<int> columnsToShow, List<float> columnWidths, float tableLeftMargin, float tableRightMargin)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                    sfd.FileName = "DataGridViewExport.pdf";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Document pdfDoc = new Document(PageSize.A4);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));

                        pdfDoc.Open();
                        PdfPTable mainTable = new PdfPTable(1);
                        mainTable.WidthPercentage = 100;

                        for (int row = 0; row < dataGridView.Rows.Count; row++)
                        {
                            // Create a new table for each sale and its details
                            PdfPTable saleTable = new PdfPTable(columnsToShow.Count);
                            saleTable.DefaultCell.PaddingLeft = tableLeftMargin;
                            saleTable.DefaultCell.PaddingRight = tableRightMargin;
                            float totalWidth = PageSize.A4.Width - (tableLeftMargin + tableRightMargin);
                            float[] columnWidthsAbs = columnWidths.ConvertAll(width => width * totalWidth / 100f).ToArray();
                            saleTable.SetTotalWidth(columnWidthsAbs);

                            // Add header cells to the sale table
                            for (int i = 0; i < columnsToShow.Count; i++)
                            {
                                int colIndex = columnsToShow[i];
                                saleTable.AddCell(new PdfPCell(new Phrase(dataGridView.Columns[colIndex].HeaderText)));
                            }

                            // Add sale data to the sale table
                            for (int i = 0; i < columnsToShow.Count; i++)
                            {
                                int colIndex = columnsToShow[i];
                                object cellValue = dataGridView[colIndex, row].Value;
                                saleTable.AddCell(new PdfPCell(new Phrase(cellValue != null ? cellValue.ToString() : "")));
                            }

                            // Retrieve sale details for the current row
                            DataTable saleDetailsTable = GetSaleDetails(dataGridView, row);

                            // Add sale details as new rows below the sale row
                            if (saleDetailsTable != null && saleDetailsTable.Rows.Count > 0)
                            {
                                for (int detailRow = 0; detailRow < saleDetailsTable.Rows.Count; detailRow++)
                                {
                                    for (int i = 0; i < columnsToShow.Count; i++)
                                    {
                                        int colIndex = columnsToShow[i];
                                        if (colIndex == 0)
                                        {
                                            continue; // Skip the first column (sale column) when adding sale details
                                        }

                                        object detailCellValue = saleDetailsTable.Rows[detailRow][colIndex - 1];
                                        saleTable.AddCell(new PdfPCell(new Phrase(detailCellValue != null ? detailCellValue.ToString() : "")));
                                    }
                                }
                            }

                            // Add the sale table as a new row in the main table
                            PdfPCell saleCell = new PdfPCell(saleTable);
                            saleCell.Colspan = 1;
                            mainTable.AddCell(saleCell);
                        }

                        // Add the main table to the document
                        pdfDoc.Add(mainTable);
                        pdfDoc.Close();

                        MessageBox.Show("PDF file has been generated and saved.", "PDF Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetSaleDetails(DataGridView dataGridView, int rowIndex)
        {
            int serial = Convert.ToInt32(dataGridView["serial", rowIndex].Value);
            salesDetailsBLL salesDetails = new salesDetailsBLL();
            salesDetails.serial = serial;
            DataTable saleDetailsTable = salesdetailsdal.SingleSelect(salesDetails);

            return saleDetailsTable;
        }
        #endregion

        
    }
}
