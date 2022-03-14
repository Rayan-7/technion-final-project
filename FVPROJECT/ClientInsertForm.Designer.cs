namespace FVPROJECT
{
    partial class ClientInsertForm
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
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxClientLastName = new System.Windows.Forms.TextBox();
            this.textBoxClientPhoneNumber = new System.Windows.Forms.TextBox();
            this.comboBoxClientAddress = new System.Windows.Forms.ComboBox();
            this.textBoxClientEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonInsertClient = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelPrev = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxClientId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxClientId.Location = new System.Drawing.Point(218, 131);
            this.textBoxClientId.MaxLength = 9;
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(148, 13);
            this.textBoxClientId.TabIndex = 0;
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxClientName.Location = new System.Drawing.Point(19, 134);
            this.textBoxClientName.MaxLength = 30;
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(150, 13);
            this.textBoxClientName.TabIndex = 1;
            this.textBoxClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxClientLastName
            // 
            this.textBoxClientLastName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxClientLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxClientLastName.Location = new System.Drawing.Point(214, 191);
            this.textBoxClientLastName.MaxLength = 30;
            this.textBoxClientLastName.Name = "textBoxClientLastName";
            this.textBoxClientLastName.Size = new System.Drawing.Size(153, 13);
            this.textBoxClientLastName.TabIndex = 2;
            this.textBoxClientLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxClientPhoneNumber
            // 
            this.textBoxClientPhoneNumber.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxClientPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxClientPhoneNumber.Location = new System.Drawing.Point(19, 191);
            this.textBoxClientPhoneNumber.MaxLength = 10;
            this.textBoxClientPhoneNumber.Name = "textBoxClientPhoneNumber";
            this.textBoxClientPhoneNumber.Size = new System.Drawing.Size(150, 13);
            this.textBoxClientPhoneNumber.TabIndex = 3;
            this.textBoxClientPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClientPhoneNumber_KeyPress);
            // 
            // comboBoxClientAddress
            // 
            this.comboBoxClientAddress.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxClientAddress.FormattingEnabled = true;
            this.comboBoxClientAddress.Location = new System.Drawing.Point(213, 251);
            this.comboBoxClientAddress.MaxLength = 40;
            this.comboBoxClientAddress.Name = "comboBoxClientAddress";
            this.comboBoxClientAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxClientAddress.Size = new System.Drawing.Size(154, 21);
            this.comboBoxClientAddress.TabIndex = 4;
            // 
            // textBoxClientEmail
            // 
            this.textBoxClientEmail.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxClientEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxClientEmail.Location = new System.Drawing.Point(18, 256);
            this.textBoxClientEmail.MaxLength = 30;
            this.textBoxClientEmail.Name = "textBoxClientEmail";
            this.textBoxClientEmail.Size = new System.Drawing.Size(148, 13);
            this.textBoxClientEmail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(344, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ת.ז";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(142, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "שם";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(301, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "שם משפחה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(104, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "מספר טלפון";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(344, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "עיר";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(93, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "דואר אלקטרוני";
            // 
            // buttonInsertClient
            // 
            this.buttonInsertClient.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonInsertClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertClient.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonInsertClient.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonInsertClient.Location = new System.Drawing.Point(145, 288);
            this.buttonInsertClient.Name = "buttonInsertClient";
            this.buttonInsertClient.Size = new System.Drawing.Size(75, 33);
            this.buttonInsertClient.TabIndex = 14;
            this.buttonInsertClient.Text = "הוספה";
            this.buttonInsertClient.UseVisualStyleBackColor = false;
            this.buttonInsertClient.Click += new System.EventHandler(this.buttonInsertClient_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(216, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 1);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(214, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 1);
            this.panel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(214, 272);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 1);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(19, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(151, 1);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(19, 206);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(151, 1);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(18, 271);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(151, 1);
            this.panel6.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.panelPrev);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(379, 100);
            this.panel7.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(120, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "הוספת לקוח";
            // 
            // panelPrev
            // 
            this.panelPrev.BackgroundImage = global::FVPROJECT.Properties.Resources.arrow__2_;
            this.panelPrev.Location = new System.Drawing.Point(18, 12);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(16, 16);
            this.panelPrev.TabIndex = 0;
            this.panelPrev.Click += new System.EventHandler(this.panelPrev_Click);
            // 
            // ClientInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(379, 329);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonInsertClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxClientEmail);
            this.Controls.Add(this.comboBoxClientAddress);
            this.Controls.Add(this.textBoxClientPhoneNumber);
            this.Controls.Add(this.textBoxClientLastName);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.textBoxClientId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientInsertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientInsertForm";
            this.Load += new System.EventHandler(this.ClientInsertForm_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxClientLastName;
        private System.Windows.Forms.TextBox textBoxClientPhoneNumber;
        private System.Windows.Forms.ComboBox comboBoxClientAddress;
        private System.Windows.Forms.TextBox textBoxClientEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonInsertClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelPrev;
        private System.Windows.Forms.Label label7;
    }
}