namespace LibraryManagementSystem
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminIdLabel = new System.Windows.Forms.Label();
            this.AdminIDText = new System.Windows.Forms.TextBox();
            this.PasswordAdminLabel = new System.Windows.Forms.Label();
            this.AdminLoginButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AdminPasswordText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(478, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Romande ADF Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(483, 656);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "© Shiam Prodhan and Nazmuj Shakib Diip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ethnocentric Rg", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(254, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(747, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Library Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Romande ADF Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(558, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Admin Log In Panel";
            // 
            // AdminIdLabel
            // 
            this.AdminIdLabel.AutoSize = true;
            this.AdminIdLabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminIdLabel.ForeColor = System.Drawing.Color.White;
            this.AdminIdLabel.Location = new System.Drawing.Point(427, 343);
            this.AdminIdLabel.Name = "AdminIdLabel";
            this.AdminIdLabel.Size = new System.Drawing.Size(115, 22);
            this.AdminIdLabel.TabIndex = 7;
            this.AdminIdLabel.Text = "Admin ID : ";
            // 
            // AdminIDText
            // 
            this.AdminIDText.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminIDText.Location = new System.Drawing.Point(548, 340);
            this.AdminIDText.Name = "AdminIDText";
            this.AdminIDText.Size = new System.Drawing.Size(220, 30);
            this.AdminIDText.TabIndex = 8;
            this.AdminIDText.TextChanged += new System.EventHandler(this.AdminIDText_TextChanged);
            // 
            // PasswordAdminLabel
            // 
            this.PasswordAdminLabel.AutoSize = true;
            this.PasswordAdminLabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordAdminLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordAdminLabel.Location = new System.Drawing.Point(427, 399);
            this.PasswordAdminLabel.Name = "PasswordAdminLabel";
            this.PasswordAdminLabel.Size = new System.Drawing.Size(114, 22);
            this.PasswordAdminLabel.TabIndex = 7;
            this.PasswordAdminLabel.Text = "Password : ";
            // 
            // AdminLoginButton
            // 
            this.AdminLoginButton.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginButton.Location = new System.Drawing.Point(660, 472);
            this.AdminLoginButton.Name = "AdminLoginButton";
            this.AdminLoginButton.Size = new System.Drawing.Size(108, 35);
            this.AdminLoginButton.TabIndex = 9;
            this.AdminLoginButton.Text = "LogIn";
            this.AdminLoginButton.UseVisualStyleBackColor = true;
            this.AdminLoginButton.Click += new System.EventHandler(this.AdminLoginButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(517, 472);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(108, 35);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AdminPasswordText
            // 
            this.AdminPasswordText.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPasswordText.Location = new System.Drawing.Point(548, 396);
            this.AdminPasswordText.Name = "AdminPasswordText";
            this.AdminPasswordText.PasswordChar = '*';
            this.AdminPasswordText.Size = new System.Drawing.Size(220, 30);
            this.AdminPasswordText.TabIndex = 10;
            this.AdminPasswordText.TextChanged += new System.EventHandler(this.AdminPasswordText_TextChanged);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.AdminPasswordText);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AdminLoginButton);
            this.Controls.Add(this.AdminIDText);
            this.Controls.Add(this.PasswordAdminLabel);
            this.Controls.Add(this.AdminIdLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closingform);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AdminIdLabel;
        private System.Windows.Forms.TextBox AdminIDText;
        private System.Windows.Forms.Label PasswordAdminLabel;
        private System.Windows.Forms.TextBox AdminPasswordText;
        private System.Windows.Forms.Button AdminLoginButton;
        private System.Windows.Forms.Button CancelButton;
       
    }
}