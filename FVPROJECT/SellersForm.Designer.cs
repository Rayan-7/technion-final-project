namespace FVPROJECT
{
    partial class SellersForm
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
            this.dataGridViewSellers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PassReset = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelPrev = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearchSellers = new System.Windows.Forms.TextBox();
            this.buttonSearchSellers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSellerInsert = new System.Windows.Forms.Button();
            this.buttonSendHours = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSellers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSellers
            // 
            this.dataGridViewSellers.AllowUserToAddRows = false;
            this.dataGridViewSellers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSellers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSellers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column10,
            this.Edit,
            this.Delete,
            this.PassReset,
            this.Column8});
            this.dataGridViewSellers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewSellers.Location = new System.Drawing.Point(0, 95);
            this.dataGridViewSellers.Name = "dataGridViewSellers";
            this.dataGridViewSellers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewSellers.RowHeadersWidth = 62;
            this.dataGridViewSellers.Size = new System.Drawing.Size(924, 335);
            this.dataGridViewSellers.TabIndex = 0;
            this.dataGridViewSellers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSellers_CellClick);
            this.dataGridViewSellers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewSellers_KeyDown);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 94.83471F;
            this.Column1.HeaderText = "ת.ז";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 94.83471F;
            this.Column2.HeaderText = "שם";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 94.83471F;
            this.Column3.HeaderText = "שם משפחה";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 94.83471F;
            this.Column4.HeaderText = "מספר טלפון";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 94.83471F;
            this.Column5.HeaderText = "כתובת";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 94.83471F;
            this.Column6.HeaderText = "דואר אלקטרוני";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 94.83471F;
            this.Column7.HeaderText = "שם משתמש";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 94.83471F;
            this.Column9.HeaderText = "תאריך כניסה";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            dataGridViewCellStyle1.Format = "N2";
            this.Column10.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column10.FillWeight = 94.83471F;
            this.Column10.HeaderText = "שעות עבודה";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 94.83471F;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 94.83471F;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            // 
            // PassReset
            // 
            this.PassReset.FillWeight = 156.8182F;
            this.PassReset.HeaderText = "";
            this.PassReset.MinimumWidth = 8;
            this.PassReset.Name = "PassReset";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panelPrev
            // 
            this.panelPrev.BackgroundImage = global::FVPROJECT.Properties.Resources.arrow__2_;
            this.panelPrev.Location = new System.Drawing.Point(43, 12);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(16, 16);
            this.panelPrev.TabIndex = 2;
            this.panelPrev.Click += new System.EventHandler(this.panelPrev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(394, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "ניהול המוכרים";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(971, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "חיפוש";
            // 
            // textBoxSearchSellers
            // 
            this.textBoxSearchSellers.Location = new System.Drawing.Point(745, 70);
            this.textBoxSearchSellers.Name = "textBoxSearchSellers";
            this.textBoxSearchSellers.Size = new System.Drawing.Size(165, 20);
            this.textBoxSearchSellers.TabIndex = 4;
            // 
            // buttonSearchSellers
            // 
            this.buttonSearchSellers.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSearchSellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchSellers.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSearchSellers.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSearchSellers.Location = new System.Drawing.Point(664, 68);
            this.buttonSearchSellers.Name = "buttonSearchSellers";
            this.buttonSearchSellers.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchSellers.TabIndex = 6;
            this.buttonSearchSellers.Text = "חפש";
            this.buttonSearchSellers.UseVisualStyleBackColor = false;
            this.buttonSearchSellers.Click += new System.EventHandler(this.buttonSearchSellers_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.buttonSellerInsert);
            this.panel1.Controls.Add(this.buttonSendHours);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonSearchSellers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelPrev);
            this.panel1.Controls.Add(this.textBoxSearchSellers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 97);
            this.panel1.TabIndex = 7;
            // 
            // buttonSellerInsert
            // 
            this.buttonSellerInsert.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSellerInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSellerInsert.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSellerInsert.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSellerInsert.Location = new System.Drawing.Point(803, 32);
            this.buttonSellerInsert.Name = "buttonSellerInsert";
            this.buttonSellerInsert.Size = new System.Drawing.Size(107, 23);
            this.buttonSellerInsert.TabIndex = 8;
            this.buttonSellerInsert.Text = "הוספת מוכר";
            this.buttonSellerInsert.UseVisualStyleBackColor = false;
            this.buttonSellerInsert.Click += new System.EventHandler(this.buttonSellerInsert_Click);
            // 
            // buttonSendHours
            // 
            this.buttonSendHours.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSendHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendHours.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSendHours.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSendHours.Location = new System.Drawing.Point(53, 68);
            this.buttonSendHours.Name = "buttonSendHours";
            this.buttonSendHours.Size = new System.Drawing.Size(130, 23);
            this.buttonSendHours.TabIndex = 7;
            this.buttonSendHours.Text = "שליחת שעות עבודה";
            this.buttonSendHours.UseVisualStyleBackColor = false;
            this.buttonSendHours.Click += new System.EventHandler(this.buttonSendHours_Click);
            // 
            // SellersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(924, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewSellers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellersForm";
            this.Load += new System.EventHandler(this.SellersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSellers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSellers;
        private System.Windows.Forms.Panel panelPrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearchSellers;
        private System.Windows.Forms.Button buttonSearchSellers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn PassReset;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.Button buttonSendHours;
        private System.Windows.Forms.Button buttonSellerInsert;
    }
}