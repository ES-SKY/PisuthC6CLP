namespace ABC_Ed_Services
{
    partial class frmNewStudents
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
            this.dtpEnrollment = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpEnrollment
            // 
            this.dtpEnrollment.Location = new System.Drawing.Point(97, 94);
            this.dtpEnrollment.Name = "dtpEnrollment";
            this.dtpEnrollment.Size = new System.Drawing.Size(153, 20);
            this.dtpEnrollment.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(113, 20);
            this.txtName.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(99, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(73, 20);
            this.txtID.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(97, 143);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(7, 98);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(71, 13);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Date Enrolled";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(4, 58);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(35, 13);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Name";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(18, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "ID";
            // 
            // frmNewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 182);
            this.Controls.Add(this.dtpEnrollment);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "frmNewStudents";
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker dtpEnrollment;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}