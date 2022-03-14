namespace FVPROJECT
{
    partial class ManagersForm
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
            this.dataGridViewManagers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSearchManager = new System.Windows.Forms.Button();
            this.textBoxSearchManager = new System.Windows.Forms.TextBox();
            this.buttonManagerInsert1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPrev = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RestPass = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewManagers
            // 
            this.dataGridViewManagers.AllowUserToAddRows = false;
            this.dataGridViewManagers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewManagers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManagers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.EntryDate,
            this.Edit,
            this.Delete,
            this.RestPass});
            this.dataGridViewManagers.Location = new System.Drawing.Point(0, 152);
            this.dataGridViewManagers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewManagers.Name = "dataGridViewManagers";
            this.dataGridViewManagers.ReadOnly = true;
            this.dataGridViewManagers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewManagers.RowHeadersWidth = 62;
            this.dataGridViewManagers.Size = new System.Drawing.Size(1251, 382);
            this.dataGridViewManagers.TabIndex = 0;
            this.dataGridViewManagers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManagers_CellClick);
            this.dataGridViewManagers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewManagers_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.buttonSearchManager);
            this.panel1.Controls.Add(this.textBoxSearchManager);
            this.panel1.Controls.Add(this.buttonManagerInsert1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelPrev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 154);
            this.panel1.TabIndex = 1;
            // 
            // buttonSearchManager
            // 
            this.buttonSearchManager.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSearchManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchManager.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSearchManager.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSearchManager.Location = new System.Drawing.Point(972, 118);
            this.buttonSearchManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearchManager.Name = "buttonSearchManager";
            this.buttonSearchManager.Size = new System.Drawing.Size(80, 35);
            this.buttonSearchManager.TabIndex = 5;
            this.buttonSearchManager.Text = "חפש";
            this.buttonSearchManager.UseVisualStyleBackColor = false;
            // 
            // textBoxSearchManager
            // 
            this.textBoxSearchManager.Location = new System.Drawing.Point(1060, 123);
            this.textBoxSearchManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSearchManager.Name = "textBoxSearchManager";
            this.textBoxSearchManager.Size = new System.Drawing.Size(184, 26);
            this.textBoxSearchManager.TabIndex = 4;
            // 
            // buttonManagerInsert1
            // 
            this.buttonManagerInsert1.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonManagerInsert1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManagerInsert1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonManagerInsert1.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonManagerInsert1.Location = new System.Drawing.Point(1134, 77);
            this.buttonManagerInsert1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonManagerInsert1.Name = "buttonManagerInsert1";
            this.buttonManagerInsert1.Size = new System.Drawing.Size(112, 35);
            this.buttonManagerInsert1.TabIndex = 2;
            this.buttonManagerInsert1.Text = "הוסף מנהל";
            this.buttonManagerInsert1.UseVisualStyleBackColor = false;
            this.buttonManagerInsert1.Click += new System.EventHandler(this.buttonManagerInsert1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(488, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "ניהול המנהלים";
            // 
            // panelPrev
            // 
            this.panelPrev.BackColor = System.Drawing.Color.Transparent;
            this.panelPrev.BackgroundImage = global::FVPROJECT.Properties.Resources.arrow__2_;
            this.panelPrev.Location = new System.Drawing.Point(48, 18);
            this.panelPrev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(24, 25);
            this.panelPrev.TabIndex = 2;
            this.panelPrev.Click += new System.EventHandler(this.panelPrev_Click);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 95.625F;
            this.Column1.HeaderText = "ת.ז";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 95.625F;
            this.Column2.HeaderText = "שם";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 95.625F;
            this.Column3.HeaderText = "שם משפחה";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 95.625F;
            this.Column4.HeaderText = "מספר טלפון";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 95.625F;
            this.Column5.HeaderText = "כתובת";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 95.625F;
            this.Column6.HeaderText = "דואר אלקטרוני";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 95.625F;
            this.Column7.HeaderText = "שם משתמש";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // EntryDate
            // 
            this.EntryDate.FillWeight = 95.625F;
            this.EntryDate.HeaderText = "תאריך כניסה";
            this.EntryDate.MinimumWidth = 8;
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 95.625F;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 95.625F;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // RestPass
            // 
            this.RestPass.FillWeight = 143.75F;
            this.RestPass.HeaderText = "";
            this.RestPass.MinimumWidth = 8;
            this.RestPass.Name = "RestPass";
            this.RestPass.ReadOnly = true;
            // 
            // ManagersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1251, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewManagers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagersForm";
            this.Load += new System.EventHandler(this.ManagersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewManagers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonManagerInsert1;
        private System.Windows.Forms.Button buttonSearchManager;
        private System.Windows.Forms.TextBox textBoxSearchManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn RestPass;
    }
}