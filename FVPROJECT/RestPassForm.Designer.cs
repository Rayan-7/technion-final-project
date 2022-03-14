namespace FVPROJECT
{
    partial class RestPassForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRestPassword = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxReRestPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRestPass = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelPrev = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(134, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "סיסמא חדשה";
            // 
            // textBoxRestPassword
            // 
            this.textBoxRestPassword.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxRestPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRestPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxRestPassword.Location = new System.Drawing.Point(10, 97);
            this.textBoxRestPassword.MaxLength = 15;
            this.textBoxRestPassword.Name = "textBoxRestPassword";
            this.textBoxRestPassword.PasswordChar = '*';
            this.textBoxRestPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxRestPassword.Size = new System.Drawing.Size(196, 16);
            this.textBoxRestPassword.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Location = new System.Drawing.Point(6, 115);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 1);
            this.panel7.TabIndex = 23;
            // 
            // textBoxReRestPassword
            // 
            this.textBoxReRestPassword.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxReRestPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxReRestPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxReRestPassword.Location = new System.Drawing.Point(10, 140);
            this.textBoxReRestPassword.MaxLength = 15;
            this.textBoxReRestPassword.Name = "textBoxReRestPassword";
            this.textBoxReRestPassword.PasswordChar = '*';
            this.textBoxReRestPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxReRestPassword.Size = new System.Drawing.Size(196, 16);
            this.textBoxReRestPassword.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(104, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "הזן את הסיסמא שוב";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(6, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 26;
            // 
            // buttonRestPass
            // 
            this.buttonRestPass.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonRestPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestPass.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonRestPass.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRestPass.Location = new System.Drawing.Point(59, 165);
            this.buttonRestPass.Name = "buttonRestPass";
            this.buttonRestPass.Size = new System.Drawing.Size(82, 34);
            this.buttonRestPass.TabIndex = 27;
            this.buttonRestPass.Text = "איפוס";
            this.buttonRestPass.UseVisualStyleBackColor = false;
            this.buttonRestPass.Click += new System.EventHandler(this.buttonRestPass_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.panelPrev);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 72);
            this.panel2.TabIndex = 28;
            // 
            // panelPrev
            // 
            this.panelPrev.BackgroundImage = global::FVPROJECT.Properties.Resources.arrow__2_;
            this.panelPrev.Location = new System.Drawing.Point(13, 12);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(16, 16);
            this.panelPrev.TabIndex = 36;
            this.panelPrev.Click += new System.EventHandler(this.panelPrev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "איפוס סיסמא";
            // 
            // RestPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 207);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonRestPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxReRestPassword);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.textBoxRestPassword);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestPassForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRestPassword;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxReRestPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRestPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPrev;
    }
}