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
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
            refresh();
        }

        private void refresh()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = alex83953458130");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from librarytable";
            NpgsqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dbdDataGridView.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
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
    }
}
