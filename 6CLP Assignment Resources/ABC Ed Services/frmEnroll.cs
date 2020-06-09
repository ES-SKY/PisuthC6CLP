using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABC_Ed_Services
{
    public partial class frmEnroll : Form
    {
        //private TafeDBDataSet.StudentDataTable studTable;
        //private TafeDBDataSet.CourseDataTable courseTable;
        private Tafe_DataTier dt;

        public frmEnroll()
        {
            InitializeComponent();
            dt = new Tafe_DataTier();
        }

        private void frmEnroll_Load(object sender, EventArgs e)
        {
            cbStudents.Text = "-Select Student-";
            var students = dt.viewStudents();
            foreach (var s in students)
            {
                cbStudents.Items.Add(s.StudentID.ToString()); ;
            }

            cbCourses .Text = "-Select Course-";
            var courses = dt.viewCourses();
            foreach (var c in courses)
            {
                cbCourses.Items.Add(c.CourseID.ToString()); ;
            }

        }


        private void btnEnroll_Click(object sender, EventArgs e)
        {
            dt = new Tafe_DataTier();
            int rowsInserted = dt.enroll(cbCourses.SelectedItem.ToString(),cbStudents.SelectedItem.ToString());
            if (rowsInserted > 0)
            {
                MessageBox.Show("New Enrollment Information Saved", "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("New Enrollment Information NOT Saved", "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbStudents.SelectedItem.ToString();
            dt = new Tafe_DataTier();
            var student = dt.viewStudents().Find(s => s.StudentID == id);
            this.txtStudName.Text = student.StduentName;
            this.txtDateEnrolled.Text = Convert.ToDateTime(student.DateEnrolled).ToString("d");

        }

        private void cbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbCourses.SelectedItem.ToString();
            dt = new Tafe_DataTier();
            var course = dt.viewCourses().Find(c => c.CourseID == id);
            this.txtCourseName.Text = course.CourseName;
            this.txtCost.Text = Convert.ToDecimal(course.Cost).ToString("C");
        }
    }
}