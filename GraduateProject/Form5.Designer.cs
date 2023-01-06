
namespace GraduateProject
{
    partial class Form5
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
			this.AddButton = new System.Windows.Forms.Button();
			this.backButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.titleTB = new System.Windows.Forms.TextBox();
			this.publisherTB = new System.Windows.Forms.TextBox();
			this.ISBNTB = new System.Windows.Forms.TextBox();
			this.genreTB = new System.Windows.Forms.TextBox();
			this.nameTB = new System.Windows.Forms.TextBox();
			this.languageTB = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dateOfPublicationDTP = new System.Windows.Forms.DateTimePicker();
			this.countryOfPublicationCB = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// AddButton
			// 
			this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.AddButton.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.AddButton.Location = new System.Drawing.Point(104, 187);
			this.AddButton.Margin = new System.Windows.Forms.Padding(2);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(124, 28);
			this.AddButton.TabIndex = 21;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = false;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// backButton
			// 
			this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.backButton.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.backButton.Location = new System.Drawing.Point(247, 187);
			this.backButton.Margin = new System.Windows.Forms.Padding(2);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(124, 28);
			this.backButton.TabIndex = 22;
			this.backButton.Text = "Go Back";
			this.backButton.UseVisualStyleBackColor = false;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label5.Location = new System.Drawing.Point(35, 34);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 17);
			this.label5.TabIndex = 23;
			this.label5.Text = "Title";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label4.Location = new System.Drawing.Point(35, 65);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 17);
			this.label4.TabIndex = 24;
			this.label4.Text = "Publisher";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(35, 96);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 17);
			this.label3.TabIndex = 25;
			this.label3.Text = "ISBN";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(35, 127);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 17);
			this.label1.TabIndex = 26;
			this.label1.Text = "Genre";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(229, 34);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 17);
			this.label2.TabIndex = 27;
			this.label2.Text = "Name";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label6.Location = new System.Drawing.Point(229, 127);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 17);
			this.label6.TabIndex = 28;
			this.label6.Text = "Languages";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label7.Location = new System.Drawing.Point(229, 96);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(123, 17);
			this.label7.TabIndex = 29;
			this.label7.Text = "Date of Publication";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label8.Location = new System.Drawing.Point(229, 65);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(139, 17);
			this.label8.TabIndex = 30;
			this.label8.Text = "Country of Publication";
			// 
			// titleTB
			// 
			this.titleTB.Location = new System.Drawing.Point(115, 34);
			this.titleTB.Margin = new System.Windows.Forms.Padding(2);
			this.titleTB.Name = "titleTB";
			this.titleTB.Size = new System.Drawing.Size(92, 20);
			this.titleTB.TabIndex = 31;
			// 
			// publisherTB
			// 
			this.publisherTB.Location = new System.Drawing.Point(115, 65);
			this.publisherTB.Margin = new System.Windows.Forms.Padding(2);
			this.publisherTB.Name = "publisherTB";
			this.publisherTB.Size = new System.Drawing.Size(92, 20);
			this.publisherTB.TabIndex = 32;
			// 
			// ISBNTB
			// 
			this.ISBNTB.Location = new System.Drawing.Point(115, 96);
			this.ISBNTB.Margin = new System.Windows.Forms.Padding(2);
			this.ISBNTB.Name = "ISBNTB";
			this.ISBNTB.Size = new System.Drawing.Size(92, 20);
			this.ISBNTB.TabIndex = 33;
			// 
			// genreTB
			// 
			this.genreTB.Location = new System.Drawing.Point(115, 127);
			this.genreTB.Margin = new System.Windows.Forms.Padding(2);
			this.genreTB.Name = "genreTB";
			this.genreTB.Size = new System.Drawing.Size(92, 20);
			this.genreTB.TabIndex = 34;
			// 
			// nameTB
			// 
			this.nameTB.Location = new System.Drawing.Point(370, 31);
			this.nameTB.Margin = new System.Windows.Forms.Padding(2);
			this.nameTB.Name = "nameTB";
			this.nameTB.Size = new System.Drawing.Size(92, 20);
			this.nameTB.TabIndex = 35;
			// 
			// languageTB
			// 
			this.languageTB.Location = new System.Drawing.Point(370, 126);
			this.languageTB.Margin = new System.Windows.Forms.Padding(2);
			this.languageTB.Name = "languageTB";
			this.languageTB.Size = new System.Drawing.Size(92, 20);
			this.languageTB.TabIndex = 36;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dateOfPublicationDTP);
			this.panel1.Controls.Add(this.countryOfPublicationCB);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.genreTB);
			this.panel1.Controls.Add(this.languageTB);
			this.panel1.Controls.Add(this.ISBNTB);
			this.panel1.Controls.Add(this.backButton);
			this.panel1.Controls.Add(this.publisherTB);
			this.panel1.Controls.Add(this.nameTB);
			this.panel1.Controls.Add(this.titleTB);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.AddButton);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Location = new System.Drawing.Point(153, 75);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(501, 261);
			this.panel1.TabIndex = 37;
			// 
			// dateOfPublicationDTP
			// 
			this.dateOfPublicationDTP.Location = new System.Drawing.Point(370, 96);
			this.dateOfPublicationDTP.Name = "dateOfPublicationDTP";
			this.dateOfPublicationDTP.Size = new System.Drawing.Size(92, 20);
			this.dateOfPublicationDTP.TabIndex = 38;
			// 
			// countryOfPublicationCB
			// 
			this.countryOfPublicationCB.FormattingEnabled = true;
			this.countryOfPublicationCB.Location = new System.Drawing.Point(370, 61);
			this.countryOfPublicationCB.Name = "countryOfPublicationCB";
			this.countryOfPublicationCB.Size = new System.Drawing.Size(94, 21);
			this.countryOfPublicationCB.TabIndex = 37;
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Name = "Form5";
			this.Text = "Form5";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox publisherTB;
        private System.Windows.Forms.TextBox ISBNTB;
        private System.Windows.Forms.TextBox genreTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox languageTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateOfPublicationDTP;
        private System.Windows.Forms.ComboBox countryOfPublicationCB;
    }
}