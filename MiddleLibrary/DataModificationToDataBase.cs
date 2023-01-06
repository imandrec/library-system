using MiddleLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleLibrary
{
	public class DataModificationToDataBase
	{
		//connection string
		private string CS = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\andre\Desktop\Universidad\segundo semestre\.net\GraduateProject\DemoDB\Database.mdf"";Integrated Security=True";

		public int InsertNewBook(Book book)
		{

			SqlConnection connection = new SqlConnection(CS);

			string query = "insert into myTable values (@title, @ISBN, @name,@country_of_publication,@publisher,@date_of_publication,@genre,@languges);";

			SqlCommand sqlCommand = new SqlCommand(query, connection);

			sqlCommand.Parameters.AddWithValue("@title", book.Title);
			sqlCommand.Parameters.AddWithValue("@ISBN", book.ISBN);
			sqlCommand.Parameters.AddWithValue("@name", book.Name);
			sqlCommand.Parameters.AddWithValue("@country_of_publication", book.Country_of_publication);
			sqlCommand.Parameters.AddWithValue("@publisher", book.Publisher);
			sqlCommand.Parameters.AddWithValue("@date_of_publication", book.Date_of_publication);
			sqlCommand.Parameters.AddWithValue("@genre", book.Genre);
			sqlCommand.Parameters.AddWithValue("@languges", book.Languages);

			connection.Open();

			int rowsAffected = sqlCommand.ExecuteNonQuery();

			connection.Close();

			return rowsAffected;

		}

		public int DeleteBook(string title)
		{
			SqlConnection connection = new SqlConnection(CS);

			string query = "delete from myTable where title =@title;";

			SqlCommand sqlCommand = new SqlCommand(query, connection);

			sqlCommand.Parameters.AddWithValue("@title", title);

			connection.Open();

			int rowsAffected = sqlCommand.ExecuteNonQuery();

			connection.Close();

			return rowsAffected;
		}

		//Update Customer throgh it ID
		public int UpdateBook(Book book)
		{
			SqlConnection connection = new SqlConnection(CS);

			string query = "update myTable set Name = @name, publisher = @publisher,genre = @genre, where Title = @title;";

			SqlCommand sqlCommand = new SqlCommand(query, connection);

			sqlCommand.Parameters.AddWithValue("@title", book.Title);
			sqlCommand.Parameters.AddWithValue("@name", book.Name);
			sqlCommand.Parameters.AddWithValue("@country_of_publication", book.Country_of_publication);
			sqlCommand.Parameters.AddWithValue("@publisher", book.Publisher);
			sqlCommand.Parameters.AddWithValue("@date_of_publication", book.Date_of_publication);
			sqlCommand.Parameters.AddWithValue("@genre", book.Genre);
			sqlCommand.Parameters.AddWithValue("@languges", book.Languages);

			connection.Open();

			int rowsAffected = sqlCommand.ExecuteNonQuery();

			connection.Close();

			return rowsAffected;

		}
	}
}
