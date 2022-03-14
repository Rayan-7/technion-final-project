namespace FVPROJECT
{
    partial class ProductsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonProductInsert1 = new System.Windows.Forms.Button();
            this.buttonInsertTypes = new System.Windows.Forms.Button();
            this.textBoxSearchProducts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelPrev = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.buttonOrderSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column4,
            this.Column3,
            this.Column7,
            this.Column2,
            this.Column1,
            this.Column6,
            this.Edit,
            this.Delete,
            this.Column8});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 94);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewProducts.Size = new System.Drawing.Size(898, 356);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
            this.dataGridViewProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewProducts_KeyDown);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "קוד מוצר";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "שם מוצר";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "סוג מוצר";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "שם הספק";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "כמות";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle10.Format = "N2";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column1.HeaderText = "מחיר";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "תאריך";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "קוד ספק";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // buttonProductInsert1
            // 
            this.buttonProductInsert1.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonProductInsert1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductInsert1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonProductInsert1.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonProductInsert1.Location = new System.Drawing.Point(811, 12);
            this.buttonProductInsert1.Name = "buttonProductInsert1";
            this.buttonProductInsert1.Size = new System.Drawing.Size(75, 23);
            this.buttonProductInsert1.TabIndex = 1;
            this.buttonProductInsert1.Text = "הוסף מוצר";
            this.buttonProductInsert1.UseVisualStyleBackColor = false;
            this.buttonProductInsert1.Click += new System.EventHandler(this.buttonProductInsert1_Click);
            // 
            // buttonInsertTypes
            // 
            this.buttonInsertTypes.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonInsertTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertTypes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonInsertTypes.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonInsertTypes.Location = new System.Drawing.Point(664, 12);
            this.buttonInsertTypes.Name = "buttonInsertTypes";
            this.buttonInsertTypes.Size = new System.Drawing.Size(123, 23);
            this.buttonInsertTypes.TabIndex = 2;
            this.buttonInsertTypes.Text = "הוסף סוג מוצר";
            this.buttonInsertTypes.UseVisualStyleBackColor = false;
            this.buttonInsertTypes.Click += new System.EventHandler(this.buttonInsertTypes_Click);
            this.buttonInsertTypes.MouseHover += new System.EventHandler(this.buttonInsertTypes_MouseHover);
            // 
            // textBoxSearchProducts
            // 
            this.textBoxSearchProducts.Location = new System.Drawing.Point(729, 68);
            this.textBoxSearchProducts.Name = "textBoxSearchProducts";
            this.textBoxSearchProducts.Size = new System.Drawing.Size(143, 20);
            this.textBoxSearchProducts.TabIndex = 4;
            this.textBoxSearchProducts.TextChanged += new System.EventHandler(this.textBoxSearchProducts_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(825, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "חיפוש";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::FVPROJECT.Properties.Resources.iconfinder_new_24_103173;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // panelPrev
            // 
            this.panelPrev.BackgroundImage = global::FVPROJECT.Properties.Resources.arrow__2_;
            this.panelPrev.Location = new System.Drawing.Point(37, 35);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(16, 16);
            this.panelPrev.TabIndex = 6;
            this.panelPrev.Click += new System.EventHandler(this.panelPrev_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(387, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "מוצרים";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numericUpDownCount);
            this.panel1.Controls.Add(this.buttonOrderSupplier);
            this.panel1.Controls.Add(this.panelPrev);
            this.panel1.Controls.Add(this.textBoxSearchProducts);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonInsertTypes);
            this.panel1.Controls.Add(this.buttonProductInsert1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 97);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(212, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "כמות";
            this.label3.Visible = false;
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDownCount.Location = new System.Drawing.Point(193, 71);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownCount.TabIndex = 14;
            this.numericUpDownCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCount.Visible = false;
            // 
            // buttonOrderSupplier
            // 
            this.buttonOrderSupplier.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonOrderSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderSupplier.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonOrderSupplier.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOrderSupplier.Location = new System.Drawing.Point(86, 68);
            this.buttonOrderSupplier.Name = "buttonOrderSupplier";
            this.buttonOrderSupplier.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderSupplier.TabIndex = 8;
            this.buttonOrderSupplier.Text = "הזמן";
            this.buttonOrderSupplier.UseVisualStyleBackColor = false;
            this.buttonOrderSupplier.Visible = false;
            this.buttonOrderSupplier.Click += new System.EventHandler(this.buttonOrderSupplier_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsBtnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button buttonProductInsert1;
        private System.Windows.Forms.Button buttonInsertTypes;
        private System.Windows.Forms.TextBox textBoxSearchProducts;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Panel panelPrev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button buttonOrderSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
    }
}