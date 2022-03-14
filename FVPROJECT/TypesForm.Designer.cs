namespace FVPROJECT
{
    partial class TypesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTypes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColorChange = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonInsertType = new System.Windows.Forms.Button();
            this.textBoxTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPrev = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTypes
            // 
            this.dataGridViewTypes.AllowUserToAddRows = false;
            this.dataGridViewTypes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTypes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Delete,
            this.ColorChange});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTypes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTypes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewTypes.Location = new System.Drawing.Point(0, 96);
            this.dataGridViewTypes.Name = "dataGridViewTypes";
            this.dataGridViewTypes.ReadOnly = true;
            this.dataGridViewTypes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewTypes.Size = new System.Drawing.Size(466, 197);
            this.dataGridViewTypes.TabIndex = 0;
            this.dataGridViewTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTypes_CellClick);
            this.dataGridViewTypes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewTypes_KeyDown);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 111.9289F;
            this.Column1.HeaderText = "קוד";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 111.9289F;
            this.Column2.HeaderText = "סוג";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 76.14214F;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // ColorChange
            // 
            this.ColorChange.HeaderText = "";
            this.ColorChange.Name = "ColorChange";
            this.ColorChange.ReadOnly = true;
            // 
            // buttonInsertType
            // 
            this.buttonInsertType.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonInsertType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertType.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonInsertType.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonInsertType.Location = new System.Drawing.Point(264, 68);
            this.buttonInsertType.Name = "buttonInsertType";
            this.buttonInsertType.Size = new System.Drawing.Size(60, 23);
            this.buttonInsertType.TabIndex = 1;
            this.buttonInsertType.Text = "הוספה";
            this.buttonInsertType.UseVisualStyleBackColor = false;
            this.buttonInsertType.Click += new System.EventHandler(this.buttonInsertType_Click);
            // 
            // textBoxTypeName
            // 
            this.textBoxTypeName.ForeColor = System.Drawing.Color.Black;
            this.textBoxTypeName.Location = new System.Drawing.Point(330, 70);
            this.textBoxTypeName.Name = "textBoxTypeName";
            this.textBoxTypeName.Size = new System.Drawing.Size(124, 20);
            this.textBoxTypeName.TabIndex = 2;
            this.textBoxTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTypeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTypeName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "ניהול קטגוריות";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(406, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "שם קטגוריה";
            // 
            // panelPrev
            // 
            this.panelPrev.BackgroundImage = global::FVPROJECT.Properties.Resources.arrow__2_;
            this.panelPrev.Location = new System.Drawing.Point(25, 24);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(16, 16);
            this.panelPrev.TabIndex = 5;
            this.panelPrev.Click += new System.EventHandler(this.panelPrev_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelPrev);
            this.panel1.Controls.Add(this.textBoxTypeName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonInsertType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 98);
            this.panel1.TabIndex = 6;
            // 
            // TypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(466, 293);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewTypes);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypesForm";
            this.Load += new System.EventHandler(this.TypesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTypes;
        private System.Windows.Forms.Button buttonInsertType;
        private System.Windows.Forms.TextBox textBoxTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn ColorChange;
        private System.Windows.Forms.Panel panel1;
    }
}