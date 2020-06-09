namespace ABC_Ed_Services
{
    partial class frmStudentTT
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCourses = new System.Windows.Forms.ListBox();
            this.txtDateEnrolled = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbStudents = new System.Windows.Forms.ComboBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lbCourses);
            this.GroupBox1.Location = new System.Drawing.Point(159, 91);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(178, 172);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Courses Enrolled In";
            // 
            // lbCourses
            // 
            this.lbCourses.FormattingEnabled = true;
            this.lbCourses.Location = new System.Drawing.Point(20, 20);
            this.lbCourses.Name = "lbCourses";
            this.lbCourses.Size = new System.Drawing.Size(152, 147);
            this.lbCourses.TabIndex = 0;
            this.lbCourses.SelectedIndexChanged += new System.EventHandler(this.lbCourses_SelectedIndexChanged);
            // 
            // txtDateEnrolled
            // 
            this.txtDateEnrolled.Location = new System.Drawing.Point(159, 52);
            this.txtDateEnrolled.Name = "txtDateEnrolled";
            this.txtDateEnrolled.ReadOnly = true;
            this.txtDateEnrolled.Size = new System.Drawing.Size(178, 20);
            this.txtDateEnrolled.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 15);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // cbStudents
            // 
            this.cbStudents.FormattingEnabled = true;
            this.cbStudents.Location = new System.Drawing.Point(13, 14);
            this.cbStudents.Name = "cbStudents";
            this.cbStudents.Size = new System.Drawing.Size(121, 21);
            this.cbStudents.TabIndex = 5;
            this.cbStudents.SelectedIndexChanged += new System.EventHandler(this.cbStudents_SelectedIndexChanged);
            // 
            // frmStudentTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 276);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.txtDateEnrolled);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbStudents);
            this.Name = "frmStudentTT";
            this.Text = "Time Table";
            this.Load += new System.EventHandler(this.frmStudentTT_Load);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ListBox lbCourses;
        internal System.Windows.Forms.TextBox txtDateEnrolled;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.ComboBox cbStudents;

    }
}