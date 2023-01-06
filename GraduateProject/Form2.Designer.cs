
using System.Windows.Forms;

namespace GraduateProject
{
	partial class Form2
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
			this.signOutLB = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label12 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.BDLanguageTextBox = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.BDGenreTextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.AddToFavButton = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.BDDatePubTextBox = new System.Windows.Forms.TextBox();
			this.BDPublisherTextBox = new System.Windows.Forms.TextBox();
			this.BDAuthorTextBox = new System.Windows.Forms.TextBox();
			this.BDIsbnTextBox = new System.Windows.Forms.TextBox();
			this.BDTitleTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.SearchButton = new System.Windows.Forms.Button();
			this.UpdateBookButton = new System.Windows.Forms.Button();
			this.AddBookButton = new System.Windows.Forms.Button();
			this.BSIsbnTextBox = new System.Windows.Forms.TextBox();
			this.BSAuthorTextBox = new System.Windows.Forms.TextBox();
			this.BSTitleTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.imageList3 = new System.Windows.Forms.ImageList(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.panel1.Controls.Add(this.signOutLB);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(180, 389);
			this.panel1.TabIndex = 0;
			// 
			// signOutLB
			// 
			this.signOutLB.AutoSize = true;
			this.signOutLB.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.signOutLB.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.signOutLB.Location = new System.Drawing.Point(36, 354);
			this.signOutLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.signOutLB.Name = "signOutLB";
			this.signOutLB.Size = new System.Drawing.Size(56, 17);
			this.signOutLB.TabIndex = 14;
			this.signOutLB.Text = "Sigh out";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label14.Location = new System.Drawing.Point(36, 176);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(74, 17);
			this.label14.TabIndex = 13;
			this.label14.Text = "Contact Us";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label13.Location = new System.Drawing.Point(36, 153);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(63, 17);
			this.label13.TabIndex = 12;
			this.label13.Text = "Favorites";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(180, 120);
			this.panel2.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::GraduateProject.Properties.Resources._181E36;
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(36, 6);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(95, 75);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label12.Location = new System.Drawing.Point(54, 86);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(72, 17);
			this.label12.TabIndex = 11;
			this.label12.Text = "User Name";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.BDLanguageTextBox);
			this.panel3.Controls.Add(this.label16);
			this.panel3.Controls.Add(this.BDGenreTextBox);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.AddToFavButton);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.BDDatePubTextBox);
			this.panel3.Controls.Add(this.BDPublisherTextBox);
			this.panel3.Controls.Add(this.BDAuthorTextBox);
			this.panel3.Controls.Add(this.BDIsbnTextBox);
			this.panel3.Controls.Add(this.BDTitleTextBox);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Location = new System.Drawing.Point(496, 28);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(240, 344);
			this.panel3.TabIndex = 1;
			// 
			// BDLanguageTextBox
			// 
			this.BDLanguageTextBox.Location = new System.Drawing.Point(108, 228);
			this.BDLanguageTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.BDLanguageTextBox.Name = "BDLanguageTextBox";
			this.BDLanguageTextBox.Size = new System.Drawing.Size(91, 20);
			this.BDLanguageTextBox.TabIndex = 25;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label16.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label16.Location = new System.Drawing.Point(42, 231);
			this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(68, 17);
			this.label16.TabIndex = 24;
			this.label16.Text = "Language";
			// 
			// BDGenreTextBox
			// 
			this.BDGenreTextBox.Location = new System.Drawing.Point(108, 198);
			this.BDGenreTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.BDGenreTextBox.Name = "BDGenreTextBox";
			this.BDGenreTextBox.Size = new System.Drawing.Size(91, 20);
			this.BDGenreTextBox.TabIndex = 23;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label11.Location = new System.Drawing.Point(42, 201);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(45, 17);
			this.label11.TabIndex = 22;
			this.label11.Text = "Genre";
			// 
			// AddToFavButton
			// 
			this.AddToFavButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.AddToFavButton.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.AddToFavButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.AddToFavButton.Location = new System.Drawing.Point(49, 295);
			this.AddToFavButton.Margin = new System.Windows.Forms.Padding(2);
			this.AddToFavButton.Name = "AddToFavButton";
			this.AddToFavButton.Size = new System.Drawing.Size(149, 28);
			this.AddToFavButton.TabIndex = 21;
			this.AddToFavButton.Text = "Add to my favorites";
			this.AddToFavButton.UseVisualStyleBackColor = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label10.Location = new System.Drawing.Point(42, 170);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 17);
			this.label10.TabIndex = 19;
			this.label10.Text = "Date pub";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label9.Location = new System.Drawing.Point(42, 136);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 17);
			this.label9.TabIndex = 18;
			this.label9.Text = "Publisher";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label8.Location = new System.Drawing.Point(42, 100);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 17);
			this.label8.TabIndex = 17;
			this.label8.Text = "Author";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label7.Location = new System.Drawing.Point(42, 66);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 17);
			this.label7.TabIndex = 11;
			this.label7.Text = "ISBN";
			// 
			// BDDatePubTextBox
			// 
			this.BDDatePubTextBox.Location = new System.Drawing.Point(108, 167);
			this.BDDatePubTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.BDDatePubTextBox.Name = "BDDatePubTextBox";
			this.BDDatePubTextBox.Size = new System.Drawing.Size(91, 20);
			this.BDDatePubTextBox.TabIndex = 15;
			// 
			// BDPublisherTextBox
			// 
			this.BDPublisherTextBox.Location = new System.Drawing.Point(108, 133);
			this.BDPublisherTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.BDPublisherTextBox.Name = "BDPublisherTextBox";
			this.BDPublisherTextBox.Size = new System.Drawing.Size(91, 20);
			this.BDPublisherTextBox.TabIndex = 14;
			// 
			// BDAuthorTextBox
			// 
			this.BDAuthorTextBox.Location = new System.Drawing.Point(108, 96);
			this.BDAuthorTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.BDAuthorTextBox.Name = "BDAuthorTextBox";
			this.BDAuthorTextBox.Size = new System.Drawing.Size(91, 20);
			this.BDAuthorTextBox.TabIndex = 13;
			// 
			// BDIsbnTextBox
			// 
			this.BDIsbnTextBox.Location = new System.Drawing.Point(108, 62);
			this.BDIsbnTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.BDIsbnTextBox.Name = "BDIsbnTextBox";
			this.BDIsbnTextBox.Size = new System.Drawing.Size(91, 20);
			this.BDIsbnTextBox.TabIndex = 12;
			// 
			// BDTitleTextBox
			// 
			this.BDTitleTextBox.Location = new System.Drawing.Point(108, 26);
			this.BDTitleTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.BDTitleTextBox.Name = "BDTitleTextBox";
			this.BDTitleTextBox.Size = new System.Drawing.Size(91, 20);
			this.BDTitleTextBox.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label6.Location = new System.Drawing.Point(42, 31);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "Title";
			// 
			// DeleteButton
			// 
			this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DeleteButton.Location = new System.Drawing.Point(43, 245);
			this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(149, 28);
			this.DeleteButton.TabIndex = 20;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = false;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.SearchButton);
			this.panel4.Controls.Add(this.DeleteButton);
			this.panel4.Controls.Add(this.UpdateBookButton);
			this.panel4.Controls.Add(this.AddBookButton);
			this.panel4.Controls.Add(this.BSIsbnTextBox);
			this.panel4.Controls.Add(this.BSAuthorTextBox);
			this.panel4.Controls.Add(this.BSTitleTextBox);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Location = new System.Drawing.Point(219, 28);
			this.panel4.Margin = new System.Windows.Forms.Padding(2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(240, 344);
			this.panel4.TabIndex = 2;
			// 
			// SearchButton
			// 
			this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.SearchButton.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.SearchButton.Location = new System.Drawing.Point(142, 118);
			this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(63, 24);
			this.SearchButton.TabIndex = 13;
			this.SearchButton.Text = "Search";
			this.SearchButton.UseVisualStyleBackColor = false;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// UpdateBookButton
			// 
			this.UpdateBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.UpdateBookButton.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.UpdateBookButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.UpdateBookButton.Location = new System.Drawing.Point(43, 295);
			this.UpdateBookButton.Margin = new System.Windows.Forms.Padding(2);
			this.UpdateBookButton.Name = "UpdateBookButton";
			this.UpdateBookButton.Size = new System.Drawing.Size(149, 28);
			this.UpdateBookButton.TabIndex = 12;
			this.UpdateBookButton.Text = "Update Book";
			this.UpdateBookButton.UseVisualStyleBackColor = false;
			this.UpdateBookButton.Click += new System.EventHandler(this.UpdateBookButton_Click);
			// 
			// AddBookButton
			// 
			this.AddBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.AddBookButton.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.AddBookButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.AddBookButton.Location = new System.Drawing.Point(43, 192);
			this.AddBookButton.Margin = new System.Windows.Forms.Padding(2);
			this.AddBookButton.Name = "AddBookButton";
			this.AddBookButton.Size = new System.Drawing.Size(149, 28);
			this.AddBookButton.TabIndex = 11;
			this.AddBookButton.Text = "Add Book";
			this.AddBookButton.UseVisualStyleBackColor = false;
			this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
			// 
			// BSIsbnTextBox
			// 
			this.BSIsbnTextBox.Location = new System.Drawing.Point(115, 76);
			this.BSIsbnTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.BSIsbnTextBox.Name = "BSIsbnTextBox";
			this.BSIsbnTextBox.Size = new System.Drawing.Size(91, 20);
			this.BSIsbnTextBox.TabIndex = 10;
			// 
			// BSAuthorTextBox
			// 
			this.BSAuthorTextBox.Location = new System.Drawing.Point(115, 50);
			this.BSAuthorTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.BSAuthorTextBox.Name = "BSAuthorTextBox";
			this.BSAuthorTextBox.Size = new System.Drawing.Size(91, 20);
			this.BSAuthorTextBox.TabIndex = 9;
			// 
			// BSTitleTextBox
			// 
			this.BSTitleTextBox.Location = new System.Drawing.Point(115, 26);
			this.BSTitleTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.BSTitleTextBox.Name = "BSTitleTextBox";
			this.BSTitleTextBox.Size = new System.Drawing.Size(91, 20);
			this.BSTitleTextBox.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label5.Location = new System.Drawing.Point(33, 81);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "ISBN";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label4.Location = new System.Drawing.Point(33, 55);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Author";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(33, 31);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Title";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(303, 23);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "Book Search";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(585, 23);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 16);
			this.label1.TabIndex = 14;
			this.label1.Text = "Book Details";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imageList2
			// 
			this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imageList3
			// 
			this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
			this.ClientSize = new System.Drawing.Size(761, 389);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form2";
			this.Text = "Form2";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
		private Panel panel4;
		private TextBox BSIsbnTextBox;
		private TextBox BSAuthorTextBox;
		private TextBox BSTitleTextBox;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label7;
		private TextBox BDDatePubTextBox;
		private TextBox BDPublisherTextBox;
		private TextBox BDIsbnTextBox;
		private TextBox BDTitleTextBox;
		private Label label6;
		private Button AddBookButton;
		private Label label12;
		private Label label10;
		private Label label9;
		private Label signOutLB;
		private Label label14;
		private Label label13;
		private Button AddToFavButton;
		private Button DeleteButton;
		private Button UpdateBookButton;
		private Label label1;
		private Label label2;
		private PictureBox pictureBox1;
		private Button SearchButton;
		private ImageList imageList1;
		private ImageList imageList2;
		private ImageList imageList3;
		private TextBox BDGenreTextBox;
		private Label label11;
		private TextBox BDLanguageTextBox;
		private Label label16;
		private Label label8;
		private TextBox BDAuthorTextBox;
	}
}