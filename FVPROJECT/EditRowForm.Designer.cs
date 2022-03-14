namespace FVPROJECT
{
    partial class EditRowForm
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
            this.panelPrev = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.buttonProductUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panelPrev);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 80);
            this.panel1.TabIndex = 0;
            // 
            // panelPrev
            // 
            this.panelPrev.BackgroundImage = global::FVPROJECT.Properties.Resources.arrow__2_;
            this.panelPrev.Location = new System.Drawing.Point(12, 12);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(16, 16);
            this.panelPrev.TabIndex = 30;
            this.panelPrev.Click += new System.EventHandler(this.panelPrev_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(73, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "עריכת שורה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(203, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "תיאור פריט";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(169, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 1);
            this.panel2.TabIndex = 16;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxName.Location = new System.Drawing.Point(169, 126);
            this.textBoxName.MaxLength = 15;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxName.Size = new System.Drawing.Size(94, 16);
            this.textBoxName.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(90, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "מחיר";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPrice.Location = new System.Drawing.Point(28, 126);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(94, 20);
            this.numericUpDownPrice.TabIndex = 26;
            // 
            // buttonProductUpdate
            // 
            this.buttonProductUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonProductUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductUpdate.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonProductUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonProductUpdate.Location = new System.Drawing.Point(104, 174);
            this.buttonProductUpdate.Name = "buttonProductUpdate";
            this.buttonProductUpdate.Size = new System.Drawing.Size(64, 31);
            this.buttonProductUpdate.TabIndex = 29;
            this.buttonProductUpdate.Text = "עדכן";
            this.buttonProductUpdate.UseVisualStyleBackColor = false;
            this.buttonProductUpdate.Click += new System.EventHandler(this.buttonProductUpdate_Click);
            // 
            // EditRowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 221);
            this.Controls.Add(this.buttonProductUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditRowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditRow";
            this.Load += new System.EventHandler(this.EditRowForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Button buttonProductUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelPrev;
    }
}