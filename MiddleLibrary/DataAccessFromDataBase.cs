using MiddleLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleLibrary
{
	public class DataAccessFromDataBase
	{
		//connection string
		private string CS = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\andre\Desktop\Universidad\segundo semestre\.net\GraduateProject\DemoDB\Database.mdf"";Integrated Security=True";

		public Book SearchBook(string title, string author, string isbn)
		{
			Book book = new Book();
			SqlConnection sqlConnection = new SqlConnection(CS);

			string query = "select * from mytable where title=@title and name = @author and isbn = @isbn";

			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			sqlCommand.Parameters.AddWithValue("@title",title);
			sqlCommand.Parameters.AddWithValue("@author", author);
			sqlCommand.Parameters.AddWithValue("@isbn", isbn);

			sqlConnection.Open();

			sqlCommand.ExecuteNonQuery();

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			if(sqlDataReader.HasRows)
			{
				while(sqlDataReader.Read())
				{
					book.Title = (string)(sqlDataReader[0] == DBNull.Value? ("") : (sqlDataReader[0])) ;
					book.ISBN = (string)(sqlDataReader[1] == DBNull.Value ? ("") : (sqlDataReader[1]));
					book.Name = (string)(sqlDataReader[2] == DBNull.Value ? ("") : (sqlDataReader[2]));//author
					book.Country_of_publication = (string)(sqlDataReader[3] == DBNull.Value ? ("") : (sqlDataReader[3]));
					book.Publisher = (string)(sqlDataReader[4] == DBNull.Value ? ("") : (sqlDataReader[4]));
					book.Date_of_publication = (string)(sqlDataReader[5] == DBNull.Value ? ("") : (sqlDataReader[5]));
					book.Genre = (string)(sqlDataReader[6] == DBNull.Value ? ("") : (sqlDataReader[6]));
					book.Languages = (string)(sqlDataReader[7] == DBNull.Value ? ("") : (sqlDataReader[7]));
				}
			}

			else
			{
				return null;
			}
			
			sqlConnection.Close();

			return book;
		}
	}
}
