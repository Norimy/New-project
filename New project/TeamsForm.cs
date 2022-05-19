
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
    public partial class TeamsForm : Form
    {
      int idTeam;

      public  String[] imgList1 = new String[] { "0.jpg", "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg", "9.jpg","10.jpg", "11.jpg", "12.jpg",
                                          "13.jpg", "14.jpg","15.jpg" };

        String[] imgList2 = new String[] { "15.jpg","16.jpg", "17.jpg", "18.jpg", "19.jpg", "20.jpg", "21.jpg", "22.jpg", "23.jpg", "24.jpg", "25.jpg","26.jpg", "27.jpg", "28.jpg",
                                          "29.jpg", "30.jpg" };

        TeamNameClass[] teams = new TeamNameClass[5];

        Player[,] player = new Player[5,5];

        TeamId id = new TeamId();

        int OpenDate(int idTeam)
        {
            this.Close();
            DetailForm detailForm = new DetailForm();
            detailForm.nameTeam = teams[idTeam].getName();
            detailForm.idTeam = id.getId();

            for(int i=0;i<5;i++)
            {
                detailForm.team[i, 0] = Convert.ToString(player[i, 0].GetPlayerId());
                detailForm.team[i, 1] = player[i, 0].GetLastName();
                detailForm.team[i, 2] = player[i, 0].GetName();
                detailForm.team[i, 3] = Convert.ToString(player[i, 0].GetWeight());
                detailForm.team[i, 4] = Convert.ToString(player[i, 0].GetHeight());
            }

            detailForm.Show();
            return idTeam;
        }

        public void TeamName()
        {

            teams[0] = new TeamNameClass();
            teams[0].setName("Miami Heat");
            teams[1] = new TeamNameClass();
            teams[1].setName("Orlando Magic");
            teams[2] = new TeamNameClass();
            teams[2].setName("Atlanta Hawks");
            teams[3] = new TeamNameClass();
            teams[3].setName("Washington Wizards");
            teams[4] = new TeamNameClass();
            teams[4].setName("Charlotte Hornets");

            for (int i = 0; i < 5; i++)
            {
                tabPage1.Controls["groupBox" + (i + 1)].Controls["label" + (1 + i)].Text = teams[i].getName();
            }

        }
        public void PlayrsDate()
        {

        }
        void PictureFilling()
        {
            List<PictureBox> listWestern = new List<PictureBox>();
            List<PictureBox> listEastern = new List<PictureBox>();

            listWestern.AddRange(new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7,
                                               pictureBox8, pictureBox9,pictureBox10,pictureBox11, pictureBox12,pictureBox13,pictureBox14, pictureBox15,});

            for (int i = 0; i < 15; i++)
            {
                listWestern[i].Load("../../picture/" + imgList1[i]);
            }

            listEastern.AddRange(new PictureBox[] {   pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20,
                                              pictureBox21,pictureBox22, pictureBox23, pictureBox24,pictureBox25,pictureBox26,pictureBox27,pictureBox28,pictureBox29, pictureBox30 });

            for (int i = 0; i < 15; i++)
            {
                listEastern[i].Load("../../picture/" + imgList2[i]);
            }
        }

        public TeamsForm()
        {
            InitializeComponent();
            TeamName();
            PictureFilling();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form adminForm = new AdminForm();
            adminForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form detailForm = new DetailForm();
            detailForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            idTeam = 0;

            player[0,0] = new Player();
            player[0,0].setPalyerAll(1, "Mo", "Williams", "", 1.85, 89.8, 0, "", "", 0);

            player[1, 0] = new Player();
            player[1, 0].setPalyerAll(2, "Alonzo", "Edward", "", 1.98, 99, 0, "", "", 0);

            player[2, 0] = new Player();
            player[2, 0].setPalyerAll(3, "Johnny", "O'Bryant", "", 2.05, 116.5, 0, "", "", 0);

            player[3, 0] = new Player();
            player[3, 0].setPalyerAll(4, "Danilo", "Gallinari", "", 2.08, 102, 0, "", "", 0);

            player[4, 0] = new Player();
            player[4, 0].setPalyerAll(5, "Darrell", "Darrell", "", 2.06, 107, 0, "", "", 0);


            OpenDate(idTeam);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            idTeam = 1;

            player[0, 0] = new Player();
            player[0, 0].setPalyerAll(1, "Nikola", "Jokic", "", 2.08,113, 0, "", "", 0);

            player[1, 0] = new Player();
            player[1, 0].setPalyerAll(2, "Will", "Barton", "", 1.98, 79, 0, "", "", 0);

            player[2, 0] = new Player();
            player[2, 0].setPalyerAll(3, "Karl-Anthony", "Towns", "", 2.13, 111, 0, "", "", 0);

            player[3, 0] = new Player();
            player[3, 0].setPalyerAll(4, "Andrew", "Wiggins", "", 2.03, 91, 0, "", "", 0);

            player[4, 0] = new Player();
            player[4, 0].setPalyerAll(5, "Nikola ", "Pekovic", "", 2.10, 139.2, 0, "", "", 0);

            id.setId(idTeam);
            OpenDate(idTeam);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            idTeam = 2;
            id.setId(idTeam);
            OpenDate(idTeam);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            idTeam = 3;
            id.setId(idTeam);
            OpenDate(idTeam);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            idTeam = 4;
            id.setId(idTeam);
            OpenDate(idTeam);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}



