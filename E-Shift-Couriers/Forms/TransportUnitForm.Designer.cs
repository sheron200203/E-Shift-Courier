namespace E_Shift_Couriers.Forms
{
    partial class TransportUnitForm
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
            this.dgvUnits = new System.Windows.Forms.DataGridView();
            this.txtLorry = new System.Windows.Forms.TextBox();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.txtAssistant = new System.Windows.Forms.TextBox();
            this.txtContainer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvUnits
            // 
            this.dgvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnits.Location = new System.Drawing.Point(150, 192);
            this.dgvUnits.Name = "dgvUnits";
            this.dgvUnits.RowHeadersWidth = 51;
            this.dgvUnits.Size = new System.Drawing.Size(498, 150);
            this.dgvUnits.TabIndex = 4;
            this.dgvUnits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtLorry
            // 
            this.txtLorry.Location = new System.Drawing.Point(394, 58);
            this.txtLorry.Name = "txtLorry";
            this.txtLorry.Size = new System.Drawing.Size(100, 20);
            this.txtLorry.TabIndex = 3;
            this.txtLorry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDriver
            // 
            this.txtDriver.Location = new System.Drawing.Point(394, 96);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(100, 20);
            this.txtDriver.TabIndex = 6;
            // 
            // txtAssistant
            // 
            this.txtAssistant.Location = new System.Drawing.Point(394, 122);
            this.txtAssistant.Name = "txtAssistant";
            this.txtAssistant.Size = new System.Drawing.Size(100, 20);
            this.txtAssistant.TabIndex = 7;
            // 
            // txtContainer
            // 
            this.txtContainer.Location = new System.Drawing.Point(394, 167);
            this.txtContainer.Name = "txtContainer";
            this.txtContainer.Size = new System.Drawing.Size(100, 20);
            this.txtContainer.TabIndex = 8;
            // 
            // TransportUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtContainer);
            this.Controls.Add(this.txtAssistant);
            this.Controls.Add(this.txtDriver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvUnits);
            this.Controls.Add(this.txtLorry);
            this.Name = "TransportUnitForm";
            this.Text = "TransportUnitForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvUnits;
        private System.Windows.Forms.TextBox txtLorry;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.TextBox txtAssistant;
        private System.Windows.Forms.TextBox txtContainer;
    }
}