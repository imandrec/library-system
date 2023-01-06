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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			//search book through title author or isbn
			DataAccessFromDataBase dataAccess = new DataAccessFromDataBase();
			Book book = new Book();

			string title = BSTitleTextBox?.Text;
			string author = BSAuthorTextBox?.Text;
			string ISBN = BSIsbnTextBox?.Text;

			if (title != null && author != null && ISBN != null)
			{
				book = dataAccess.SearchBook(title, author, ISBN);
			}

			if (book == null)
			{
				MessageBox.Show("Book Not Found");
			}
			else
			{
				BDTitleTextBox.Text = book.Title;
				BDIsbnTextBox.Text = book.ISBN;
				BDPublisherTextBox.Text = book.Publisher;
				BDAuthorTextBox.Text = book.Name;
				BDDatePubTextBox.Text = book.Date_of_publication;
				BDGenreTextBox.Text = book.Genre;
				BDLanguageTextBox.Text = book.Languages;
			}
		}

		private void AddBookButton_Click(object sender, EventArgs e)
		{
			Form5 form5 = new Form5();
			form5.ShowDialog();
		}

		private void UpdateBookButton_Click(object sender, EventArgs e)
		{
			DataModificationToDataBase dataModification = new DataModificationToDataBase();

			if (BDTitleTextBox.Text == "")
			{
				MessageBox.Show("Enter at least Title");
			}

			else
			{
				dataModification.UpdateBook(new Book
				{
					Title = BDTitleTextBox?.Text,
					Name = BDAuthorTextBox?.Text,
					ISBN = BDIsbnTextBox?.Text,
					Publisher = BDPublisherTextBox?.Text,
					Date_of_publication = BDDatePubTextBox?.Text,
					Genre = BDGenreTextBox?.Text,
					Languages = BDLanguageTextBox?.Text
				});
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			DataModificationToDataBase dataModification = new DataModificationToDataBase();

			string title = "";
			title = BSTitleTextBox.Text;

			if (BSTitleTextBox.Text != "")
			{
				int result = dataModification.DeleteBook(title);

				if (result == 0)
				{
					MessageBox.Show("Deletion Failed May be Book not in DB");
				}
				else if (result > 0)
				{
					MessageBox.Show("Deletion Successful");
				}
			}

			else if (BSTitleTextBox.Text == "")
			{
				MessageBox.Show("Please provide at least Title of the book");
			}
		}
	}
}
