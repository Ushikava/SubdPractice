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
    public partial class ProfileForm : Form
    {
        string userNickName = "";

        public ProfileForm(string nickname)
        {
            InitializeComponent();
            userNickName = nickname;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            int planes = 0;
            int reading = 0;
            int readed = 0;
            int dropped = 0;
            int putout = 0;
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
                while (reader.Read())
                {
                    switch (reader.GetInt32(2))
                    { 
                        case 1:
                            planes++;
                            break;
                        case 2:
                            reading++;
                            break;
                        case 3:
                            readed++;
                            break;
                        case 4:
                            dropped++;
                            break;
                        case 5:
                            putout++;
                            break;
                        default:
                            break;
                    }
                }
            }
            comm.Dispose();
            conn.Close();

            numOfLabel1.Text = planes.ToString();
            numOfLabel2.Text = reading.ToString();
            numOfLabel3.Text = readed.ToString();
            numOfLabel4.Text = dropped.ToString();
            numOfLabel5.Text = putout.ToString();

            userNickNameLabel.Text = "Имя пользователя - " + userNickName + "\n\nКоличество прочитанных книг = " + readed.ToString() + ". Так держать!";


        }

        private void profileTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changePasswordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void profileDeleteLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить свой профиль? Все данные о вашей библиотеке удалятся!",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = alex83953458130");
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.Parameters.Add(new NpgsqlParameter("@userNickName", userNickName));
                comm.CommandText = "delete from statustable where userlogin = @userNickName";
                comm.ExecuteReader();
                comm.Dispose();
                conn.Close();

                conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = alex83953458130");
                conn.Open();
                comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.Parameters.Add(new NpgsqlParameter("@userNickName", userNickName));
                comm.CommandText = "delete from userstable where userlogin = @userNickName";
                comm.ExecuteReader();
                comm.Dispose();
                conn.Close();

                Environment.Exit(0);
            }
        }
    }
}
