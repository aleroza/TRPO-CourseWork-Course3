using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CP.Main
{
    public partial class LessonDBForm : Form
    {
        private string filepath = Path.GetFullPath("chapters.sqlite");
        private SQLiteConnection conn;
        private SQLiteDataAdapter da;
        private DataTable dt;
        private SQLiteCommand cmd;
        private string stm, mode;

        public LessonDBForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupsRadio_CheckedChanged(object sender, EventArgs e)
        {
            mode = "groups";
            panel1.Visible = true;

            label2.Visible = false;
            idGrBox.Visible = false;
            label3.Visible = false;
            subtitleBox.Visible = false;
            textBox.Visible = false;

            LoadDB();
        }

        private void chaptersRadio_CheckedChanged(object sender, EventArgs e)
        {
            mode = "chapters";
            panel1.Visible = true;

            label2.Visible = true;
            idGrBox.Visible = true;
            label3.Visible = true;
            subtitleBox.Visible = true;
            textBox.Visible = true;

            LoadDB();
        }

        private void LoadDB()
        {
            GC.Collect();
            dt = new DataTable(mode);
            stm = $"SELECT * FROM {mode}";
            conn = new SQLiteConnection(string.Concat("Data Source=", filepath));
            da = new SQLiteDataAdapter(stm, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.ClearSelection();
            foreach (TextBox texbox in this.Controls.OfType<TextBox>())
            {
                texbox.Text = "";
            }
            textBox.Text = "";
            idGrBox.ResetText();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SQLiteCommand(stm, conn);
            cmd.Connection = conn;

            if (mode == "groups") cmd.CommandText = $"update groups set name='{titleBox.Text}' where id='{idBox.Text}'";
            if (mode == "chapters") cmd.CommandText = $"update chapters set group_id='{idGrBox.Value}',title='{titleBox.Text}',subtitle='{subtitleBox.Text}',content='{textBox.Text}' where id='{idBox.Text}'";

            cmd.ExecuteNonQuery();
            conn.Close();
            LoadDB();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SQLiteCommand(stm, conn);
            cmd.Connection = conn;

            if (mode == "groups") cmd.CommandText = $"INSERT INTO groups (name) VALUES('{titleBox.Text}');";
            if (mode == "chapters") cmd.CommandText = $"INSERT INTO chapters (group_id, title, subtitle, content) VALUES('{idGrBox.Value}','{titleBox.Text}', '{subtitleBox.Text}', '{textBox.Text}');";

            cmd.ExecuteNonQuery();
            conn.Close();
            LoadDB();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SQLiteCommand(stm, conn);
            cmd.Connection = conn;
            cmd.CommandText = $"delete from {mode} where id='{idBox.Text}'";
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadDB();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int curRow;
            if (mode == "groups")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    idBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    titleBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                }
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    curRow = dataGridView1.SelectedCells[0].RowIndex;
                    idBox.Text = dataGridView1.Rows[curRow].Cells[0].Value.ToString();
                    titleBox.Text = dataGridView1.Rows[curRow].Cells[1].Value.ToString();
                }
            }
            if (mode == "chapters")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    idBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    idGrBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    titleBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    subtitleBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    textBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                }
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    curRow = dataGridView1.SelectedCells[0].RowIndex;
                    idBox.Text = dataGridView1.Rows[curRow].Cells[0].Value.ToString();
                    idGrBox.Text = dataGridView1.Rows[curRow].Cells[1].Value.ToString();
                    titleBox.Text = dataGridView1.Rows[curRow].Cells[2].Value.ToString();
                    subtitleBox.Text = dataGridView1.Rows[curRow].Cells[3].Value.ToString();
                    textBox.Text = dataGridView1.Rows[curRow].Cells[4].Value.ToString();
                }
            }
        }
    }
}