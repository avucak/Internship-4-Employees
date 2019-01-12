namespace AppForProjectManagers.Presentation
{
    partial class ChooseProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbChooseProject = new System.Windows.Forms.ComboBox();
            this.SeeDetails = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(100, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the project you want to edit or see details for:";
            // 
            // cbChooseProject
            // 
            this.cbChooseProject.FormattingEnabled = true;
            this.cbChooseProject.Location = new System.Drawing.Point(169, 73);
            this.cbChooseProject.Name = "cbChooseProject";
            this.cbChooseProject.Size = new System.Drawing.Size(236, 24);
            this.cbChooseProject.TabIndex = 1;
            // 
            // SeeDetails
            // 
            this.SeeDetails.Location = new System.Drawing.Point(169, 131);
            this.SeeDetails.Name = "SeeDetails";
            this.SeeDetails.Size = new System.Drawing.Size(99, 47);
            this.SeeDetails.TabIndex = 2;
            this.SeeDetails.Text = "See details";
            this.SeeDetails.UseVisualStyleBackColor = true;
            this.SeeDetails.Click += new System.EventHandler(this.SeeDetails_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(303, 131);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(102, 47);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // ChooseProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 240);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.SeeDetails);
            this.Controls.Add(this.cbChooseProject);
            this.Controls.Add(this.label1);
            this.Name = "ChooseProject";
            this.Text = "ChooseProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChooseProject;
        private System.Windows.Forms.Button SeeDetails;
        private System.Windows.Forms.Button Edit;
    }
}