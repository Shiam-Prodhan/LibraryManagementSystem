namespace LibraryManagementSystem
{
    partial class AddManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddManager));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ManagerNameLabel = new System.Windows.Forms.Label();
            this.ManagerNameText = new System.Windows.Forms.TextBox();
            this.ManagerIDLabel = new System.Windows.Forms.Label();
            this.ManagerIDText = new System.Windows.Forms.TextBox();
            this.ManagerPasswordLabel = new System.Windows.Forms.Label();
            this.ManagerPasswordText = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddManagerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ethnocentric Rg", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(282, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(747, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Library Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(508, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(601, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // ManagerNameLabel
            // 
            this.ManagerNameLabel.AutoSize = true;
            this.ManagerNameLabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerNameLabel.ForeColor = System.Drawing.Color.White;
            this.ManagerNameLabel.Location = new System.Drawing.Point(410, 315);
            this.ManagerNameLabel.Name = "ManagerNameLabel";
            this.ManagerNameLabel.Size = new System.Drawing.Size(166, 22);
            this.ManagerNameLabel.TabIndex = 12;
            this.ManagerNameLabel.Text = "Manager Name : ";
            this.ManagerNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManagerNameText
            // 
            this.ManagerNameText.BackColor = System.Drawing.SystemColors.Window;
            this.ManagerNameText.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerNameText.Location = new System.Drawing.Point(582, 312);
            this.ManagerNameText.Name = "ManagerNameText";
            this.ManagerNameText.Size = new System.Drawing.Size(256, 30);
            this.ManagerNameText.TabIndex = 13;
            this.ManagerNameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ManagerIDLabel
            // 
            this.ManagerIDLabel.AutoSize = true;
            this.ManagerIDLabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerIDLabel.ForeColor = System.Drawing.Color.White;
            this.ManagerIDLabel.Location = new System.Drawing.Point(443, 365);
            this.ManagerIDLabel.Name = "ManagerIDLabel";
            this.ManagerIDLabel.Size = new System.Drawing.Size(133, 22);
            this.ManagerIDLabel.TabIndex = 12;
            this.ManagerIDLabel.Text = "Manager ID : ";
            this.ManagerIDLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManagerIDText
            // 
            this.ManagerIDText.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerIDText.Location = new System.Drawing.Point(582, 362);
            this.ManagerIDText.Name = "ManagerIDText";
            this.ManagerIDText.Size = new System.Drawing.Size(256, 30);
            this.ManagerIDText.TabIndex = 15;
            // 
            // ManagerPasswordLabel
            // 
            this.ManagerPasswordLabel.AutoSize = true;
            this.ManagerPasswordLabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.ManagerPasswordLabel.Location = new System.Drawing.Point(376, 413);
            this.ManagerPasswordLabel.Name = "ManagerPasswordLabel";
            this.ManagerPasswordLabel.Size = new System.Drawing.Size(200, 22);
            this.ManagerPasswordLabel.TabIndex = 12;
            this.ManagerPasswordLabel.Text = "Manager Password : ";
            this.ManagerPasswordLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManagerPasswordText
            // 
            this.ManagerPasswordText.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerPasswordText.Location = new System.Drawing.Point(582, 410);
            this.ManagerPasswordText.Name = "ManagerPasswordText";
            this.ManagerPasswordText.Size = new System.Drawing.Size(256, 30);
            this.ManagerPasswordText.TabIndex = 16;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(414, 491);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(212, 29);
            this.BackButton.TabIndex = 17;
            this.BackButton.Text = "Back to Admin Panel";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddManagerButton
            // 
            this.AddManagerButton.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddManagerButton.Location = new System.Drawing.Point(669, 491);
            this.AddManagerButton.Name = "AddManagerButton";
            this.AddManagerButton.Size = new System.Drawing.Size(151, 29);
            this.AddManagerButton.TabIndex = 18;
            this.AddManagerButton.Text = "Add Manager";
            this.AddManagerButton.UseVisualStyleBackColor = true;
            this.AddManagerButton.Click += new System.EventHandler(this.AddManagerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Romande ADF Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(496, 656);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "© Shiam Prodhan and Nazmuj Shakib Diip";
            // 
            // AddManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddManagerButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ManagerPasswordText);
            this.Controls.Add(this.ManagerIDText);
            this.Controls.Add(this.ManagerNameText);
            this.Controls.Add(this.ManagerPasswordLabel);
            this.Controls.Add(this.ManagerIDLabel);
            this.Controls.Add(this.ManagerNameLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closingform);
            this.Load += new System.EventHandler(this.AddManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ManagerNameLabel;
        private System.Windows.Forms.TextBox ManagerNameText;
        private System.Windows.Forms.Label ManagerIDLabel;
        private System.Windows.Forms.TextBox ManagerIDText;
        private System.Windows.Forms.Label ManagerPasswordLabel;
        private System.Windows.Forms.TextBox ManagerPasswordText;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddManagerButton;
        private System.Windows.Forms.Label label3;
    }
}