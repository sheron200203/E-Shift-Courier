namespace E_Shift_Couriers.Forms
{
    partial class LoadForm
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
            this.dgvLoads = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoads)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoads
            // 
            this.dgvLoads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoads.Location = new System.Drawing.Point(12, 67);
            this.dgvLoads.Name = "dgvLoads";
            this.dgvLoads.RowHeadersWidth = 51;
            this.dgvLoads.Size = new System.Drawing.Size(861, 391);
            this.dgvLoads.TabIndex = 9;
            this.dgvLoads.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoads_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(798, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 474);
            this.Controls.Add(this.dgvLoads);
            this.Controls.Add(this.button1);
            this.Name = "LoadForm";
            this.Text = "LoadForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoads;
        private System.Windows.Forms.Button button1;
    }
}