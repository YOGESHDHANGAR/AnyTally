namespace bharatplantdesktop.UI
{
    partial class frmTransactionModes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTransactionMode = new System.Windows.Forms.Label();
            this.txtPaymentMode = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPaymentModes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentModes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblTransactionMode);
            this.panel1.Controls.Add(this.txtPaymentMode);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 138);
            this.panel1.TabIndex = 2;
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1066, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 32);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTransactionMode
            // 
            this.lblTransactionMode.AutoSize = true;
            this.lblTransactionMode.Location = new System.Drawing.Point(45, 30);
            this.lblTransactionMode.Name = "lblTransactionMode";
            this.lblTransactionMode.Size = new System.Drawing.Size(116, 16);
            this.lblTransactionMode.TabIndex = 11;
            this.lblTransactionMode.Text = "Transaction Mode";
            // 
            // txtPaymentMode
            // 
            this.txtPaymentMode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaymentMode.Location = new System.Drawing.Point(195, 30);
            this.txtPaymentMode.Name = "txtPaymentMode";
            this.txtPaymentMode.Size = new System.Drawing.Size(150, 15);
            this.txtPaymentMode.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPaymentModes);
            this.panel2.Location = new System.Drawing.Point(12, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 492);
            this.panel2.TabIndex = 3;
            // 
            // dgvPaymentModes
            // 
            this.dgvPaymentModes.AllowUserToAddRows = false;
            this.dgvPaymentModes.AllowUserToDeleteRows = false;
            this.dgvPaymentModes.AllowUserToResizeColumns = false;
            this.dgvPaymentModes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPaymentModes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaymentModes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaymentModes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPaymentModes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPaymentModes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentModes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaymentModes.ColumnHeadersHeight = 50;
            this.dgvPaymentModes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentModes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPaymentModes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPaymentModes.EnableHeadersVisualStyles = false;
            this.dgvPaymentModes.Location = new System.Drawing.Point(20, 16);
            this.dgvPaymentModes.Name = "dgvPaymentModes";
            this.dgvPaymentModes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPaymentModes.RowHeadersVisible = false;
            this.dgvPaymentModes.RowHeadersWidth = 40;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.dgvPaymentModes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPaymentModes.RowTemplate.Height = 40;
            this.dgvPaymentModes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentModes.Size = new System.Drawing.Size(1188, 461);
            this.dgvPaymentModes.TabIndex = 2;
            // 
            // frmTransactionModes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransactionModes";
            this.Text = "frmPaymentModes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentModes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTransactionMode;
        private System.Windows.Forms.TextBox txtPaymentMode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPaymentModes;
    }
}