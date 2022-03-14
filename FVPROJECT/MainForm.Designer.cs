namespace FVPROJECT
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.clientsBtn = new System.Windows.Forms.Button();
            this.suppliersBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sellerTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProductsCount = new System.Windows.Forms.TextBox();
            this.dataGridViewMainOrder = new System.Windows.Forms.DataGridView();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxProductShow = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonNumberC = new System.Windows.Forms.Button();
            this.buttonNumber0 = new System.Windows.Forms.Button();
            this.buttonCash = new System.Windows.Forms.Button();
            this.buttonNumber3 = new System.Windows.Forms.Button();
            this.buttonNumber2 = new System.Windows.Forms.Button();
            this.buttonNumber1 = new System.Windows.Forms.Button();
            this.buttonDiscount = new System.Windows.Forms.Button();
            this.buttonNumber6 = new System.Windows.Forms.Button();
            this.buttonNumber5 = new System.Windows.Forms.Button();
            this.buttonNumber4 = new System.Windows.Forms.Button();
            this.buttonNumber8 = new System.Windows.Forms.Button();
            this.buttonNumber7 = new System.Windows.Forms.Button();
            this.buttonNumber9 = new System.Windows.Forms.Button();
            this.buttonDeleteRow = new System.Windows.Forms.Button();
            this.panelButtonsCuts = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonDiscountCancel = new System.Windows.Forms.Button();
            this.buttonEditRow = new System.Windows.Forms.Button();
            this.panelExit = new System.Windows.Forms.Panel();
            this.discountLabel = new System.Windows.Forms.Label();
            this.numericUpDownDiscount = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainOrder)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonOrders);
            this.panel2.Controls.Add(this.buttonSearchProduct);
            this.panel2.Controls.Add(this.clientsBtn);
            this.panel2.Controls.Add(this.suppliersBtn);
            this.panel2.Controls.Add(this.productsBtn);
            this.panel2.Location = new System.Drawing.Point(440, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 67);
            this.panel2.TabIndex = 3;
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOrders.BackgroundImage = global::FVPROJECT.Properties.Resources.icons8_open_box_64;
            this.buttonOrders.Location = new System.Drawing.Point(147, -1);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(67, 67);
            this.buttonOrders.TabIndex = 8;
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonSearchProduct
            // 
            this.buttonSearchProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearchProduct.BackgroundImage = global::FVPROJECT.Properties.Resources.icons8_search_64;
            this.buttonSearchProduct.Location = new System.Drawing.Point(-1, -1);
            this.buttonSearchProduct.Name = "buttonSearchProduct";
            this.buttonSearchProduct.Size = new System.Drawing.Size(68, 67);
            this.buttonSearchProduct.TabIndex = 7;
            this.buttonSearchProduct.UseVisualStyleBackColor = false;
            this.buttonSearchProduct.Click += new System.EventHandler(this.buttonSearchProduct_Click);
            // 
            // clientsBtn
            // 
            this.clientsBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clientsBtn.BackgroundImage = global::FVPROJECT.Properties.Resources.avatar;
            this.clientsBtn.Location = new System.Drawing.Point(73, -1);
            this.clientsBtn.Name = "clientsBtn";
            this.clientsBtn.Size = new System.Drawing.Size(68, 67);
            this.clientsBtn.TabIndex = 6;
            this.clientsBtn.UseVisualStyleBackColor = false;
            this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click);
            this.clientsBtn.MouseHover += new System.EventHandler(this.clientsBtn_MouseHover);
            // 
            // suppliersBtn
            // 
            this.suppliersBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.suppliersBtn.BackgroundImage = global::FVPROJECT.Properties.Resources.supplier;
            this.suppliersBtn.Location = new System.Drawing.Point(293, -1);
            this.suppliersBtn.Name = "suppliersBtn";
            this.suppliersBtn.Size = new System.Drawing.Size(65, 67);
            this.suppliersBtn.TabIndex = 5;
            this.suppliersBtn.UseVisualStyleBackColor = false;
            this.suppliersBtn.Click += new System.EventHandler(this.suppliersBtn_Click);
            this.suppliersBtn.MouseHover += new System.EventHandler(this.suppliersBtn_MouseHover);
            // 
            // productsBtn
            // 
            this.productsBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.productsBtn.BackgroundImage = global::FVPROJECT.Properties.Resources._64;
            this.productsBtn.Location = new System.Drawing.Point(220, -1);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(67, 67);
            this.productsBtn.TabIndex = 4;
            this.productsBtn.UseVisualStyleBackColor = false;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            this.productsBtn.MouseHover += new System.EventHandler(this.productsBtn_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBoxTotalPrice);
            this.panel3.Location = new System.Drawing.Point(11, 613);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 31);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(130, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = ":סה\"כ";
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxTotalPrice.Location = new System.Drawing.Point(6, -1);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(115, 29);
            this.textBoxTotalPrice.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(157, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = ":שעה/תאריך";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.timeTextBox.Location = new System.Drawing.Point(11, 13);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.Size = new System.Drawing.Size(136, 22);
            this.timeTextBox.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sellerTextBox
            // 
            this.sellerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sellerTextBox.Location = new System.Drawing.Point(549, 13);
            this.sellerTextBox.Name = "sellerTextBox";
            this.sellerTextBox.ReadOnly = true;
            this.sellerTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sellerTextBox.Size = new System.Drawing.Size(123, 22);
            this.sellerTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(680, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = ":מוכר";
            // 
            // textBoxProductsCount
            // 
            this.textBoxProductsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxProductsCount.Location = new System.Drawing.Point(-1, 73);
            this.textBoxProductsCount.MaxLength = 6;
            this.textBoxProductsCount.Name = "textBoxProductsCount";
            this.textBoxProductsCount.ReadOnly = true;
            this.textBoxProductsCount.Size = new System.Drawing.Size(148, 49);
            this.textBoxProductsCount.TabIndex = 10;
            // 
            // dataGridViewMainOrder
            // 
            this.dataGridViewMainOrder.AllowUserToAddRows = false;
            this.dataGridViewMainOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMainOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewMainOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCode,
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4});
            this.dataGridViewMainOrder.Location = new System.Drawing.Point(-1, 158);
            this.dataGridViewMainOrder.Name = "dataGridViewMainOrder";
            this.dataGridViewMainOrder.ReadOnly = true;
            this.dataGridViewMainOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewMainOrder.Size = new System.Drawing.Size(435, 423);
            this.dataGridViewMainOrder.TabIndex = 11;
            this.dataGridViewMainOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewMainOrder_KeyDown);
            // 
            // productCode
            // 
            this.productCode.HeaderText = "code";
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            this.productCode.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "תיאור פריט";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle5.Format = "N2";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "מחיר";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "כמות";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle6.Format = "N2";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "מחיר כולל";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // textBoxProductShow
            // 
            this.textBoxProductShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxProductShow.Location = new System.Drawing.Point(187, 73);
            this.textBoxProductShow.Name = "textBoxProductShow";
            this.textBoxProductShow.ReadOnly = true;
            this.textBoxProductShow.Size = new System.Drawing.Size(241, 49);
            this.textBoxProductShow.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(153, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "x";
            // 
            // buttonNumberC
            // 
            this.buttonNumberC.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonNumberC.BackColor = System.Drawing.Color.Thistle;
            this.buttonNumberC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNumberC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNumberC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNumberC.Location = new System.Drawing.Point(60, 195);
            this.buttonNumberC.Name = "buttonNumberC";
            this.buttonNumberC.Padding = new System.Windows.Forms.Padding(3);
            this.buttonNumberC.Size = new System.Drawing.Size(109, 44);
            this.buttonNumberC.TabIndex = 10;
            this.buttonNumberC.Text = "C";
            this.buttonNumberC.UseVisualStyleBackColor = false;
            this.buttonNumberC.Click += new System.EventHandler(this.buttonNumberC_Click);
            // 
            // buttonNumber0
            // 
            this.buttonNumber0.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonNumber0.BackColor = System.Drawing.Color.Thistle;
            this.buttonNumber0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNumber0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNumber0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNumber0.Location = new System.Drawing.Point(4, 195);
            this.buttonNumber0.Name = "buttonNumber0";
            this.buttonNumber0.Padding = new System.Windows.Forms.Padding(3);
            this.buttonNumber0.Size = new System.Drawing.Size(51, 44);
            this.buttonNumber0.TabIndex = 9;
            this.buttonNumber0.Text = "0";
            this.buttonNumber0.UseVisualStyleBackColor = false;
            this.buttonNumber0.Click += new System.EventHandler(this.buttonNumber0_Click);
            // 
            // buttonCash
            // 
            this.buttonCash.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonCash.BackColor = System.Drawing.Color.Lime;
            this.buttonCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonCash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCash.Location = new System.Drawing.Point(175, 186);
            this.buttonCash.Name = "buttonCash";
            this.buttonCash.Padding = new System.Windows.Forms.Padding(3);
            this.buttonCash.Size = new System.Drawing.Size(175, 53);
            this.buttonCash.TabIndex = 11;
            this.buttonCash.Text = "מזומן";
            this.buttonCash.UseVisualStyleBackColor = false;
            this.buttonCash.Click += new System.EventHandler(this.buttonCash_Click);
            // 
            // buttonNumber3
            // 
            this.buttonNumber3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonNumber3.BackColor = System.Drawing.Color.Thistle;
            this.buttonNumber3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNumber3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNumber3.Location = new System.Drawing.Point(118, 145);
            this.buttonNumber3.Name = "buttonNumber3";
            this.buttonNumber3.Padding = new System.Windows.Forms.Padding(3);
            this.buttonNumber3.Size = new System.Drawing.Size(51, 44);
            this.buttonNumber3.TabIndex = 8;
            this.buttonNumber3.Text = "3";
            this.buttonNumber3.UseVisualStyleBackColor = false;
            this.buttonNumber3.Click += new System.EventHandler(this.buttonNumber3_Click);
            // 
            // buttonNumber2
            // 
            this.buttonNumber2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonNumber2.BackColor = System.Drawing.Color.Thistle;
            this.buttonNumber2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNumber2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNumber2.Location = new System.Drawing.Point(61, 145);
            this.buttonNumber2.Name = "buttonNumber2";
            this.buttonNumber2.Padding = new System.Windows.Forms.Padding(3);
            this.buttonNumber2.Size = new System.Drawing.Size(51, 44);
            this.buttonNumber2.TabIndex = 7;
            this.buttonNumber2.Text = "2";
            this.buttonNumber2.UseVisualStyleBackColor = false;
            this.buttonNumber2.Click += new System.EventHandler(this.buttonNumber2_Click);
            // 
            // buttonNumber1
            // 
            this.buttonNumber1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonNumber1.BackColor = System.Drawing.Color.Thistle;
            this.buttonNumber1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNumber1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNumber1.Location = new System.Drawing.Point(4, 145);
            this.buttonNumber1.Name = "buttonNumber1";
            this.buttonNumber1.Padding = new System.Windows.Forms.Padding(3);
            this.buttonNumber1.Size = new System.Drawing.Size(51, 44);
            this.buttonNumber1.TabIndex = 6;
            this.buttonNumber1.Text = "1";
            this.buttonNumber1.UseVisualStyleBackColor = false;
            this.buttonNumber1.Click += new System.EventHandler(this.buttonNumber1_Click);
            // 
            // buttonDiscount
            // 
            this.buttonDiscount.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonDiscount.BackColor = System.Drawing.Color.Yellow;
            this.buttonDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonDiscount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDiscount.Location = new System.Drawing.Point(272, 126);
            this.buttonDiscount.Name = "buttonDiscount";
            this.buttonDiscount.Padding = new System.Windows.Forms.Padding(3);
            this.buttonDiscount.Size = new System.Drawing.Size(78, 54);
            this.buttonDiscount.TabIndex = 13;
            this.buttonDiscount.Text = "הנחה";
            this.buttonDiscount.UseVisualStyleBackColor = false;
            this.buttonDiscount.Click += new System.EventHandler(this.buttonDiscount_Click);
            // 
            // buttonNumber6
            // 
            this.buttonNumber6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonNumber6.BackColor = System.Drawing.Color.Thistle;
            this.buttonNumber6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNumber6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNumber6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNumber6.Location = new System.Drawing.Point(118, 95);
            this.buttonNumber6.Name = "buttonNumber6";
            this.buttonNumber6.Padding = new System.Windows.Forms.Padding(3);
            this.buttonNumber6.Size = new System.Drawing.Size(51, 44);
            this.buttonNumber6.TabIndex = 5;
            this.buttonNumber6.Text = "6";
            this.buttonNumber6.UseVisualStyleBackColor = false;
            this.buttonNumber6.Click += new System.EventHandler(this.buttonNumber6_Click);
            // 
            // buttonNumber5
            // 
            this.buttonNumber5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonNumber5.BackColor = System.Drawing.Color.Thistle;
            this.buttonNumber5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNumber5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNumber5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNumber5.Location = new System.Drawing.Point(61, 95);
            this.buttonNumber5.Name = "buttonNumber5";
            this.buttonNumber5.Padding = new System.Windows.Forms.Padding(3);
            this.buttonNumber5.Size = new System.Drawing.Size(51, 44);
            this.buttonNumber5.TabIndex = 4;
            this.buttonNumber5.Text = "5";
            this.buttonNumber5.UseVisualStyleBackColor = false;
            this.buttonNumber5.Click += new System.EventHandler(this.buttonNumber5_Click);
            // 
            // buttonNumber4
            // 
            this.buttonNumber4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonNumber4.BackColor = System.Drawing.Color.Thistle;
            this.buttonNumber4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNumber4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNumber4.Location = new System.Drawing.Point(4, 95);
            this.buttonNumber4.Name = "buttonNumber4";
            this.buttonNumber4.Padding = new System.Windows.Forms.Padding(3);
            this.buttonNumber4.Size = new System.Drawing.Size(51, 44);
            this.buttonNumber4.TabIndex = 3;
            this.buttonNumber4.Text = "4";
            this.buttonNumber4.UseVisualStyleBackColor = false;
            this.buttonNumber4.Click += new System.EventHandler(this.buttonNumber4_Click);
            // 
            // buttonNumber8
            // 
            this.buttonNumber8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonNumber8.BackColor = System.Drawing.Color.Thistle;
            this.buttonNumber8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNumber8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNumber8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNumber8.Location = new System.Drawing.Point(61, 45);
            this.buttonNumber8.Name = "buttonNumber8";
            this.buttonNumber8.Padding = new System.Windows.Forms.Padding(3);
            this.buttonNumber8.Size = new System.Drawing.Size(51, 44);
            this.buttonNumber8.TabIndex = 1;
            this.buttonNumber8.Text = "8";
            this.buttonNumber8.UseVisualStyleBackColor = false;
            this.buttonNumber8.Click += new System.EventHandler(this.buttonNumber8_Click);
            // 
            // buttonNumber7
            // 
            this.buttonNumber7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonNumber7.BackColor = System.Drawing.Color.Thistle;
            this.buttonNumber7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNumber7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNumber7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNumber7.Location = new System.Drawing.Point(4, 45);
            this.buttonNumber7.Name = "buttonNumber7";
            this.buttonNumber7.Padding = new System.Windows.Forms.Padding(3);
            this.buttonNumber7.Size = new System.Drawing.Size(51, 44);
            this.buttonNumber7.TabIndex = 15;
            this.buttonNumber7.Text = "7";
            this.buttonNumber7.UseVisualStyleBackColor = false;
            this.buttonNumber7.Click += new System.EventHandler(this.buttonNumber7_Click);
            // 
            // buttonNumber9
            // 
            this.buttonNumber9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonNumber9.BackColor = System.Drawing.Color.Thistle;
            this.buttonNumber9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNumber9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNumber9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNumber9.Location = new System.Drawing.Point(118, 45);
            this.buttonNumber9.Name = "buttonNumber9";
            this.buttonNumber9.Padding = new System.Windows.Forms.Padding(3);
            this.buttonNumber9.Size = new System.Drawing.Size(51, 44);
            this.buttonNumber9.TabIndex = 2;
            this.buttonNumber9.Text = "9";
            this.buttonNumber9.UseVisualStyleBackColor = false;
            this.buttonNumber9.Click += new System.EventHandler(this.buttonNumber9_Click);
            // 
            // buttonDeleteRow
            // 
            this.buttonDeleteRow.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonDeleteRow.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonDeleteRow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteRow.Location = new System.Drawing.Point(244, 3);
            this.buttonDeleteRow.Name = "buttonDeleteRow";
            this.buttonDeleteRow.Padding = new System.Windows.Forms.Padding(3);
            this.buttonDeleteRow.Size = new System.Drawing.Size(107, 49);
            this.buttonDeleteRow.TabIndex = 17;
            this.buttonDeleteRow.Text = "מחק שורה";
            this.buttonDeleteRow.UseVisualStyleBackColor = false;
            this.buttonDeleteRow.Click += new System.EventHandler(this.buttonDeleteRow_Click);
            // 
            // panelButtonsCuts
            // 
            this.panelButtonsCuts.AutoScroll = true;
            this.panelButtonsCuts.BackColor = System.Drawing.SystemColors.Control;
            this.panelButtonsCuts.Location = new System.Drawing.Point(440, 158);
            this.panelButtonsCuts.Name = "panelButtonsCuts";
            this.panelButtonsCuts.Size = new System.Drawing.Size(351, 178);
            this.panelButtonsCuts.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.buttonDiscountCancel);
            this.panel4.Controls.Add(this.buttonEditRow);
            this.panel4.Controls.Add(this.buttonNumberC);
            this.panel4.Controls.Add(this.buttonNumber5);
            this.panel4.Controls.Add(this.buttonNumber4);
            this.panel4.Controls.Add(this.buttonDeleteRow);
            this.panel4.Controls.Add(this.buttonNumber6);
            this.panel4.Controls.Add(this.buttonCash);
            this.panel4.Controls.Add(this.buttonNumber8);
            this.panel4.Controls.Add(this.buttonNumber1);
            this.panel4.Controls.Add(this.buttonNumber2);
            this.panel4.Controls.Add(this.buttonNumber9);
            this.panel4.Controls.Add(this.buttonNumber7);
            this.panel4.Controls.Add(this.buttonNumber3);
            this.panel4.Controls.Add(this.buttonDiscount);
            this.panel4.Controls.Add(this.buttonNumber0);
            this.panel4.Location = new System.Drawing.Point(440, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(353, 242);
            this.panel4.TabIndex = 19;
            // 
            // buttonDiscountCancel
            // 
            this.buttonDiscountCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonDiscountCancel.BackColor = System.Drawing.Color.Red;
            this.buttonDiscountCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiscountCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonDiscountCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDiscountCancel.Location = new System.Drawing.Point(175, 126);
            this.buttonDiscountCancel.Name = "buttonDiscountCancel";
            this.buttonDiscountCancel.Padding = new System.Windows.Forms.Padding(3);
            this.buttonDiscountCancel.Size = new System.Drawing.Size(81, 54);
            this.buttonDiscountCancel.TabIndex = 19;
            this.buttonDiscountCancel.Text = "ביטול הנחה";
            this.buttonDiscountCancel.UseVisualStyleBackColor = false;
            this.buttonDiscountCancel.Click += new System.EventHandler(this.buttonDiscountCancel_Click);
            // 
            // buttonEditRow
            // 
            this.buttonEditRow.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonEditRow.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonEditRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonEditRow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEditRow.Location = new System.Drawing.Point(244, 58);
            this.buttonEditRow.Name = "buttonEditRow";
            this.buttonEditRow.Padding = new System.Windows.Forms.Padding(3);
            this.buttonEditRow.Size = new System.Drawing.Size(106, 49);
            this.buttonEditRow.TabIndex = 18;
            this.buttonEditRow.Text = "ערוך שורה";
            this.buttonEditRow.UseVisualStyleBackColor = false;
            this.buttonEditRow.Click += new System.EventHandler(this.buttonEditRow_Click);
            // 
            // panelExit
            // 
            this.panelExit.BackgroundImage = global::FVPROJECT.Properties.Resources.icons8_close_pane_24;
            this.panelExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExit.Location = new System.Drawing.Point(759, 12);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(24, 24);
            this.panelExit.TabIndex = 15;
            this.panelExit.Click += new System.EventHandler(this.panelExit_Click);
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.BackColor = System.Drawing.Color.Yellow;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.discountLabel.Location = new System.Drawing.Point(158, 592);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(44, 18);
            this.discountLabel.TabIndex = 20;
            this.discountLabel.Text = "הנחה";
            this.discountLabel.Visible = false;
            // 
            // numericUpDownDiscount
            // 
            this.numericUpDownDiscount.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDownDiscount.DecimalPlaces = 2;
            this.numericUpDownDiscount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownDiscount.Location = new System.Drawing.Point(661, 616);
            this.numericUpDownDiscount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDiscount.Name = "numericUpDownDiscount";
            this.numericUpDownDiscount.Size = new System.Drawing.Size(112, 20);
            this.numericUpDownDiscount.TabIndex = 21;
            this.numericUpDownDiscount.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(803, 652);
            this.Controls.Add(this.numericUpDownDiscount);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelButtonsCuts);
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxProductShow);
            this.Controls.Add(this.dataGridViewMainOrder);
            this.Controls.Add(this.textBoxProductsCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sellerTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RyoSofts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainOrder)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox sellerTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button suppliersBtn;
        private System.Windows.Forms.Button clientsBtn;
        private System.Windows.Forms.Button buttonSearchProduct;
        public System.Windows.Forms.DataGridView dataGridViewMainOrder;
        public System.Windows.Forms.TextBox textBoxProductsCount;
        public System.Windows.Forms.TextBox textBoxProductShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.Button buttonNumberC;
        private System.Windows.Forms.Button buttonNumber0;
        private System.Windows.Forms.Button buttonCash;
        private System.Windows.Forms.Button buttonNumber3;
        private System.Windows.Forms.Button buttonNumber2;
        private System.Windows.Forms.Button buttonNumber1;
        private System.Windows.Forms.Button buttonDiscount;
        private System.Windows.Forms.Button buttonNumber6;
        private System.Windows.Forms.Button buttonNumber5;
        private System.Windows.Forms.Button buttonNumber4;
        private System.Windows.Forms.Button buttonNumber8;
        private System.Windows.Forms.Button buttonNumber7;
        private System.Windows.Forms.Button buttonNumber9;
        private System.Windows.Forms.Button buttonDeleteRow;
        private System.Windows.Forms.Panel panelButtonsCuts;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonEditRow;
        private System.Windows.Forms.Button buttonDiscountCancel;
        public System.Windows.Forms.Label discountLabel;
        public System.Windows.Forms.NumericUpDown numericUpDownDiscount;
    }
}

