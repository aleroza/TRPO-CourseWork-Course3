using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CP
{
    public partial class LessonChooser : Form
    {
        string filepath = Path.GetFullPath("chapters.sqlite");
        SQLiteConnection conn;


        public LessonChooser()
        {
            InitializeComponent();
        }

        static public string GetlesText()
        {
            return lesText;
        }
        static string lesText;

        private void LessonChooser_Load(object sender, EventArgs e)
        {
            MenuLoad(); ;
            this.Size = new Size(LessonMenu.Size.Width, LessonMenu.Size.Height * 3);
        }


        public void ItemClick(object sender, System.EventArgs e)
        {
            string lesname = sender.ToString();
            int index = lesname.IndexOf(" — ");
            lesname = lesname.Substring(0, index);
            SendLesson(lesname);
            this.Close();
        }

        private void SendLesson(string lesname)
        {
            conn = new SQLiteConnection(string.Concat("Data Source=", filepath));
            conn.Open();
            string stm = $"SELECT content FROM chapters WHERE title = '{lesname}'";
            var cmd = new SQLiteCommand(stm, conn);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()){
                lesText = rdr.GetString(0);
            }
            
        }

        private void MenuLoad()
        {
            conn = new SQLiteConnection(string.Concat("Data Source=", filepath));
            conn.Open();

            string stmGr = "SELECT * FROM groups";
            string stmCh = "SELECT * FROM chapters";
            var cmdGr = new SQLiteCommand(stmGr, conn);
            var cmdCh = new SQLiteCommand(stmCh, conn);
            SQLiteDataReader rdrGr = cmdGr.ExecuteReader();
            SQLiteDataReader rdrCh = cmdCh.ExecuteReader();

            ArrayList groups = new ArrayList();
            while (rdrGr.Read())
            {
                string nameGr = rdrGr.GetString(1);
                groups.Add(nameGr);
            }

            List<List<string>> chapters = new List<List<string>>();
            while (rdrCh.Read())
            {
                if (rdrCh.IsDBNull(3)) continue;
                chapters.Add(new List<string> { $"{rdrCh.GetInt32(1)}", $"{rdrCh.GetString(3)}", $"{rdrCh.GetString(4)}" });
            }
            int n = 0;
            foreach (string nameGr in groups)
            {
                n++;
                ToolStripMenuItem namesGr = new ToolStripMenuItem(nameGr);
                LessonMenu.Items.Add(namesGr);

                foreach (List<string> subList in chapters)
                {
                    if (n == int.Parse(subList[0]))
                    {
                        ToolStripMenuItem dropdwn = new ToolStripMenuItem(string.Concat(subList[1], " — ", subList[2]), null, ItemClick);
                        namesGr.DropDownItems.Add(dropdwn);
                    }
                }
            }
        }
    }
}


