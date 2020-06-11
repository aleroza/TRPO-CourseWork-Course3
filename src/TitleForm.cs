using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CP
{
    public partial class TitleForm : Form
    {
        public TitleForm()
        {
            InitializeComponent();
        }

        private void Start()
        {
            pictureBox1.Image = Bitmap.FromFile("images/logo.png");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            new LoginForm().Show();
            this.Hide();
        }

        private void TitleForm_Shown(object sender, EventArgs e)
        {
            Start();
        }
    }
}