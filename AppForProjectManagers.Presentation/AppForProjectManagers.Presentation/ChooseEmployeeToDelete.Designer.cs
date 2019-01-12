namespace AppForProjectManagers.Presentation
{
    partial class ChooseEmployeeToDelete
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
            this.cbChooseEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbChooseEmployee
            // 
            this.cbChooseEmployee.FormattingEnabled = true;
            this.cbChooseEmployee.Location = new System.Drawing.Point(96, 80);
            this.cbChooseEmployee.Name = "cbChooseEmployee";
            this.cbChooseEmployee.Size = new System.Drawing.Size(218, 24);
            this.cbChooseEmployee.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose the employee you want to delete:";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(167, 128);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ChooseEmployeeToDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 195);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.cbChooseEmployee);
            this.Controls.Add(this.label1);
            this.Name = "ChooseEmployeeToDelete";
            this.Text = "ChooseEmployeeToDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChooseEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
    }
}