using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CP
{
    public delegate void SetResultDel(string mode, int result);

    public partial class UserForm : Form
    {
        public UserForm(string sessionLogin)
        {
            InitializeComponent();
            this.SessionLogin = sessionLogin;
        }

        public static string lesName;
        private string filepath = Path.GetFullPath("auth.sqlite");
        private SQLiteConnection conn;
        public string SessionLogin { get; }

        private void UserForm_Load(object sender, System.EventArgs e)
        {
            statusBar1.Panels[1].Text = string.Concat(" Вход выполнен пользователем ", SessionLogin);
            LoadMarks();
        }

        private void LoadMarks()
        {
            conn = new SQLiteConnection(string.Concat("Data Source=", filepath));
            conn.Open();
            string stm = $"SELECT hira, kata, part FROM auth WHERE login = '{SessionLogin}'";
            var cmd = new SQLiteCommand(stm, conn);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (!rdr.IsDBNull(0)) hiraLabel.Text = $"Тест по хирагане — {rdr.GetString(0)}";
                if (!rdr.IsDBNull(1)) kataLabel.Text = $"Тест по катакане — {rdr.GetString(1)}";
                if (!rdr.IsDBNull(2)) partLabel.Text = $"Тест по чacтицам — {rdr.GetString(2)}";
            }
        }

        private void SetMarks(string mode, int result)
        {
            switch (mode)
            {
                case "hiragana/":
                    mode = "hira";
                    break;

                case "katakana/":
                    mode = "kata";
                    break;

                case "particles":
                    mode = "part";
                    break;

                default:
                    break;
            }
            conn = new SQLiteConnection(string.Concat("Data Source=", filepath));
            conn.Open();

            string stm = $"UPDATE auth SET {mode}='{result}' WHERE login='{SessionLogin}'";
            var cmd = new SQLiteCommand(stm, conn);
            cmd.ExecuteNonQuery();
            LoadMarks();
        }

        private void backBtn_Click(object sender, System.EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены?",
                "Завершение работы...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
                Application.Exit();
            else
                this.TopMost = true;
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("HH:mm:ss, dd.MM.yyyy");
        }

        private void lessonBtn_Click(object sender, EventArgs e)
        {
            new LessonChooser().ShowDialog();
            lessonBrowser.DocumentText = LessonChooser.GetlesText();
        }

        private void partBtn_Click(object sender, EventArgs e)
        {
        }

        private void kanaBtn_Click(object sender, EventArgs e)
        {
            new KanaForm(new SetResultDel(SetMarks)).Show();
        }
    }
}