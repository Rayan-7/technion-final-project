namespace FVPROJECT
{
    partial class UserLoginForm
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
            this.panelClose = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ש = new System.Windows.Forms.Button();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panelClose);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 129);
            this.panel1.TabIndex = 3;
            // 
            // panelClose
            // 
            this.panelClose.BackgroundImage = global::FVPROJECT.Properties.Resources.icons8_close_pane_24;
            this.panelClose.Location = new System.Drawing.Point(447, 3);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(24, 24);
            this.panelClose.TabIndex = 1;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::FVPROJECT.Properties.Resources.Untitled_3;
            this.panel2.Location = new System.Drawing.Point(94, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 100);
            this.panel2.TabIndex = 0;
            // 
            // ש
            // 
            this.ש.Location = new System.Drawing.Point(201, 170);
            this.ש.Name = "ש";
            this.ש.Size = new System.Drawing.Size(75, 23);
            this.ש.TabIndex = 4;
            this.ש.Text = "button1";
            this.ש.UseVisualStyleBackColor = true;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSignIn.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSignIn.Location = new System.Drawing.Point(168, 161);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(143, 69);
            this.buttonSignIn.TabIndex = 4;
            this.buttonSignIn.Text = "כניסה למערכת";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(479, 253);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLoginForm";
            this.Load += new System.EventHandler(this.UserLoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Button ש;
        private System.Windows.Forms.Button buttonSignIn;
    }
}