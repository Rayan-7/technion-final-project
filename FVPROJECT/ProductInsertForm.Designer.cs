namespace FVPROJECT
{
    partial class ProductInsertForm
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
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.buttonProductInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            this.comboBoxProductSupplier = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelPrev = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxProductCode
            // 
            this.textBoxProductCode.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxProductCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProductCode.Location = new System.Drawing.Point(216, 137);
            this.textBoxProductCode.MaxLength = 30;
            this.textBoxProductCode.Name = "textBoxProductCode";
            this.textBoxProductCode.Size = new System.Drawing.Size(151, 13);
            this.textBoxProductCode.TabIndex = 0;
            this.textBoxProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxProductCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProductCode_KeyPress);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProductName.Location = new System.Drawing.Point(21, 137);
            this.textBoxProductName.MaxLength = 30;
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(151, 13);
            this.textBoxProductName.TabIndex = 1;
            this.textBoxProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProductName_KeyPress);
            // 
            // buttonProductInsert
            // 
            this.buttonProductInsert.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonProductInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductInsert.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonProductInsert.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonProductInsert.Location = new System.Drawing.Point(142, 282);
            this.buttonProductInsert.Name = "buttonProductInsert";
            this.buttonProductInsert.Size = new System.Drawing.Size(75, 35);
            this.buttonProductInsert.TabIndex = 5;
            this.buttonProductInsert.Text = "הוספה";
            this.buttonProductInsert.UseVisualStyleBackColor = false;
            this.buttonProductInsert.Click += new System.EventHandler(this.buttonProductInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(317, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "קוד מוצר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(317, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "סוג מוצר";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(118, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 8;
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
            this.numericUpDownPrice.Location = new System.Drawing.Point(38, 252);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(112, 20);
            this.numericUpDownPrice.TabIndex = 11;
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDownCount.Location = new System.Drawing.Point(38, 190);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(112, 20);
            this.numericUpDownCount.TabIndex = 12;
            this.numericUpDownCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProductType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProductType.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxProductType.FormattingEnabled = true;
            this.comboBoxProductType.Location = new System.Drawing.Point(216, 252);
            this.comboBoxProductType.MaxLength = 30;
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxProductType.Size = new System.Drawing.Size(151, 21);
            this.comboBoxProductType.TabIndex = 13;
            // 
            // comboBoxProductSupplier
            // 
            this.comboBoxProductSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProductSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProductSupplier.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxProductSupplier.FormattingEnabled = true;
            this.comboBoxProductSupplier.Location = new System.Drawing.Point(216, 190);
            this.comboBoxProductSupplier.MaxLength = 30;
            this.comboBoxProductSupplier.Name = "comboBoxProductSupplier";
            this.comboBoxProductSupplier.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxProductSupplier.Size = new System.Drawing.Size(151, 21);
            this.comboBoxProductSupplier.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(338, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "ספק";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panelPrev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 100);
            this.panel1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(114, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "הוספת מוצר";
            // 
            // panelPrev
            // 
            this.panelPrev.BackgroundImage = global::FVPROJECT.Properties.Resources.arrow__2_;
            this.panelPrev.Location = new System.Drawing.Point(21, 12);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(16, 16);
            this.panelPrev.TabIndex = 0;
            this.panelPrev.Click += new System.EventHandler(this.panelPrev_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(216, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 1);
            this.panel2.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(21, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(151, 1);
            this.panel4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(118, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "כמות";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(121, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "שם מוצר";
            // 
            // ProductInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(379, 329);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxProductSupplier);
            this.Controls.Add(this.comboBoxProductType);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonProductInsert);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxProductCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductInsertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInsertForm";
            this.Load += new System.EventHandler(this.ProductInsertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductCode;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Button buttonProductInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.ComboBox comboBoxProductType;
        private System.Windows.Forms.ComboBox comboBoxProductSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPrev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}