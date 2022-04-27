using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SubdSecond
{
    public partial class AddBookForm : Form
    {
        int genreIndex = -1;
        string bookName = "";
        int numOfPages = -1;
        string bookAuthor = "";

        public AddBookForm()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = alex83953458130");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from genretable";
            NpgsqlDataReader reader = comm.ExecuteReader();
            List<(int,string)> genreOfBooks = new List<(int,string)>();
            //while (reader.Read()==true)
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string genre = reader["genre"].ToString();
                genreOfBooks.Add((id, genre));
                //bookGenreComboBox.Items.Add(genre);
            }
            comm.Dispose();
            conn.Close();

            bookGenreComboBox.DataSource = genreOfBooks;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = alex83953458130");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add(new NpgsqlParameter("@newBookName", bookName));
            comm.Parameters.Add(new NpgsqlParameter("@newNumberOfPages", numOfPages));
            comm.Parameters.Add(new NpgsqlParameter("@newAuthorName", bookAuthor));
            comm.Parameters.Add(new NpgsqlParameter("@newGenreName", genreIndex));
            comm.CommandText = "insert into librarytable (bookname, numberofpages, authorname, bookgenre) values (@newBookName, @newNumberOfPages, @newAuthorName, @newGenreName);";

            comm.ExecuteNonQuery();

            comm.Dispose();
            conn.Close();

            genreIndex = -1;
            bookName = "";
            numOfPages = -1;
            bookAuthor = "";

            this.Close();
            
        }

        private void bookGenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexOfGenre = bookGenreComboBox.SelectedIndex + 1;
            genreIndex = indexOfGenre;
        }

        private void bookNameTextBox_TextChanged(object sender, EventArgs e)
        {
            bookName = bookNameTextBox.Text;
        }

        private void bookAuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            bookAuthor = bookAuthorTextBox.Text;
        }

        private void bookPagesTextBox_TextChanged(object sender, EventArgs e)
        {
            numOfPages = Convert.ToInt32(bookPagesTextBox.Text);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            genreIndex = -1;
            bookName = "";
            numOfPages = -1;
            bookAuthor = "";

            this.Close();
        }
    }
}
