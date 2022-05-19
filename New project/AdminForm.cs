using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form teamsForms = new TeamsForm();
            teamsForms.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form matchupsForm = new MatchupsForm();
            matchupsForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form playersForm = new PlayersForm();
            playersForm.Show();
            this.Close();
        }

    }
}
