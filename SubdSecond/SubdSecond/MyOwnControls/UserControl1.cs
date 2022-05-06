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

namespace SubdSecond.MyOwnControls
{
    public partial class singleBookPanelControl : UserControl
    {
        string userNickName = "";
        public singleBookPanelControl(string nickName)
        {
            InitializeComponent();
            userNickName = nickName;
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = alex83953458130");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select statustypes from statusestable";
            NpgsqlDataReader reader = comm.ExecuteReader();
            List<string> personalBookStatus = new List<string>();
            
            while (reader.Read())
            {
                string status = reader["statustypes"].ToString();
                personalBookStatus.Add(status);
            }
            comm.Dispose();
            conn.Close();
            personalBookStatus.Add("Добавить...");
            statusComboBox.DataSource = personalBookStatus;
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            statusComboBox.Visible = true;
        }

        private void bookNameLabel_MouseEnter(object sender, EventArgs e)
        {
            statusComboBox.Visible = true;
        }

        private void bookNameLabel_MouseLeave(object sender, EventArgs e)
        {
            statusComboBox.Visible = false;
        }

        private void statusComboBox_MouseEnter(object sender, EventArgs e)
        {
            statusComboBox.Visible = true;
        }

        private void statusComboBox_MouseLeave(object sender, EventArgs e)
        {
            statusComboBox.Visible = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            //statusComboBox.Visible = false;
        }

        private void statusComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string currentBookName = bookNameLabel.Text;
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = alex83953458130");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add(new NpgsqlParameter("@userNickName", userNickName));
            comm.Parameters.Add(new NpgsqlParameter("@curBookName", currentBookName));
            comm.CommandText = "select * from statustable where userlogin = @userNickName and booknames = @curBookName";
            NpgsqlDataReader reader = comm.ExecuteReader();

            bool addOrChange = reader.HasRows;
            
            comm.Dispose();
            conn.Close();

            int newStatusIndex = statusComboBox.SelectedIndex + 1;
            conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = alex83953458130");
            conn.Open();
            comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add(new NpgsqlParameter("@userNickName", userNickName));
            comm.Parameters.Add(new NpgsqlParameter("@curBookName", currentBookName));
            comm.Parameters.Add(new NpgsqlParameter("@newStatusIndex", newStatusIndex));
            if (newStatusIndex != 6)
            {
                if (addOrChange)
                    comm.CommandText = "update statustable set statuslist = @newStatusIndex where userlogin = @userNickName and booknames = @curBookName";
                else
                    comm.CommandText = "insert into statustable (userlogin, booknames, statuslist) values (@userNickName, @curBookName, @newStatusIndex)";
            }
            else
                comm.CommandText = "delete from statustable where userlogin = @userNickName and booknames = @curBookName";

            comm.ExecuteReader();
            comm.Dispose();
            conn.Close();
        }
    }
}
