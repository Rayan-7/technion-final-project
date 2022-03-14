namespace FVPROJECT
{
    partial class ManagerForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHiText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStatistic = new System.Windows.Forms.Button();
            this.buttonManagers = new System.Windows.Forms.Button();
            this.buttonSellers = new System.Windows.Forms.Button();
            this.buttonSuppliers = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panelClose);
            this.panel1.Controls.Add(this.timeTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelHiText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 102);
            this.panel1.TabIndex = 4;
            // 
            // panelClose
            // 
            this.panelClose.BackgroundImage = global::FVPROJECT.Properties.Resources.icons8_close_pane_24;
            this.panelClose.Location = new System.Drawing.Point(582, 13);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(24, 24);
            this.panelClose.TabIndex = 8;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.timeTextBox.Location = new System.Drawing.Point(202, 13);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.Size = new System.Drawing.Size(136, 22);
            this.timeTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(344, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = ":שעה/תאריך";
            // 
            // labelHiText
            // 
            this.labelHiText.AutoSize = true;
            this.labelHiText.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHiText.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHiText.Location = new System.Drawing.Point(250, 52);
            this.labelHiText.Name = "labelHiText";
            this.labelHiText.Size = new System.Drawing.Size(88, 36);
            this.labelHiText.TabIndex = 0;
            this.labelHiText.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStatistic
            // 
            this.buttonStatistic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStatistic.BackgroundImage = global::FVPROJECT.Properties.Resources.icons8_combo_chart_80;
            this.buttonStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistic.Location = new System.Drawing.Point(541, 134);
            this.buttonStatistic.Name = "buttonStatistic";
            this.buttonStatistic.Size = new System.Drawing.Size(65, 65);
            this.buttonStatistic.TabIndex = 7;
            this.buttonStatistic.UseVisualStyleBackColor = false;
            this.buttonStatistic.Click += new System.EventHandler(this.buttonStatistic_Click);
            // 
            // buttonManagers
            // 
            this.buttonManagers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonManagers.BackgroundImage = global::FVPROJECT.Properties.Resources.manager65;
            this.buttonManagers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManagers.Location = new System.Drawing.Point(451, 134);
            this.buttonManagers.Name = "buttonManagers";
            this.buttonManagers.Size = new System.Drawing.Size(65, 65);
            this.buttonManagers.TabIndex = 6;
            this.buttonManagers.UseVisualStyleBackColor = false;
            this.buttonManagers.Click += new System.EventHandler(this.buttonManagers_Click);
            // 
            // buttonSellers
            // 
            this.buttonSellers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSellers.BackgroundImage = global::FVPROJECT.Properties.Resources.seller65;
            this.buttonSellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSellers.Location = new System.Drawing.Point(380, 134);
            this.buttonSellers.Name = "buttonSellers";
            this.buttonSellers.Size = new System.Drawing.Size(65, 65);
            this.buttonSellers.TabIndex = 5;
            this.buttonSellers.UseVisualStyleBackColor = false;
            this.buttonSellers.Click += new System.EventHandler(this.buttonSellers_Click);
            // 
            // buttonSuppliers
            // 
            this.buttonSuppliers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSuppliers.BackgroundImage = global::FVPROJECT.Properties.Resources.supplier;
            this.buttonSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuppliers.Location = new System.Drawing.Point(273, 134);
            this.buttonSuppliers.Name = "buttonSuppliers";
            this.buttonSuppliers.Size = new System.Drawing.Size(65, 65);
            this.buttonSuppliers.TabIndex = 3;
            this.buttonSuppliers.UseVisualStyleBackColor = false;
            this.buttonSuppliers.Click += new System.EventHandler(this.buttonSuppliers_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClients.BackgroundImage = global::FVPROJECT.Properties.Resources.avatar;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClients.Location = new System.Drawing.Point(12, 134);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(65, 65);
            this.buttonClients.TabIndex = 2;
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonProducts.BackgroundImage = global::FVPROJECT.Properties.Resources._64;
            this.buttonProducts.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducts.ForeColor = System.Drawing.Color.Red;
            this.buttonProducts.Location = new System.Drawing.Point(191, 134);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(67, 65);
            this.buttonProducts.TabIndex = 1;
            this.buttonProducts.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonProducts.UseVisualStyleBackColor = false;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOrders.BackgroundImage = global::FVPROJECT.Properties.Resources.icons8_open_box_64;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.Location = new System.Drawing.Point(92, 134);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(66, 65);
            this.buttonOrders.TabIndex = 0;
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 220);
            this.Controls.Add(this.buttonStatistic);
            this.Controls.Add(this.buttonManagers);
            this.Controls.Add(this.buttonSellers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSuppliers);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonSuppliers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSellers;
        private System.Windows.Forms.Label labelHiText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonManagers;
        private System.Windows.Forms.Button buttonStatistic;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Button buttonProducts;
    }
}