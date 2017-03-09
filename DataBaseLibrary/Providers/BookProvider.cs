using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApplicationWindowsForms.Presenter
{
    public class BookProvider
    {
        System.Data.SqlClient.SqlConnection sqlConnection1 =
            new System.Data.SqlClient.SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slavik\Desktop\Проект\Задание2\BookApplicationWindowsForms14\DataBaseLibrary\DatabaseLibrary.mdf;Integrated Security = True");

        public void AddBook(string name, string subjects)
        {
            System.Data.SqlClient.SqlCommand addBook = new System.Data.SqlClient.SqlCommand();
            addBook.CommandType = System.Data.CommandType.Text;
            addBook.CommandText = "INSERT INTO [Books] (Name, Subjects)VALUES(@Name, @Subjects)";
            addBook.Parameters.AddWithValue("@Name", name);
            addBook.Parameters.AddWithValue("@Subjects", subjects);
            addBook.Connection = sqlConnection1;
            sqlConnection1.Open();
            addBook.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        public void AddAuthor(string name, string surname, string middleName, int _index)
        {
            System.Data.SqlClient.SqlCommand addAuthor = new System.Data.SqlClient.SqlCommand();
            addAuthor.CommandType = System.Data.CommandType.Text;
            addAuthor.CommandText = "INSERT INTO [Authors] (Name, Surname,MiddleName,BookId)VALUES(@Name, @Surname, @MiddleName, @BookId)";
            addAuthor.Parameters.AddWithValue("@Name", name);
            addAuthor.Parameters.AddWithValue("@Surname", surname);
            addAuthor.Parameters.AddWithValue("@MiddleName", middleName);
            addAuthor.Parameters.AddWithValue("@BookId", _index);
            addAuthor.Connection = sqlConnection1;
            sqlConnection1.Open();
            addAuthor.ExecuteNonQuery();
            sqlConnection1.Close();
        }


        public bool FindBook(string name)
        {
            System.Data.SqlClient.SqlCommand findBook = new System.Data.SqlClient.SqlCommand();
            findBook.CommandType = System.Data.CommandType.Text;
            findBook.CommandText = "SELECT Id FROM [Books] WHERE Name=@Name";
            findBook.Parameters.AddWithValue("@Name", name);
            findBook.Connection = sqlConnection1;
            sqlConnection1.Open();
            SqlDataReader reader = null;
            bool _flag = false;
            try
            {
                reader = findBook.ExecuteReader();
                while (reader.Read())
                {
                    _flag = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    sqlConnection1.Close();
                }
            }
            return _flag;
        }

        public bool FindAuthor(string name, string surname, string middleName, int _index)
        {
            System.Data.SqlClient.SqlCommand findAuthor = new System.Data.SqlClient.SqlCommand();
            findAuthor.CommandType = System.Data.CommandType.Text;
            findAuthor.CommandText = "SELECT Id FROM [Authors] WHERE Name=@Name AND Surname=@Surname AND MiddleName=@MiddleName AND BookId=@BookId";
            findAuthor.Parameters.AddWithValue("@Name", name);
            findAuthor.Parameters.AddWithValue("@Surname", surname);
            findAuthor.Parameters.AddWithValue("@MiddleName", middleName);
            findAuthor.Parameters.AddWithValue("@BookId", _index);
            findAuthor.Connection = sqlConnection1;
            sqlConnection1.Open();
            SqlDataReader reader = null;
            bool _flag = false;
            try
            {
                reader = findAuthor.ExecuteReader();
                while (reader.Read())
                {
                    _flag = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    sqlConnection1.Close();
                }
            }
            return _flag;
        }

        public int FindIndexBook(string name)
        {
            System.Data.SqlClient.SqlCommand findBook = new System.Data.SqlClient.SqlCommand();
            findBook.CommandType = System.Data.CommandType.Text;
            findBook.CommandText = "SELECT Id FROM [Books] WHERE Name=@Name";
            findBook.Parameters.AddWithValue("@Name", name);
            findBook.Connection = sqlConnection1;
            sqlConnection1.Open();
            SqlDataReader reader = null;
            int _index = 0;
            try
            {
                reader = findBook.ExecuteReader();

                while (reader.Read())
                {
                    _index = Convert.ToInt32(reader["Id"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    sqlConnection1.Close();
                }
            }
            return _index;
        }

        public void SqlConnectionClose()
        {
            if (sqlConnection1 != null && sqlConnection1.State != ConnectionState.Closed)
                sqlConnection1.Close();
        }
    }
}
