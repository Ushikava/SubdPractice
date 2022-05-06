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
    public partial class deleteBookForm : Form
    {
        string bookName = "";

        public deleteBookForm()
        {
            InitializeComponent();
        }

        private void deletebButton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = alex83953458130");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add(new NpgsqlParameter("@delBookName", bookName));
            comm.CommandText = "delete from librarytable where bookname = (@delBookName);";

            comm.ExecuteNonQuery();

            comm.Dispose();
            conn.Close();

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            bookName = "";
            this.Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            bookName = nameTextBox.Text;
        }
    }
}
