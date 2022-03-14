namespace FVPROJECT
{
    partial class DiscountForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPrev = new System.Windows.Forms.Panel();
            this.numericUpDownDiscount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDiscount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelPrev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 69);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(65, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "הנחה";
            // 
            // panelPrev
            // 
            this.panelPrev.BackgroundImage = global::FVPROJECT.Properties.Resources.arrow__2_;
            this.panelPrev.Location = new System.Drawing.Point(23, 12);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(16, 16);
            this.panelPrev.TabIndex = 6;
            this.panelPrev.Click += new System.EventHandler(this.panelPrev_Click);
            // 
            // numericUpDownDiscount
            // 
            this.numericUpDownDiscount.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDownDiscount.DecimalPlaces = 2;
            this.numericUpDownDiscount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownDiscount.Location = new System.Drawing.Point(79, 96);
            this.numericUpDownDiscount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDiscount.Name = "numericUpDownDiscount";
            this.numericUpDownDiscount.Size = new System.Drawing.Size(112, 20);
            this.numericUpDownDiscount.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(159, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "הנחה";
            // 
            // buttonDiscount
            // 
            this.buttonDiscount.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiscount.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonDiscount.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDiscount.Location = new System.Drawing.Point(69, 135);
            this.buttonDiscount.Name = "buttonDiscount";
            this.buttonDiscount.Size = new System.Drawing.Size(69, 30);
            this.buttonDiscount.TabIndex = 14;
            this.buttonDiscount.Text = "הנחה";
            this.buttonDiscount.UseVisualStyleBackColor = false;
            this.buttonDiscount.Click += new System.EventHandler(this.buttonDiscount_Click);
            // 
            // DiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 168);
            this.Controls.Add(this.buttonDiscount);
            this.Controls.Add(this.numericUpDownDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiscountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "discountForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPrev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDiscount;
    }
}