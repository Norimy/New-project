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
    public partial class DetailForm : Form
    {
        public int idTeam;
        public string[,] arr = new string[5, 5];
        public string[,] team = new string[5, 5];

        public string nameTeam;

        //Team teams = new Team();

        void TabelPage2()
        {
            dataGridView2.RowCount = 5;
            dataGridView2.ColumnCount = 5;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    arr[i, j] = team[i, j];
                }
            }

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j].ToString();
                }
            }
        }

        void TabelPage1()
        {
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    arr[i, j] = team[i, j];
                }
            }

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j].ToString();
                }
            }
        }
      /*  public int Mass(int Rows)
        {
            this.team[Rows, 0] = Convert.ToString(teams.GetTeamId());
            this.team[Rows, 1] = teams.GetTeamName();
            this.team[Rows, 2] = teams.GetTeamAbbr();
            this.team[Rows, 3] = teams.GetTeamLogo();
            return ++Rows;
        }
      */
        public DetailForm()
        {
            InitializeComponent();
            int Rows = 0;
/*
            teams.SetTeamAll(1, "Miami Heat", "SG", "1.jpg");
            Rows = Mass(Rows);
            teams.SetTeamAll(2, "Jaylen Brown", "SF", "2.jpg");
            Rows = Mass(Rows);
            teams.SetTeamAll(3, "Jae Crowder", "SF", "3.jpg");
            Rows = Mass(Rows);
            teams.SetTeamAll(4, "Gerald Green", "SF", "4.jpg");
            Rows = Mass(Rows);
            teams.SetTeamAll(5, "Al Horford", "C", "5.jpg");
            Rows = Mass(Rows);
*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form teamsForm = new TeamsForm();
            teamsForm.Show();
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            TeamsForm fteam = new TeamsForm();

            label2.Text = nameTeam;
            pictureBox3.Load("../../picture/" + fteam.imgList1[idTeam]);

            

            TabelPage1();
            TabelPage2();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
