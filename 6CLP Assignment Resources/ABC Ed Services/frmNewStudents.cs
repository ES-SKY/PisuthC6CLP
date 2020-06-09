using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABC_Ed_Services
{
    public partial class frmNewStudents : Form
    {
        public frmNewStudents()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Tafe_DataTier dt = new Tafe_DataTier();
            int rowsInserted = dt.insertStudent(txtID.Text, txtName.Text, dtpEnrollment.Value);
            if (rowsInserted > 0)
            {
                MessageBox.Show("New Student Information Saved", "Add Student",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("New Student Information NOT Saved", "Add Student", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}