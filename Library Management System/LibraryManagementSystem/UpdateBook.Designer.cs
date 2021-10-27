namespace LibraryManagementSystem
{
    partial class UpdateBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBook));
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Deletegridview = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.bookidtext = new System.Windows.Forms.TextBox();
            this.Bookidlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AvailableBox = new System.Windows.Forms.ComboBox();
            this.publishyeartext = new System.Windows.Forms.TextBox();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.quantitytext = new System.Windows.Forms.TextBox();
            this.writernametext = new System.Windows.Forms.TextBox();
            this.bookidupdate = new System.Windows.Forms.TextBox();
            this.booknametext = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.Quantitylabel = new System.Windows.Forms.Label();
            this.AvailableBooklabel = new System.Windows.Forms.Label();
            this.Publishyearlabel = new System.Windows.Forms.Label();
            this.Writernamelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Booknamelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Deletegridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(468, 601);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(90, 29);
            this.UpdateButton.TabIndex = 91;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(746, 211);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(83, 33);
            this.SearchButton.TabIndex = 90;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Deletegridview
            // 
            this.Deletegridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Deletegridview.Location = new System.Drawing.Point(145, 250);
            this.Deletegridview.Name = "Deletegridview";
            this.Deletegridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Deletegridview.Size = new System.Drawing.Size(956, 135);
            this.Deletegridview.TabIndex = 89;
            this.Deletegridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(654, 601);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(240, 29);
            this.BackButton.TabIndex = 88;
            this.BackButton.Text = "Back to Manager Panel";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // bookidtext
            // 
            this.bookidtext.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookidtext.Location = new System.Drawing.Point(448, 216);
            this.bookidtext.Name = "bookidtext";
            this.bookidtext.Size = new System.Drawing.Size(274, 26);
            this.bookidtext.TabIndex = 87;
            // 
            // Bookidlabel
            // 
            this.Bookidlabel.AutoSize = true;
            this.Bookidlabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookidlabel.ForeColor = System.Drawing.Color.White;
            this.Bookidlabel.Location = new System.Drawing.Point(349, 216);
            this.Bookidlabel.Name = "Bookidlabel";
            this.Bookidlabel.Size = new System.Drawing.Size(93, 22);
            this.Bookidlabel.TabIndex = 85;
            this.Bookidlabel.Text = "Book ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Romande ADF Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(509, 645);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 16);
            this.label3.TabIndex = 83;
            this.label3.Text = "© Shiam Prodhan and Nazmuj Shakib Diip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ethnocentric Rg", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(295, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(747, 38);
            this.label2.TabIndex = 82;
            this.label2.Text = "Library Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(417, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 36);
            this.label1.TabIndex = 81;
            this.label1.Text = "Manager Panel (Update Book)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(611, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // AvailableBox
            // 
            this.AvailableBox.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableBox.FormattingEnabled = true;
            this.AvailableBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.AvailableBox.Location = new System.Drawing.Point(815, 537);
            this.AvailableBox.Name = "AvailableBox";
            this.AvailableBox.Size = new System.Drawing.Size(274, 28);
            this.AvailableBox.TabIndex = 107;
            // 
            // publishyeartext
            // 
            this.publishyeartext.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishyeartext.Location = new System.Drawing.Point(313, 538);
            this.publishyeartext.Name = "publishyeartext";
            this.publishyeartext.Size = new System.Drawing.Size(274, 26);
            this.publishyeartext.TabIndex = 106;
            // 
            // DateTime
            // 
            this.DateTime.CustomFormat = "yyyy/MM/dd";
            this.DateTime.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTime.Location = new System.Drawing.Point(815, 488);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(274, 26);
            this.DateTime.TabIndex = 105;
            // 
            // CategoryBox
            // 
            this.CategoryBox.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Items.AddRange(new object[] {
            "Educational",
            "Horror",
            "Comics",
            "Magazines"});
            this.CategoryBox.Location = new System.Drawing.Point(815, 442);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(274, 28);
            this.CategoryBox.TabIndex = 104;
            // 
            // quantitytext
            // 
            this.quantitytext.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitytext.Location = new System.Drawing.Point(815, 396);
            this.quantitytext.Name = "quantitytext";
            this.quantitytext.Size = new System.Drawing.Size(274, 26);
            this.quantitytext.TabIndex = 103;
            // 
            // writernametext
            // 
            this.writernametext.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writernametext.Location = new System.Drawing.Point(313, 489);
            this.writernametext.Name = "writernametext";
            this.writernametext.Size = new System.Drawing.Size(274, 26);
            this.writernametext.TabIndex = 102;
            // 
            // bookidupdate
            // 
            this.bookidupdate.Enabled = false;
            this.bookidupdate.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookidupdate.Location = new System.Drawing.Point(313, 440);
            this.bookidupdate.Name = "bookidupdate";
            this.bookidupdate.Size = new System.Drawing.Size(274, 26);
            this.bookidupdate.TabIndex = 101;
            // 
            // booknametext
            // 
            this.booknametext.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booknametext.Location = new System.Drawing.Point(313, 391);
            this.booknametext.Name = "booknametext";
            this.booknametext.Size = new System.Drawing.Size(274, 26);
            this.booknametext.TabIndex = 100;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(742, 492);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(57, 22);
            this.DateLabel.TabIndex = 92;
            this.DateLabel.Text = "Date:";
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorylabel.ForeColor = System.Drawing.Color.White;
            this.Categorylabel.Location = new System.Drawing.Point(701, 447);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(98, 22);
            this.Categorylabel.TabIndex = 93;
            this.Categorylabel.Text = "Category:";
            // 
            // Quantitylabel
            // 
            this.Quantitylabel.AutoSize = true;
            this.Quantitylabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantitylabel.ForeColor = System.Drawing.Color.White;
            this.Quantitylabel.Location = new System.Drawing.Point(704, 399);
            this.Quantitylabel.Name = "Quantitylabel";
            this.Quantitylabel.Size = new System.Drawing.Size(95, 22);
            this.Quantitylabel.TabIndex = 94;
            this.Quantitylabel.Text = "Quantity:";
            // 
            // AvailableBooklabel
            // 
            this.AvailableBooklabel.AutoSize = true;
            this.AvailableBooklabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableBooklabel.ForeColor = System.Drawing.Color.White;
            this.AvailableBooklabel.Location = new System.Drawing.Point(699, 537);
            this.AvailableBooklabel.Name = "AvailableBooklabel";
            this.AvailableBooklabel.Size = new System.Drawing.Size(100, 22);
            this.AvailableBooklabel.TabIndex = 95;
            this.AvailableBooklabel.Text = "Available:";
            // 
            // Publishyearlabel
            // 
            this.Publishyearlabel.AutoSize = true;
            this.Publishyearlabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publishyearlabel.ForeColor = System.Drawing.Color.White;
            this.Publishyearlabel.Location = new System.Drawing.Point(169, 537);
            this.Publishyearlabel.Name = "Publishyearlabel";
            this.Publishyearlabel.Size = new System.Drawing.Size(130, 22);
            this.Publishyearlabel.TabIndex = 96;
            this.Publishyearlabel.Text = "Publish Year:";
            // 
            // Writernamelabel
            // 
            this.Writernamelabel.AutoSize = true;
            this.Writernamelabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Writernamelabel.ForeColor = System.Drawing.Color.White;
            this.Writernamelabel.Location = new System.Drawing.Point(169, 489);
            this.Writernamelabel.Name = "Writernamelabel";
            this.Writernamelabel.Size = new System.Drawing.Size(131, 22);
            this.Writernamelabel.TabIndex = 97;
            this.Writernamelabel.Text = "Writer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(214, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 98;
            this.label4.Text = "Book ID: ";
            // 
            // Booknamelabel
            // 
            this.Booknamelabel.AutoSize = true;
            this.Booknamelabel.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booknamelabel.ForeColor = System.Drawing.Color.White;
            this.Booknamelabel.Location = new System.Drawing.Point(181, 394);
            this.Booknamelabel.Name = "Booknamelabel";
            this.Booknamelabel.Size = new System.Drawing.Size(126, 22);
            this.Booknamelabel.TabIndex = 99;
            this.Booknamelabel.Text = "Book Name: ";
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.AvailableBox);
            this.Controls.Add(this.publishyeartext);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.quantitytext);
            this.Controls.Add(this.writernametext);
            this.Controls.Add(this.bookidupdate);
            this.Controls.Add(this.booknametext);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.Categorylabel);
            this.Controls.Add(this.Quantitylabel);
            this.Controls.Add(this.AvailableBooklabel);
            this.Controls.Add(this.Publishyearlabel);
            this.Controls.Add(this.Writernamelabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Booknamelabel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Deletegridview);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.bookidtext);
            this.Controls.Add(this.Bookidlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UpdateBook";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closingform);
            ((System.ComponentModel.ISupportInitialize)(this.Deletegridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView Deletegridview;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox bookidtext;
        private System.Windows.Forms.Label Bookidlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox AvailableBox;
        private System.Windows.Forms.TextBox publishyeartext;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.TextBox quantitytext;
        private System.Windows.Forms.TextBox writernametext;
        private System.Windows.Forms.TextBox bookidupdate;
        private System.Windows.Forms.TextBox booknametext;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.Label Quantitylabel;
        private System.Windows.Forms.Label AvailableBooklabel;
        private System.Windows.Forms.Label Publishyearlabel;
        private System.Windows.Forms.Label Writernamelabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Booknamelabel;
    }
}