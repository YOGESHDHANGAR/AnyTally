namespace bharatplantdesktop.UI
{
    partial class frmPartys
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbLenaDena = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOpeningBalance = new System.Windows.Forms.Label();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.lblPartyName = new System.Windows.Forms.Label();
            this.txtPartyName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbLenaDena);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblOpeningBalance);
            this.panel1.Controls.Add(this.txtOpeningBalance);
            this.panel1.Controls.Add(this.lblPartyName);
            this.panel1.Controls.Add(this.txtPartyName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 138);
            this.panel1.TabIndex = 1;
            // 
            // cmbLenaDena
            // 
            this.cmbLenaDena.FormattingEnabled = true;
            this.cmbLenaDena.Items.AddRange(new object[] {
            "Lena",
            "Dena"});
            this.cmbLenaDena.Location = new System.Drawing.Point(503, 59);
            this.cmbLenaDena.Name = "cmbLenaDena";
            this.cmbLenaDena.Size = new System.Drawing.Size(121, 24);
            this.cmbLenaDena.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1066, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 32);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1066, 51);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 32);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1066, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 32);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblOpeningBalance
            // 
            this.lblOpeningBalance.AutoSize = true;
            this.lblOpeningBalance.Location = new System.Drawing.Point(18, 68);
            this.lblOpeningBalance.Name = "lblOpeningBalance";
            this.lblOpeningBalance.Size = new System.Drawing.Size(111, 16);
            this.lblOpeningBalance.TabIndex = 13;
            this.lblOpeningBalance.Text = "Opening Balance";
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpeningBalance.Location = new System.Drawing.Point(170, 68);
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.Size = new System.Drawing.Size(315, 15);
            this.txtOpeningBalance.TabIndex = 2;
            // 
            // lblPartyName
            // 
            this.lblPartyName.AutoSize = true;
            this.lblPartyName.Location = new System.Drawing.Point(18, 31);
            this.lblPartyName.Name = "lblPartyName";
            this.lblPartyName.Size = new System.Drawing.Size(78, 16);
            this.lblPartyName.TabIndex = 11;
            this.lblPartyName.Text = "Party Name";
            // 
            // txtPartyName
            // 
            this.txtPartyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPartyName.Location = new System.Drawing.Point(170, 31);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(315, 15);
            this.txtPartyName.TabIndex = 1;
            // 
            // frmPartys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 702);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPartys";
            this.Text = "PARTY";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOpeningBalance;
        private System.Windows.Forms.TextBox txtOpeningBalance;
        private System.Windows.Forms.Label lblPartyName;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.ComboBox cmbLenaDena;
    }
}