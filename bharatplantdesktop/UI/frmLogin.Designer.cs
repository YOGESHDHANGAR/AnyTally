namespace bharatplantdesktop.UI
{
    partial class frmLogin
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
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.tabControlLoginAndRegister = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOrRegister = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tabPageRegister = new System.Windows.Forms.TabPage();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.lblOrLogin = new System.Windows.Forms.Label();
            this.txtRegisterConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblRegisterConfirmPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblRegisterUsername = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.tabControlLoginAndRegister.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageRegister.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(365, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControlLoginAndRegister
            // 
            this.tabControlLoginAndRegister.Controls.Add(this.tabPageLogin);
            this.tabControlLoginAndRegister.Controls.Add(this.tabPageRegister);
            this.tabControlLoginAndRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlLoginAndRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlLoginAndRegister.Location = new System.Drawing.Point(0, 30);
            this.tabControlLoginAndRegister.Name = "tabControlLoginAndRegister";
            this.tabControlLoginAndRegister.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlLoginAndRegister.SelectedIndex = 0;
            this.tabControlLoginAndRegister.Size = new System.Drawing.Size(415, 630);
            this.tabControlLoginAndRegister.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlLoginAndRegister.TabIndex = 0;
            this.tabControlLoginAndRegister.TabStop = false;
            this.tabControlLoginAndRegister.SelectedIndexChanged += new System.EventHandler(this.tabControlLoginAndRegister_SelectedIndexChanged);
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageLogin.Controls.Add(this.panel1);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 40);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(407, 586);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblOrRegister);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 580);
            this.panel1.TabIndex = 0;
            // 
            // lblOrRegister
            // 
            this.lblOrRegister.AutoSize = true;
            this.lblOrRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOrRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrRegister.Location = new System.Drawing.Point(252, 397);
            this.lblOrRegister.Name = "lblOrRegister";
            this.lblOrRegister.Size = new System.Drawing.Size(92, 20);
            this.lblOrRegister.TabIndex = 0;
            this.lblOrRegister.Text = "or Register";
            this.lblOrRegister.Click += new System.EventHandler(this.lblOrRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(54, 346);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(292, 51);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(52, 242);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = 'x';
            this.txtPassword.Size = new System.Drawing.Size(292, 38);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(52, 143);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(292, 38);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(48, 216);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(48, 120);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(159, 23);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(83, 31);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "LOGIN";
            // 
            // tabPageRegister
            // 
            this.tabPageRegister.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageRegister.Controls.Add(this.pnlRegister);
            this.tabPageRegister.Location = new System.Drawing.Point(4, 40);
            this.tabPageRegister.Name = "tabPageRegister";
            this.tabPageRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegister.Size = new System.Drawing.Size(407, 586);
            this.tabPageRegister.TabIndex = 1;
            this.tabPageRegister.Text = "Register";
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackColor = System.Drawing.Color.White;
            this.pnlRegister.Controls.Add(this.lblOrLogin);
            this.pnlRegister.Controls.Add(this.txtRegisterConfirmPassword);
            this.pnlRegister.Controls.Add(this.lblRegisterConfirmPassword);
            this.pnlRegister.Controls.Add(this.txtName);
            this.pnlRegister.Controls.Add(this.lblName);
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Controls.Add(this.txtRegisterPassword);
            this.pnlRegister.Controls.Add(this.txtRegisterUsername);
            this.pnlRegister.Controls.Add(this.lblRegisterPassword);
            this.pnlRegister.Controls.Add(this.lblRegisterUsername);
            this.pnlRegister.Controls.Add(this.lblRegister);
            this.pnlRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegister.Location = new System.Drawing.Point(3, 3);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(401, 580);
            this.pnlRegister.TabIndex = 0;
            // 
            // lblOrLogin
            // 
            this.lblOrLogin.AutoSize = true;
            this.lblOrLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOrLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrLogin.Location = new System.Drawing.Point(271, 489);
            this.lblOrLogin.Name = "lblOrLogin";
            this.lblOrLogin.Size = new System.Drawing.Size(70, 20);
            this.lblOrLogin.TabIndex = 0;
            this.lblOrLogin.Text = "or Login";
            this.lblOrLogin.Click += new System.EventHandler(this.lblOrLogin_Click);
            // 
            // txtRegisterConfirmPassword
            // 
            this.txtRegisterConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegisterConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegisterConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterConfirmPassword.Location = new System.Drawing.Point(54, 362);
            this.txtRegisterConfirmPassword.Name = "txtRegisterConfirmPassword";
            this.txtRegisterConfirmPassword.PasswordChar = 'x';
            this.txtRegisterConfirmPassword.Size = new System.Drawing.Size(292, 38);
            this.txtRegisterConfirmPassword.TabIndex = 4;
            // 
            // lblRegisterConfirmPassword
            // 
            this.lblRegisterConfirmPassword.AutoSize = true;
            this.lblRegisterConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterConfirmPassword.Location = new System.Drawing.Point(50, 336);
            this.lblRegisterConfirmPassword.Name = "lblRegisterConfirmPassword";
            this.lblRegisterConfirmPassword.Size = new System.Drawing.Size(127, 20);
            this.lblRegisterConfirmPassword.TabIndex = 7;
            this.lblRegisterConfirmPassword.Text = "Confirm Password";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(54, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(292, 38);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(50, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(49, 435);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(292, 51);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegisterPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegisterPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPassword.Location = new System.Drawing.Point(54, 279);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.PasswordChar = 'x';
            this.txtRegisterPassword.Size = new System.Drawing.Size(292, 38);
            this.txtRegisterPassword.TabIndex = 3;
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegisterUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegisterUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterUsername.Location = new System.Drawing.Point(54, 196);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(292, 38);
            this.txtRegisterUsername.TabIndex = 2;
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterPassword.Location = new System.Drawing.Point(50, 253);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(70, 20);
            this.lblRegisterPassword.TabIndex = 1;
            this.lblRegisterPassword.Text = "Password";
            // 
            // lblRegisterUsername
            // 
            this.lblRegisterUsername.AutoSize = true;
            this.lblRegisterUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterUsername.Location = new System.Drawing.Point(50, 170);
            this.lblRegisterUsername.Name = "lblRegisterUsername";
            this.lblRegisterUsername.Size = new System.Drawing.Size(75, 20);
            this.lblRegisterUsername.TabIndex = 1;
            this.lblRegisterUsername.Text = "Username";
            // 
            // lblRegister
            // 
            this.lblRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(142, 29);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(117, 31);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "REGISTER";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(415, 660);
            this.Controls.Add(this.tabControlLoginAndRegister);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            this.tabControlLoginAndRegister.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageRegister.ResumeLayout(false);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.TabControl tabControlLoginAndRegister;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.TabPage tabPageRegister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.TextBox txtRegisterConfirmPassword;
        private System.Windows.Forms.Label lblRegisterConfirmPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblRegisterUsername;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblOrRegister;
        private System.Windows.Forms.Label lblOrLogin;
    }
}