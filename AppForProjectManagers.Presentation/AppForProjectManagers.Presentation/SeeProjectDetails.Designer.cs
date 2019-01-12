namespace AppForProjectManagers.Presentation
{
    partial class SeeProjectDetails
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
            this.lblProjectName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfProgrammers = new System.Windows.Forms.Label();
            this.numberOfDesigners = new System.Windows.Forms.Label();
            this.numberOfSecretaries = new System.Windows.Forms.Label();
            this.numberOfAccountants = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listOfEmployees = new System.Windows.Forms.CheckedListBox();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProjectName.Location = new System.Drawing.Point(17, 22);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(0, 25);
            this.lblProjectName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project start and end date:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(225, 67);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(0, 17);
            this.lblDuration.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employees working on the project:";
            // 
            // numberOfProgrammers
            // 
            this.numberOfProgrammers.AutoSize = true;
            this.numberOfProgrammers.Location = new System.Drawing.Point(19, 136);
            this.numberOfProgrammers.Name = "numberOfProgrammers";
            this.numberOfProgrammers.Size = new System.Drawing.Size(170, 17);
            this.numberOfProgrammers.TabIndex = 4;
            this.numberOfProgrammers.Text = "Number of programmers: ";
            // 
            // numberOfDesigners
            // 
            this.numberOfDesigners.AutoSize = true;
            this.numberOfDesigners.Location = new System.Drawing.Point(19, 179);
            this.numberOfDesigners.Name = "numberOfDesigners";
            this.numberOfDesigners.Size = new System.Drawing.Size(148, 17);
            this.numberOfDesigners.TabIndex = 5;
            this.numberOfDesigners.Text = "Number of designers: ";
            // 
            // numberOfSecretaries
            // 
            this.numberOfSecretaries.AutoSize = true;
            this.numberOfSecretaries.Location = new System.Drawing.Point(19, 222);
            this.numberOfSecretaries.Name = "numberOfSecretaries";
            this.numberOfSecretaries.Size = new System.Drawing.Size(156, 17);
            this.numberOfSecretaries.TabIndex = 6;
            this.numberOfSecretaries.Text = "Number of secretaries: ";
            // 
            // numberOfAccountants
            // 
            this.numberOfAccountants.AutoSize = true;
            this.numberOfAccountants.Location = new System.Drawing.Point(19, 276);
            this.numberOfAccountants.Name = "numberOfAccountants";
            this.numberOfAccountants.Size = new System.Drawing.Size(163, 17);
            this.numberOfAccountants.TabIndex = 7;
            this.numberOfAccountants.Text = "Number of accountants: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Employees working on the project by positions:";
            // 
            // listOfEmployees
            // 
            this.listOfEmployees.FormattingEnabled = true;
            this.listOfEmployees.Location = new System.Drawing.Point(410, 136);
            this.listOfEmployees.Name = "listOfEmployees";
            this.listOfEmployees.Size = new System.Drawing.Size(283, 157);
            this.listOfEmployees.TabIndex = 9;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(592, 11);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(101, 36);
            this.Edit.TabIndex = 10;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // SeeProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 340);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.listOfEmployees);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numberOfAccountants);
            this.Controls.Add(this.numberOfSecretaries);
            this.Controls.Add(this.numberOfDesigners);
            this.Controls.Add(this.numberOfProgrammers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProjectName);
            this.Name = "SeeProjectDetails";
            this.Text = "SeeProjectDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberOfProgrammers;
        private System.Windows.Forms.Label numberOfDesigners;
        private System.Windows.Forms.Label numberOfSecretaries;
        private System.Windows.Forms.Label numberOfAccountants;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox listOfEmployees;
        private System.Windows.Forms.Button Edit;
    }
}