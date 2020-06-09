using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABC_Ed_Services
{
    public partial class frmStudents : Form
    {
        private TafeDBDataSet.StudentDataTable table;

        public frmStudents()
        {
            InitializeComponent();
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
         
            Tafe_DataTier dt = new Tafe_DataTier();
            var students = dt.viewStudents();


            foreach (var s in students)
            {
                lbStudents.Items.Add(s.StudentID.ToString() + "-->" + s.StduentName.ToString()); ;

            }
        }
    }
}
