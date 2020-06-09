namespace ABC_Ed_Services
{
    partial class frmViewEnrollments
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
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbCourses = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(158, 8);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(196, 238);
            this.lbStudents.TabIndex = 7;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(12, 62);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(62, 20);
            this.txtCost.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 36);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 5;
            // 
            // cbCourses
            // 
            this.cbCourses.FormattingEnabled = true;
            this.cbCourses.Location = new System.Drawing.Point(12, 9);
            this.cbCourses.Name = "cbCourses";
            this.cbCourses.Size = new System.Drawing.Size(121, 21);
            this.cbCourses.TabIndex = 4;
            this.cbCourses.SelectedIndexChanged += new System.EventHandler(this.cbCourses_SelectedIndexChanged);
            // 
            // frmViewEnrollments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 258);
            this.Controls.Add(this.lbStudents);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbCourses);
            this.Name = "frmViewEnrollments";
            this.Text = "Enrollment Details";
            this.Load += new System.EventHandler(this.frmViewEnrollments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox lbStudents;
        internal System.Windows.Forms.TextBox txtCost;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.ComboBox cbCourses;

    }
}