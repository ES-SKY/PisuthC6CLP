namespace ABC_Ed_Services
{
    partial class frmNewCourses
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
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(99, 103);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(75, 20);
            this.txtCost.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(99, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 11;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(13, 103);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(28, 13);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Cost";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 57);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Course Name";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(54, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Course ID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(99, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 189);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmNewCourses";
            this.Text = "Add New Course";
            this.Load += new System.EventHandler(this.frmNewCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtCost;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
    }
}