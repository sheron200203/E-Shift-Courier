namespace E_Shift_Couriers.Forms.CustomerForms
{
    partial class CustomerJobForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.dtRequestedDate = new System.Windows.Forms.DateTimePicker();
            this.txtStart = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Job Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "End Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Start Location";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(499, 86);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 20);
            this.txtEnd.TabIndex = 15;
            // 
            // dgvJobs
            // 
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Location = new System.Drawing.Point(12, 221);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.RowHeadersWidth = 51;
            this.dgvJobs.Size = new System.Drawing.Size(776, 217);
            this.dgvJobs.TabIndex = 14;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(557, 127);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtRequestedDate
            // 
            this.dtRequestedDate.Location = new System.Drawing.Point(293, 127);
            this.dtRequestedDate.Name = "dtRequestedDate";
            this.dtRequestedDate.Size = new System.Drawing.Size(200, 20);
            this.dtRequestedDate.TabIndex = 12;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(296, 81);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 20);
            this.txtStart.TabIndex = 11;
            // 
            // CustomerJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dtRequestedDate);
            this.Controls.Add(this.txtStart);
            this.Name = "CustomerJobForm";
            this.Text = "CustomerJobForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DateTimePicker dtRequestedDate;
        private System.Windows.Forms.TextBox txtStart;
    }
}