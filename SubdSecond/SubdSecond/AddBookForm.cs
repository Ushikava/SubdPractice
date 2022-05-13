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
        string choosenPictureFile = "";
        string choosenBookFile = "";

        public AddBookForm()
        {
            InitializeComponent();
            //NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = uliya1992");
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
            if (bookName == "" || bookAuthor == "")
            {
                MessageBox.Show("Не все параметры указаны!","Ошибка");
                return;
            }

            if (findBookInList(bookName) == true)
            {
                MessageBox.Show("Такая книга уже существует!", "Ошибка");
                return;
            }

            //NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = uliya1992");
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
            
            if (choosenPictureFile != "")
            {
                try
                {
                    System.IO.File.Copy(choosenPictureFile, @"CoversOfBooks\" + bookName + ".png", true);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Не удалось взять картинку. Ошибка: " + exp.Message, "Ошибка");
                }
            }
            
            if (choosenBookFile != "")
            {
                try
                {
                    System.IO.File.Copy(choosenBookFile, @"Books\" + bookName + ".pdf", true);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Не удалось взять выбранный источник. Ошибка: " + exp.Message, "Ошибка");
                }
            }

            comm.ExecuteNonQuery();

            comm.Dispose();
            conn.Close();

            genreIndex = -1;
            bookName = "";
            numOfPages = -1;
            bookAuthor = "";

            this.Close();
            
        }

        private bool findBookInList(string bookname)
        {
            bool searchcheck = false;
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = alex83953458130");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add(new NpgsqlParameter("@newBookName", bookName));
            comm.CommandText = "select * from librarytable where bookname = @newBookName";
            NpgsqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
                searchcheck = true;
            return searchcheck;
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
            bool check = int.TryParse(bookPagesTextBox.Text, out numOfPages);
            if (check == false)
            {
                numOfPages = -1;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            genreIndex = -1;
            bookName = "";
            numOfPages = -1;
            bookAuthor = "";

            this.Close();
        }

        private void choosePictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.Filter = "png files (*.png)|*.png";
            ofdlg.Multiselect = false;
            ofdlg.RestoreDirectory = true;
            ofdlg.ShowDialog();
            choosenPictureFile = ofdlg.FileName;
            
        }

        private void chooseSourceButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.Filter = "pdf files (*.pdf)|*.pdf";
            ofdlg.Multiselect = false;
            ofdlg.RestoreDirectory = true;
            ofdlg.ShowDialog();
            choosenBookFile = ofdlg.FileName;
        }
    }
}
