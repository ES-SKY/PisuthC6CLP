namespace ABC_Ed_Services
{
    partial class frmEnroll
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
            this.txtDateEnrolled = new System.Windows.Forms.TextBox();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.cbStudents = new System.Windows.Forms.ComboBox();
            this.Student = new System.Windows.Forms.GroupBox();
            this.cbCourses = new System.Windows.Forms.ComboBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Student.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDateEnrolled
            // 
            this.txtDateEnrolled.Location = new System.Drawing.Point(7, 106);
            this.txtDateEnrolled.Name = "txtDateEnrolled";
            this.txtDateEnrolled.ReadOnly = true;
            this.txtDateEnrolled.Size = new System.Drawing.Size(103, 20);
            this.txtDateEnrolled.TabIndex = 2;
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(13, 207);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(106, 23);
            this.btnEnroll.TabIndex = 5;
            this.btnEnroll.Text = "Enroll Student";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // txtStudName
            // 
            this.txtStudName.Location = new System.Drawing.Point(6, 72);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.ReadOnly = true;
            this.txtStudName.Size = new System.Drawing.Size(149, 20);
            this.txtStudName.TabIndex = 1;
            // 
            // cbStudents
            // 
            this.cbStudents.FormattingEnabled = true;
            this.cbStudents.Location = new System.Drawing.Point(6, 19);
            this.cbStudents.Name = "cbStudents";
            this.cbStudents.Size = new System.Drawing.Size(112, 21);
            this.cbStudents.TabIndex = 0;
            this.cbStudents.SelectedIndexChanged += new System.EventHandler(this.cbStudents_SelectedIndexChanged);
            // 
            // Student
            // 
            this.Student.Controls.Add(this.txtDateEnrolled);
            this.Student.Controls.Add(this.txtStudName);
            this.Student.Controls.Add(this.cbStudents);
            this.Student.Location = new System.Drawing.Point(184, 37);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(171, 155);
            this.Student.TabIndex = 4;
            this.Student.TabStop = false;
            this.Student.Text = "Student";
            // 
            // cbCourses
            // 
            this.cbCourses.FormattingEnabled = true;
            this.cbCourses.Location = new System.Drawing.Point(7, 20);
            this.cbCourses.Name = "cbCourses";
            this.cbCourses.Size = new System.Drawing.Size(117, 21);
            this.cbCourses.TabIndex = 2;
            this.cbCourses.SelectedIndexChanged += new System.EventHandler(this.cbCourses_SelectedIndexChanged);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(6, 107);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 1;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(6, 72);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.ReadOnly = true;
            this.txtCourseName.Size = new System.Drawing.Size(153, 20);
            this.txtCourseName.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cbCourses);
            this.GroupBox1.Controls.Add(this.txtCost);
            this.GroupBox1.Controls.Add(this.txtCourseName);
            this.GroupBox1.Location = new System.Drawing.Point(13, 37);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(165, 155);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Course";
            // 
            // frmEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 255);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmEnroll";
            this.Text = "Enrollment Form";
            this.Load += new System.EventHandler(this.frmEnroll_Load);
            this.Student.ResumeLayout(false);
            this.Student.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox txtDateEnrolled;
        internal System.Windows.Forms.Button btnEnroll;
        internal System.Windows.Forms.TextBox txtStudName;
        internal System.Windows.Forms.ComboBox cbStudents;
        internal System.Windows.Forms.GroupBox Student;
        internal System.Windows.Forms.ComboBox cbCourses;
        internal System.Windows.Forms.TextBox txtCost;
        internal System.Windows.Forms.TextBox txtCourseName;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}