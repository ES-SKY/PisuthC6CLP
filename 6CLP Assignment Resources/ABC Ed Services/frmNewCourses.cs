using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABC_Ed_Services
{
    public partial class frmNewCourses : Form
    {
        public frmNewCourses()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Tafe_DataTier dt = new Tafe_DataTier();

            if (this.validateData())
            {
                try
                {
                    int rowsInserted = dt.insertCourse(txtID.Text, txtName.Text, Decimal.Parse(txtCost.Text));
                    if (rowsInserted > 0)
                    {
                        MessageBox.Show("New Course Information Saved", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("New Course Information NOT Saved", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewCourses_Load(object sender, EventArgs e)
        {

        }
        private bool validateData()
        {
            if (string.IsNullOrEmpty(txtCost.Text))
                return false;
            if (string.IsNullOrEmpty(txtID.Text))
                return false;
            if (string.IsNullOrEmpty(txtName.Text))
                return false;
            else
                return true;
        }
    }
}