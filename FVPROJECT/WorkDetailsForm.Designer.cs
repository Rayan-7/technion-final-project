namespace FVPROJECT
{
    partial class WorkDetailsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxFolders = new System.Windows.Forms.ComboBox();
            this.panelPrev = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewWorkHoursDetails = new System.Windows.Forms.DataGridView();
            this.StartDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxTotalWorkHours = new System.Windows.Forms.TextBox();
            this.buttonSendWorkHours = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkHoursDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.comboBoxFolders);
            this.panel1.Controls.Add(this.panelPrev);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 135);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxFolders
            // 
            this.comboBoxFolders.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxFolders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFolders.FormattingEnabled = true;
            this.comboBoxFolders.Items.AddRange(new object[] {
            ""});
            this.comboBoxFolders.Location = new System.Drawing.Point(534, 94);
            this.comboBoxFolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxFolders.Name = "comboBoxFolders";
            this.comboBoxFolders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxFolders.Size = new System.Drawing.Size(180, 28);
            this.comboBoxFolders.TabIndex = 13;
            this.comboBoxFolders.SelectedIndexChanged += new System.EventHandler(this.comboBoxFolders_SelectedIndexChanged);
            // 
            // panelPrev
            // 
            this.panelPrev.BackgroundImage = global::FVPROJECT.Properties.Resources.arrow__2_;
            this.panelPrev.Location = new System.Drawing.Point(34, 18);
            this.panelPrev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(24, 25);
            this.panelPrev.TabIndex = 12;
            this.panelPrev.Click += new System.EventHandler(this.panelPrev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(204, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "פרטי שעות עבודה";
            // 
            // dataGridViewWorkHoursDetails
            // 
            this.dataGridViewWorkHoursDetails.AllowUserToAddRows = false;
            this.dataGridViewWorkHoursDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Format = "N3";
            this.dataGridViewWorkHoursDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewWorkHoursDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWorkHoursDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewWorkHoursDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkHoursDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartDay,
            this.EndDay,
            this.HoursWork});
            this.dataGridViewWorkHoursDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewWorkHoursDetails.Location = new System.Drawing.Point(0, 135);
            this.dataGridViewWorkHoursDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewWorkHoursDetails.Name = "dataGridViewWorkHoursDetails";
            this.dataGridViewWorkHoursDetails.ReadOnly = true;
            this.dataGridViewWorkHoursDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewWorkHoursDetails.RowHeadersWidth = 62;
            this.dataGridViewWorkHoursDetails.Size = new System.Drawing.Size(734, 297);
            this.dataGridViewWorkHoursDetails.TabIndex = 1;
            // 
            // StartDay
            // 
            this.StartDay.HeaderText = "תאריך תחילת עבודה";
            this.StartDay.MinimumWidth = 8;
            this.StartDay.Name = "StartDay";
            this.StartDay.ReadOnly = true;
            // 
            // EndDay
            // 
            this.EndDay.HeaderText = "תאריך סיום עבודה";
            this.EndDay.MinimumWidth = 8;
            this.EndDay.Name = "EndDay";
            this.EndDay.ReadOnly = true;
            // 
            // HoursWork
            // 
            dataGridViewCellStyle4.Format = "N3";
            this.HoursWork.DefaultCellStyle = dataGridViewCellStyle4;
            this.HoursWork.HeaderText = "שעות עבודה";
            this.HoursWork.MinimumWidth = 8;
            this.HoursWork.Name = "HoursWork";
            this.HoursWork.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(93, 446);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "סכה\"כ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(18, 497);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(135, 2);
            this.panel4.TabIndex = 23;
            // 
            // textBoxTotalWorkHours
            // 
            this.textBoxTotalWorkHours.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTotalWorkHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalWorkHours.Location = new System.Drawing.Point(18, 474);
            this.textBoxTotalWorkHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTotalWorkHours.MaxLength = 30;
            this.textBoxTotalWorkHours.Name = "textBoxTotalWorkHours";
            this.textBoxTotalWorkHours.ReadOnly = true;
            this.textBoxTotalWorkHours.Size = new System.Drawing.Size(135, 19);
            this.textBoxTotalWorkHours.TabIndex = 22;
            this.textBoxTotalWorkHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSendWorkHours
            // 
            this.buttonSendWorkHours.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSendWorkHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendWorkHours.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSendWorkHours.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSendWorkHours.Location = new System.Drawing.Point(505, 442);
            this.buttonSendWorkHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSendWorkHours.Name = "buttonSendWorkHours";
            this.buttonSendWorkHours.Size = new System.Drawing.Size(112, 54);
            this.buttonSendWorkHours.TabIndex = 25;
            this.buttonSendWorkHours.Text = "שליחה";
            this.buttonSendWorkHours.UseVisualStyleBackColor = false;
            this.buttonSendWorkHours.Click += new System.EventHandler(this.buttonSendWorkHours_Click);
            // 
            // WorkDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 512);
            this.Controls.Add(this.buttonSendWorkHours);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBoxTotalWorkHours);
            this.Controls.Add(this.dataGridViewWorkHoursDetails);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WorkDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkDetailsForm";
            this.Load += new System.EventHandler(this.WorkDetailsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkHoursDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPrev;
        private System.Windows.Forms.DataGridView dataGridViewWorkHoursDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursWork;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxTotalWorkHours;
        private System.Windows.Forms.Button buttonSendWorkHours;
        private System.Windows.Forms.ComboBox comboBoxFolders;
    }
}