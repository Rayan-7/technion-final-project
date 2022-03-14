namespace FVPROJECT
{
    partial class SuppliersForm
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
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonInsertSupplier1 = new System.Windows.Forms.Button();
            this.textBoxSearchProducts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPrev = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.AllowUserToAddRows = false;
            this.dataGridViewSuppliers.AllowUserToDeleteRows = false;
            this.dataGridViewSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSuppliers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Edit,
            this.Delete});
            this.dataGridViewSuppliers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(0, 95);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.ReadOnly = true;
            this.dataGridViewSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(713, 313);
            this.dataGridViewSuppliers.TabIndex = 0;
            this.dataGridViewSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuppliers_CellClick);
            this.dataGridViewSuppliers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewSuppliers_KeyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ת.ז/עוסק מורשה/ח.פ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "שם ספק/שם החברה";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "מספר טלפון";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "איש קשר";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "כתובת";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "דואר אלקטרוני";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // buttonInsertSupplier1
            // 
            this.buttonInsertSupplier1.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonInsertSupplier1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertSupplier1.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonInsertSupplier1.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonInsertSupplier1.Location = new System.Drawing.Point(624, 9);
            this.buttonInsertSupplier1.Name = "buttonInsertSupplier1";
            this.buttonInsertSupplier1.Size = new System.Drawing.Size(77, 23);
            this.buttonInsertSupplier1.TabIndex = 1;
            this.buttonInsertSupplier1.Text = "הוסף ספק";
            this.buttonInsertSupplier1.UseVisualStyleBackColor = false;
            this.buttonInsertSupplier1.Click += new System.EventHandler(this.buttonInsertSupplier1_Click);
            // 
            // textBoxSearchProducts
            // 
            this.textBoxSearchProducts.Location = new System.Drawing.Point(552, 69);
            this.textBoxSearchProducts.Name = "textBoxSearchProducts";
            this.textBoxSearchProducts.Size = new System.Drawing.Size(149, 20);
            this.textBoxSearchProducts.TabIndex = 3;
            this.textBoxSearchProducts.TextChanged += new System.EventHandler(this.textBoxSearchProducts_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(654, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "חיפוש";
            // 
            // panelPrev
            // 
            this.panelPrev.BackgroundImage = global::FVPROJECT.Properties.Resources.arrow__2_;
            this.panelPrev.Location = new System.Drawing.Point(33, 16);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(16, 16);
            this.panelPrev.TabIndex = 5;
            this.panelPrev.Click += new System.EventHandler(this.panelPrev_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(271, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "ניהול הספקים";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelPrev);
            this.panel1.Controls.Add(this.textBoxSearchProducts);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonInsertSupplier1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 98);
            this.panel1.TabIndex = 7;
            // 
            // SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(713, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewSuppliers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuppliersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierForm";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonInsertSupplier1;
        private System.Windows.Forms.TextBox textBoxSearchProducts;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Panel panelPrev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}