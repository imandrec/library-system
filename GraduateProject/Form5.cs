using MiddleLibrary;
using MiddleLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduateProject
{
	public partial class Form5 : Form
	{
		DataModificationToDataBase dataModification = new DataModificationToDataBase();
		public Form5()
		{
			InitializeComponent();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			string title = titleTB?.Text;
			string publisher = publisherTB?.Text;
			string ISBN = ISBNTB?.Text;
			string genre = genreTB?.Text;
			string name = nameTB?.Text;
			string countryOfPublication = countryOfPublicationCB?.Text.ToString();
			string dateOfPublication = (dateOfPublicationDTP?.Value.Year.ToString());
			string languages = languageTB?.Text;

			if (title != null && languages != null)
			{
				int chkIfAdded = dataModification.InsertNewBook(new Book
				{
					Title = title,
					Publisher = publisher,
					ISBN = ISBN,
					Genre = genre,
					Name = name,
					Country_of_publication = countryOfPublication,
					Date_of_publication = dateOfPublication,
					Languages = languages
				});

				if (chkIfAdded > 0)
				{
					MessageBox.Show(this, "Book Added Successfuly", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show(this, "Book Cannot be Added.", "NOT Added!", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
			}
			else
			{
				MessageBox.Show("Title or Language cannot be null");
			}
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

