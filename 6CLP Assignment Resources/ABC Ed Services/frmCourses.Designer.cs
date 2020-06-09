namespace ABC_Ed_Services
{
    partial class frmCourses
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
            this.lbCourses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbCourses
            // 
            this.lbCourses.FormattingEnabled = true;
            this.lbCourses.Location = new System.Drawing.Point(3, -1);
            this.lbCourses.Name = "lbCourses";
            this.lbCourses.Size = new System.Drawing.Size(182, 264);
            this.lbCourses.TabIndex = 1;
            this.lbCourses.SelectedIndexChanged += new System.EventHandler(this.lbCourses_SelectedIndexChanged);
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 266);
            this.Controls.Add(this.lbCourses);
            this.Name = "frmCourses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.frmCourses_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListBox lbCourses;
    }
}