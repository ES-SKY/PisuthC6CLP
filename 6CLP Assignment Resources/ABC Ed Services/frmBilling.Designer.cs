namespace ABC_Ed_Services
{
    partial class frmBilling
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
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lbCourses = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbStudents = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(160, 51);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 7;
            // 
            // lbCourses
            // 
            this.lbCourses.FormattingEnabled = true;
            this.lbCourses.Location = new System.Drawing.Point(32, 94);
            this.lbCourses.Name = "lbCourses";
            this.lbCourses.Size = new System.Drawing.Size(227, 160);
            this.lbCourses.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(160, 13);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // cbStudents
            // 
            this.cbStudents.FormattingEnabled = true;
            this.cbStudents.Location = new System.Drawing.Point(33, 13);
            this.cbStudents.Name = "cbStudents";
            this.cbStudents.Size = new System.Drawing.Size(110, 21);
            this.cbStudents.TabIndex = 4;
            this.cbStudents.SelectedIndexChanged += new System.EventHandler(this.cbStudents_SelectedIndexChanged);
            // 
            // frmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lbCourses);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbStudents);
            this.Name = "frmBilling";
            this.Text = "Billing System";
            this.Load += new System.EventHandler(this.frmBilling_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtCost;
        internal System.Windows.Forms.ListBox lbCourses;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.ComboBox cbStudents;
    }
}