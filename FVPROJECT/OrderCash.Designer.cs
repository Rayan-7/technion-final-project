namespace FVPROJECT
{
    partial class OrderCash
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCash = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPayNow = new System.Windows.Forms.Button();
            this.comboBoxClientId = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPrev = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCash)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Location = new System.Drawing.Point(12, 102);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxName.Size = new System.Drawing.Size(151, 13);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastName.Location = new System.Drawing.Point(228, 165);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxLastName.Size = new System.Drawing.Size(151, 13);
            this.textBoxLastName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(357, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ת.ז";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(139, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "שם";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(313, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "שם משפחה";
            // 
            // numericUpDownCash
            // 
            this.numericUpDownCash.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDownCash.DecimalPlaces = 2;
            this.numericUpDownCash.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownCash.Location = new System.Drawing.Point(41, 161);
            this.numericUpDownCash.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCash.Name = "numericUpDownCash";
            this.numericUpDownCash.Size = new System.Drawing.Size(108, 20);
            this.numericUpDownCash.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(73, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "תשלום במזומן";
            // 
            // buttonPayNow
            // 
            this.buttonPayNow.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonPayNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayNow.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPayNow.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPayNow.Location = new System.Drawing.Point(152, 214);
            this.buttonPayNow.Name = "buttonPayNow";
            this.buttonPayNow.Size = new System.Drawing.Size(97, 42);
            this.buttonPayNow.TabIndex = 8;
            this.buttonPayNow.Text = "בצע הזמנה";
            this.buttonPayNow.UseVisualStyleBackColor = false;
            this.buttonPayNow.Click += new System.EventHandler(this.buttonPayNow_Click);
            // 
            // comboBoxClientId
            // 
            this.comboBoxClientId.AllowDrop = true;
            this.comboBoxClientId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxClientId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxClientId.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxClientId.FormattingEnabled = true;
            this.comboBoxClientId.Location = new System.Drawing.Point(228, 97);
            this.comboBoxClientId.MaxLength = 30;
            this.comboBoxClientId.Name = "comboBoxClientId";
            this.comboBoxClientId.Size = new System.Drawing.Size(151, 21);
            this.comboBoxClientId.TabIndex = 9;
            this.comboBoxClientId.TextChanged += new System.EventHandler(this.comboBoxClientId_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panelPrev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 73);
            this.panel1.TabIndex = 10;
            // 
            // panelPrev
            // 
            this.panelPrev.BackgroundImage = global::FVPROJECT.Properties.Resources.arrow__2_;
            this.panelPrev.Location = new System.Drawing.Point(22, 12);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(16, 16);
            this.panelPrev.TabIndex = 0;
            this.panelPrev.Click += new System.EventHandler(this.panelPrev_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(12, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 1);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(228, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 1);
            this.panel3.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(134, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "ביצוע ההזמנה";
            // 
            // OrderCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(421, 259);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxClientId);
            this.Controls.Add(this.buttonPayNow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderCash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderCash";
            this.Load += new System.EventHandler(this.OrderCash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCash)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonPayNow;
        private System.Windows.Forms.ComboBox comboBoxClientId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelPrev;
        private System.Windows.Forms.Label label5;
    }
}