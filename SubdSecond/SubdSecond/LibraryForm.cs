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
        enum Statuses
        {
            ADDBOOK,
            PLANNING,
            READAING,
            READ,
            DROPPED,
            PUTAWAY
        }

        string userNickName = "";

        public LibraryForm(string nickName)
        {
            userNickName = nickName;
            InitializeComponent();
            refresh();
            sayHiLabel.Text = "Добро пожаловать, " + nickName + "!";
        }

        private void refresh()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = alex83953458130");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add(new NpgsqlParameter("@userNickName", userNickName));
            comm.CommandText = "select * from statustable where userlogin = @userNickName";
            NpgsqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                //показывать все книжки, но статусы только у некоторых
                singleBookPanelControl sbpc = new singleBookPanelControl(userNickName);

                while (reader.Read())
                {
                    //sbpc.Location = new Point(20, 50);
                    sbpc.Margin = new Padding(15,15,15,15);
                    myOwnPanel.Controls.Add(sbpc);
                    sbpc.bookNameLabel.Text = reader.GetString(1);
                    sbpc.statusComboBox.SelectedIndex = (reader.GetInt32(2))-1;
                }
            }
            comm.Dispose();
            conn.Close();
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

        private string GetBookStatus(Statuses statusCode)
        {
            switch (statusCode)
            {
                case Statuses.PLANNING:
                    return "В планах";
                case Statuses.READAING:
                    return "Читаю";
                case Statuses.READ:
                    return "Прочитал";
                case Statuses.DROPPED:
                    return "Бросил";
                case Statuses.PUTAWAY:
                    return "Отложил";
                default:
                    return "Добавить...";
            }
        }
    }
}
