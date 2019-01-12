namespace AppForProjectManagers.Presentation
{
    partial class SeeEmployeeDetails
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
            this.ListOfProjects = new System.Windows.Forms.CheckedListBox();
            this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoursThisWeek = new System.Windows.Forms.TextBox();
            this.btnIndicator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListOfProjects
            // 
            this.ListOfProjects.FormattingEnabled = true;
            this.ListOfProjects.Location = new System.Drawing.Point(130, 254);
            this.ListOfProjects.Name = "ListOfProjects";
            this.ListOfProjects.Size = new System.Drawing.Size(254, 123);
            this.ListOfProjects.TabIndex = 26;
            // 
            // DateOfBirthPicker
            // 
            this.DateOfBirthPicker.Location = new System.Drawing.Point(157, 167);
            this.DateOfBirthPicker.Name = "DateOfBirthPicker";
            this.DateOfBirthPicker.Size = new System.Drawing.Size(200, 22);
            this.DateOfBirthPicker.TabIndex = 25;
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(180, 215);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(155, 24);
            this.cbPosition.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(180, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 22);
            this.txtName.TabIndex = 23;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(180, 92);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(155, 22);
            this.txtSurname.TabIndex = 22;
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(180, 128);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(155, 22);
            this.txtOIB.TabIndex = 21;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(207, 533);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(105, 45);
            this.Edit.TabIndex = 20;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Position:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date of birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "OIB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(35, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Details about an employee:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Hours this week:";
            // 
            // txtHoursThisWeek
            // 
            this.txtHoursThisWeek.Location = new System.Drawing.Point(180, 419);
            this.txtHoursThisWeek.Name = "txtHoursThisWeek";
            this.txtHoursThisWeek.Size = new System.Drawing.Size(155, 22);
            this.txtHoursThisWeek.TabIndex = 28;
            // 
            // btnIndicator
            // 
            this.btnIndicator.Location = new System.Drawing.Point(359, 416);
            this.btnIndicator.Name = "btnIndicator";
            this.btnIndicator.Size = new System.Drawing.Size(94, 25);
            this.btnIndicator.TabIndex = 29;
            this.btnIndicator.UseVisualStyleBackColor = true;
            // 
            // SeeEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 629);
            this.Controls.Add(this.btnIndicator);
            this.Controls.Add(this.txtHoursThisWeek);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ListOfProjects);
            this.Controls.Add(this.DateOfBirthPicker);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SeeEmployeeDetails";
            this.Text = "SeeEmployeeDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ListOfProjects;
        private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoursThisWeek;
        private System.Windows.Forms.Button btnIndicator;
    }
}