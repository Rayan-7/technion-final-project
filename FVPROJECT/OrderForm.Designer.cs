namespace FVPROJECT
{
    partial class OrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerOrderMin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerOrderMax = new System.Windows.Forms.DateTimePicker();
            this.buttonDateSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPrev = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column9,
            this.Column10});
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 82);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewOrders.Size = new System.Drawing.Size(681, 301);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "קוד הזמנה";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ת.ז";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "שם";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "שם משפחה";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column9
            // 
            dataGridViewCellStyle1.Format = "N2";
            this.Column9.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column9.HeaderText = "מחיר כולל";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "תאריך קניה";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // textBoxSearchOrder
            // 
            this.textBoxSearchOrder.Location = new System.Drawing.Point(504, 61);
            this.textBoxSearchOrder.Name = "textBoxSearchOrder";
            this.textBoxSearchOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxSearchOrder.Size = new System.Drawing.Size(174, 20);
            this.textBoxSearchOrder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(631, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "חיפוש";
            // 
            // dateTimePickerOrderMin
            // 
            this.dateTimePickerOrderMin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOrderMin.Location = new System.Drawing.Point(386, 61);
            this.dateTimePickerOrderMin.Name = "dateTimePickerOrderMin";
            this.dateTimePickerOrderMin.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerOrderMin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(429, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "מתאריך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(351, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "עד";
            // 
            // dateTimePickerOrderMax
            // 
            this.dateTimePickerOrderMax.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOrderMax.Location = new System.Drawing.Point(278, 61);
            this.dateTimePickerOrderMax.Name = "dateTimePickerOrderMax";
            this.dateTimePickerOrderMax.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerOrderMax.TabIndex = 6;
            // 
            // buttonDateSearch
            // 
            this.buttonDateSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDateSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDateSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDateSearch.Location = new System.Drawing.Point(222, 59);
            this.buttonDateSearch.Name = "buttonDateSearch";
            this.buttonDateSearch.Size = new System.Drawing.Size(50, 23);
            this.buttonDateSearch.TabIndex = 7;
            this.buttonDateSearch.Text = "חפש";
            this.buttonDateSearch.UseVisualStyleBackColor = false;
            this.buttonDateSearch.Click += new System.EventHandler(this.buttonDateSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(295, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "הזמנות";
            // 
            // panelPrev
            // 
            this.panelPrev.BackgroundImage = global::FVPROJECT.Properties.Resources.arrow__2_;
            this.panelPrev.Location = new System.Drawing.Point(27, 17);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(16, 16);
            this.panelPrev.TabIndex = 8;
            this.panelPrev.Click += new System.EventHandler(this.panelPrev_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.textBoxSearchOrder);
            this.panel1.Controls.Add(this.panelPrev);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonDateSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerOrderMin);
            this.panel1.Controls.Add(this.dateTimePickerOrderMax);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 84);
            this.panel1.TabIndex = 10;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(681, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.TextBox textBoxSearchOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderMax;
        private System.Windows.Forms.Button buttonDateSearch;
        private System.Windows.Forms.Panel panelPrev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Panel panel1;
    }
}