﻿namespace PR1_SaveOcean2_Qihang
{
    partial class FormResult
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
            lblResult = new Label();
            btnHome = new Button();
            lblAffectation = new Label();
            lblExperience = new Label();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 20F);
            lblResult.Location = new Point(12, 31);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(534, 76);
            lblResult.TabIndex = 0;
            lblResult.Text = "CONGRATULATIONS, IT HAS BEEN A SUCCES";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Segoe UI", 12F);
            btnHome.Location = new Point(192, 189);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(177, 38);
            btnHome.TabIndex = 1;
            btnHome.Text = "RETURN TO MENU";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnSave_Click;
            // 
            // lblAffectation
            // 
            lblAffectation.Font = new Font("Segoe UI", 12F);
            lblAffectation.Location = new Point(148, 119);
            lblAffectation.Name = "lblAffectation";
            lblAffectation.Size = new Size(269, 28);
            lblAffectation.TabIndex = 2;
            lblAffectation.Text = "Affectation grade:";
            lblAffectation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblExperience
            // 
            lblExperience.Font = new Font("Segoe UI", 12F);
            lblExperience.Location = new Point(148, 147);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(269, 28);
            lblExperience.TabIndex = 3;
            lblExperience.Text = "Player experience:";
            lblExperience.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ocean;
            ClientSize = new Size(558, 250);
            Controls.Add(lblExperience);
            Controls.Add(lblAffectation);
            Controls.Add(btnHome);
            Controls.Add(lblResult);
            Name = "FormResult";
            Text = "Game result";
            Load += FormResult_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblResult;
        private Button btnHome;
        private Label lblAffectation;
        private Label lblExperience;
    }
}