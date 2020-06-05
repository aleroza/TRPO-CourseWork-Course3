using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CP
{
    public partial class KanaForm : Form
    {
        private SetResultDel srd;

        public KanaForm(SetResultDel sender)
        {
            InitializeComponent();
            srd = sender;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void hiraBtn_Click(object sender, EventArgs e)
        {
            if (mode != null)
            {
                DialogResult result = MessageBox.Show(
                "Вы уверены?",
                "Смена теста",
                MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    mode = "hiragana/";
                    MainQuiz();
                }
                else
                    this.TopMost = true;
            }
            else
            {
                mode = "hiragana/";
                MainQuiz();
            }
        }

        private void kataBtn_Click(object sender, EventArgs e)
        {
            if (mode != null)
            {
                DialogResult result = MessageBox.Show(
                "Вы уверены?",
                "Смена теста",
                MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    mode = "katakana/";
                    MainQuiz();
                }
                else
                    this.TopMost = true;
            }
            else
            {
                mode = "katakana/";
                MainQuiz();
            }
        }

        private int counter;
        private int result;
        private string mode;
        private string[] kanaNames = { "a", "chi", "e", "fu", "ha", "he", "hi", "ho", "i", "ka", "ke", "ki", "ko", "ku", "ma", "me", "mi", "mo", "mu", "n", "na", "ne", "ni", "no", "nu", "o", "ra", "re", "ri", "ro", "ru", "sa", "se", "shi", "so", "su", "ta", "te", "to", "tsu", "u", "wa", "wo", "ya", "yo", "yu" };

        private Random rand = new Random();
        private List<List<string>> quiz = new List<List<string>>();

        private void MainQuiz()
        {
            panel1.Visible = true;
            quiz.Clear();
            result = 0;
            counter = 0;
            string[] answers = kanaNames.OrderBy(x => rand.Next()).ToArray();
            Array.Resize(ref answers, 5);

            for (int i = 0; i < answers.Length; i++)
            {
                List<string> temp = new List<string>();
                temp = kanaNames.ToList();
                temp.Remove($"{answers[i]}");
                string[] examples = temp.ToArray();
                examples = examples.OrderBy(x => rand.Next()).ToArray();
                Array.Resize(ref examples, 3);
                examples = examples.Append($"{answers[i]}").ToArray();
                examples = examples.OrderBy(x => rand.Next()).ToArray();
                quiz.Add(new List<string> { $"{answers[i]}", $"{examples[0]}", $"{examples[1]}", $"{examples[2]}", $"{examples[3]}" });
            }
            ChangeQuiz();
        }

        private void ChangeQuiz()
        {
            foreach (Button btn in panel1.Controls.OfType<Button>())
            {
                btn.BackColor = SystemColors.Control;
            }
            pictureBox1.Image = Bitmap.FromFile(string.Concat("images/", mode, quiz[counter][0], ".gif"));
            int t = 1;
            foreach (Button btn in panel1.Controls.OfType<Button>())
            {
                btn.Text = quiz[counter][t].ToUpper();
                t++;
            }
        }

        private void quizBtn_Click(object sender, EventArgs e)
        {
            string choise = sender.ToString();
            choise = choise.Substring(35).ToLower();
            if (quiz[counter][0] == choise)
            {
                result++;
                (sender as Button).BackColor = Color.Green;
            }
            else
            {
                (Controls[$"{quiz[counter][0]}"]).BackColor = Color.Green;
                //foreach (Button btn in panel1.Controls.OfType<Button>())
                //{
                //    if (btn.Text.ToLower() == quiz[counter][0]) btn.BackColor = Color.Green;
                //}
                (sender as Button).BackColor = Color.Red;
            }
            panel1.Refresh();
            counter++;
            Thread.Sleep(TimeSpan.FromSeconds(1));

            if (counter == 5)
            {
                panel1.Visible = false;
                MessageBox.Show($"Вы ответили верно на {result} из 5.", "Задание завершено");
                srd(mode, result);
            }
            else ChangeQuiz();
        }
    }
}