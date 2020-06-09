namespace ABC_Ed_Services
{
    partial class frmMain
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
            this.mnuViewCourses = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StudentAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimeTable = new System.Windows.Forms.ToolStripMenuItem();
            this.CourseAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewCourses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnroll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewRoll = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuViewCourses
            // 
            this.mnuViewCourses.Name = "mnuViewCourses";
            this.mnuViewCourses.Size = new System.Drawing.Size(165, 22);
            this.mnuViewCourses.Text = "View Courses";
            this.mnuViewCourses.Click += new System.EventHandler(this.mnuViewCourses_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentAdminToolStripMenuItem,
            this.CourseAdminToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(292, 24);
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // StudentAdminToolStripMenuItem
            // 
            this.StudentAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewStudents,
            this.mnuViewStudents,
            this.mnuTimeTable});
            this.StudentAdminToolStripMenuItem.Name = "StudentAdminToolStripMenuItem";
            this.StudentAdminToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.StudentAdminToolStripMenuItem.Text = "Student Admin";
            // 
            // mnuNewStudents
            // 
            this.mnuNewStudents.Name = "mnuNewStudents";
            this.mnuNewStudents.Size = new System.Drawing.Size(171, 22);
            this.mnuNewStudents.Text = "New Students";
            this.mnuNewStudents.Click += new System.EventHandler(this.mnuNewStudents_Click);
            // 
            // mnuViewStudents
            // 
            this.mnuViewStudents.Name = "mnuViewStudents";
            this.mnuViewStudents.Size = new System.Drawing.Size(171, 22);
            this.mnuViewStudents.Text = "View Students";
            this.mnuViewStudents.Click += new System.EventHandler(this.mnuViewStudents_Click);
            // 
            // mnuTimeTable
            // 
            this.mnuTimeTable.Name = "mnuTimeTable";
            this.mnuTimeTable.Size = new System.Drawing.Size(171, 22);
            this.mnuTimeTable.Text = "Student Timetable";
            this.mnuTimeTable.Click += new System.EventHandler(this.mnuTimeTable_Click);
            // 
            // CourseAdminToolStripMenuItem
            // 
            this.CourseAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewCourses,
            this.mnuViewCourses,
            this.mnuEnroll,
            this.mnuViewRoll,
            this.DisplayBillToolStripMenuItem});
            this.CourseAdminToolStripMenuItem.Name = "CourseAdminToolStripMenuItem";
            this.CourseAdminToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.CourseAdminToolStripMenuItem.Text = "Course Admin";
            // 
            // mnuNewCourses
            // 
            this.mnuNewCourses.Name = "mnuNewCourses";
            this.mnuNewCourses.Size = new System.Drawing.Size(165, 22);
            this.mnuNewCourses.Text = "New Courses";
            this.mnuNewCourses.Click += new System.EventHandler(this.mnuNewCourses_Click);
            // 
            // mnuEnroll
            // 
            this.mnuEnroll.Name = "mnuEnroll";
            this.mnuEnroll.Size = new System.Drawing.Size(165, 22);
            this.mnuEnroll.Text = "Enroll Student";
            this.mnuEnroll.Click += new System.EventHandler(this.mnuEnroll_Click);
            // 
            // mnuViewRoll
            // 
            this.mnuViewRoll.Name = "mnuViewRoll";
            this.mnuViewRoll.Size = new System.Drawing.Size(165, 22);
            this.mnuViewRoll.Text = "View Enrollments";
            this.mnuViewRoll.Click += new System.EventHandler(this.mnuViewRoll_Click);
            // 
            // DisplayBillToolStripMenuItem
            // 
            this.DisplayBillToolStripMenuItem.Name = "DisplayBillToolStripMenuItem";
            this.DisplayBillToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.DisplayBillToolStripMenuItem.Text = "Display Bill";
            this.DisplayBillToolStripMenuItem.Click += new System.EventHandler(this.DisplayBillToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 74);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "frmMain";
            this.Text = "Course Enrollments";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripMenuItem mnuViewCourses;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem StudentAdminToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem mnuNewStudents;
        internal System.Windows.Forms.ToolStripMenuItem mnuViewStudents;
        internal System.Windows.Forms.ToolStripMenuItem mnuTimeTable;
        internal System.Windows.Forms.ToolStripMenuItem CourseAdminToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem mnuNewCourses;
        internal System.Windows.Forms.ToolStripMenuItem mnuEnroll;
        internal System.Windows.Forms.ToolStripMenuItem mnuViewRoll;
        internal System.Windows.Forms.ToolStripMenuItem DisplayBillToolStripMenuItem;
    }
}