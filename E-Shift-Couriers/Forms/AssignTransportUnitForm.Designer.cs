﻿namespace E_Shift_Couriers.Forms
{
    partial class AssignTransportUnitForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Transport Unit";
            // 
            // cmbUnits
            // 
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Location = new System.Drawing.Point(323, 180);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(121, 21);
            this.cmbUnits.TabIndex = 25;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(510, 247);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 23);
            this.btnAssign.TabIndex = 24;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // AssignTransportUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbUnits);
            this.Controls.Add(this.btnAssign);
            this.Name = "AssignTransportUnitForm";
            this.Text = "AssignTransportUnitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.Button btnAssign;
    }
}