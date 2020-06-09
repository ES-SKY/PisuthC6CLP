using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABC_Ed_Services
{
   
    public partial class frmCourses : Form
    {
        private TafeDBDataSet.CourseDataTable table;

        public frmCourses()
        {
            InitializeComponent();
        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
            Tafe_DataTier dt = new Tafe_DataTier();
            var courses = dt.viewCourses();


            foreach (var c in courses)
            {
                lbCourses.Items.Add(c.CourseID.ToString() + "-->" + c.CourseName.ToString()); ;

            }
        }

        private void lbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}