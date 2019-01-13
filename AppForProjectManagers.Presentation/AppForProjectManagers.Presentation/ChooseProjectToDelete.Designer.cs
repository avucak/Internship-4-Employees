namespace AppForProjectManagers.Presentation
{
    partial class ChooseProjectToDelete
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
            this.cbChooseProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbChooseProject
            // 
            this.cbChooseProject.FormattingEnabled = true;
            this.cbChooseProject.Location = new System.Drawing.Point(116, 91);
            this.cbChooseProject.Name = "cbChooseProject";
            this.cbChooseProject.Size = new System.Drawing.Size(236, 24);
            this.cbChooseProject.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(88, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose the project you want to delete:";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(189, 146);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(87, 46);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ChooseProjectToDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 222);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.cbChooseProject);
            this.Controls.Add(this.label1);
            this.Name = "ChooseProjectToDelete";
            this.Text = "ChooseProjectToDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbChooseProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
    }
}