using CP.Main;
using System.Windows.Forms;

namespace CP
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, System.EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void userdbBtn_Click(object sender, System.EventArgs e)
        {
            new UserDBForm().ShowDialog();
        }

        private void lessonsdbBtn_Click(object sender, System.EventArgs e)
        {
            new LessonDBForm().ShowDialog();
        }
    }
}