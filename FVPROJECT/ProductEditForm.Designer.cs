namespace FVPROJECT
{
    partial class ProductEditForm
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
            this.textBoxProductCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            this.comboBoxProductSupplier = new System.Windows.Forms.ComboBox();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.buttonProductUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPrev = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxProductCode
            // 
            this.textBoxProductCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProductCode.Location = new System.Drawing.Point(206, 135);
            this.textBoxProductCode.MaxLength = 30;
            this.textBoxProductCode.Name = "textBoxProductCode";
            this.textBoxProductCode.ReadOnly = true;
            this.textBoxProductCode.Size = new System.Drawing.Size(151, 13);
            this.textBoxProductCode.TabIndex = 1;
            this.textBoxProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(307, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "קוד מוצר";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProductName.Location = new System.Drawing.Point(17, 135);
            this.textBoxProductName.MaxLength = 30;
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(151, 13);
            this.textBoxProductName.TabIndex = 8;
            this.textBoxProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProductType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProductType.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxProductType.FormattingEnabled = true;
            this.comboBoxProductType.Location = new System.Drawing.Point(207, 243);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxProductType.Size = new System.Drawing.Size(151, 21);
            this.comboBoxProductType.TabIndex = 14;
            // 
            // comboBoxProductSupplier
            // 
            this.comboBoxProductSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProductSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProductSupplier.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxProductSupplier.FormattingEnabled = true;
            this.comboBoxProductSupplier.Location = new System.Drawing.Point(207, 185);
            this.comboBoxProductSupplier.Name = "comboBoxProductSupplier";
            this.comboBoxProductSupplier.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxProductSupplier.Size = new System.Drawing.Size(151, 21);
            this.comboBoxProductSupplier.TabIndex = 16;
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDownCount.Location = new System.Drawing.Point(39, 186);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(112, 20);
            this.numericUpDownCount.TabIndex = 17;
            this.numericUpDownCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.numericUpDownPrice.Location = new System.Drawing.Point(35, 243);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(116, 20);
            this.numericUpDownPrice.TabIndex = 18;
            // 
            // buttonProductUpdate
            // 
            this.buttonProductUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonProductUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductUpdate.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonProductUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonProductUpdate.Location = new System.Drawing.Point(138, 286);
            this.buttonProductUpdate.Name = "buttonProductUpdate";
            this.buttonProductUpdate.Size = new System.Drawing.Size(75, 31);
            this.buttonProductUpdate.TabIndex = 19;
            this.buttonProductUpdate.Text = "עדכן";
            this.buttonProductUpdate.UseVisualStyleBackColor = false;
            this.buttonProductUpdate.Click += new System.EventHandler(this.buttonProductUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(117, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "שם מוצר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(328, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "ספק";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(329, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "מוצר";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(119, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "כמות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(119, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "מחיר";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panelPrev);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 100);
            this.panel1.TabIndex = 25;
            // 
            // panelPrev
            // 
            this.panelPrev.BackgroundImage = global::FVPROJECT.Properties.Resources.arrow__2_;
            this.panelPrev.Location = new System.Drawing.Point(17, 12);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(16, 16);
            this.panelPrev.TabIndex = 1;
            this.panelPrev.Click += new System.EventHandler(this.panelPrev_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(119, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "עדכון מוצר";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(207, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 1);
            this.panel2.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(17, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(151, 1);
            this.panel5.TabIndex = 29;
            // 
            // ProductEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(379, 329);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonProductUpdate);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.comboBoxProductSupplier);
            this.Controls.Add(this.comboBoxProductType);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProductCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductEditForm";
            this.Load += new System.EventHandler(this.ProductEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.ComboBox comboBoxProductType;
        private System.Windows.Forms.ComboBox comboBoxProductSupplier;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Button buttonProductUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelPrev;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
    }
}