using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CP.Main
{
    public partial class UserDBForm : Form
    {
        private string filepath = Path.GetFullPath("auth.sqlite");
        private SQLiteConnection conn;
        private SQLiteDataAdapter da;
        private DataTable dt;
        private SQLiteCommand cmd;
        private string stm;

        public UserDBForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadDB()
        {
            GC.Collect();
            dt = new DataTable("auth");
            stm = "SELECT * FROM auth";
            conn = new SQLiteConnection(string.Concat("Data Source=", filepath));
            da = new SQLiteDataAdapter(stm, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.ClearSelection();
            foreach (TextBox texbox in this.Controls.OfType<TextBox>())
            {
                texbox.Text = "";
            }
            foreach (NumericUpDown numeric in this.Controls.OfType<NumericUpDown>())
            {
                numeric.ResetText();
            }
        }

        private void UserDBForm_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SQLiteCommand(stm, conn);
            cmd.Connection = conn;
            cmd.CommandText = $"update auth set login='{loginBox.Text}',password='{passwdBox.Text}',hira='{hiraBox.Value}',kata='{kataBox.Value}',part='{partBox.Value}' where id='{idBox.Text}'";
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadDB();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SQLiteCommand(stm, conn);
            cmd.Connection = conn;
            cmd.CommandText = $"INSERT INTO auth (login, password, hira, kata, part) VALUES('{loginBox.Text}', '{passwdBox.Text}', '{hiraBox.Value}', '{kataBox.Value}', '{partBox.Value}');";
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadDB();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SQLiteCommand(stm, conn);
            cmd.Connection = conn;
            cmd.CommandText = $"delete from auth where id='{idBox.Text}'";
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadDB();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                loginBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                passwdBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                hiraBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                kataBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                partBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int curRow = dataGridView1.SelectedCells[0].RowIndex;
                idBox.Text = dataGridView1.Rows[curRow].Cells[0].Value.ToString();
                loginBox.Text = dataGridView1.Rows[curRow].Cells[1].Value.ToString();
                passwdBox.Text = dataGridView1.Rows[curRow].Cells[2].Value.ToString();
                hiraBox.Text = dataGridView1.Rows[curRow].Cells[3].Value.ToString();
                kataBox.Text = dataGridView1.Rows[curRow].Cells[4].Value.ToString();
                partBox.Text = dataGridView1.Rows[curRow].Cells[5].Value.ToString();
            }
        }
    }
}