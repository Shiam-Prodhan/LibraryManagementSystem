namespace LibraryManagementSystem
{
    partial class DeleteBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBook));
            this.BackButton = new System.Windows.Forms.Button();
            this.bookidtext = new System.Windows.Forms.TextBox();
            this.booknametext = new System.Windows.Forms.TextBox();
            this.Bookidlabel = new System.Windows.Forms.Label();
            this.Booknamelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Deletegridview = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deletegridview)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(731, 517);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(240, 29);
            this.BackButton.TabIndex = 76;
            this.BackButton.Text = "Back to Manager Panel";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // bookidtext
            // 
            this.bookidtext.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookidtext.Location = new System.Drawing.Point(774, 277);
            this.bookidtext.Name = "bookidtext";
            this.bookidtext.Size = new System.Drawing.Size(274, 26);
            this.bookidtext.TabIndex = 70;
            // 
            // booknametext
            // 
            this.booknametext.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booknametext.Location = new System.Drawing.Point(361, 277);
            this.booknametext.Name = "booknametext";
            this.booknametext.Size = new System.Drawing.Size(274, 26);
            this.booknametext.TabIndex = 69;
            // 
            // Bookidlabel
            // 
            this.Bookidlabel.AutoSize = true;
            this.Bookidlabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookidlabel.ForeColor = System.Drawing.Color.White;
            this.Bookidlabel.Location = new System.Drawing.Point(675, 277);
            this.Bookidlabel.Name = "Bookidlabel";
            this.Bookidlabel.Size = new System.Drawing.Size(93, 22);
            this.Bookidlabel.TabIndex = 62;
            this.Bookidlabel.Text = "Book ID: ";
            // 
            // Booknamelabel
            // 
            this.Booknamelabel.AutoSize = true;
            this.Booknamelabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booknamelabel.ForeColor = System.Drawing.Color.White;
            this.Booknamelabel.Location = new System.Drawing.Point(229, 280);
            this.Booknamelabel.Name = "Booknamelabel";
            this.Booknamelabel.Size = new System.Drawing.Size(126, 22);
            this.Booknamelabel.TabIndex = 61;
            this.Booknamelabel.Text = "Book Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Romande ADF Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(532, 645);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "© Shiam Prodhan and Nazmuj Shakib Diip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ethnocentric Rg", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(318, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(747, 38);
            this.label2.TabIndex = 59;
            this.label2.Text = "Library Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(440, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 36);
            this.label1.TabIndex = 58;
            this.label1.Text = "Manager Panel (Delete Book)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(634, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // Deletegridview
            // 
            this.Deletegridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Deletegridview.Location = new System.Drawing.Point(177, 376);
            this.Deletegridview.Name = "Deletegridview";
            this.Deletegridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Deletegridview.Size = new System.Drawing.Size(956, 110);
            this.Deletegridview.TabIndex = 77;
            this.Deletegridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(634, 324);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(83, 33);
            this.SearchButton.TabIndex = 78;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(545, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 79;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Deletegridview);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.bookidtext);
            this.Controls.Add(this.booknametext);
            this.Controls.Add(this.Bookidlabel);
            this.Controls.Add(this.Booknamelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DeleteBook";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closingform);
            this.Load += new System.EventHandler(this.DeleteBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deletegridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox bookidtext;
        private System.Windows.Forms.TextBox booknametext;
        private System.Windows.Forms.Label Bookidlabel;
        private System.Windows.Forms.Label Booknamelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView Deletegridview;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button button1;
    }
}