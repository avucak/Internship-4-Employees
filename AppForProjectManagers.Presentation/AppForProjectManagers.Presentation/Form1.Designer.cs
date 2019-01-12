namespace AppForProjectManagers.Presentation
{
    partial class Form1
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
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnSeeDetailsEmployees = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.AddProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(118, 56);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(252, 35);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add an employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnSeeDetailsEmployees
            // 
            this.btnSeeDetailsEmployees.Location = new System.Drawing.Point(118, 112);
            this.btnSeeDetailsEmployees.Name = "btnSeeDetailsEmployees";
            this.btnSeeDetailsEmployees.Size = new System.Drawing.Size(252, 37);
            this.btnSeeDetailsEmployees.TabIndex = 1;
            this.btnSeeDetailsEmployees.Text = "See details about employees or edit";
            this.btnSeeDetailsEmployees.UseVisualStyleBackColor = true;
            this.btnSeeDetailsEmployees.Click += new System.EventHandler(this.BtnSeeDetailsEmployees_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(118, 174);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(252, 37);
            this.btnDeleteEmployee.TabIndex = 3;
            this.btnDeleteEmployee.Text = "Delete an employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // AddProject
            // 
            this.AddProject.Location = new System.Drawing.Point(425, 56);
            this.AddProject.Name = "AddProject";
            this.AddProject.Size = new System.Drawing.Size(259, 35);
            this.AddProject.TabIndex = 4;
            this.AddProject.Text = "Add a project";
            this.AddProject.UseVisualStyleBackColor = true;
            this.AddProject.Click += new System.EventHandler(this.AddProject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddProject);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnSeeDetailsEmployees);
            this.Controls.Add(this.btnAddEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnSeeDetailsEmployees;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button AddProject;
    }
}

