namespace FVPROJECT
{
    partial class StatisticForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelPrev = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewStatisticsMax = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDateSearch = new System.Windows.Forms.Button();
            this.dateTimePickerMin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerMax = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewStatisticsMin = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatisticsMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatisticsMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panelPrev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 91);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(395, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "סטטיסטיקה";
            // 
            // panelPrev
            // 
            this.panelPrev.BackgroundImage = global::FVPROJECT.Properties.Resources.arrow__2_;
            this.panelPrev.Location = new System.Drawing.Point(30, 12);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(16, 16);
            this.panelPrev.TabIndex = 6;
            this.panelPrev.Click += new System.EventHandler(this.panelPrev_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 185);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(417, 264);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // dataGridViewStatisticsMax
            // 
            this.dataGridViewStatisticsMax.AllowUserToAddRows = false;
            this.dataGridViewStatisticsMax.AllowUserToDeleteRows = false;
            this.dataGridViewStatisticsMax.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStatisticsMax.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewStatisticsMax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatisticsMax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewStatisticsMax.Location = new System.Drawing.Point(468, 225);
            this.dataGridViewStatisticsMax.Name = "dataGridViewStatisticsMax";
            this.dataGridViewStatisticsMax.ReadOnly = true;
            this.dataGridViewStatisticsMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewStatisticsMax.Size = new System.Drawing.Size(444, 161);
            this.dataGridViewStatisticsMax.TabIndex = 2;
            // 
            // number
            // 
            this.number.HeaderText = "";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "קוד מוצר";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "תיאור פריט";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "כמות";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // buttonDateSearch
            // 
            this.buttonDateSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDateSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDateSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDateSearch.Location = new System.Drawing.Point(648, 123);
            this.buttonDateSearch.Name = "buttonDateSearch";
            this.buttonDateSearch.Size = new System.Drawing.Size(50, 23);
            this.buttonDateSearch.TabIndex = 12;
            this.buttonDateSearch.Text = "חפש";
            this.buttonDateSearch.UseVisualStyleBackColor = false;
            this.buttonDateSearch.Click += new System.EventHandler(this.buttonDateSearch_Click);
            // 
            // dateTimePickerMin
            // 
            this.dateTimePickerMin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMin.Location = new System.Drawing.Point(812, 125);
            this.dateTimePickerMin.Name = "dateTimePickerMin";
            this.dateTimePickerMin.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerMin.TabIndex = 8;
            // 
            // dateTimePickerMax
            // 
            this.dateTimePickerMax.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMax.Location = new System.Drawing.Point(704, 125);
            this.dateTimePickerMax.Name = "dateTimePickerMax";
            this.dateTimePickerMax.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerMax.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(855, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "מתאריך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(777, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "עד";
            // 
            // dataGridViewStatisticsMin
            // 
            this.dataGridViewStatisticsMin.AllowUserToAddRows = false;
            this.dataGridViewStatisticsMin.AllowUserToDeleteRows = false;
            this.dataGridViewStatisticsMin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStatisticsMin.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewStatisticsMin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatisticsMin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewStatisticsMin.Location = new System.Drawing.Point(468, 516);
            this.dataGridViewStatisticsMin.Name = "dataGridViewStatisticsMin";
            this.dataGridViewStatisticsMin.ReadOnly = true;
            this.dataGridViewStatisticsMin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewStatisticsMin.Size = new System.Drawing.Size(444, 161);
            this.dataGridViewStatisticsMin.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "קוד מוצר";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "תיאור פריט";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "כמות";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.SystemColors.Control;
            this.chart2.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(12, 486);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(417, 264);
            this.chart2.TabIndex = 14;
            this.chart2.Text = "chart2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(480, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 59);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(100, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "המוצרים שפחות נמכרו";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(480, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 59);
            this.panel3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(100, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "המוצרים הנמכרו ביותר";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 788);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.dataGridViewStatisticsMin);
            this.Controls.Add(this.buttonDateSearch);
            this.Controls.Add(this.dataGridViewStatisticsMax);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dateTimePickerMin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePickerMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticForm";
            this.Text = "StatisticForm";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatisticsMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatisticsMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPrev;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridViewStatisticsMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDateSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerMin;
        private System.Windows.Forms.DateTimePicker dateTimePickerMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewStatisticsMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}