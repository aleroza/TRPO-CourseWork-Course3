using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP.Main
{
    public partial class PartForm : Form
    {
        public PartForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        List<List<string>> partList = new List<List<string>>() {new List<string> };
        
        int i = 0;
        Button[] btn = new Button[10];
        private void partStartBtn_Click(object sender, EventArgs e)
        {
            
            btn[i]= new Button();
            btn[i].Text = $"{i}";
            flowLayoutPanel1.Controls.Add(btn[i]);
            i++;
        }
    }
}
