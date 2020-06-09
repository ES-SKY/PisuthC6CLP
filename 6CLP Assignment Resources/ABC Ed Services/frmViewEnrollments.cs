using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABC_Ed_Services
{
    public partial class frmViewEnrollments : Form
    {
        TafeDBDataSet.CourseDataTable table;
        public frmViewEnrollments()
        {
            InitializeComponent();
        }

        private void frmViewEnrollments_Load(object sender, EventArgs e)
        {
            cbCourses.Text = "-Select Courset-";
            Tafe_DataTier dt = new Tafe_DataTier();
            var courses = dt.viewCourses();


            foreach (var c in courses)
            {
                cbCourses.Items.Add(c.CourseID.ToString()); ;

            }
        }

        private void cbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbStudents.Items.Clear();
            string id = cbCourses.SelectedItem.ToString();
            Tafe_DataTier dt = new Tafe_DataTier();
            var course = dt.viewCourses().Find(c => c.CourseID == id);
            this.txtName.Text = course.CourseName;
            decimal costValue = course.Cost.Value;
            this.txtCost.Text = costValue.ToString("C");

            //dt.getStudentsEnrolledInCourse(id);
            if (dt.getStudentsEnrolledInCourse(id).Count==0)
            {
                lbStudents.Items.Add("--------- NO ENROLLMENTS ----------");
            }
            else
            {
                var students = dt.getStudentsEnrolledInCourse(id);
                foreach (var s in students)
                {
                    this.lbStudents.Items.Add(s.StudentID + "-->" + s.StduentName);
                }
                
               
            }
        }
    }
}