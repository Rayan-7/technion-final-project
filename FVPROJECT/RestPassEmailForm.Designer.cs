namespace FVPROJECT
{
    partial class RestPassEmailForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPrev = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRestPass = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxEmailPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panelPrev);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 78);
            this.panel1.TabIndex = 0;
            // 
            // panelPrev
            // 
            this.panelPrev.BackgroundImage = global::FVPROJECT.Properties.Resources.arrow__2_;
            this.panelPrev.Location = new System.Drawing.Point(12, 12);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(16, 16);
            this.panelPrev.TabIndex = 35;
            this.panelPrev.Click += new System.EventHandler(this.panelPrev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "?שכחת את הסיסמא";
            // 
            // buttonRestPass
            // 
            this.buttonRestPass.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonRestPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestPass.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonRestPass.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRestPass.Location = new System.Drawing.Point(61, 164);
            this.buttonRestPass.Name = "buttonRestPass";
            this.buttonRestPass.Size = new System.Drawing.Size(82, 34);
            this.buttonRestPass.TabIndex = 34;
            this.buttonRestPass.Text = "שלח";
            this.buttonRestPass.UseVisualStyleBackColor = false;
            this.buttonRestPass.Click += new System.EventHandler(this.buttonRestPass_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Location = new System.Drawing.Point(21, 142);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(185, 1);
            this.panel7.TabIndex = 30;
            // 
            // textBoxEmailPassword
            // 
            this.textBoxEmailPassword.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEmailPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmailPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxEmailPassword.Location = new System.Drawing.Point(21, 127);
            this.textBoxEmailPassword.MaxLength = 30;
            this.textBoxEmailPassword.Name = "textBoxEmailPassword";
            this.textBoxEmailPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxEmailPassword.Size = new System.Drawing.Size(185, 16);
            this.textBoxEmailPassword.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(77, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "תקליד את הדואר האלקטרוני";
            // 
            // RestPassEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 207);
            this.Controls.Add(this.buttonRestPass);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.textBoxEmailPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestPassEmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRestPassMessage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRestPass;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxEmailPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelPrev;
    }
}