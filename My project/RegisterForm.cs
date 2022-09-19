using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace My_project
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            UserLoginField.Text = "Введите имя";
            UserEmailField.Text = "Введите email";
            UserPasswordField.Text = "Введите пароль";
            this.Text = "Регистрация в программе";
        }

        public void Text_BoxEnter(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "Введите имя")
            { 
                UserLoginField.Text = ""; 
            }
            if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "Введите email")
            { 
                UserEmailField.Text = ""; 
            }
            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "Введите пароль")
            {
                UserPasswordField.Text = "";
                UserPasswordField.UseSystemPasswordChar = true;
            }
                

        }


        public void Text_BoxLeave(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "")
            {
                UserLoginField.Text = "Введите имя";
            }
            if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "")
            {
                UserEmailField.Text = "Введите email";
            }
            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Введите пароль";
                UserPasswordField.UseSystemPasswordChar = false;
            }


        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            if(UserLoginField.Text == "" || UserLoginField.Text == "Введите имя")
            {
                MessageBox.Show("Вы не ввели имя");
            }

            if (UserEmailField.Text == "" || UserEmailField.Text == "Введите email")
            {
                MessageBox.Show("Вы не ввели email");
            }
            if (UserPasswordField.Text == "" || UserPasswordField.Text == "Введите пароль")
            {
                MessageBox.Show("Вы не ввели пароль");
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(
                "INSERT INTO users (login, email, password) VALUES(@login,@email,@password)", 
                db.GetConnection());
            command.Parameters.AddWithValue("login", UserLoginField.Text);
            command.Parameters.AddWithValue("email", UserEmailField.Text);
            command.Parameters.AddWithValue("password", Hash(UserPasswordField.Text));


            db.OpenConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1) MessageBox.Show("Аккаунт создан");
                else MessageBox.Show("Ошибка при выполнении");
            }catch(MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate entry")) MessageBox.Show("Такой логин уже занят");
                else MessageBox.Show(ex.Message);
            }
            db.CloseConnection();
        }


        private string Hash(string password)
        {
            byte[] temp = Encoding.UTF8.GetBytes(password);
            using(SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(temp);
                return Convert.ToBase64String(hash);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void LinkToAuth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
            this.Close();
        }
    }
}
