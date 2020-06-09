namespace ABC_Ed_Services
{
    partial class frmStudents
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
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(4, -1);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(229, 264);
            this.lbStudents.TabIndex = 2;
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 278);
            this.Controls.Add(this.lbStudents);
            this.Name = "frmStudents";
            this.Text = "frmStudents";
            this.Load += new System.EventHandler(this.frmStudents_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListBox lbStudents;
    }
}