using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CP
{
    public partial class LoginForm : Form
    {
        private int logintype; // 0 - admin, 1 - user login, 2 - user register
        private string filepath = Path.GetFullPath("auth.sqlite");
        public string sessionLogin = "";
        private SQLiteConnection conn;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            logintype = 0;
            logpasPanel.Visible = true;
            passwd2Panel.Visible = false;
            userLoginPanel.Visible = false;
            loginPanel.Visible = true;
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = true;
            userLoginPanel.Visible = true;
        }

        private void loginRadio_CheckedChanged(object sender, EventArgs e)
        {
            logintype = 1;
            logpasPanel.Visible = true;
            passwd2Panel.Visible = false;
        }

        private void registerRadio_CheckedChanged(object sender, EventArgs e)
        {
            logintype = 2;
            logpasPanel.Visible = true;
            passwd2Panel.Visible = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new TitleForm().Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string stm = "";

            switch (logintype)
            {
                case 0:
                    stm = "SELECT * FROM auth LIMIT 1";
                    if (LoginMethod(stm))
                    {
                        sessionLogin = loginTextBox.Text;
                        new AdminForm().Show();
                        this.Hide();
                    }
                    break;

                case 1:
                    stm = "SELECT * FROM auth";
                    if (LoginMethod(stm))
                    {
                        sessionLogin = loginTextBox.Text;
                        new UserForm(sessionLogin).Show();
                        this.Hide();
                    }
                    break;

                case 2:
                    stm = "SELECT login FROM auth";
                    if (RegisterMethod(stm))
                    {
                        MessageBox.Show("Регистрация прошла успешно!", "Регистрация");
                        sessionLogin = loginTextBox.Text;
                        new UserForm(sessionLogin).Show();
                        this.Hide();
                    }
                    break;

                default: break;
            }
        }

        private bool LoginMethod(string stm)
        {
            string Login = "";
            string Passwd = "";
            conn = new SQLiteConnection(string.Concat("Data Source=", filepath));
            conn.Open();

            var cmd = new SQLiteCommand(stm, conn);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Login = $"{rdr.GetString(0)}";
                Passwd = $"{rdr.GetString(1)}";
                //Console.WriteLine($"{Login} {Passwd}");
                if (loginTextBox.Text == Login && passwdTextBox.Text == Passwd)
                {
                    return true;
                }
                else continue;
            }

            loginTextBox.Text = "";
            passwdTextBox.Text = "";
            MessageBox.Show("Неправильный логин или пароль.", "Ошибка!");
            return false;
        }

        private bool RegisterMethod(string stm)
        {
            string Login = "";

            conn = new SQLiteConnection(string.Concat("Data Source=", filepath));
            conn.Open();

            var cmd = new SQLiteCommand(stm, conn);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Login = $"{rdr.GetString(0)}";
                Console.WriteLine($"{Login}");
                if (loginTextBox.Text == Login)
                {
                    loginTextBox.Text = "";
                    passwdTextBox.Text = "";
                    passwd2TextBox.Text = "";
                    MessageBox.Show("Пользователь с таким логином уже существует.", "Ошибка!");
                    return false;
                }
                else continue;
            }
            conn.Close();
            conn = new SQLiteConnection(string.Concat("Data Source=", filepath));
            cmd = new SQLiteCommand(conn);
            conn.Open();

            if (!(passwdTextBox.Text == passwd2TextBox.Text) | string.IsNullOrWhiteSpace(passwdTextBox.Text) | string.IsNullOrWhiteSpace(loginTextBox.Text))
            {
                loginTextBox.Text = "";
                passwdTextBox.Text = "";
                passwd2TextBox.Text = "";
                MessageBox.Show("Поля yне заполнены или пароли не совпадают.", "Ошибка!");
                return false;
            }
            cmd.CommandText = $"INSERT INTO auth(login, password) VALUES('{loginTextBox.Text}','{passwdTextBox.Text}')";
            cmd.ExecuteNonQuery();

            return true;
        }
    }
}