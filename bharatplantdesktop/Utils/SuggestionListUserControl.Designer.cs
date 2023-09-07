namespace bharatplantdesktop.Utils
{
    partial class SuggestionListUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxSuggestions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxSuggestions
            // 
            this.listBoxSuggestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSuggestions.FormattingEnabled = true;
            this.listBoxSuggestions.ItemHeight = 16;
            this.listBoxSuggestions.Location = new System.Drawing.Point(0, 0);
            this.listBoxSuggestions.Name = "listBoxSuggestions";
            this.listBoxSuggestions.Size = new System.Drawing.Size(373, 967);
            this.listBoxSuggestions.TabIndex = 0;
            // 
            // SuggestionLIst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxSuggestions);
            this.Name = "SuggestionLIst";
            this.Size = new System.Drawing.Size(373, 967);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSuggestions;
    }
}
