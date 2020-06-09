using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ABC_Ed_Services
{
    public partial class frmStudentTT : Form
    {
        private TafeDBDataSet.StudentDataTable table;
        

        public frmStudentTT()
        {
            InitializeComponent();
        }

        private void frmStudentTT_Load(object sender, EventArgs e)
        {
            
            cbStudents.Text = "-Select Student-";
            Tafe_DataTier dt = new Tafe_DataTier();
            var students = dt.viewStudents();
        
            
            foreach (var s in students)
            {
                cbStudents.Items.Add(s.StudentID.ToString()); ;

            }
           
        }

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
                lbCourses.Items.Clear();
                string id = cbStudents.SelectedItem.ToString();
                Tafe_DataTier dt = new Tafe_DataTier();
                var student = dt.viewStudents().Find(s => s.StudentID == id);
                txtName.Text = student.StduentName;
                DateTime date = student.DateEnrolled.Value; 
                txtDateEnrolled.Text = date.ToString("d");

                

                if (dt.getEnrollmentsForStudent(id).Count == 0)
                {
                    lbCourses.Items.Add("--------- NO ENROLLMENTS ----------");
                }
                else
                {
                    var enrolls = dt.getEnrollmentsForStudent(id);
                    foreach (var enroll in enrolls)
                    {
                        lbCourses.Items.Add(enroll.CourseID);                   
                    }
                }
        }

        private void lbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}