namespace AppForProjectManagers.Presentation
{
    partial class HoursOnProject
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
            this.btnAddHours = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.txtNumberOfHours = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddHours
            // 
            this.btnAddHours.Location = new System.Drawing.Point(216, 87);
            this.btnAddHours.Name = "btnAddHours";
            this.btnAddHours.Size = new System.Drawing.Size(104, 36);
            this.btnAddHours.TabIndex = 0;
            this.btnAddHours.Text = "Confirm";
            this.btnAddHours.UseVisualStyleBackColor = true;
            this.btnAddHours.Click += new System.EventHandler(this.btnAddHours_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Write how many hours employee wih OIB";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(320, 24);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(0, 17);
            this.lblEmployee.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "will be working on project";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(231, 41);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(0, 17);
            this.lblProject.TabIndex = 4;
            // 
            // txtNumberOfHours
            // 
            this.txtNumberOfHours.Location = new System.Drawing.Point(61, 94);
            this.txtNumberOfHours.Name = "txtNumberOfHours";
            this.txtNumberOfHours.Size = new System.Drawing.Size(125, 22);
            this.txtNumberOfHours.TabIndex = 5;
            this.txtNumberOfHours.TextChanged += new System.EventHandler(this.txtNumberOfHours_TextChanged);
            // 
            // HoursOnProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 159);
            this.Controls.Add(this.txtNumberOfHours);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddHours);
            this.Name = "HoursOnProject";
            this.Text = "HoursOnProject";
            this.Load += new System.EventHandler(this.HoursOnProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.TextBox txtNumberOfHours;
    }
}