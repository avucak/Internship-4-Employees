﻿namespace AppForProjectManagers.Presentation
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSeeDetailsEmployees = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add an employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeeDetailsEmployees
            // 
            this.btnSeeDetailsEmployees.Location = new System.Drawing.Point(118, 112);
            this.btnSeeDetailsEmployees.Name = "btnSeeDetailsEmployees";
            this.btnSeeDetailsEmployees.Size = new System.Drawing.Size(252, 37);
            this.btnSeeDetailsEmployees.TabIndex = 1;
            this.btnSeeDetailsEmployees.Text = "See details about employees";
            this.btnSeeDetailsEmployees.UseVisualStyleBackColor = true;
            this.btnSeeDetailsEmployees.Click += new System.EventHandler(this.btnSeeDetailsEmployees_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(118, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(118, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSeeDetailsEmployees);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSeeDetailsEmployees;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

