namespace E_Shift_Couriers.Forms
{
    partial class ReportsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.dgvJobSummary = new System.Windows.Forms.DataGridView();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.dgvCustomerJobs = new System.Windows.Forms.DataGridView();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.dgvTransportUtil = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobSummary)).BeginInit();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerJobs)).BeginInit();
            this.tab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportUtil)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Controls.Add(this.tab3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.dgvJobSummary);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(792, 427);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Job Summary";
            // 
            // dgvJobSummary
            // 
            this.dgvJobSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobSummary.Location = new System.Drawing.Point(8, 82);
            this.dgvJobSummary.Name = "dgvJobSummary";
            this.dgvJobSummary.RowHeadersWidth = 51;
            this.dgvJobSummary.Size = new System.Drawing.Size(776, 339);
            this.dgvJobSummary.TabIndex = 0;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.dgvCustomerJobs);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(792, 427);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "CustomerJobs";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // dgvCustomerJobs
            // 
            this.dgvCustomerJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerJobs.Location = new System.Drawing.Point(0, 98);
            this.dgvCustomerJobs.Name = "dgvCustomerJobs";
            this.dgvCustomerJobs.RowHeadersWidth = 51;
            this.dgvCustomerJobs.Size = new System.Drawing.Size(796, 326);
            this.dgvCustomerJobs.TabIndex = 0;
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.dgvTransportUtil);
            this.tab3.Location = new System.Drawing.Point(4, 25);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(792, 424);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "Transport";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // dgvTransportUtil
            // 
            this.dgvTransportUtil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportUtil.Location = new System.Drawing.Point(4, 81);
            this.dgvTransportUtil.Name = "dgvTransportUtil";
            this.dgvTransportUtil.RowHeadersWidth = 51;
            this.dgvTransportUtil.Size = new System.Drawing.Size(788, 343);
            this.dgvTransportUtil.TabIndex = 0;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsForm";
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobSummary)).EndInit();
            this.tab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerJobs)).EndInit();
            this.tab3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportUtil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.DataGridView dgvJobSummary;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.DataGridView dgvCustomerJobs;
        private System.Windows.Forms.DataGridView dgvTransportUtil;
    }
}