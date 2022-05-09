using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SubdSecond.MyOwnControls;
using Npgsql;

namespace SubdSecond
{
    public partial class LibraryForm : Form
    {
        string userNickName = "";

        enum Statuses
        {
            ADDBOOK,
            PLANNING,
            READAING,
            READ,
            DROPPED,
            PUTAWAY
        }

        public struct Book
        {
            public string name;
            public int genre;
            public string author;
            public int numOfPages;
            public int status;
        }


        public LibraryForm(string nickName)
        {
            userNickName = nickName;
            InitializeComponent();
            refresh();
            sayHiLabel.Text = "Добро пожаловать, " + nickName + "!";
        }

        private void refresh()
        {
            List<Book> library = new List<Book>();
            myOwnPanel.Controls.Clear();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = alex83953458130");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from librarytable";
            NpgsqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Book oneBook = new Book();
                    oneBook.name = reader["bookname"].ToString();
                    oneBook.author = reader["authorname"].ToString();
                    oneBook.numOfPages = Convert.ToInt32(reader["numberofpages"]);
                    oneBook.genre = Convert.ToInt32(reader["bookgenre"]);
                    oneBook.status = -1;
                    library.Add(oneBook);
                }
            }
            comm.Dispose();
            conn.Close();


            conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = alex83953458130");
            conn.Open();
            comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add(new NpgsqlParameter("@userNickName", userNickName));
            comm.CommandText = "select * from statustable where userlogin = @userNickName";
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string bookName = reader["booknames"].ToString();
                
                for (int i = 0; i<library.Count; i++)
                {
                    if (library[i].name == bookName)
                    {
                        Book currentBook = library[i];
                        currentBook.status = ((reader.GetInt32(2)) - 1);
                        library[i] = currentBook;
                    }
                }
                
            }
            comm.Dispose();
            conn.Close();

            foreach (Book j in library)
            {
                singleBookPanelControl sbpc = new singleBookPanelControl(userNickName);
                sbpc.Margin = new Padding(15, 15, 15, 15);
                myOwnPanel.Controls.Add(sbpc);
                sbpc.bookNameLabel.Text = j.name;
                sbpc.statusComboBox.SelectedIndex = j.status;
                if (j.status == -1)
                {
                    sbpc.statusComboBox.SelectedIndex = 5;
                }

            }

            myOwnPanel.PaintForm();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm abf = new AddBookForm();
            abf.ShowDialog(this);
            refresh();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteBookForm dbf = new deleteBookForm();
            dbf.ShowDialog(this);
            refresh();
        }

        private void LibraryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {

        }

        private void LibraryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите выйти?",
                "Выход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void оПриложенииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение \"Моя библиотека\" создано в качестве личной пользовательской библиотеки. Сохраняйте списки книг, добавляйте новые, редактируйте предпочтения. Язык программирования С#, .NET Framework 5. Использованные библиотеки: WinForms, RealTaiizor, NPGSQL. 2022 год ",
                "О приложении",
                MessageBoxButtons.OK);
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Брюханов Алексей Владимирович, Братский государственный универститет, 2022 год.",
                "Об авторе",
                MessageBoxButtons.OK);
        }

        //private string GetBookStatus(Statuses statusCode)
        //{
        //    switch (statusCode)
        //    {
        //        case Statuses.PLANNING:
        //            return "В планах";
        //        case Statuses.READAING:
        //            return "Читаю";
        //        case Statuses.READ:
        //            return "Прочитал";
        //        case Statuses.DROPPED:
        //            return "Бросил";
        //        case Statuses.PUTAWAY:
        //            return "Отложил";
        //        default:
        //            return "Добавить...";
        //    }
        //}

    }
}
