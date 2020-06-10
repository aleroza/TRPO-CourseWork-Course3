using System;
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