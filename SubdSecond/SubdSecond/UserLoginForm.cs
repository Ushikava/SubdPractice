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
    public partial class UserLoginForm : Form
    {
        //true if sign in, false if need to register
        bool signInUpCheck = true;

        string userLogin = "";
        string userPassword = "";

        public UserLoginForm()
        {
            InitializeComponent();
        }

        public bool signUpNewUser()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = alex83953458130");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add(new NpgsqlParameter("@newUserLogin", userLogin));
            comm.Parameters.Add(new NpgsqlParameter("@newUserPassword", userPassword));
            comm.CommandText = "select userlogin from userstable where (userlogin = @newUserLogin);";
            NpgsqlDataReader reader = comm.ExecuteReader();
            
            bool signUpNewCheck = false;
            if (reader.HasRows == false)
            {
                comm.Dispose();
                conn.Close();

                conn.Open();
                NpgsqlCommand newComm = new NpgsqlCommand();
                newComm.Connection = conn;
                newComm.CommandType = CommandType.Text;
                newComm.Parameters.Add(new NpgsqlParameter("@newUserLogin", userLogin));
                newComm.Parameters.Add(new NpgsqlParameter("@newUserPassword", userPassword));
                newComm.CommandText = "insert into userstable (userlogin, userpassword) values (@newUserLogin, @newUserPassword);";
                newComm.ExecuteNonQuery();
                signUpNewCheck = true;
                newComm.Dispose();
                conn.Close();

                return signUpNewCheck;
            }
            comm.Dispose();
            conn.Close();

            return signUpNewCheck;
        }

        public bool signInUser()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database = kursachdb;User Id=postgres;Password = alex83953458130");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add(new NpgsqlParameter("@oldUserLogin", userLogin));
            comm.Parameters.Add(new NpgsqlParameter("@oldUserPassword", userPassword));
            comm.CommandText = "select userlogin from userstable where (userlogin = @oldUserLogin) and (userpassword = @oldUserPassword);";
            NpgsqlDataReader reader = comm.ExecuteReader();
            bool userCheck = reader.HasRows;
            //comm.ExecuteNonQuery()
            comm.Dispose();
            conn.Close();
            return userCheck;
        }

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (signInUpCheck)
            {
                signInButton.Text = "Создать аккаунт";
                signUpLinkLabel.Text = "Уже есть аккаунт";
                logoLabel.Text = "Регистрация в Мою библиотеку";
            }
            else
            {
                signInButton.Text = "Войти в аккаунт";
                signUpLinkLabel.Text = "Создать аккаунт";
                logoLabel.Text ="Моя библиотека";
            }
            loginMaskedTextBox.Text = "";
            passwordMaskedTextBox.Text = "";

            signInUpCheck = !signInUpCheck;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            userLogin = loginMaskedTextBox.Text;
            userPassword = passwordMaskedTextBox.Text;
            
            LibraryForm library = new LibraryForm();

            if (signInUpCheck)
            {
                //signInUser();
                if (signInUser())
                {
                    this.Hide();
                    library.Show();
                }
                else
                    MessageBox.Show("Неверный логин или пароль","Ошибка");
            }
            else
            {
                //signUpNewUser();
                if (signUpNewUser())
                {
                    this.Hide();
                    library.Show();
                }
                else
                    MessageBox.Show("Такой пользователь уже существует","Ошибка");
                
            }
            
        }

        private void loginMaskedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signInButton_Click(sender, e);
            }
        }

        private void passwordMaskedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signInButton_Click(sender, e);
            }
        }
    }
}
