namespace bharatplantdesktop
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.btnMaximise = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnPayments = new FontAwesome.Sharp.IconButton();
            this.btnReceipts = new FontAwesome.Sharp.IconButton();
            this.btnPurchases = new FontAwesome.Sharp.IconButton();
            this.btnSales = new FontAwesome.Sharp.IconButton();
            this.btnMinimise = new FontAwesome.Sharp.IconButton();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.txtLoggedInUser = new System.Windows.Forms.TextBox();
            this.iconCurrentChildFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnTransactionModes = new FontAwesome.Sharp.IconButton();
            this.btnExpenses = new FontAwesome.Sharp.IconButton();
            this.btnUsers = new FontAwesome.Sharp.IconButton();
            this.btnItems = new FontAwesome.Sharp.IconButton();
            this.btnLedgers = new FontAwesome.Sharp.IconButton();
            this.btnEmployees = new FontAwesome.Sharp.IconButton();
            this.btnPartys = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.txtCalculator = new System.Windows.Forms.TextBox();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFormIcon)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMaximise
            // 
            this.btnMaximise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.btnMaximise.FlatAppearance.BorderSize = 0;
            this.btnMaximise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximise.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximise.IconColor = System.Drawing.Color.White;
            this.btnMaximise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximise.IconSize = 20;
            this.btnMaximise.Location = new System.Drawing.Point(914, 0);
            this.btnMaximise.Name = "btnMaximise";
            this.btnMaximise.Size = new System.Drawing.Size(45, 25);
            this.btnMaximise.TabIndex = 0;
            this.btnMaximise.TabStop = false;
            this.btnMaximise.UseVisualStyleBackColor = false;
            this.btnMaximise.Click += new System.EventHandler(this.btnMaximise_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(959, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 40;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 886);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 15);
            this.btnExit.Size = new System.Drawing.Size(240, 60);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Tag = "Exit";
            this.btnExit.Text = "   Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btnPayments.IconColor = System.Drawing.Color.White;
            this.btnPayments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPayments.IconSize = 40;
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.Location = new System.Drawing.Point(0, 324);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPayments.Size = new System.Drawing.Size(240, 60);
            this.btnPayments.TabIndex = 0;
            this.btnPayments.TabStop = false;
            this.btnPayments.Tag = "Pa&yments";
            this.btnPayments.Text = "   Pa&yments";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnReceipts
            // 
            this.btnReceipts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceipts.FlatAppearance.BorderSize = 0;
            this.btnReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipts.ForeColor = System.Drawing.Color.White;
            this.btnReceipts.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnReceipts.IconColor = System.Drawing.Color.White;
            this.btnReceipts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReceipts.IconSize = 40;
            this.btnReceipts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipts.Location = new System.Drawing.Point(0, 264);
            this.btnReceipts.Name = "btnReceipts";
            this.btnReceipts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReceipts.Size = new System.Drawing.Size(240, 60);
            this.btnReceipts.TabIndex = 0;
            this.btnReceipts.TabStop = false;
            this.btnReceipts.Tag = "&Receipts";
            this.btnReceipts.Text = "   &Receipts";
            this.btnReceipts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceipts.UseVisualStyleBackColor = true;
            this.btnReceipts.Click += new System.EventHandler(this.btnReceipts_Click);
            // 
            // btnPurchases
            // 
            this.btnPurchases.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchases.FlatAppearance.BorderSize = 0;
            this.btnPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchases.ForeColor = System.Drawing.Color.White;
            this.btnPurchases.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnPurchases.IconColor = System.Drawing.Color.White;
            this.btnPurchases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPurchases.IconSize = 40;
            this.btnPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchases.Location = new System.Drawing.Point(0, 204);
            this.btnPurchases.Name = "btnPurchases";
            this.btnPurchases.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPurchases.Size = new System.Drawing.Size(240, 60);
            this.btnPurchases.TabIndex = 0;
            this.btnPurchases.TabStop = false;
            this.btnPurchases.Tag = "&Purchases";
            this.btnPurchases.Text = "   &Purchases";
            this.btnPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurchases.UseVisualStyleBackColor = true;
            this.btnPurchases.Click += new System.EventHandler(this.btnPurchases_Click);
            // 
            // btnSales
            // 
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnSales.IconColor = System.Drawing.Color.White;
            this.btnSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSales.IconSize = 40;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 144);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSales.Size = new System.Drawing.Size(240, 60);
            this.btnSales.TabIndex = 0;
            this.btnSales.TabStop = false;
            this.btnSales.Tag = "&Sales";
            this.btnSales.Text = "   &Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnMinimise
            // 
            this.btnMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimise.IconColor = System.Drawing.Color.White;
            this.btnMinimise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimise.IconSize = 20;
            this.btnMinimise.Location = new System.Drawing.Point(869, 0);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(45, 25);
            this.btnMinimise.TabIndex = 0;
            this.btnMinimise.TabStop = false;
            this.btnMinimise.UseVisualStyleBackColor = false;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitleBar.BackColor = System.Drawing.Color.White;
            this.pnlTitleBar.Controls.Add(this.txtLoggedInUser);
            this.pnlTitleBar.Controls.Add(this.iconCurrentChildFormIcon);
            this.pnlTitleBar.Controls.Add(this.btnMinimise);
            this.pnlTitleBar.Controls.Add(this.btnMaximise);
            this.pnlTitleBar.Controls.Add(this.lblTitleChildForm);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Location = new System.Drawing.Point(240, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1004, 73);
            this.pnlTitleBar.TabIndex = 4;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // txtLoggedInUser
            // 
            this.txtLoggedInUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoggedInUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoggedInUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoggedInUser.Location = new System.Drawing.Point(649, 3);
            this.txtLoggedInUser.Multiline = true;
            this.txtLoggedInUser.Name = "txtLoggedInUser";
            this.txtLoggedInUser.Size = new System.Drawing.Size(214, 22);
            this.txtLoggedInUser.TabIndex = 0;
            this.txtLoggedInUser.TabStop = false;
            this.txtLoggedInUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // iconCurrentChildFormIcon
            // 
            this.iconCurrentChildFormIcon.BackColor = System.Drawing.Color.White;
            this.iconCurrentChildFormIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconCurrentChildFormIcon.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildFormIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconCurrentChildFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildFormIcon.IconSize = 40;
            this.iconCurrentChildFormIcon.Location = new System.Drawing.Point(15, 16);
            this.iconCurrentChildFormIcon.Name = "iconCurrentChildFormIcon";
            this.iconCurrentChildFormIcon.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentChildFormIcon.TabIndex = 5;
            this.iconCurrentChildFormIcon.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(61, 20);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(201, 32);
            this.lblTitleChildForm.TabIndex = 2;
            this.lblTitleChildForm.Tag = "DASHBOARD";
            this.lblTitleChildForm.Text = "DASHBOARD";
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.btnMenu);
            this.pnlLogo.Controls.Add(this.btnLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(240, 144);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(172, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(68, 144);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(173, 144);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogo.TabIndex = 2;
            this.btnLogo.TabStop = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnTransactionModes);
            this.pnlMenu.Controls.Add(this.btnExpenses);
            this.pnlMenu.Controls.Add(this.btnUsers);
            this.pnlMenu.Controls.Add(this.btnItems);
            this.pnlMenu.Controls.Add(this.btnLedgers);
            this.pnlMenu.Controls.Add(this.btnEmployees);
            this.pnlMenu.Controls.Add(this.btnPartys);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnPayments);
            this.pnlMenu.Controls.Add(this.btnReceipts);
            this.pnlMenu.Controls.Add(this.btnPurchases);
            this.pnlMenu.Controls.Add(this.btnSales);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 946);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 40;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 804);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(240, 60);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.TabStop = false;
            this.btnSettings.Tag = "Settin&gs";
            this.btnSettings.Text = "   Settin&gs";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnTransactionModes
            // 
            this.btnTransactionModes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionModes.FlatAppearance.BorderSize = 0;
            this.btnTransactionModes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionModes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionModes.ForeColor = System.Drawing.Color.White;
            this.btnTransactionModes.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnTransactionModes.IconColor = System.Drawing.Color.White;
            this.btnTransactionModes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransactionModes.IconSize = 40;
            this.btnTransactionModes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionModes.Location = new System.Drawing.Point(0, 744);
            this.btnTransactionModes.Name = "btnTransactionModes";
            this.btnTransactionModes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTransactionModes.Size = new System.Drawing.Size(240, 60);
            this.btnTransactionModes.TabIndex = 1;
            this.btnTransactionModes.TabStop = false;
            this.btnTransactionModes.Tag = "T&ransaction_Mode";
            this.btnTransactionModes.Text = "   T&rn Modes";
            this.btnTransactionModes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionModes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransactionModes.UseVisualStyleBackColor = true;
            this.btnTransactionModes.Click += new System.EventHandler(this.btnTransactionModes_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpenses.FlatAppearance.BorderSize = 0;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.ForeColor = System.Drawing.Color.White;
            this.btnExpenses.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnExpenses.IconColor = System.Drawing.Color.White;
            this.btnExpenses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExpenses.IconSize = 40;
            this.btnExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenses.Location = new System.Drawing.Point(0, 684);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExpenses.Size = new System.Drawing.Size(240, 60);
            this.btnExpenses.TabIndex = 0;
            this.btnExpenses.TabStop = false;
            this.btnExpenses.Tag = "E&xpenses";
            this.btnExpenses.Text = "   E&xpenses";
            this.btnExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpenses.UseVisualStyleBackColor = true;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btnUsers.IconColor = System.Drawing.Color.White;
            this.btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsers.IconSize = 40;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 624);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(240, 60);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.TabStop = false;
            this.btnUsers.Tag = "&Users";
            this.btnUsers.Text = "   &Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnItems
            // 
            this.btnItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItems.FlatAppearance.BorderSize = 0;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnItems.IconColor = System.Drawing.Color.White;
            this.btnItems.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnItems.IconSize = 40;
            this.btnItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItems.Location = new System.Drawing.Point(0, 564);
            this.btnItems.Name = "btnItems";
            this.btnItems.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnItems.Size = new System.Drawing.Size(240, 60);
            this.btnItems.TabIndex = 0;
            this.btnItems.TabStop = false;
            this.btnItems.Tag = "&Items";
            this.btnItems.Text = "   &Items";
            this.btnItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnLedgers
            // 
            this.btnLedgers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLedgers.FlatAppearance.BorderSize = 0;
            this.btnLedgers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLedgers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLedgers.ForeColor = System.Drawing.Color.White;
            this.btnLedgers.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btnLedgers.IconColor = System.Drawing.Color.White;
            this.btnLedgers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLedgers.IconSize = 40;
            this.btnLedgers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLedgers.Location = new System.Drawing.Point(0, 504);
            this.btnLedgers.Name = "btnLedgers";
            this.btnLedgers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLedgers.Size = new System.Drawing.Size(240, 60);
            this.btnLedgers.TabIndex = 0;
            this.btnLedgers.TabStop = false;
            this.btnLedgers.Tag = "&Ledgers";
            this.btnLedgers.Text = "   &Ledgers";
            this.btnLedgers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLedgers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLedgers.UseVisualStyleBackColor = true;
            this.btnLedgers.Click += new System.EventHandler(this.btnLedgers_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btnEmployees.IconColor = System.Drawing.Color.White;
            this.btnEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmployees.IconSize = 40;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(0, 444);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmployees.Size = new System.Drawing.Size(240, 60);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.TabStop = false;
            this.btnEmployees.Tag = "&Employees";
            this.btnEmployees.Text = "   &Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnPartys
            // 
            this.btnPartys.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPartys.FlatAppearance.BorderSize = 0;
            this.btnPartys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartys.ForeColor = System.Drawing.Color.White;
            this.btnPartys.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btnPartys.IconColor = System.Drawing.Color.White;
            this.btnPartys.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPartys.IconSize = 40;
            this.btnPartys.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartys.Location = new System.Drawing.Point(0, 384);
            this.btnPartys.Name = "btnPartys";
            this.btnPartys.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPartys.Size = new System.Drawing.Size(240, 60);
            this.btnPartys.TabIndex = 0;
            this.btnPartys.TabStop = false;
            this.btnPartys.Tag = "Par&ty\'s";
            this.btnPartys.Text = "   Par&ty\'s";
            this.btnPartys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartys.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPartys.UseVisualStyleBackColor = true;
            this.btnPartys.Click += new System.EventHandler(this.btnPartys_Click);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDesktop.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDesktop.Controls.Add(this.txtCalculator);
            this.pnlDesktop.Location = new System.Drawing.Point(240, 73);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1004, 873);
            this.pnlDesktop.TabIndex = 10;
            // 
            // txtCalculator
            // 
            this.txtCalculator.AllowDrop = true;
            this.txtCalculator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCalculator.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtCalculator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCalculator.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalculator.Location = new System.Drawing.Point(0, 723);
            this.txtCalculator.Multiline = true;
            this.txtCalculator.Name = "txtCalculator";
            this.txtCalculator.Size = new System.Drawing.Size(1004, 150);
            this.txtCalculator.TabIndex = 0;
            this.txtCalculator.TabStop = false;
            this.txtCalculator.Visible = false;
            this.txtCalculator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalculator_KeyPress);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 946);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAHSBOARD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDashboard_FormClosing);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFormIcon)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnMaximise;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnPayments;
        private FontAwesome.Sharp.IconButton btnReceipts;
        private FontAwesome.Sharp.IconButton btnPurchases;
        private FontAwesome.Sharp.IconButton btnSales;
        private FontAwesome.Sharp.IconButton btnMinimise;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.PictureBox btnLogo;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildFormIcon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton btnLedgers;
        private FontAwesome.Sharp.IconButton btnEmployees;
        private FontAwesome.Sharp.IconButton btnPartys;
        private System.Windows.Forms.Panel pnlDesktop;
        private FontAwesome.Sharp.IconButton btnUsers;
        private FontAwesome.Sharp.IconButton btnItems;
        private FontAwesome.Sharp.IconButton btnExpenses;
        private System.Windows.Forms.TextBox txtLoggedInUser;
        private System.Windows.Forms.TextBox txtCalculator;
        private FontAwesome.Sharp.IconButton btnTransactionModes;
        private FontAwesome.Sharp.IconButton btnSettings;
    }
}

