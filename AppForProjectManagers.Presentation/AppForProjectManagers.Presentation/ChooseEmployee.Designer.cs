﻿namespace AppForProjectManagers.Presentation
{
    partial class ChooseEmployee
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
            this.cbChooseEmployee = new System.Windows.Forms.ComboBox();
            this.btnSeeDetails = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the employee you want to see details for or edit:";
            // 
            // cbChooseEmployee
            // 
            this.cbChooseEmployee.FormattingEnabled = true;
            this.cbChooseEmployee.Location = new System.Drawing.Point(92, 73);
            this.cbChooseEmployee.Name = "cbChooseEmployee";
            this.cbChooseEmployee.Size = new System.Drawing.Size(218, 24);
            this.cbChooseEmployee.TabIndex = 1;
            // 
            // btnSeeDetails
            // 
            this.btnSeeDetails.Location = new System.Drawing.Point(138, 120);
            this.btnSeeDetails.Name = "btnSeeDetails";
            this.btnSeeDetails.Size = new System.Drawing.Size(121, 38);
            this.btnSeeDetails.TabIndex = 2;
            this.btnSeeDetails.Text = "See Details";
            this.btnSeeDetails.UseVisualStyleBackColor = true;
            this.btnSeeDetails.Click += new System.EventHandler(this.btnSeeDetails_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(138, 180);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(121, 42);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // ChooseEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 255);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.btnSeeDetails);
            this.Controls.Add(this.cbChooseEmployee);
            this.Controls.Add(this.label1);
            this.Name = "ChooseEmployee";
            this.Text = "ChooseEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChooseEmployee;
        private System.Windows.Forms.Button btnSeeDetails;
        private System.Windows.Forms.Button Edit;
    }
}