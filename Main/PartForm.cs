using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CP.Main
{
    public partial class PartForm : Form
    {
        private SetResultDel srd;
        private string filepath = Path.GetFullPath("chapters.sqlite");
        private SQLiteConnection conn;
        private Random rand = new Random();
        private int result = 0;
        private int counter = 0;
        private List<List<string>> newpart = new List<List<string>>();
        private List<List<string>> partQuiz = new List<List<string>>();
        private string mode = "part";

        public PartForm(SetResultDel sender)
        {
            InitializeComponent();
            srd = sender;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void QuizLoad()
        {
            panel1.Visible = true;
            partQuiz.Clear();
            newpart.Clear();
            conn = new SQLiteConnection(string.Concat("Data Source=", filepath));
            conn.Open();
            string stm = "SELECT * FROM partquiz";
            var cmd = new SQLiteCommand(stm, conn);
            SQLiteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                partQuiz.Add(new List<string> { $"{rdr.GetString(0)}", $"{rdr.GetString(1)}" });
            }

            int randnum;
            for (int i = 0; i < 3; i++)
            {
                randnum = rand.Next(partQuiz.Count);
                newpart.Add(partQuiz[randnum]);
                partQuiz.RemoveAt(randnum);
            }
            string[] partkana = { "は", "も", "が", "を", "に", "へ", "で", "と", "や", "とか", "の" };
            partkana = partkana.OrderBy(x => rand.Next()).ToArray();
            int k = 0;
            Button[] btn = new Button[partkana.Length];
            foreach (string part in partkana)
            {
                btn[k] = new Button();
                btn[k].Font = new Font(pfc.Families[0], 12);
                btn[k].Text = $"{part}";
                btn[k].Click += quizBtn_Click;
                btn[k].UseCompatibleTextRendering = true;
                flowLayoutPanel1.Controls.Add(btn[k]);
                k++;
            }
            ChangeQuiz();
        }

        private void ChangeQuiz()
        {
            foreach (Button btn in flowLayoutPanel1.Controls.OfType<Button>())
            {
                btn.BackColor = SystemColors.Control;
            }

            queNumLabel.Text = $"Вопрос {counter + 1} из 3";
            queTextLabel.Text = newpart[counter][1];
        }

        private void quizBtn_Click(object sender, EventArgs e)
        {
            string choise = sender.ToString();
            choise = choise.Substring(35).ToLower();
            if (newpart[counter][0] == choise)
            {
                result++;
                (sender as Button).BackColor = Color.Green;
            }
            else
            {
                foreach (Button btn in flowLayoutPanel1.Controls.OfType<Button>())
                {
                    if (btn.Text == newpart[counter][0]) btn.BackColor = Color.Green;
                }
                (sender as Button).BackColor = Color.Red;
            }
            panel1.Refresh();
            Thread.Sleep(TimeSpan.FromSeconds(1));
            foreach (Button btn in flowLayoutPanel1.Controls.OfType<Button>())
            {
                if (btn.Text == newpart[counter][0]) btn.Dispose();
            }
            counter++;
            if (counter == 3)
            {
                panel1.Visible = false;
                MessageBox.Show($"Вы ответили верно на {result} из 3.", "Задание завершено");
                srd(mode, result);
            }
            else ChangeQuiz();
        }

        private PrivateFontCollection pfc;

        private void InitCustomLabelFont()
        {
            //Create your private font collection object.
            pfc = new PrivateFontCollection();

            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.NotoSansJP_Regular.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.NotoSansJP_Regular;

            // create an unsafe memory block for the font data
            IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);
        }

        private void PartForm_Load(object sender, EventArgs e)
        {
        }

        private void partStartBtn_Click(object sender, EventArgs e)
        {
            InitCustomLabelFont();
            QuizLoad();
        }
    }
}