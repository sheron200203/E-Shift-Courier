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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(680, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvUnits
            // 
            this.dgvUnits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnits.Location = new System.Drawing.Point(26, 222);
            this.dgvUnits.Name = "dgvUnits";
            this.dgvUnits.RowHeadersWidth = 51;
            this.dgvUnits.Size = new System.Drawing.Size(750, 189);
            this.dgvUnits.TabIndex = 4;
            this.dgvUnits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtLorry
            // 
            this.txtLorry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLorry.Location = new System.Drawing.Point(132, 50);
            this.txtLorry.Name = "txtLorry";
            this.txtLorry.Size = new System.Drawing.Size(223, 20);
            this.txtLorry.TabIndex = 3;
            this.txtLorry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDriver
            // 
            this.txtDriver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDriver.Location = new System.Drawing.Point(132, 88);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(223, 20);
            this.txtDriver.TabIndex = 6;
            // 
            // txtAssistant
            // 
            this.txtAssistant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAssistant.Location = new System.Drawing.Point(554, 44);
            this.txtAssistant.Name = "txtAssistant";
            this.txtAssistant.Size = new System.Drawing.Size(223, 20);
            this.txtAssistant.TabIndex = 7;
            // 
            // txtContainer
            // 
            this.txtContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContainer.Location = new System.Drawing.Point(554, 89);
            this.txtContainer.Name = "txtContainer";
            this.txtContainer.Size = new System.Drawing.Size(223, 20);
            this.txtContainer.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lorry Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Driver";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Driver Assistant";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Container Type";
            // 
            // TransportUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContainer);
            this.Controls.Add(this.txtAssistant);
            this.Controls.Add(this.txtDriver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvUnits);
            this.Controls.Add(this.txtLorry);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "TransportUnitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}