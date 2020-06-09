using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABC_Ed_Services
{
    public partial class frmBilling : Form
    {
        private TafeDBDataSet.StudentDataTable studTable;
        private Tafe_DataTier dt;

        public frmBilling()
        {
            dt = new Tafe_DataTier();
            InitializeComponent();
        }

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCourses.Items.Clear();
            string id = cbStudents.SelectedItem.ToString();
            dt = new Tafe_DataTier();
            var student = dt.viewStudents().Find(s => s.StudentID == id);
            this.txtName.Text = student.StduentName;
            
            Decimal total = 0.0M;
            if (dt.getEnrollmentsForStudent(id).Count == 0)
            {
                lbCourses.Items.Add("--------- NO ENROLLMENTS ----------");
            }
            else
            {
                var enrolls=dt.getEnrollmentsForStudent(id);
                foreach (var enroll in enrolls)
                {
                    lbCourses.Items.Add(enroll.CourseID);
                    var cost = dt.viewCourses().Find(c => c.CourseID == enroll.CourseID).Cost;
                    total = total + Convert.ToDecimal(cost);
                }             
            }
            txtCost.Text = total.ToString("C");
        }

        private void frmBilling_Load(object sender, EventArgs e)
        {
            cbStudents.Text = "-Select Student-";
            var students = dt.viewStudents();
            foreach (var s in students)
            {
                cbStudents.Items.Add(s.StudentID.ToString()); ;
            }
        }
    }
}