namespace bharatplantdesktop.UI
{
    partial class frmSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlSales = new System.Windows.Forms.TabControl();
            this.tabPageEntry = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCreatedByName = new System.Windows.Forms.Label();
            this.txtCreatedByName = new System.Windows.Forms.TextBox();
            this.listBoxNarration = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.pnlTrnDtl = new System.Windows.Forms.Panel();
            this.btnProceed = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.btnDGVhandler = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAddedItems = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtCustomeDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtPartyName = new System.Windows.Forms.TextBox();
            this.lblPartyName = new System.Windows.Forms.Label();
            this.txtVoucher = new System.Windows.Forms.TextBox();
            this.lblVoucher = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDgvCurrentTotal = new System.Windows.Forms.TextBox();
            this.lblDgvCurrentTotal = new System.Windows.Forms.Label();
            this.lblSortyBy = new System.Windows.Forms.Label();
            this.cmbSortingOptions = new System.Windows.Forms.ComboBox();
            this.txtSalesCount = new System.Windows.Forms.TextBox();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.txtFilterPartyName = new System.Windows.Forms.TextBox();
            this.txtFilterPeriodTo = new System.Windows.Forms.TextBox();
            this.lblFilterFromPeriod = new System.Windows.Forms.Label();
            this.txtFilterPeriodFrom = new System.Windows.Forms.TextBox();
            this.lblFilterPeriodTo = new System.Windows.Forms.Label();
            this.checkBoxFilterCreatedBy = new System.Windows.Forms.CheckBox();
            this.lblFilterPartyName = new System.Windows.Forms.Label();
            this.txtFilterCreatedBy = new System.Windows.Forms.TextBox();
            this.checkBoxFilterPartyName = new System.Windows.Forms.CheckBox();
            this.lblFilterCreatedBy = new System.Windows.Forms.Label();
            this.lblFilterSearch = new System.Windows.Forms.Label();
            this.txtFilterSearch = new System.Windows.Forms.TextBox();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bharatPlantDesktopDataSet1 = new bharatplantdesktop.BharatPlantDesktopDataSet();
            this.printDgvSales = new System.Drawing.Printing.PrintDocument();
            this.tabControlSales.SuspendLayout();
            this.tabPageEntry.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlTrnDtl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageReport.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bharatPlantDesktopDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSales
            // 
            this.tabControlSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSales.Controls.Add(this.tabPageEntry);
            this.tabControlSales.Controls.Add(this.tabPageReport);
            this.tabControlSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSales.Location = new System.Drawing.Point(0, 0);
            this.tabControlSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlSales.Name = "tabControlSales";
            this.tabControlSales.SelectedIndex = 0;
            this.tabControlSales.Size = new System.Drawing.Size(1660, 967);
            this.tabControlSales.TabIndex = 0;
            this.tabControlSales.TabStop = false;
            this.tabControlSales.SelectedIndexChanged += new System.EventHandler(this.tabControlSales_SelectedIndexChanged);
            this.tabControlSales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControlSales_KeyDown);
            // 
            // tabPageEntry
            // 
            this.tabPageEntry.BackColor = System.Drawing.Color.Transparent;
            this.tabPageEntry.Controls.Add(this.panel3);
            this.tabPageEntry.Controls.Add(this.pnlTrnDtl);
            this.tabPageEntry.Controls.Add(this.panel2);
            this.tabPageEntry.Controls.Add(this.panel1);
            this.tabPageEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageEntry.Location = new System.Drawing.Point(4, 40);
            this.tabPageEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageEntry.Name = "tabPageEntry";
            this.tabPageEntry.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageEntry.Size = new System.Drawing.Size(1652, 923);
            this.tabPageEntry.TabIndex = 0;
            this.tabPageEntry.Text = "Entry";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCreatedByName);
            this.panel3.Controls.Add(this.txtCreatedByName);
            this.panel3.Controls.Add(this.listBoxNarration);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.lblTotalAmount);
            this.panel3.Controls.Add(this.txtTotalAmount);
            this.panel3.Controls.Add(this.txtNarration);
            this.panel3.Controls.Add(this.lblNarration);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 673);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1646, 246);
            this.panel3.TabIndex = 26;
            // 
            // lblCreatedByName
            // 
            this.lblCreatedByName.AutoSize = true;
            this.lblCreatedByName.Location = new System.Drawing.Point(937, 203);
            this.lblCreatedByName.Name = "lblCreatedByName";
            this.lblCreatedByName.Size = new System.Drawing.Size(105, 22);
            this.lblCreatedByName.TabIndex = 37;
            this.lblCreatedByName.Text = "Created By:";
            this.lblCreatedByName.Visible = false;
            // 
            // txtCreatedByName
            // 
            this.txtCreatedByName.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatedByName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedByName.Location = new System.Drawing.Point(1048, 203);
            this.txtCreatedByName.Name = "txtCreatedByName";
            this.txtCreatedByName.Size = new System.Drawing.Size(543, 27);
            this.txtCreatedByName.TabIndex = 0;
            this.txtCreatedByName.TabStop = false;
            this.txtCreatedByName.Visible = false;
            // 
            // listBoxNarration
            // 
            this.listBoxNarration.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxNarration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNarration.FormattingEnabled = true;
            this.listBoxNarration.ItemHeight = 22;
            this.listBoxNarration.Location = new System.Drawing.Point(60, 140);
            this.listBoxNarration.Name = "listBoxNarration";
            this.listBoxNarration.Size = new System.Drawing.Size(806, 88);
            this.listBoxNarration.TabIndex = 0;
            this.listBoxNarration.TabStop = false;
            this.listBoxNarration.Visible = false;
            this.listBoxNarration.SelectedIndexChanged += new System.EventHandler(this.listBoxNarration_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(1269, 144);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 44);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(1433, 144);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(158, 44);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(1105, 144);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 44);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(941, 144);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 44);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(1373, 69);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(117, 22);
            this.lblTotalAmount.TabIndex = 35;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(1377, 95);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(214, 41);
            this.txtTotalAmount.TabIndex = 0;
            this.txtTotalAmount.TabStop = false;
            // 
            // txtNarration
            // 
            this.txtNarration.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNarration.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNarration.BackColor = System.Drawing.SystemColors.Control;
            this.txtNarration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNarration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNarration.Location = new System.Drawing.Point(60, 56);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(806, 80);
            this.txtNarration.TabIndex = 11;
            this.txtNarration.TextChanged += new System.EventHandler(this.txtNarration_TextChanged);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.Location = new System.Drawing.Point(56, 30);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(89, 22);
            this.lblNarration.TabIndex = 34;
            this.lblNarration.Text = "Narration:";
            // 
            // pnlTrnDtl
            // 
            this.pnlTrnDtl.Controls.Add(this.btnProceed);
            this.pnlTrnDtl.Controls.Add(this.lblAmount);
            this.pnlTrnDtl.Controls.Add(this.lblUnit);
            this.pnlTrnDtl.Controls.Add(this.lblItemName);
            this.pnlTrnDtl.Controls.Add(this.lblQuantity);
            this.pnlTrnDtl.Controls.Add(this.lblRate);
            this.pnlTrnDtl.Controls.Add(this.btnDGVhandler);
            this.pnlTrnDtl.Controls.Add(this.txtAmount);
            this.pnlTrnDtl.Controls.Add(this.txtUnit);
            this.pnlTrnDtl.Controls.Add(this.txtQuantity);
            this.pnlTrnDtl.Controls.Add(this.txtItemName);
            this.pnlTrnDtl.Controls.Add(this.txtRate);
            this.pnlTrnDtl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTrnDtl.Location = new System.Drawing.Point(3, 567);
            this.pnlTrnDtl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTrnDtl.Name = "pnlTrnDtl";
            this.pnlTrnDtl.Size = new System.Drawing.Size(1646, 106);
            this.pnlTrnDtl.TabIndex = 25;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.Transparent;
            this.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProceed.FlatAppearance.BorderSize = 2;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.Location = new System.Drawing.Point(1451, 43);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(140, 38);
            this.btnProceed.TabIndex = 10;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(1160, 28);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(71, 22);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "Amount";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(1040, 28);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(36, 22);
            this.lblUnit.TabIndex = 12;
            this.lblUnit.Text = "per";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(56, 28);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(95, 22);
            this.lblItemName.TabIndex = 9;
            this.lblItemName.Text = "Item Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(789, 28);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(77, 22);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(990, 28);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(48, 22);
            this.lblRate.TabIndex = 11;
            this.lblRate.Text = "Rate";
            // 
            // btnDGVhandler
            // 
            this.btnDGVhandler.BackColor = System.Drawing.Color.Transparent;
            this.btnDGVhandler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDGVhandler.FlatAppearance.BorderSize = 2;
            this.btnDGVhandler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDGVhandler.Location = new System.Drawing.Point(1305, 43);
            this.btnDGVhandler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDGVhandler.Name = "btnDGVhandler";
            this.btnDGVhandler.Size = new System.Drawing.Size(140, 38);
            this.btnDGVhandler.TabIndex = 9;
            this.btnDGVhandler.Text = "ADD";
            this.btnDGVhandler.UseVisualStyleBackColor = false;
            this.btnDGVhandler.Click += new System.EventHandler(this.btnDGVhandler_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.AcceptsTab = true;
            this.txtAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(1164, 54);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(133, 27);
            this.txtAmount.TabIndex = 8;
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // txtUnit
            // 
            this.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(1044, 54);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(60, 27);
            this.txtUnit.TabIndex = 0;
            this.txtUnit.TabStop = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(793, 54);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(115, 27);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantity_Validating);
            // 
            // txtItemName
            // 
            this.txtItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtItemName.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(60, 54);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(348, 27);
            this.txtItemName.TabIndex = 5;
            this.txtItemName.Validating += new System.ComponentModel.CancelEventHandler(this.txtItemName_Validating);
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.SystemColors.Control;
            this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(950, 54);
            this.txtRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRate.Name = "txtRate";
            this.txtRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRate.Size = new System.Drawing.Size(88, 27);
            this.txtRate.TabIndex = 7;
            this.txtRate.Enter += new System.EventHandler(this.txtRate_Enter);
            this.txtRate.Leave += new System.EventHandler(this.txtRate_Leave);
            this.txtRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtRate_Validating);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAddedItems);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 196);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1646, 371);
            this.panel2.TabIndex = 24;
            // 
            // dgvAddedItems
            // 
            this.dgvAddedItems.AllowUserToAddRows = false;
            this.dgvAddedItems.AllowUserToDeleteRows = false;
            this.dgvAddedItems.AllowUserToResizeColumns = false;
            this.dgvAddedItems.AllowUserToResizeRows = false;
            this.dgvAddedItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAddedItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAddedItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddedItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddedItems.ColumnHeadersHeight = 40;
            this.dgvAddedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAddedItems.EnableHeadersVisualStyles = false;
            this.dgvAddedItems.Location = new System.Drawing.Point(60, 0);
            this.dgvAddedItems.Name = "dgvAddedItems";
            this.dgvAddedItems.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddedItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddedItems.RowHeadersVisible = false;
            this.dgvAddedItems.RowHeadersWidth = 51;
            this.dgvAddedItems.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAddedItems.RowTemplate.DividerHeight = 1;
            this.dgvAddedItems.RowTemplate.Height = 30;
            this.dgvAddedItems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddedItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddedItems.Size = new System.Drawing.Size(1531, 371);
            this.dgvAddedItems.TabIndex = 0;
            this.dgvAddedItems.TabStop = false;
            this.dgvAddedItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddedItems_CellContentClick);
            this.dgvAddedItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddedItems_CellDoubleClick);
            this.dgvAddedItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAddedItems_RowsAdded);
            this.dgvAddedItems.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvAddedItems_RowsRemoved);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.txtDay);
            this.panel1.Controls.Add(this.txtCustomeDate);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.txtPartyName);
            this.panel1.Controls.Add(this.lblPartyName);
            this.panel1.Controls.Add(this.txtVoucher);
            this.panel1.Controls.Add(this.lblVoucher);
            this.panel1.Controls.Add(this.txtSerial);
            this.panel1.Controls.Add(this.lblSerial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1646, 192);
            this.panel1.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1510, 36);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(81, 27);
            this.btnNext.TabIndex = 0;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(1424, 36);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(81, 27);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.TabStop = false;
            this.btnPrev.Text = "Prev";
            this.btnPrev.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtDay
            // 
            this.txtDay.BackColor = System.Drawing.SystemColors.Control;
            this.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDay.Location = new System.Drawing.Point(1491, 118);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(100, 23);
            this.txtDay.TabIndex = 0;
            this.txtDay.TabStop = false;
            this.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCustomeDate
            // 
            this.txtCustomeDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtCustomeDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomeDate.Location = new System.Drawing.Point(1468, 95);
            this.txtCustomeDate.Name = "txtCustomeDate";
            this.txtCustomeDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCustomeDate.Size = new System.Drawing.Size(123, 27);
            this.txtCustomeDate.TabIndex = 3;
            this.txtCustomeDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCustomeDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustomeDate_Validating);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(1420, 95);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 22);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // txtPartyName
            // 
            this.txtPartyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPartyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPartyName.BackColor = System.Drawing.SystemColors.Control;
            this.txtPartyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPartyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartyName.Location = new System.Drawing.Point(172, 130);
            this.txtPartyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(427, 27);
            this.txtPartyName.TabIndex = 4;
            this.txtPartyName.Validating += new System.ComponentModel.CancelEventHandler(this.txtPartyName_Validating);
            // 
            // lblPartyName
            // 
            this.lblPartyName.AutoSize = true;
            this.lblPartyName.Location = new System.Drawing.Point(56, 130);
            this.lblPartyName.Name = "lblPartyName";
            this.lblPartyName.Size = new System.Drawing.Size(109, 22);
            this.lblPartyName.TabIndex = 0;
            this.lblPartyName.Text = "Party Name:";
            // 
            // txtVoucher
            // 
            this.txtVoucher.BackColor = System.Drawing.SystemColors.Control;
            this.txtVoucher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucher.Location = new System.Drawing.Point(172, 95);
            this.txtVoucher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.Size = new System.Drawing.Size(208, 27);
            this.txtVoucher.TabIndex = 2;
            // 
            // lblVoucher
            // 
            this.lblVoucher.AutoSize = true;
            this.lblVoucher.Location = new System.Drawing.Point(56, 95);
            this.lblVoucher.Name = "lblVoucher";
            this.lblVoucher.Size = new System.Drawing.Size(110, 22);
            this.lblVoucher.TabIndex = 0;
            this.lblVoucher.Text = "Voucher No.";
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(123, 36);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(236, 27);
            this.txtSerial.TabIndex = 1;
            this.txtSerial.TabStop = false;
            this.txtSerial.TextChanged += new System.EventHandler(this.txtSerial_TextChanged);
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(56, 36);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(61, 22);
            this.lblSerial.TabIndex = 0;
            this.lblSerial.Text = "Serial:";
            // 
            // tabPageReport
            // 
            this.tabPageReport.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageReport.Controls.Add(this.btnPrint);
            this.tabPageReport.Controls.Add(this.panel4);
            this.tabPageReport.Controls.Add(this.lblSortyBy);
            this.tabPageReport.Controls.Add(this.cmbSortingOptions);
            this.tabPageReport.Controls.Add(this.txtSalesCount);
            this.tabPageReport.Controls.Add(this.pnlFilter);
            this.tabPageReport.Controls.Add(this.lblFilterSearch);
            this.tabPageReport.Controls.Add(this.txtFilterSearch);
            this.tabPageReport.Controls.Add(this.dgvSales);
            this.tabPageReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageReport.Location = new System.Drawing.Point(4, 40);
            this.tabPageReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageReport.Size = new System.Drawing.Size(1652, 923);
            this.tabPageReport.TabIndex = 1;
            this.tabPageReport.Text = "Report";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1327, 75);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtDgvCurrentTotal);
            this.panel4.Controls.Add(this.lblDgvCurrentTotal);
            this.panel4.Location = new System.Drawing.Point(24, 871);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1607, 44);
            this.panel4.TabIndex = 22;
            // 
            // txtDgvCurrentTotal
            // 
            this.txtDgvCurrentTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDgvCurrentTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDgvCurrentTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDgvCurrentTotal.Location = new System.Drawing.Point(1402, 6);
            this.txtDgvCurrentTotal.Margin = new System.Windows.Forms.Padding(0);
            this.txtDgvCurrentTotal.Name = "txtDgvCurrentTotal";
            this.txtDgvCurrentTotal.Size = new System.Drawing.Size(204, 29);
            this.txtDgvCurrentTotal.TabIndex = 16;
            // 
            // lblDgvCurrentTotal
            // 
            this.lblDgvCurrentTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDgvCurrentTotal.AutoSize = true;
            this.lblDgvCurrentTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDgvCurrentTotal.Location = new System.Drawing.Point(1210, 6);
            this.lblDgvCurrentTotal.Name = "lblDgvCurrentTotal";
            this.lblDgvCurrentTotal.Size = new System.Drawing.Size(68, 25);
            this.lblDgvCurrentTotal.TabIndex = 17;
            this.lblDgvCurrentTotal.Text = "Total:";
            // 
            // lblSortyBy
            // 
            this.lblSortyBy.AutoSize = true;
            this.lblSortyBy.Location = new System.Drawing.Point(477, 76);
            this.lblSortyBy.Name = "lblSortyBy";
            this.lblSortyBy.Size = new System.Drawing.Size(83, 22);
            this.lblSortyBy.TabIndex = 15;
            this.lblSortyBy.Text = "Sorty By:";
            // 
            // cmbSortingOptions
            // 
            this.cmbSortingOptions.BackColor = System.Drawing.SystemColors.Control;
            this.cmbSortingOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortingOptions.FormattingEnabled = true;
            this.cmbSortingOptions.Location = new System.Drawing.Point(566, 68);
            this.cmbSortingOptions.MaxDropDownItems = 100;
            this.cmbSortingOptions.Name = "cmbSortingOptions";
            this.cmbSortingOptions.Size = new System.Drawing.Size(237, 37);
            this.cmbSortingOptions.TabIndex = 8;
            this.cmbSortingOptions.SelectedIndexChanged += new System.EventHandler(this.cmbSortingOptions_SelectedIndexChanged);
            // 
            // txtSalesCount
            // 
            this.txtSalesCount.BackColor = System.Drawing.SystemColors.Control;
            this.txtSalesCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesCount.Location = new System.Drawing.Point(1408, 78);
            this.txtSalesCount.Name = "txtSalesCount";
            this.txtSalesCount.ReadOnly = true;
            this.txtSalesCount.Size = new System.Drawing.Size(236, 27);
            this.txtSalesCount.TabIndex = 0;
            this.txtSalesCount.TabStop = false;
            this.txtSalesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.txtFilterPartyName);
            this.pnlFilter.Controls.Add(this.txtFilterPeriodTo);
            this.pnlFilter.Controls.Add(this.lblFilterFromPeriod);
            this.pnlFilter.Controls.Add(this.txtFilterPeriodFrom);
            this.pnlFilter.Controls.Add(this.lblFilterPeriodTo);
            this.pnlFilter.Controls.Add(this.checkBoxFilterCreatedBy);
            this.pnlFilter.Controls.Add(this.lblFilterPartyName);
            this.pnlFilter.Controls.Add(this.txtFilterCreatedBy);
            this.pnlFilter.Controls.Add(this.checkBoxFilterPartyName);
            this.pnlFilter.Controls.Add(this.lblFilterCreatedBy);
            this.pnlFilter.Location = new System.Drawing.Point(24, 7);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1607, 42);
            this.pnlFilter.TabIndex = 0;
            // 
            // txtFilterPartyName
            // 
            this.txtFilterPartyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFilterPartyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFilterPartyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFilterPartyName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilterPartyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterPartyName.Enabled = false;
            this.txtFilterPartyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterPartyName.Location = new System.Drawing.Point(634, 7);
            this.txtFilterPartyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterPartyName.Name = "txtFilterPartyName";
            this.txtFilterPartyName.Size = new System.Drawing.Size(427, 34);
            this.txtFilterPartyName.TabIndex = 3;
            this.txtFilterPartyName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterPartyName_Validating);
            this.txtFilterPartyName.Validated += new System.EventHandler(this.txtFilterPartyName_Validated);
            // 
            // txtFilterPeriodTo
            // 
            this.txtFilterPeriodTo.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilterPeriodTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilterPeriodTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterPeriodTo.Location = new System.Drawing.Point(305, 7);
            this.txtFilterPeriodTo.Name = "txtFilterPeriodTo";
            this.txtFilterPeriodTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFilterPeriodTo.Size = new System.Drawing.Size(123, 27);
            this.txtFilterPeriodTo.TabIndex = 2;
            this.txtFilterPeriodTo.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterPeriodTo_Validating);
            this.txtFilterPeriodTo.Validated += new System.EventHandler(this.txtFilterPeriodTo_Validated);
            // 
            // lblFilterFromPeriod
            // 
            this.lblFilterFromPeriod.AutoSize = true;
            this.lblFilterFromPeriod.Location = new System.Drawing.Point(3, 7);
            this.lblFilterFromPeriod.Name = "lblFilterFromPeriod";
            this.lblFilterFromPeriod.Size = new System.Drawing.Size(113, 22);
            this.lblFilterFromPeriod.TabIndex = 4;
            this.lblFilterFromPeriod.Text = "Period From:";
            // 
            // txtFilterPeriodFrom
            // 
            this.txtFilterPeriodFrom.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilterPeriodFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilterPeriodFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterPeriodFrom.Location = new System.Drawing.Point(131, 7);
            this.txtFilterPeriodFrom.Name = "txtFilterPeriodFrom";
            this.txtFilterPeriodFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFilterPeriodFrom.Size = new System.Drawing.Size(123, 27);
            this.txtFilterPeriodFrom.TabIndex = 1;
            this.txtFilterPeriodFrom.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterPeriodFrom_Validating);
            // 
            // lblFilterPeriodTo
            // 
            this.lblFilterPeriodTo.AutoSize = true;
            this.lblFilterPeriodTo.Location = new System.Drawing.Point(260, 7);
            this.lblFilterPeriodTo.Name = "lblFilterPeriodTo";
            this.lblFilterPeriodTo.Size = new System.Drawing.Size(37, 22);
            this.lblFilterPeriodTo.TabIndex = 6;
            this.lblFilterPeriodTo.Text = "To:";
            // 
            // checkBoxFilterCreatedBy
            // 
            this.checkBoxFilterCreatedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFilterCreatedBy.AutoSize = true;
            this.checkBoxFilterCreatedBy.Location = new System.Drawing.Point(1579, 7);
            this.checkBoxFilterCreatedBy.Name = "checkBoxFilterCreatedBy";
            this.checkBoxFilterCreatedBy.Size = new System.Drawing.Size(18, 17);
            this.checkBoxFilterCreatedBy.TabIndex = 6;
            this.checkBoxFilterCreatedBy.UseVisualStyleBackColor = true;
            this.checkBoxFilterCreatedBy.CheckedChanged += new System.EventHandler(this.checkBoxFilterCreatedBy_CheckedChanged);
            // 
            // lblFilterPartyName
            // 
            this.lblFilterPartyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFilterPartyName.AutoSize = true;
            this.lblFilterPartyName.Location = new System.Drawing.Point(519, 7);
            this.lblFilterPartyName.Name = "lblFilterPartyName";
            this.lblFilterPartyName.Size = new System.Drawing.Size(109, 22);
            this.lblFilterPartyName.TabIndex = 8;
            this.lblFilterPartyName.Text = "Party Name:";
            // 
            // txtFilterCreatedBy
            // 
            this.txtFilterCreatedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterCreatedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFilterCreatedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFilterCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilterCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterCreatedBy.Enabled = false;
            this.txtFilterCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterCreatedBy.Location = new System.Drawing.Point(1249, 7);
            this.txtFilterCreatedBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterCreatedBy.Name = "txtFilterCreatedBy";
            this.txtFilterCreatedBy.Size = new System.Drawing.Size(324, 34);
            this.txtFilterCreatedBy.TabIndex = 5;
            this.txtFilterCreatedBy.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterCreatedBy_Validating);
            this.txtFilterCreatedBy.Validated += new System.EventHandler(this.txtFilterCreatedBy_Validated);
            // 
            // checkBoxFilterPartyName
            // 
            this.checkBoxFilterPartyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxFilterPartyName.AutoSize = true;
            this.checkBoxFilterPartyName.Location = new System.Drawing.Point(1067, 7);
            this.checkBoxFilterPartyName.Name = "checkBoxFilterPartyName";
            this.checkBoxFilterPartyName.Size = new System.Drawing.Size(18, 17);
            this.checkBoxFilterPartyName.TabIndex = 4;
            this.checkBoxFilterPartyName.UseVisualStyleBackColor = true;
            this.checkBoxFilterPartyName.CheckedChanged += new System.EventHandler(this.checkBoxFilterPartyName_CheckedChanged);
            // 
            // lblFilterCreatedBy
            // 
            this.lblFilterCreatedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterCreatedBy.AutoSize = true;
            this.lblFilterCreatedBy.Location = new System.Drawing.Point(1138, 4);
            this.lblFilterCreatedBy.Name = "lblFilterCreatedBy";
            this.lblFilterCreatedBy.Size = new System.Drawing.Size(105, 22);
            this.lblFilterCreatedBy.TabIndex = 14;
            this.lblFilterCreatedBy.Text = "Created By:";
            // 
            // lblFilterSearch
            // 
            this.lblFilterSearch.AutoSize = true;
            this.lblFilterSearch.Location = new System.Drawing.Point(20, 76);
            this.lblFilterSearch.Name = "lblFilterSearch";
            this.lblFilterSearch.Size = new System.Drawing.Size(72, 22);
            this.lblFilterSearch.TabIndex = 13;
            this.lblFilterSearch.Text = "Search:";
            // 
            // txtFilterSearch
            // 
            this.txtFilterSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterSearch.Location = new System.Drawing.Point(98, 70);
            this.txtFilterSearch.Name = "txtFilterSearch";
            this.txtFilterSearch.Size = new System.Drawing.Size(359, 34);
            this.txtFilterSearch.TabIndex = 7;
            this.txtFilterSearch.TextChanged += new System.EventHandler(this.txtFilterSearch_TextChanged);
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AllowUserToResizeColumns = false;
            this.dgvSales.AllowUserToResizeRows = false;
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSales.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSales.ColumnHeadersHeight = 30;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSales.EnableHeadersVisualStyles = false;
            this.dgvSales.Location = new System.Drawing.Point(24, 108);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(0);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSales.RowTemplate.DividerHeight = 1;
            this.dgvSales.RowTemplate.Height = 30;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(1607, 750);
            this.dgvSales.TabIndex = 0;
            this.dgvSales.TabStop = false;
            this.dgvSales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSales_CellDoubleClick);
            this.dgvSales.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSales_CellFormatting);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bharatPlantDesktopDataSet1
            // 
            this.bharatPlantDesktopDataSet1.DataSetName = "BharatPlantDesktopDataSet";
            this.bharatPlantDesktopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printDgvSales
            // 
            this.printDgvSales.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDgvSales_PrintPage);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1660, 967);
            this.Controls.Add(this.tabControlSales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSales";
            this.Text = "SALES";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.tabControlSales.ResumeLayout(false);
            this.tabPageEntry.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlTrnDtl.ResumeLayout(false);
            this.pnlTrnDtl.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageReport.ResumeLayout(false);
            this.tabPageReport.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bharatPlantDesktopDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSales;
        private System.Windows.Forms.TabPage tabPageEntry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.Label lblPartyName;
        private System.Windows.Forms.TextBox txtVoucher;
        private System.Windows.Forms.Label lblVoucher;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlTrnDtl;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnDGVhandler;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtCustomeDate;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.ListBox listBoxNarration;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.TextBox txtCreatedByName;
        private System.Windows.Forms.Label lblCreatedByName;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DataGridView dgvAddedItems;
        private System.Windows.Forms.TextBox txtFilterSearch;
        private System.Windows.Forms.Label lblFilterSearch;
        private System.Windows.Forms.TextBox txtFilterPeriodTo;
        private System.Windows.Forms.TextBox txtFilterPeriodFrom;
        private System.Windows.Forms.CheckBox checkBoxFilterCreatedBy;
        private System.Windows.Forms.TextBox txtFilterCreatedBy;
        private System.Windows.Forms.Label lblFilterCreatedBy;
        private System.Windows.Forms.TextBox txtFilterPartyName;
        private System.Windows.Forms.Label lblFilterPartyName;
        private System.Windows.Forms.Label lblFilterPeriodTo;
        private System.Windows.Forms.Label lblFilterFromPeriod;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.CheckBox checkBoxFilterPartyName;
        private System.Windows.Forms.TextBox txtSalesCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cmbSortingOptions;
        private System.Windows.Forms.Label lblSortyBy;
        private System.Windows.Forms.TextBox txtDgvCurrentTotal;
        private System.Windows.Forms.Label lblDgvCurrentTotal;
        private System.Windows.Forms.Panel panel4;
        private BharatPlantDesktopDataSet bharatPlantDesktopDataSet1;
        private System.Drawing.Printing.PrintDocument printDgvSales;
        private System.Windows.Forms.Button btnPrint;
    }
}