using MySql.Data.MySqlClient;
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

namespace My_project
{
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
            ChangeEmail.Text = "Введите email";
            ChangePassword.Text = "Введите пароль";
        }

        public void Text_BoxEnter(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "ChangeEmail" && ChangeEmail.Text.Trim() == "Введите email")
            {
                ChangeEmail.Text = "";
            }
            if (((TextBox)sender).Name == "ChangePassword" && ChangePassword.Text.Trim() == "Введите пароль")
            {
                ChangePassword.Text = "";
                ChangePassword.UseSystemPasswordChar = true;
            }


        }


        public void Text_BoxLeave(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "ChangeEmail" && ChangeEmail.Text.Trim() == "")
            {
                ChangeEmail.Text = "Введите email";
                ChangeEmail.ForeColor = Color.Gray;
            }
            if (((TextBox)sender).Name == "ChangePassword" && ChangePassword.Text.Trim() == "")
            {
                ChangePassword.Text = "Введите пароль";
                ChangePassword.UseSystemPasswordChar = false; 
                ChangePassword.ForeColor = Color.Gray;
            }
           
           

        }

        private void RegBtn_Click(object sender, EventArgs e)
        {

            if (ChangeEmail.Text == "" || ChangeEmail.Text == "Введите email")
            {
                MessageBox.Show("Вы не ввели email");
            }
            if (ChangePassword.Text == "" || ChangePassword.Text == "Введите пароль")
            {
                MessageBox.Show("Вы не ввели пароль");
            }
        }
        




        private void ChangeForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ChangeEmail.Text == "" || ChangeEmail.Text == "Введите email")
            {
                MessageBox.Show("Вы не ввели email");
            }
            if (ChangePassword.Text == "" || ChangePassword.Text == "Введите пароль")
            {
                MessageBox.Show("Вы не ввели пароль");
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(
                "UPDATE users SET email = @email, password = @password WHERE login = 'admin'",
                db.GetConnection());
            command.Parameters.AddWithValue("email", ChangeEmail.Text);
            command.Parameters.AddWithValue("password", Hash(ChangePassword.Text));


            db.OpenConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1) 
                { 
                    MessageBox.Show("Данные обновлены");
                    button1.Text = "Готово";
                }

                else MessageBox.Show("Ошибка при выполнении");
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate entry")) MessageBox.Show("Такой логин уже занят");
                else MessageBox.Show(ex.Message);
            }
            db.CloseConnection();
        }


        private string Hash(string password)
        {
            byte[] temp = Encoding.UTF8.GetBytes(password);
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(temp);
                return Convert.ToBase64String(hash);
            }
        }
    }
}